USE [master]
GO
/****** Object:  Database [ESMPLUS]    Script Date: 17/11/2016 00:27:09 ******/
CREATE DATABASE [ESMPLUS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ESMPLUS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.LOCALHOST\MSSQL\DATA\ESMPLUS.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ESMPLUS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.LOCALHOST\MSSQL\DATA\ESMPLUS_log.ldf' , SIZE = 1088KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ESMPLUS] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ESMPLUS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ESMPLUS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ESMPLUS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ESMPLUS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ESMPLUS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ESMPLUS] SET ARITHABORT OFF 
GO
ALTER DATABASE [ESMPLUS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ESMPLUS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ESMPLUS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ESMPLUS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ESMPLUS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ESMPLUS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ESMPLUS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ESMPLUS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ESMPLUS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ESMPLUS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ESMPLUS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ESMPLUS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ESMPLUS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ESMPLUS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ESMPLUS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ESMPLUS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ESMPLUS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ESMPLUS] SET RECOVERY FULL 
GO
ALTER DATABASE [ESMPLUS] SET  MULTI_USER 
GO
ALTER DATABASE [ESMPLUS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ESMPLUS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ESMPLUS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ESMPLUS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ESMPLUS] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ESMPLUS', N'ON'
GO
USE [ESMPLUS]
GO
/****** Object:  UserDefinedFunction [dbo].[ufnTextoTabela]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ufnTextoTabela]
(@INvchTexto VARCHAR(MAX))
RETURNS 
    @tblRetorno TABLE (
        [ID] VARCHAR (MAX) NULL)
AS
BEGIN
	DECLARE @intIdx as int
	DECLARE @vchID as varchar(MAX)
	WHILE (1 = 1)
	BEGIN
		SET @intIdx = CharIndex(',', @INvchTexto)
		IF (@intIdx > 0)
		BEGIN
			SET @vchID = SUBSTRING(@INvchTexto, 1, @intIdx - 1 )
			SET @INvchTexto = SUBSTRING(@INvchTexto, @intIdx + 1, LEN(@INvchTexto))
		END
		ELSE
		BEGIN
			SET @vchID = @INvchTexto
			SET @INvchTexto = ''
		END
		INSERT INTO @tblRetorno VALUES (@vchID)
		IF (CAST(@INvchTexto as VARCHAR(MAX))= '')
			BREAK
	END 
	
	RETURN 
END


GO
/****** Object:  UserDefinedFunction [dbo].[ufnTextoTabelaInformarSeparador]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ufnTextoTabelaInformarSeparador]
(
	@INvchTexto VARCHAR(MAX),
	@INvchSeparador VARCHAR(50)
)
RETURNS 
    @tblRetorno TABLE (
        [ID] VARCHAR (MAX) NULL)
AS
BEGIN

	IF(@INvchSeparador IS NULL)
		SET @INvchSeparador = 'É OBRIGATÓRIO PASSAR O SEPARADOR';

	DECLARE 
		@intIdx AS INT,
		@vchID AS VARCHAR(MAX);
	
	
	WHILE (1 = 1)
	BEGIN
		SET @intIdx = CharIndex(@INvchSeparador, @INvchTexto)
		IF (@intIdx > 0)
		BEGIN
			SET @vchID = SUBSTRING(@INvchTexto, 1, @intIdx - 1 )
			SET @INvchTexto = SUBSTRING(@INvchTexto, @intIdx + 1, LEN(@INvchTexto))
		END
		ELSE
		BEGIN
			SET @vchID = @INvchTexto
			SET @INvchTexto = ''
		END
		INSERT INTO @tblRetorno VALUES (@vchID)
		IF (CAST(@INvchTexto as VARCHAR(MAX))= '')
			BREAK
	END 
	
	RETURN 
END


GO
/****** Object:  UserDefinedFunction [dbo].[ufnTextoTabelaInformarSeparadorComIndex]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ufnTextoTabelaInformarSeparadorComIndex]
(
	@INvchTexto VARCHAR(MAX),
	@INvchSeparador VARCHAR(1)
)
RETURNS 
    @tblRetorno TABLE 
	(
		[IDIndex] INT IDENTITY(1,1),
        [Valor] VARCHAR (MAX) NULL
	)
AS
BEGIN

	IF(@INvchSeparador IS NULL)
		SET @INvchSeparador = 'É OBRIGATÓRIO PASSAR O SEPARADOR';

	DECLARE 
		@intIdx AS INT,
		@vchID AS VARCHAR(MAX);
	
	
	WHILE (1 = 1)
	BEGIN
		SET @intIdx = CharIndex(@INvchSeparador, @INvchTexto)
		IF (@intIdx > 0)
		BEGIN
			SET @vchID = SUBSTRING(@INvchTexto, 1, @intIdx - 1 )
			SET @INvchTexto = SUBSTRING(@INvchTexto, @intIdx + 1, LEN(@INvchTexto))
		END
		ELSE
		BEGIN
			SET @vchID = @INvchTexto
			SET @INvchTexto = ''
		END
		
		INSERT INTO @tblRetorno VALUES (@vchID)
		
		IF (CAST(@INvchTexto as VARCHAR(MAX))= '')
			BREAK

	END 
	
	RETURN 
END


GO
/****** Object:  UserDefinedFunction [dbo].[ufnTextoTabelaPontoVirgula]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ufnTextoTabelaPontoVirgula]
(@INvchTexto VARCHAR(MAX))
RETURNS 
    @tblRetorno TABLE (
        [ID] VARCHAR (MAX) NULL)
AS
BEGIN
	DECLARE @intIdx as int
	DECLARE @vchID as varchar(MAX)
	WHILE (1 = 1)
	BEGIN
		SET @intIdx = CharIndex(';', @INvchTexto)
		IF (@intIdx > 0)
		BEGIN
			SET @vchID = SUBSTRING(@INvchTexto, 1, @intIdx - 1 )
			SET @INvchTexto = SUBSTRING(@INvchTexto, @intIdx + 1, LEN(@INvchTexto))
		END
		ELSE
		BEGIN
			SET @vchID = @INvchTexto
			SET @INvchTexto = ''
		END
		INSERT INTO @tblRetorno VALUES (@vchID)
		IF (CAST(@INvchTexto as VARCHAR(MAX))= '')
			BREAK
	END 
	
	RETURN 
END


GO
/****** Object:  UserDefinedFunction [dbo].[ufnTextoTabelaPontoVirgulaComChavePrimaria]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: funçõesSQLSERVER.sql|7459|0|E:\Vinicius\Downloads\Outlook.com (1)\funçõesSQLSERVER.sql
CREATE FUNCTION [dbo].[ufnTextoTabelaPontoVirgulaComChavePrimaria]
(@INvchTexto TEXT)
RETURNS 
    @tblRetorno TABLE
	(
		[Chave] INT IDENTITY,
        [Valor] VARCHAR (8000) NULL
	)
AS
BEGIN
	DECLARE @intIdx as int
	DECLARE @vchID as varchar(8000)
	WHILE (1 = 1)
	BEGIN
		SET @intIdx = CharIndex(';', @INvchTexto)
		IF (@intIdx > 0)
		BEGIN
			SET @vchID = SUBSTRING(@INvchTexto, 1, @intIdx - 1 )
			SET @INvchTexto = SUBSTRING(@INvchTexto, @intIdx + 1, 8000)
		END
		ELSE
		BEGIN
			SET @vchID = @INvchTexto
			SET @INvchTexto = ''
		END
		INSERT INTO @tblRetorno VALUES (@vchID)
		IF (CAST(@INvchTexto as VARCHAR(8000))= '')
			BREAK
	END 
	
	RETURN 
END


GO
/****** Object:  UserDefinedFunction [dbo].[ufnTextoTabelaPontoVirgulaComIndex]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create FUNCTION [dbo].[ufnTextoTabelaPontoVirgulaComIndex]
(@INvchTexto VARCHAR(MAX))
RETURNS 
    @tblRetorno TABLE
	(
		[IDIndex] INT IDENTITY(1,1),
        [Valor] VARCHAR (MAX) NULL
	)
AS
BEGIN
	
	--Em 13/03/2014 percebi que na função ufnTextoTabelaPontoVirgulaComChavePrimaria se o ultimo caracter for ; (ponto e virgula) não cria o ultimo campo. 
	--Por isso para não alterar ele, criei esta nova
	DECLARE 
		@intIndexPontoVirgula int,
		@vchValor as varchar(max),
		@bitUltimoCaracetereEhPontoVirgula bit = 0
	
	SET @bitUltimoCaracetereEhPontoVirgula = CASE WHEN substring(@INvchTexto, len(@INvchTexto), 1) = ';' THEN 1 ELSE 0 END


	WHILE (1 = 1)
	BEGIN
	
		SET @intIndexPontoVirgula = CharIndex(';', @INvchTexto)
	
		IF (@intIndexPontoVirgula > 0)
		BEGIN
			
			SET @vchValor = SUBSTRING(@INvchTexto, 1, @intIndexPontoVirgula - 1 )
			SET @INvchTexto = SUBSTRING(@INvchTexto, @intIndexPontoVirgula + 1, LEN(@INvchTexto))

		END
		ELSE
		BEGIN
			
			SET @vchValor = @INvchTexto
			SET @INvchTexto = ''

		END
	
		INSERT INTO @tblRetorno VALUES (@vchValor)
	
		IF (CAST(@INvchTexto as VARCHAR(MAX))= '')
		BEGIN
			--Se o ultimo caractere é ; (ponto virgula) siginifica que o ultimo valor é uma string em branco.
			IF(@bitUltimoCaracetereEhPontoVirgula = 1)
				INSERT INTO @tblRetorno VALUES ('')

			BREAK;
		END
	END 
	
	RETURN 
END



GO
/****** Object:  UserDefinedFunction [dbo].[ufnZerosEsquerda]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ufnZerosEsquerda]
(@INintTamanho INT, @INintValor BIGINT)
RETURNS VARCHAR (400)
AS
BEGIN

	  --RETURN REPLICATE('0',@INintTamanho - LEN(CAST(@INintValor AS VARCHAR))) + CAST(@INintValor AS VARCHAR)

	  DECLARE @vchRetorno VARCHAR(400)

	  IF(DATALENGTH(CAST(@INintValor AS VARCHAR)) <= @INintTamanho)
		 SET @vchRetorno = (REPLICATE('0',@INintTamanho - DATALENGTH(CAST(@INintValor AS VARCHAR))) + CAST(@INintValor AS VARCHAR))
	  ELSE
		SET @vchRetorno = CAST(@INintValor AS VARCHAR)
		
	RETURN @vchRetorno
END


GO
/****** Object:  UserDefinedFunction [dbo].[ufnZerosEsquerdaTexto]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ufnZerosEsquerdaTexto]
(
	@INintTamanho INT, 
	@INvchValor VARCHAR(400)
)
RETURNS VARCHAR (400)
AS
BEGIN
	 --RETURN REPLICATE('0',@INintTamanho - LEN(CAST(@INvchValor AS VARCHAR))) + CAST(@INvchValor AS VARCHAR)
	 
	 DECLARE @vchRetorno VARCHAR(400)

	  IF(DATALENGTH(@INvchValor) <= @INintTamanho)
		 SET @vchRetorno = (REPLICATE('0',@INintTamanho - DATALENGTH(CAST(@INvchValor AS VARCHAR(400)))) + CAST(@INvchValor AS VARCHAR(400)))
	  ELSE
		SET @vchRetorno = @INvchValor
		
	RETURN @vchRetorno
END

GO
/****** Object:  Table [dbo].[tblCliente]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCliente](
	[IDPessoaCliente] [int] NOT NULL,
	[DataCadastro] [datetime] NULL,
	[LimiteMinimo] [decimal](12, 2) NULL,
	[LimiteMaximo] [decimal](12, 2) NULL,
	[DataNascimento] [datetime] NULL,
 CONSTRAINT [PK_TLCLIENTEIDPESSOACLIENTE] PRIMARY KEY CLUSTERED 
(
	[IDPessoaCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblContasPagar]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblContasPagar](
	[IDContasPagar] [int] IDENTITY(1,1) NOT NULL,
	[IDPessoaFornecedor] [int] NULL,
	[DataPagamento] [datetime] NULL,
	[DataVencimento] [datetime] NULL,
	[Valor] [decimal](18, 2) NOT NULL,
	[Observacao] [varchar](250) NULL,
	[IDSituacao] [int] NULL,
	[IDOperacao] [int] NULL,
	[IDContasPagarTipo] [int] NULL,
	[DataLancamento] [datetime] NULL,
 CONSTRAINT [PK_tblContasPagarIDContasPagar] PRIMARY KEY CLUSTERED 
(
	[IDContasPagar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblContasPagarTipo]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblContasPagarTipo](
	[IDContasPagarTipo] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NULL,
	[Ativo] [bit] NULL DEFAULT ((0)),
 CONSTRAINT [PK_tblContasPagarTipo] PRIMARY KEY CLUSTERED 
(
	[IDContasPagarTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblContasReceber]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblContasReceber](
	[IDContasReceber] [int] IDENTITY(1,1) NOT NULL,
	[DataPagamento] [date] NULL,
	[ValorTotal] [decimal](18, 2) NULL,
	[DataLancamento] [datetime] NULL,
	[DataVencimento] [date] NULL,
	[IDContasReceberSituacao] [int] NOT NULL,
	[IDPessoaCliente] [int] NOT NULL,
	[IDPessoaVendedor] [int] NOT NULL,
	[IDUsuario] [int] NULL,
	[IDPedido] [int] NOT NULL,
	[IDTipoPagamento] [int] NULL,
	[IDContasReceberOrigem] [int] NOT NULL,
	[ValorPagar] [decimal](18, 2) NULL,
 CONSTRAINT [PK_TBLCONTASRECEBERIDCONTASRECEBER] PRIMARY KEY CLUSTERED 
(
	[IDContasReceber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblContasReceberOrigem]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblContasReceberOrigem](
	[IDContasReceberOrigem] [int] NOT NULL,
	[Descricao] [varchar](30) NOT NULL,
 CONSTRAINT [PK_tblContasReceberOrigem] PRIMARY KEY CLUSTERED 
(
	[IDContasReceberOrigem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblContasReceberSituacao]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblContasReceberSituacao](
	[IDSituacao] [int] NOT NULL,
	[Descricao] [varchar](20) NOT NULL,
 CONSTRAINT [PK_ContasReceberSitucaoIDSituacao] PRIMARY KEY CLUSTERED 
(
	[IDSituacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblEMail]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblEMail](
	[IDEmail] [int] IDENTITY(1,1) NOT NULL,
	[IDPessoa] [int] NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
	[Principal] [bit] NULL,
 CONSTRAINT [PK_TBLEMAILIDEMAIL] PRIMARY KEY CLUSTERED 
(
	[IDEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblEndereco]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblEndereco](
	[IDEndereco] [int] IDENTITY(1,1) NOT NULL,
	[IDPessoa] [int] NOT NULL,
	[Logradouro] [varchar](100) NULL,
	[Numero] [smallint] NULL,
	[Complemento] [varchar](50) NULL DEFAULT (NULL),
	[Bairro] [varchar](80) NULL,
	[Cep] [decimal](9, 0) NULL,
	[Cidade] [varchar](50) NOT NULL,
	[Principal] [bit] NULL,
 CONSTRAINT [PK_TBLENDERECOIDENDERECO] PRIMARY KEY CLUSTERED 
(
	[IDEndereco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblEstoque]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEstoque](
	[IDProduto] [int] NOT NULL,
	[Quantidade] [decimal](12, 0) NOT NULL,
 CONSTRAINT [PK_TBLESTOQUEIDPRODUTO] PRIMARY KEY CLUSTERED 
(
	[IDProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblEstoqueMovimentacao]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblEstoqueMovimentacao](
	[IDMovimentacao] [int] IDENTITY(1,1) NOT NULL,
	[Data] [datetime] NOT NULL,
	[IDProduto] [int] NOT NULL,
	[Quantidade] [decimal](18, 2) NOT NULL,
	[Operacao] [char](1) NOT NULL,
 CONSTRAINT [PK_tblEstoqueMovimentacaoIDMovimentacao] PRIMARY KEY CLUSTERED 
(
	[IDMovimentacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblFornecedor]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblFornecedor](
	[IDPessoaFornecedor] [int] NOT NULL,
	[IE] [varchar](15) NULL,
	[DataCadastro] [datetime] NULL,
 CONSTRAINT [PK_TBLFORNECEDORIDPESSOAFORNECEDOR] PRIMARY KEY CLUSTERED 
(
	[IDPessoaFornecedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBLNIVELACESSO]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBLNIVELACESSO](
	[IDNIVELACESSO] [int] NOT NULL,
	[DESCRICAO] [varchar](30) NOT NULL,
 CONSTRAINT [PK_TBLNIVELACESSOIDNIVELACESSO] PRIMARY KEY CLUSTERED 
(
	[IDNIVELACESSO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBLNIVELACESSOUSUARIO]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLNIVELACESSOUSUARIO](
	[IDUSUARIO] [int] NOT NULL,
	[IDNIVELACESSO] [int] NOT NULL,
 CONSTRAINT [PK_IDUSUARIONIVELACESSO] PRIMARY KEY CLUSTERED 
(
	[IDUSUARIO] ASC,
	[IDNIVELACESSO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblOperacao]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblOperacao](
	[IDOperacao] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](20) NOT NULL,
 CONSTRAINT [PK_TBLOPERACAOIDOPERACAO] PRIMARY KEY CLUSTERED 
(
	[IDOperacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblOperacaoSituacao]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblOperacaoSituacao](
	[IDOperacao] [int] NOT NULL,
	[IDSituacao] [int] NOT NULL,
 CONSTRAINT [PK_TBLOPERACAOSITUACAOIDOPERACAOIDSITUACAO] PRIMARY KEY CLUSTERED 
(
	[IDOperacao] ASC,
	[IDSituacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblPedido]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPedido](
	[IDPedido] [int] IDENTITY(1,1) NOT NULL,
	[IDPessoaCliente] [int] NOT NULL,
	[IDPessoaVendedor] [int] NOT NULL,
	[IDOperacao] [int] NOT NULL,
	[IDSituacao] [int] NOT NULL,
	[DataPedido] [datetime] NOT NULL,
	[Observacao] [varchar](100) NULL,
	[IDPedidoTipo] [int] NOT NULL,
	[ValorTotal] [decimal](8, 2) NULL,
	[IDContasReceber] [int] NULL,
 CONSTRAINT [PK_TBLPEDIDOIDPEDIDO] PRIMARY KEY CLUSTERED 
(
	[IDPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPedidoItem]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPedidoItem](
	[IDPedido] [int] NOT NULL,
	[IDProduto] [int] NOT NULL,
	[Quantidade] [decimal](12, 0) NOT NULL,
	[Preco] [decimal](8, 2) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblPedidoTipo]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPedidoTipo](
	[IDPedidoTipo] [int] NOT NULL,
	[DescricaoPedidoTipo] [varchar](25) NOT NULL,
 CONSTRAINT [PK_TBLPEDIDOTIPOIDPEDIOTIPO] PRIMARY KEY CLUSTERED 
(
	[IDPedidoTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPessoa]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPessoa](
	[IDPessoa] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NULL,
	[CpfCnpj] [decimal](14, 0) NULL,
	[Ativo] [bit] NULL DEFAULT ((1)),
 CONSTRAINT [PK_TBLPESSOAIDPESSOA] PRIMARY KEY CLUSTERED 
(
	[IDPessoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblProduto]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblProduto](
	[IDProduto] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](80) NOT NULL,
	[Ativo] [bit] NULL DEFAULT ((1)),
	[Largura] [decimal](10, 3) NULL,
	[Altura] [decimal](10, 3) NULL,
	[Profudidade] [decimal](10, 3) NULL,
	[Cubagem] [decimal](10, 3) NULL,
	[QuanitadeMinima] [decimal](12, 0) NULL,
	[Quantidade] [decimal](12, 0) NULL,
	[Preco] [decimal](18, 2) NULL,
 CONSTRAINT [PK_TBLPRODUTOIDPRODUTO] PRIMARY KEY CLUSTERED 
(
	[IDProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblSituacao]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblSituacao](
	[IDSituacao] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](20) NOT NULL,
 CONSTRAINT [PK_TBLSITUACAOIDSITUACAO] PRIMARY KEY CLUSTERED 
(
	[IDSituacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblTelefone]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTelefone](
	[IDTelefone] [int] IDENTITY(1,1) NOT NULL,
	[IDPessoa] [int] NOT NULL,
	[Numero] [decimal](13, 0) NOT NULL,
	[Principal] [bit] NULL,
	[TipoTelefone] [varchar](12) NOT NULL,
 CONSTRAINT [PK_TBLTELEFONE] PRIMARY KEY CLUSTERED 
(
	[IDTelefone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblTipoPagamento]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTipoPagamento](
	[IDTipoPagamento] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](40) NULL,
	[Ativo] [bit] NULL,
 CONSTRAINT [PK_TBLTIPOPAGAMENTOIDPAGAMENTO] PRIMARY KEY CLUSTERED 
(
	[IDTipoPagamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblUsuario]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblUsuario](
	[IDUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](20) NOT NULL,
	[Senha] [varchar](20) NOT NULL,
	[IDPessoa] [int] NULL,
 CONSTRAINT [PK_TBLUSUARIOIDUSUARIO] PRIMARY KEY CLUSTERED 
(
	[IDUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblVendedor]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblVendedor](
	[IDPessoaVendedor] [int] NOT NULL,
	[DataCadastro] [datetime] NULL,
 CONSTRAINT [PK_TBVENDEDORIDPESSOAVENDEDOR] PRIMARY KEY CLUSTERED 
(
	[IDPessoaVendedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[tblCliente] ([IDPessoaCliente], [DataCadastro], [LimiteMinimo], [LimiteMaximo], [DataNascimento]) VALUES (14, CAST(N'2016-09-11 00:00:00.000' AS DateTime), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(N'2016-09-11 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[tblCliente] ([IDPessoaCliente], [DataCadastro], [LimiteMinimo], [LimiteMaximo], [DataNascimento]) VALUES (32, CAST(N'2016-10-13 00:00:00.000' AS DateTime), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(N'2016-10-13 00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[tblContasPagar] ON 

GO
INSERT [dbo].[tblContasPagar] ([IDContasPagar], [IDPessoaFornecedor], [DataPagamento], [DataVencimento], [Valor], [Observacao], [IDSituacao], [IDOperacao], [IDContasPagarTipo], [DataLancamento]) VALUES (2, 31, NULL, CAST(N'2016-11-14 00:00:00.000' AS DateTime), CAST(10.00 AS Decimal(18, 2)), N'OBSERVAÇÕES', 2, 3, 5, CAST(N'2016-01-14 00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[tblContasPagar] OFF
GO
SET IDENTITY_INSERT [dbo].[tblContasPagarTipo] ON 

GO
INSERT [dbo].[tblContasPagarTipo] ([IDContasPagarTipo], [Descricao], [Ativo]) VALUES (5, N'FORNERCEDORCCCCC', 1)
GO
INSERT [dbo].[tblContasPagarTipo] ([IDContasPagarTipo], [Descricao], [Ativo]) VALUES (6, N'FORNERCEDOR', 1)
GO
INSERT [dbo].[tblContasPagarTipo] ([IDContasPagarTipo], [Descricao], [Ativo]) VALUES (7, N'FORNERCEDOR', 1)
GO
INSERT [dbo].[tblContasPagarTipo] ([IDContasPagarTipo], [Descricao], [Ativo]) VALUES (8, N'FORNERCEDOR', 1)
GO
SET IDENTITY_INSERT [dbo].[tblContasPagarTipo] OFF
GO
SET IDENTITY_INSERT [dbo].[tblContasReceber] ON 

GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (2, NULL, CAST(102.50 AS Decimal(18, 2)), CAST(N'2016-09-09 00:00:00.000' AS DateTime), NULL, 3, 11, 13, NULL, 1026, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (3, NULL, CAST(102.50 AS Decimal(18, 2)), CAST(N'2016-09-09 00:00:00.000' AS DateTime), NULL, 3, 11, 13, NULL, 1027, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (4, NULL, CAST(1025.00 AS Decimal(18, 2)), CAST(N'2016-11-09 00:00:00.000' AS DateTime), NULL, 3, 11, 13, NULL, 1028, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (5, NULL, CAST(1025.00 AS Decimal(18, 2)), CAST(N'2016-11-09 00:00:00.000' AS DateTime), NULL, 3, 11, 13, NULL, 1028, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (6, NULL, CAST(1025.00 AS Decimal(18, 2)), CAST(N'2016-11-09 00:00:00.000' AS DateTime), NULL, 3, 11, 13, NULL, 1028, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (7, NULL, CAST(102.50 AS Decimal(18, 2)), CAST(N'2016-11-09 00:00:00.000' AS DateTime), NULL, 3, 11, 13, NULL, 1029, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (8, NULL, CAST(102.50 AS Decimal(18, 2)), CAST(N'2016-11-09 00:00:00.000' AS DateTime), NULL, 3, 11, 13, NULL, 1029, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (9, NULL, CAST(102.50 AS Decimal(18, 2)), CAST(N'2016-11-09 00:00:00.000' AS DateTime), NULL, 3, 11, 13, NULL, 1029, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (10, NULL, CAST(102.50 AS Decimal(18, 2)), CAST(N'2016-11-09 00:00:00.000' AS DateTime), NULL, 3, 11, 13, NULL, 1029, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (11, NULL, CAST(102.50 AS Decimal(18, 2)), CAST(N'2016-11-09 00:00:00.000' AS DateTime), NULL, 3, 11, 13, NULL, 1029, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (12, NULL, CAST(102.50 AS Decimal(18, 2)), CAST(N'2016-11-09 00:00:00.000' AS DateTime), NULL, 3, 11, 13, NULL, 1029, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (13, NULL, CAST(102.50 AS Decimal(18, 2)), CAST(N'2016-11-09 00:00:00.000' AS DateTime), NULL, 3, 11, 13, NULL, 1029, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (14, NULL, CAST(102.50 AS Decimal(18, 2)), CAST(N'2016-11-09 22:35:58.800' AS DateTime), NULL, 3, 11, 13, NULL, 1029, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (15, NULL, CAST(102.50 AS Decimal(18, 2)), CAST(N'2016-11-09 22:36:44.283' AS DateTime), NULL, 1, 11, 13, NULL, 1029, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (16, NULL, CAST(102.50 AS Decimal(18, 2)), CAST(N'2016-11-09 22:37:39.180' AS DateTime), NULL, 1, 11, 13, NULL, 1029, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (17, NULL, CAST(102.50 AS Decimal(18, 2)), CAST(N'2016-11-09 22:41:31.753' AS DateTime), NULL, 1, 11, 13, NULL, 1029, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (18, NULL, CAST(102.50 AS Decimal(18, 2)), CAST(N'2016-11-09 22:41:46.960' AS DateTime), NULL, 1, 11, 13, NULL, 1029, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (19, NULL, CAST(10.25 AS Decimal(18, 2)), CAST(N'2016-09-11 23:44:54.410' AS DateTime), NULL, 3, 14, 15, NULL, 1030, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (20, NULL, CAST(10.25 AS Decimal(18, 2)), CAST(N'2016-09-11 23:46:07.763' AS DateTime), NULL, 3, 14, 15, NULL, 1030, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (21, NULL, CAST(10.25 AS Decimal(18, 2)), CAST(N'2016-09-11 23:46:46.913' AS DateTime), NULL, 3, 14, 15, NULL, 1030, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (22, NULL, CAST(10.25 AS Decimal(18, 2)), CAST(N'2016-09-11 23:49:17.420' AS DateTime), NULL, 3, 14, 15, NULL, 1030, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (23, NULL, CAST(10.25 AS Decimal(18, 2)), CAST(N'2016-09-11 23:55:27.890' AS DateTime), NULL, 3, 14, 15, NULL, 1030, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (24, NULL, CAST(10.25 AS Decimal(18, 2)), CAST(N'2016-09-11 23:56:04.847' AS DateTime), NULL, 1, 14, 15, NULL, 1030, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (25, NULL, CAST(102.50 AS Decimal(18, 2)), CAST(N'2016-09-13 19:40:34.453' AS DateTime), NULL, 3, 14, 15, NULL, 1031, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (26, NULL, CAST(102.50 AS Decimal(18, 2)), CAST(N'2016-09-13 19:45:39.210' AS DateTime), NULL, 3, 14, 15, NULL, 1031, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (27, NULL, CAST(102.50 AS Decimal(18, 2)), CAST(N'2016-09-13 19:55:09.390' AS DateTime), NULL, 3, 14, 15, NULL, 1031, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (28, NULL, CAST(10250.00 AS Decimal(18, 2)), CAST(N'2016-09-13 20:12:27.120' AS DateTime), NULL, 3, 14, 15, NULL, 1033, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (29, NULL, CAST(10250.00 AS Decimal(18, 2)), CAST(N'2016-09-13 20:14:31.093' AS DateTime), NULL, 3, 14, 15, NULL, 1033, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (30, NULL, CAST(102.50 AS Decimal(18, 2)), CAST(N'2016-09-13 20:17:53.160' AS DateTime), NULL, 3, 14, 15, NULL, 1034, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (31, NULL, CAST(102.50 AS Decimal(18, 2)), CAST(N'2016-09-13 20:28:33.547' AS DateTime), NULL, 3, 14, 15, NULL, 1034, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (32, NULL, CAST(102.50 AS Decimal(18, 2)), CAST(N'2016-09-13 20:29:52.987' AS DateTime), NULL, 3, 14, 15, NULL, 1034, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (33, NULL, CAST(102.50 AS Decimal(18, 2)), CAST(N'2016-09-13 20:45:59.083' AS DateTime), NULL, 3, 14, 15, NULL, 1034, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (34, NULL, CAST(102.50 AS Decimal(18, 2)), CAST(N'2016-09-13 21:59:33.013' AS DateTime), NULL, 3, 14, 15, NULL, 1035, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (35, NULL, CAST(102.50 AS Decimal(18, 2)), CAST(N'2016-09-13 22:01:39.820' AS DateTime), NULL, 3, 14, 15, NULL, 1036, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (36, NULL, CAST(102.50 AS Decimal(18, 2)), CAST(N'2016-09-13 22:07:21.767' AS DateTime), NULL, 3, 14, 15, NULL, 1037, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (37, NULL, CAST(205.00 AS Decimal(18, 2)), CAST(N'2016-09-15 20:45:26.910' AS DateTime), NULL, 3, 14, 15, NULL, 1038, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (38, NULL, CAST(30.60 AS Decimal(18, 2)), CAST(N'2016-11-10 21:48:39.410' AS DateTime), NULL, 3, 14, 15, NULL, 1039, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (39, NULL, CAST(123.00 AS Decimal(18, 2)), CAST(N'2016-11-15 15:42:50.103' AS DateTime), NULL, 3, 14, 15, NULL, 1040, NULL, 2, NULL)
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (40, CAST(N'2016-11-15' AS Date), CAST(123.00 AS Decimal(18, 2)), CAST(N'2016-11-15 15:47:52.867' AS DateTime), NULL, 2, 14, 15, NULL, 1040, NULL, 2, CAST(113.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[tblContasReceber] ([IDContasReceber], [DataPagamento], [ValorTotal], [DataLancamento], [DataVencimento], [IDContasReceberSituacao], [IDPessoaCliente], [IDPessoaVendedor], [IDUsuario], [IDPedido], [IDTipoPagamento], [IDContasReceberOrigem], [ValorPagar]) VALUES (41, NULL, CAST(102.50 AS Decimal(18, 2)), CAST(N'2016-11-15 20:18:47.157' AS DateTime), NULL, 1, 14, 15, NULL, 1041, NULL, 2, NULL)
GO
SET IDENTITY_INSERT [dbo].[tblContasReceber] OFF
GO
INSERT [dbo].[tblContasReceberOrigem] ([IDContasReceberOrigem], [Descricao]) VALUES (1, N'MANUAL')
GO
INSERT [dbo].[tblContasReceberOrigem] ([IDContasReceberOrigem], [Descricao]) VALUES (2, N'AUTOMÁTICO')
GO
INSERT [dbo].[tblContasReceberSituacao] ([IDSituacao], [Descricao]) VALUES (1, N'ABERTA')
GO
INSERT [dbo].[tblContasReceberSituacao] ([IDSituacao], [Descricao]) VALUES (2, N'PAGA')
GO
INSERT [dbo].[tblContasReceberSituacao] ([IDSituacao], [Descricao]) VALUES (3, N'EXCLUÍDA')
GO
SET IDENTITY_INSERT [dbo].[tblEMail] ON 

GO
INSERT [dbo].[tblEMail] ([IDEmail], [IDPessoa], [Descricao], [Principal]) VALUES (2, 11, N'GGGGGGGGGGGGGGG', 1)
GO
INSERT [dbo].[tblEMail] ([IDEmail], [IDPessoa], [Descricao], [Principal]) VALUES (3, 12, N'TESTE', 1)
GO
INSERT [dbo].[tblEMail] ([IDEmail], [IDPessoa], [Descricao], [Principal]) VALUES (4, 14, N'VMELIN@HOTMAIL.COM', 1)
GO
INSERT [dbo].[tblEMail] ([IDEmail], [IDPessoa], [Descricao], [Principal]) VALUES (6, 17, N'TESTE@HOTAIL.COM', 1)
GO
INSERT [dbo].[tblEMail] ([IDEmail], [IDPessoa], [Descricao], [Principal]) VALUES (8, 31, N'RRRRR', 0)
GO
INSERT [dbo].[tblEMail] ([IDEmail], [IDPessoa], [Descricao], [Principal]) VALUES (9, 32, N'TTTTTT', 0)
GO
INSERT [dbo].[tblEMail] ([IDEmail], [IDPessoa], [Descricao], [Principal]) VALUES (10, 15, N'UBIRAJARA@HOTMAIL.COM', 1)
GO
SET IDENTITY_INSERT [dbo].[tblEMail] OFF
GO
SET IDENTITY_INSERT [dbo].[tblEndereco] ON 

GO
INSERT [dbo].[tblEndereco] ([IDEndereco], [IDPessoa], [Logradouro], [Numero], [Complemento], [Bairro], [Cep], [Cidade], [Principal]) VALUES (1, 11, N'RUAHHHHH', 221, N'TESTE', N'TESTE', CAST(14709034 AS Decimal(9, 0)), N'BEBEDOUROTTT', 1)
GO
INSERT [dbo].[tblEndereco] ([IDEndereco], [IDPessoa], [Logradouro], [Numero], [Complemento], [Bairro], [Cep], [Cidade], [Principal]) VALUES (2, 11, N'TESTE', 1, N'RWR', N'RRRR', CAST(0 AS Decimal(9, 0)), N'BEBEDOURO', 0)
GO
INSERT [dbo].[tblEndereco] ([IDEndereco], [IDPessoa], [Logradouro], [Numero], [Complemento], [Bairro], [Cep], [Cidade], [Principal]) VALUES (4, 16, N'R', 11, N'TTTTT', N'R', CAST(14709034 AS Decimal(9, 0)), N'BEBEDOURO', 1)
GO
INSERT [dbo].[tblEndereco] ([IDEndereco], [IDPessoa], [Logradouro], [Numero], [Complemento], [Bairro], [Cep], [Cidade], [Principal]) VALUES (5, 17, N'TESTE', 22, N'FFF', N'TESTE', CAST(14555555 AS Decimal(9, 0)), N'BEBEDOURO', NULL)
GO
INSERT [dbo].[tblEndereco] ([IDEndereco], [IDPessoa], [Logradouro], [Numero], [Complemento], [Bairro], [Cep], [Cidade], [Principal]) VALUES (6, 32, N'RUA PASCHOAL CAMPANELLI', 221, N'', N'JARDIM CLAUDIA 2', CAST(14709034 AS Decimal(9, 0)), N'BEBEDOURO', NULL)
GO
SET IDENTITY_INSERT [dbo].[tblEndereco] OFF
GO
SET IDENTITY_INSERT [dbo].[tblEstoqueMovimentacao] ON 

GO
INSERT [dbo].[tblEstoqueMovimentacao] ([IDMovimentacao], [Data], [IDProduto], [Quantidade], [Operacao]) VALUES (3, CAST(N'2016-09-17 12:54:03.537' AS DateTime), 2, CAST(100.00 AS Decimal(18, 2)), N'C')
GO
INSERT [dbo].[tblEstoqueMovimentacao] ([IDMovimentacao], [Data], [IDProduto], [Quantidade], [Operacao]) VALUES (4, CAST(N'2016-09-17 12:54:19.073' AS DateTime), 2, CAST(100.00 AS Decimal(18, 2)), N'C')
GO
INSERT [dbo].[tblEstoqueMovimentacao] ([IDMovimentacao], [Data], [IDProduto], [Quantidade], [Operacao]) VALUES (5, CAST(N'2016-09-17 12:55:16.633' AS DateTime), 2, CAST(100.00 AS Decimal(18, 2)), N'D')
GO
INSERT [dbo].[tblEstoqueMovimentacao] ([IDMovimentacao], [Data], [IDProduto], [Quantidade], [Operacao]) VALUES (6, CAST(N'2016-09-17 12:55:22.543' AS DateTime), 2, CAST(100.00 AS Decimal(18, 2)), N'D')
GO
INSERT [dbo].[tblEstoqueMovimentacao] ([IDMovimentacao], [Data], [IDProduto], [Quantidade], [Operacao]) VALUES (7, CAST(N'2016-09-17 12:55:23.533' AS DateTime), 2, CAST(100.00 AS Decimal(18, 2)), N'D')
GO
INSERT [dbo].[tblEstoqueMovimentacao] ([IDMovimentacao], [Data], [IDProduto], [Quantidade], [Operacao]) VALUES (8, CAST(N'2016-09-17 12:55:26.150' AS DateTime), 2, CAST(100.00 AS Decimal(18, 2)), N'D')
GO
INSERT [dbo].[tblEstoqueMovimentacao] ([IDMovimentacao], [Data], [IDProduto], [Quantidade], [Operacao]) VALUES (9, CAST(N'2016-09-17 12:55:29.673' AS DateTime), 2, CAST(100.00 AS Decimal(18, 2)), N'D')
GO
INSERT [dbo].[tblEstoqueMovimentacao] ([IDMovimentacao], [Data], [IDProduto], [Quantidade], [Operacao]) VALUES (10, CAST(N'2016-09-17 12:57:41.080' AS DateTime), 2, CAST(100.00 AS Decimal(18, 2)), N'D')
GO
INSERT [dbo].[tblEstoqueMovimentacao] ([IDMovimentacao], [Data], [IDProduto], [Quantidade], [Operacao]) VALUES (11, CAST(N'2016-09-17 12:58:12.457' AS DateTime), 2, CAST(100.00 AS Decimal(18, 2)), N'D')
GO
INSERT [dbo].[tblEstoqueMovimentacao] ([IDMovimentacao], [Data], [IDProduto], [Quantidade], [Operacao]) VALUES (12, CAST(N'2016-09-17 12:58:27.367' AS DateTime), 2, CAST(120.00 AS Decimal(18, 2)), N'C')
GO
INSERT [dbo].[tblEstoqueMovimentacao] ([IDMovimentacao], [Data], [IDProduto], [Quantidade], [Operacao]) VALUES (13, CAST(N'2016-09-17 13:27:08.883' AS DateTime), 2, CAST(10.00 AS Decimal(18, 2)), N'D')
GO
INSERT [dbo].[tblEstoqueMovimentacao] ([IDMovimentacao], [Data], [IDProduto], [Quantidade], [Operacao]) VALUES (14, CAST(N'2016-09-17 13:27:34.413' AS DateTime), 2, CAST(10.00 AS Decimal(18, 2)), N'D')
GO
INSERT [dbo].[tblEstoqueMovimentacao] ([IDMovimentacao], [Data], [IDProduto], [Quantidade], [Operacao]) VALUES (15, CAST(N'2016-09-17 13:29:04.557' AS DateTime), 2, CAST(10.00 AS Decimal(18, 2)), N'D')
GO
INSERT [dbo].[tblEstoqueMovimentacao] ([IDMovimentacao], [Data], [IDProduto], [Quantidade], [Operacao]) VALUES (16, CAST(N'2016-09-17 13:32:09.733' AS DateTime), 2, CAST(120.00 AS Decimal(18, 2)), N'C')
GO
INSERT [dbo].[tblEstoqueMovimentacao] ([IDMovimentacao], [Data], [IDProduto], [Quantidade], [Operacao]) VALUES (17, CAST(N'2016-09-17 13:35:39.570' AS DateTime), 2, CAST(10.00 AS Decimal(18, 2)), N'D')
GO
INSERT [dbo].[tblEstoqueMovimentacao] ([IDMovimentacao], [Data], [IDProduto], [Quantidade], [Operacao]) VALUES (18, CAST(N'2016-09-17 13:36:56.557' AS DateTime), 2, CAST(101.00 AS Decimal(18, 2)), N'C')
GO
INSERT [dbo].[tblEstoqueMovimentacao] ([IDMovimentacao], [Data], [IDProduto], [Quantidade], [Operacao]) VALUES (19, CAST(N'2016-11-10 21:44:51.073' AS DateTime), 7, CAST(10.00 AS Decimal(18, 2)), N'D')
GO
INSERT [dbo].[tblEstoqueMovimentacao] ([IDMovimentacao], [Data], [IDProduto], [Quantidade], [Operacao]) VALUES (20, CAST(N'2016-11-15 14:06:28.027' AS DateTime), 2, CAST(100.00 AS Decimal(18, 2)), N'D')
GO
INSERT [dbo].[tblEstoqueMovimentacao] ([IDMovimentacao], [Data], [IDProduto], [Quantidade], [Operacao]) VALUES (21, CAST(N'2016-11-15 14:06:46.183' AS DateTime), 3, CAST(100.00 AS Decimal(18, 2)), N'D')
GO
INSERT [dbo].[tblEstoqueMovimentacao] ([IDMovimentacao], [Data], [IDProduto], [Quantidade], [Operacao]) VALUES (22, CAST(N'2016-11-15 14:34:16.110' AS DateTime), 2, CAST(2.00 AS Decimal(18, 2)), N'C')
GO
INSERT [dbo].[tblEstoqueMovimentacao] ([IDMovimentacao], [Data], [IDProduto], [Quantidade], [Operacao]) VALUES (23, CAST(N'2016-11-15 14:34:16.110' AS DateTime), 6, CAST(2.00 AS Decimal(18, 2)), N'D')
GO
INSERT [dbo].[tblEstoqueMovimentacao] ([IDMovimentacao], [Data], [IDProduto], [Quantidade], [Operacao]) VALUES (24, CAST(N'2016-11-15 20:03:52.750' AS DateTime), 8, CAST(10.00 AS Decimal(18, 2)), N'D')
GO
INSERT [dbo].[tblEstoqueMovimentacao] ([IDMovimentacao], [Data], [IDProduto], [Quantidade], [Operacao]) VALUES (25, CAST(N'2016-11-15 20:04:57.450' AS DateTime), 8, CAST(5.00 AS Decimal(18, 2)), N'C')
GO
SET IDENTITY_INSERT [dbo].[tblEstoqueMovimentacao] OFF
GO
INSERT [dbo].[tblFornecedor] ([IDPessoaFornecedor], [IE], [DataCadastro]) VALUES (31, N'INSETO', CAST(N'2016-10-13 00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[tblOperacao] ON 

GO
INSERT [dbo].[tblOperacao] ([IDOperacao], [Descricao]) VALUES (1, N'VENDA')
GO
INSERT [dbo].[tblOperacao] ([IDOperacao], [Descricao]) VALUES (2, N'ORÇAMENTO')
GO
INSERT [dbo].[tblOperacao] ([IDOperacao], [Descricao]) VALUES (3, N'CONTAS A PAGAR')
GO
SET IDENTITY_INSERT [dbo].[tblOperacao] OFF
GO
INSERT [dbo].[tblOperacaoSituacao] ([IDOperacao], [IDSituacao]) VALUES (1, 1)
GO
INSERT [dbo].[tblOperacaoSituacao] ([IDOperacao], [IDSituacao]) VALUES (1, 2)
GO
INSERT [dbo].[tblOperacaoSituacao] ([IDOperacao], [IDSituacao]) VALUES (1, 3)
GO
INSERT [dbo].[tblOperacaoSituacao] ([IDOperacao], [IDSituacao]) VALUES (2, 1)
GO
INSERT [dbo].[tblOperacaoSituacao] ([IDOperacao], [IDSituacao]) VALUES (2, 2)
GO
INSERT [dbo].[tblOperacaoSituacao] ([IDOperacao], [IDSituacao]) VALUES (2, 3)
GO
INSERT [dbo].[tblOperacaoSituacao] ([IDOperacao], [IDSituacao]) VALUES (3, 1)
GO
INSERT [dbo].[tblOperacaoSituacao] ([IDOperacao], [IDSituacao]) VALUES (3, 2)
GO
INSERT [dbo].[tblOperacaoSituacao] ([IDOperacao], [IDSituacao]) VALUES (3, 4)
GO
SET IDENTITY_INSERT [dbo].[tblPedido] ON 

GO
INSERT [dbo].[tblPedido] ([IDPedido], [IDPessoaCliente], [IDPessoaVendedor], [IDOperacao], [IDSituacao], [DataPedido], [Observacao], [IDPedidoTipo], [ValorTotal], [IDContasReceber]) VALUES (1020, 11, 13, 1, 2, CAST(N'2016-04-09 00:00:00.000' AS DateTime), NULL, 1, CAST(102.50 AS Decimal(8, 2)), NULL)
GO
INSERT [dbo].[tblPedido] ([IDPedido], [IDPessoaCliente], [IDPessoaVendedor], [IDOperacao], [IDSituacao], [DataPedido], [Observacao], [IDPedidoTipo], [ValorTotal], [IDContasReceber]) VALUES (1025, 11, 13, 1, 2, CAST(N'2016-08-09 00:00:00.000' AS DateTime), NULL, 1, CAST(102.50 AS Decimal(8, 2)), NULL)
GO
INSERT [dbo].[tblPedido] ([IDPedido], [IDPessoaCliente], [IDPessoaVendedor], [IDOperacao], [IDSituacao], [DataPedido], [Observacao], [IDPedidoTipo], [ValorTotal], [IDContasReceber]) VALUES (1026, 11, 13, 1, 1, CAST(N'2016-09-09 00:00:00.000' AS DateTime), NULL, 1, CAST(102.50 AS Decimal(8, 2)), NULL)
GO
INSERT [dbo].[tblPedido] ([IDPedido], [IDPessoaCliente], [IDPessoaVendedor], [IDOperacao], [IDSituacao], [DataPedido], [Observacao], [IDPedidoTipo], [ValorTotal], [IDContasReceber]) VALUES (1027, 11, 13, 1, 1, CAST(N'2016-09-09 00:00:00.000' AS DateTime), NULL, 1, CAST(102.50 AS Decimal(8, 2)), NULL)
GO
INSERT [dbo].[tblPedido] ([IDPedido], [IDPessoaCliente], [IDPessoaVendedor], [IDOperacao], [IDSituacao], [DataPedido], [Observacao], [IDPedidoTipo], [ValorTotal], [IDContasReceber]) VALUES (1028, 11, 13, 1, 1, CAST(N'2016-11-09 00:00:00.000' AS DateTime), NULL, 1, CAST(1025.00 AS Decimal(8, 2)), 6)
GO
INSERT [dbo].[tblPedido] ([IDPedido], [IDPessoaCliente], [IDPessoaVendedor], [IDOperacao], [IDSituacao], [DataPedido], [Observacao], [IDPedidoTipo], [ValorTotal], [IDContasReceber]) VALUES (1029, 11, 13, 1, 3, CAST(N'2016-11-09 00:00:00.000' AS DateTime), NULL, 1, CAST(102.50 AS Decimal(8, 2)), 18)
GO
INSERT [dbo].[tblPedido] ([IDPedido], [IDPessoaCliente], [IDPessoaVendedor], [IDOperacao], [IDSituacao], [DataPedido], [Observacao], [IDPedidoTipo], [ValorTotal], [IDContasReceber]) VALUES (1030, 14, 15, 1, 3, CAST(N'2016-09-11 00:00:00.000' AS DateTime), NULL, 1, CAST(10.25 AS Decimal(8, 2)), 24)
GO
INSERT [dbo].[tblPedido] ([IDPedido], [IDPessoaCliente], [IDPessoaVendedor], [IDOperacao], [IDSituacao], [DataPedido], [Observacao], [IDPedidoTipo], [ValorTotal], [IDContasReceber]) VALUES (1031, 14, 15, 1, 1, CAST(N'2016-09-13 00:00:00.000' AS DateTime), NULL, 1, CAST(102.50 AS Decimal(8, 2)), 27)
GO
INSERT [dbo].[tblPedido] ([IDPedido], [IDPessoaCliente], [IDPessoaVendedor], [IDOperacao], [IDSituacao], [DataPedido], [Observacao], [IDPedidoTipo], [ValorTotal], [IDContasReceber]) VALUES (1032, 14, 15, 1, 1, CAST(N'2016-09-13 00:00:00.000' AS DateTime), NULL, 1, CAST(102.50 AS Decimal(8, 2)), NULL)
GO
INSERT [dbo].[tblPedido] ([IDPedido], [IDPessoaCliente], [IDPessoaVendedor], [IDOperacao], [IDSituacao], [DataPedido], [Observacao], [IDPedidoTipo], [ValorTotal], [IDContasReceber]) VALUES (1033, 14, 15, 1, 1, CAST(N'2016-09-13 00:00:00.000' AS DateTime), NULL, 1, CAST(10250.00 AS Decimal(8, 2)), 29)
GO
INSERT [dbo].[tblPedido] ([IDPedido], [IDPessoaCliente], [IDPessoaVendedor], [IDOperacao], [IDSituacao], [DataPedido], [Observacao], [IDPedidoTipo], [ValorTotal], [IDContasReceber]) VALUES (1034, 14, 15, 1, 1, CAST(N'2016-09-13 00:00:00.000' AS DateTime), NULL, 1, CAST(102.50 AS Decimal(8, 2)), 33)
GO
INSERT [dbo].[tblPedido] ([IDPedido], [IDPessoaCliente], [IDPessoaVendedor], [IDOperacao], [IDSituacao], [DataPedido], [Observacao], [IDPedidoTipo], [ValorTotal], [IDContasReceber]) VALUES (1035, 14, 15, 1, 1, CAST(N'2016-09-13 00:00:00.000' AS DateTime), NULL, 1, CAST(102.50 AS Decimal(8, 2)), 34)
GO
INSERT [dbo].[tblPedido] ([IDPedido], [IDPessoaCliente], [IDPessoaVendedor], [IDOperacao], [IDSituacao], [DataPedido], [Observacao], [IDPedidoTipo], [ValorTotal], [IDContasReceber]) VALUES (1036, 14, 15, 1, 1, CAST(N'2016-09-13 00:00:00.000' AS DateTime), NULL, 1, CAST(102.50 AS Decimal(8, 2)), 35)
GO
INSERT [dbo].[tblPedido] ([IDPedido], [IDPessoaCliente], [IDPessoaVendedor], [IDOperacao], [IDSituacao], [DataPedido], [Observacao], [IDPedidoTipo], [ValorTotal], [IDContasReceber]) VALUES (1037, 14, 15, 1, 1, CAST(N'2016-09-13 00:00:00.000' AS DateTime), NULL, 1, CAST(102.50 AS Decimal(8, 2)), 36)
GO
INSERT [dbo].[tblPedido] ([IDPedido], [IDPessoaCliente], [IDPessoaVendedor], [IDOperacao], [IDSituacao], [DataPedido], [Observacao], [IDPedidoTipo], [ValorTotal], [IDContasReceber]) VALUES (1038, 14, 15, 1, 1, CAST(N'2016-09-15 00:00:00.000' AS DateTime), NULL, 1, CAST(205.00 AS Decimal(8, 2)), 37)
GO
INSERT [dbo].[tblPedido] ([IDPedido], [IDPessoaCliente], [IDPessoaVendedor], [IDOperacao], [IDSituacao], [DataPedido], [Observacao], [IDPedidoTipo], [ValorTotal], [IDContasReceber]) VALUES (1039, 14, 15, 1, 1, CAST(N'2016-11-10 00:00:00.000' AS DateTime), NULL, 1, CAST(30.60 AS Decimal(8, 2)), 38)
GO
INSERT [dbo].[tblPedido] ([IDPedido], [IDPessoaCliente], [IDPessoaVendedor], [IDOperacao], [IDSituacao], [DataPedido], [Observacao], [IDPedidoTipo], [ValorTotal], [IDContasReceber]) VALUES (1040, 14, 15, 2, 3, CAST(N'2016-11-15 00:00:00.000' AS DateTime), NULL, 2, CAST(123.00 AS Decimal(8, 2)), 40)
GO
INSERT [dbo].[tblPedido] ([IDPedido], [IDPessoaCliente], [IDPessoaVendedor], [IDOperacao], [IDSituacao], [DataPedido], [Observacao], [IDPedidoTipo], [ValorTotal], [IDContasReceber]) VALUES (1041, 14, 15, 1, 3, CAST(N'2016-11-15 00:00:00.000' AS DateTime), NULL, 1, CAST(102.50 AS Decimal(8, 2)), 41)
GO
SET IDENTITY_INSERT [dbo].[tblPedido] OFF
GO
INSERT [dbo].[tblPedidoItem] ([IDPedido], [IDProduto], [Quantidade], [Preco]) VALUES (1030, 2, CAST(1 AS Decimal(12, 0)), CAST(10.25 AS Decimal(8, 2)))
GO
INSERT [dbo].[tblPedidoItem] ([IDPedido], [IDProduto], [Quantidade], [Preco]) VALUES (1031, 2, CAST(10 AS Decimal(12, 0)), CAST(10.25 AS Decimal(8, 2)))
GO
INSERT [dbo].[tblPedidoItem] ([IDPedido], [IDProduto], [Quantidade], [Preco]) VALUES (1032, 2, CAST(10 AS Decimal(12, 0)), CAST(10.25 AS Decimal(8, 2)))
GO
INSERT [dbo].[tblPedidoItem] ([IDPedido], [IDProduto], [Quantidade], [Preco]) VALUES (1033, 2, CAST(1000 AS Decimal(12, 0)), CAST(10.25 AS Decimal(8, 2)))
GO
INSERT [dbo].[tblPedidoItem] ([IDPedido], [IDProduto], [Quantidade], [Preco]) VALUES (1039, 7, CAST(3 AS Decimal(12, 0)), CAST(10.20 AS Decimal(8, 2)))
GO
INSERT [dbo].[tblPedidoItem] ([IDPedido], [IDProduto], [Quantidade], [Preco]) VALUES (1040, 2, CAST(12 AS Decimal(12, 0)), CAST(10.25 AS Decimal(8, 2)))
GO
INSERT [dbo].[tblPedidoItem] ([IDPedido], [IDProduto], [Quantidade], [Preco]) VALUES (1034, 2, CAST(10 AS Decimal(12, 0)), CAST(10.25 AS Decimal(8, 2)))
GO
INSERT [dbo].[tblPedidoItem] ([IDPedido], [IDProduto], [Quantidade], [Preco]) VALUES (1035, 2, CAST(10 AS Decimal(12, 0)), CAST(10.25 AS Decimal(8, 2)))
GO
INSERT [dbo].[tblPedidoItem] ([IDPedido], [IDProduto], [Quantidade], [Preco]) VALUES (1036, 2, CAST(10 AS Decimal(12, 0)), CAST(10.25 AS Decimal(8, 2)))
GO
INSERT [dbo].[tblPedidoItem] ([IDPedido], [IDProduto], [Quantidade], [Preco]) VALUES (1037, 2, CAST(10 AS Decimal(12, 0)), CAST(10.25 AS Decimal(8, 2)))
GO
INSERT [dbo].[tblPedidoItem] ([IDPedido], [IDProduto], [Quantidade], [Preco]) VALUES (1038, 2, CAST(20 AS Decimal(12, 0)), CAST(10.25 AS Decimal(8, 2)))
GO
INSERT [dbo].[tblPedidoTipo] ([IDPedidoTipo], [DescricaoPedidoTipo]) VALUES (1, N'VENDA')
GO
INSERT [dbo].[tblPedidoTipo] ([IDPedidoTipo], [DescricaoPedidoTipo]) VALUES (2, N'ORÇAMENTO')
GO
SET IDENTITY_INSERT [dbo].[tblPessoa] ON 

GO
INSERT [dbo].[tblPessoa] ([IDPessoa], [Nome], [CpfCnpj], [Ativo]) VALUES (11, N'TESTE', CAST(11111111111 AS Decimal(14, 0)), 1)
GO
INSERT [dbo].[tblPessoa] ([IDPessoa], [Nome], [CpfCnpj], [Ativo]) VALUES (12, N'TTTTTTTTTTTT', CAST(111111111 AS Decimal(14, 0)), 1)
GO
INSERT [dbo].[tblPessoa] ([IDPessoa], [Nome], [CpfCnpj], [Ativo]) VALUES (13, N'VINICIUS', CAST(44444444444 AS Decimal(14, 0)), 1)
GO
INSERT [dbo].[tblPessoa] ([IDPessoa], [Nome], [CpfCnpj], [Ativo]) VALUES (14, N'VINICIUS AUGUSTUS SILVA MELIN', CAST(22222222222 AS Decimal(14, 0)), 0)
GO
INSERT [dbo].[tblPessoa] ([IDPessoa], [Nome], [CpfCnpj], [Ativo]) VALUES (15, N'UBIRAJA', CAST(99999999999 AS Decimal(14, 0)), 1)
GO
INSERT [dbo].[tblPessoa] ([IDPessoa], [Nome], [CpfCnpj], [Ativo]) VALUES (16, N'TESTE', CAST(22222222222 AS Decimal(14, 0)), 1)
GO
INSERT [dbo].[tblPessoa] ([IDPessoa], [Nome], [CpfCnpj], [Ativo]) VALUES (17, N'TESSSSSS', CAST(77778787878 AS Decimal(14, 0)), 0)
GO
INSERT [dbo].[tblPessoa] ([IDPessoa], [Nome], [CpfCnpj], [Ativo]) VALUES (20, N'55555555555555555555555555555555', CAST(11111111111 AS Decimal(14, 0)), 1)
GO
INSERT [dbo].[tblPessoa] ([IDPessoa], [Nome], [CpfCnpj], [Ativo]) VALUES (21, N'TTT', CAST(11111111111 AS Decimal(14, 0)), 1)
GO
INSERT [dbo].[tblPessoa] ([IDPessoa], [Nome], [CpfCnpj], [Ativo]) VALUES (22, N'TTT', CAST(11111111111 AS Decimal(14, 0)), 1)
GO
INSERT [dbo].[tblPessoa] ([IDPessoa], [Nome], [CpfCnpj], [Ativo]) VALUES (23, N'TTT', CAST(11111111111 AS Decimal(14, 0)), 1)
GO
INSERT [dbo].[tblPessoa] ([IDPessoa], [Nome], [CpfCnpj], [Ativo]) VALUES (24, N'TTT', CAST(11111111111 AS Decimal(14, 0)), 1)
GO
INSERT [dbo].[tblPessoa] ([IDPessoa], [Nome], [CpfCnpj], [Ativo]) VALUES (25, N'TTTTTTTTTTT', CAST(11111222222 AS Decimal(14, 0)), 1)
GO
INSERT [dbo].[tblPessoa] ([IDPessoa], [Nome], [CpfCnpj], [Ativo]) VALUES (26, N'TTTTTTTTTTT', CAST(29874928372 AS Decimal(14, 0)), 1)
GO
INSERT [dbo].[tblPessoa] ([IDPessoa], [Nome], [CpfCnpj], [Ativo]) VALUES (27, N'222222222222222222222222222222222222', CAST(55555555555 AS Decimal(14, 0)), 1)
GO
INSERT [dbo].[tblPessoa] ([IDPessoa], [Nome], [CpfCnpj], [Ativo]) VALUES (28, N'TTTTTTTT', CAST(44444444444 AS Decimal(14, 0)), 1)
GO
INSERT [dbo].[tblPessoa] ([IDPessoa], [Nome], [CpfCnpj], [Ativo]) VALUES (29, N'RRRRRRRRRR', CAST(0 AS Decimal(14, 0)), 1)
GO
INSERT [dbo].[tblPessoa] ([IDPessoa], [Nome], [CpfCnpj], [Ativo]) VALUES (31, N'ADADADASDSAD', CAST(71545234000162 AS Decimal(14, 0)), 1)
GO
INSERT [dbo].[tblPessoa] ([IDPessoa], [Nome], [CpfCnpj], [Ativo]) VALUES (32, N'TTTTTTTTTTTT', CAST(11111111111 AS Decimal(14, 0)), 1)
GO
SET IDENTITY_INSERT [dbo].[tblPessoa] OFF
GO
SET IDENTITY_INSERT [dbo].[tblProduto] ON 

GO
INSERT [dbo].[tblProduto] ([IDProduto], [Descricao], [Ativo], [Largura], [Altura], [Profudidade], [Cubagem], [QuanitadeMinima], [Quantidade], [Preco]) VALUES (2, N'MADEIRA', 1, CAST(10.000 AS Decimal(10, 3)), CAST(10.000 AS Decimal(10, 3)), CAST(20.000 AS Decimal(10, 3)), CAST(2000.000 AS Decimal(10, 3)), CAST(10 AS Decimal(12, 0)), CAST(97 AS Decimal(12, 0)), CAST(10.25 AS Decimal(18, 2)))
GO
INSERT [dbo].[tblProduto] ([IDProduto], [Descricao], [Ativo], [Largura], [Altura], [Profudidade], [Cubagem], [QuanitadeMinima], [Quantidade], [Preco]) VALUES (3, N'TESTEHHHRRRRR', 1, CAST(23.000 AS Decimal(10, 3)), CAST(12.500 AS Decimal(10, 3)), CAST(12.000 AS Decimal(10, 3)), CAST(3450.000 AS Decimal(10, 3)), CAST(10 AS Decimal(12, 0)), CAST(100 AS Decimal(12, 0)), CAST(10.25 AS Decimal(18, 2)))
GO
INSERT [dbo].[tblProduto] ([IDProduto], [Descricao], [Ativo], [Largura], [Altura], [Profudidade], [Cubagem], [QuanitadeMinima], [Quantidade], [Preco]) VALUES (6, N'TTTTTTTTTTTTTTT', 1, CAST(0.000 AS Decimal(10, 3)), CAST(10.000 AS Decimal(10, 3)), CAST(10.000 AS Decimal(10, 3)), CAST(1000.000 AS Decimal(10, 3)), CAST(10 AS Decimal(12, 0)), CAST(2 AS Decimal(12, 0)), CAST(0.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[tblProduto] ([IDProduto], [Descricao], [Ativo], [Largura], [Altura], [Profudidade], [Cubagem], [QuanitadeMinima], [Quantidade], [Preco]) VALUES (7, N'TESTE', 1, CAST(12.000 AS Decimal(10, 3)), CAST(12.000 AS Decimal(10, 3)), CAST(12.000 AS Decimal(10, 3)), CAST(1728.000 AS Decimal(10, 3)), CAST(0 AS Decimal(12, 0)), CAST(10 AS Decimal(12, 0)), CAST(10.20 AS Decimal(18, 2)))
GO
INSERT [dbo].[tblProduto] ([IDProduto], [Descricao], [Ativo], [Largura], [Altura], [Profudidade], [Cubagem], [QuanitadeMinima], [Quantidade], [Preco]) VALUES (8, N'TERÇA 2,00', 1, CAST(0.110 AS Decimal(10, 3)), CAST(0.050 AS Decimal(10, 3)), CAST(2.000 AS Decimal(10, 3)), CAST(0.011 AS Decimal(10, 3)), CAST(0 AS Decimal(12, 0)), CAST(5 AS Decimal(12, 0)), CAST(0.00 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[tblProduto] OFF
GO
SET IDENTITY_INSERT [dbo].[tblSituacao] ON 

GO
INSERT [dbo].[tblSituacao] ([IDSituacao], [Descricao]) VALUES (1, N'EXCLUÍDO')
GO
INSERT [dbo].[tblSituacao] ([IDSituacao], [Descricao]) VALUES (2, N'ABERTO')
GO
INSERT [dbo].[tblSituacao] ([IDSituacao], [Descricao]) VALUES (3, N'FINALIZADO')
GO
INSERT [dbo].[tblSituacao] ([IDSituacao], [Descricao]) VALUES (4, N'PAGO')
GO
SET IDENTITY_INSERT [dbo].[tblSituacao] OFF
GO
SET IDENTITY_INSERT [dbo].[tblTipoPagamento] ON 

GO
INSERT [dbo].[tblTipoPagamento] ([IDTipoPagamento], [Descricao], [Ativo]) VALUES (1, N'Á VISTA', 1)
GO
INSERT [dbo].[tblTipoPagamento] ([IDTipoPagamento], [Descricao], [Ativo]) VALUES (3, N'DÉBITOGGGG', 0)
GO
SET IDENTITY_INSERT [dbo].[tblTipoPagamento] OFF
GO
INSERT [dbo].[tblVendedor] ([IDPessoaVendedor], [DataCadastro]) VALUES (15, CAST(N'2016-09-11 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[tblVendedor] ([IDPessoaVendedor], [DataCadastro]) VALUES (27, CAST(N'2016-10-08 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[tblVendedor] ([IDPessoaVendedor], [DataCadastro]) VALUES (29, CAST(N'2016-10-13 00:00:00.000' AS DateTime))
GO
ALTER TABLE [dbo].[tblCliente]  WITH CHECK ADD  CONSTRAINT [FK_TBLCLIENTEIDPESSOA] FOREIGN KEY([IDPessoaCliente])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblCliente] CHECK CONSTRAINT [FK_TBLCLIENTEIDPESSOA]
GO
ALTER TABLE [dbo].[tblContasPagar]  WITH CHECK ADD  CONSTRAINT [FK_tblContasPagarIDContasPagarTipo] FOREIGN KEY([IDContasPagarTipo])
REFERENCES [dbo].[tblContasPagarTipo] ([IDContasPagarTipo])
GO
ALTER TABLE [dbo].[tblContasPagar] CHECK CONSTRAINT [FK_tblContasPagarIDContasPagarTipo]
GO
ALTER TABLE [dbo].[tblContasPagar]  WITH CHECK ADD  CONSTRAINT [FK_tblContasPagarIDPessoaFornecedor] FOREIGN KEY([IDPessoaFornecedor])
REFERENCES [dbo].[tblFornecedor] ([IDPessoaFornecedor])
GO
ALTER TABLE [dbo].[tblContasPagar] CHECK CONSTRAINT [FK_tblContasPagarIDPessoaFornecedor]
GO
ALTER TABLE [dbo].[tblContasPagar]  WITH CHECK ADD  CONSTRAINT [FK_tblContasPagarIDSitutacaoOperacaoo] FOREIGN KEY([IDOperacao], [IDSituacao])
REFERENCES [dbo].[tblOperacaoSituacao] ([IDOperacao], [IDSituacao])
GO
ALTER TABLE [dbo].[tblContasPagar] CHECK CONSTRAINT [FK_tblContasPagarIDSitutacaoOperacaoo]
GO
ALTER TABLE [dbo].[tblContasReceber]  WITH CHECK ADD  CONSTRAINT [FK_IDContasReceberOrigem] FOREIGN KEY([IDContasReceberOrigem])
REFERENCES [dbo].[tblContasReceberOrigem] ([IDContasReceberOrigem])
GO
ALTER TABLE [dbo].[tblContasReceber] CHECK CONSTRAINT [FK_IDContasReceberOrigem]
GO
ALTER TABLE [dbo].[tblContasReceber]  WITH CHECK ADD  CONSTRAINT [FK_TBLCONTASRECEBERIDCONTASRECEBERSITUACAO] FOREIGN KEY([IDContasReceberSituacao])
REFERENCES [dbo].[tblContasReceberSituacao] ([IDSituacao])
GO
ALTER TABLE [dbo].[tblContasReceber] CHECK CONSTRAINT [FK_TBLCONTASRECEBERIDCONTASRECEBERSITUACAO]
GO
ALTER TABLE [dbo].[tblContasReceber]  WITH CHECK ADD  CONSTRAINT [FK_TBLCONTASRECEBERIDPEDIDO] FOREIGN KEY([IDPedido])
REFERENCES [dbo].[tblPedido] ([IDPedido])
GO
ALTER TABLE [dbo].[tblContasReceber] CHECK CONSTRAINT [FK_TBLCONTASRECEBERIDPEDIDO]
GO
ALTER TABLE [dbo].[tblContasReceber]  WITH CHECK ADD  CONSTRAINT [FK_tblContasReceberIDTipoPagamento] FOREIGN KEY([IDTipoPagamento])
REFERENCES [dbo].[tblTipoPagamento] ([IDTipoPagamento])
GO
ALTER TABLE [dbo].[tblContasReceber] CHECK CONSTRAINT [FK_tblContasReceberIDTipoPagamento]
GO
ALTER TABLE [dbo].[tblContasReceber]  WITH CHECK ADD  CONSTRAINT [FK_TBLCONTASRECEBERIDUSUARIO] FOREIGN KEY([IDUsuario])
REFERENCES [dbo].[tblUsuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[tblContasReceber] CHECK CONSTRAINT [FK_TBLCONTASRECEBERIDUSUARIO]
GO
ALTER TABLE [dbo].[tblEMail]  WITH CHECK ADD  CONSTRAINT [FK_TBLEMAILIDPESSOA] FOREIGN KEY([IDPessoa])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblEMail] CHECK CONSTRAINT [FK_TBLEMAILIDPESSOA]
GO
ALTER TABLE [dbo].[tblEndereco]  WITH CHECK ADD  CONSTRAINT [FK_TBLENDERECOIDPESSOA] FOREIGN KEY([IDPessoa])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblEndereco] CHECK CONSTRAINT [FK_TBLENDERECOIDPESSOA]
GO
ALTER TABLE [dbo].[tblEstoque]  WITH CHECK ADD  CONSTRAINT [FK_TBLESTOQUEIDPRODUTO] FOREIGN KEY([IDProduto])
REFERENCES [dbo].[tblProduto] ([IDProduto])
GO
ALTER TABLE [dbo].[tblEstoque] CHECK CONSTRAINT [FK_TBLESTOQUEIDPRODUTO]
GO
ALTER TABLE [dbo].[tblEstoqueMovimentacao]  WITH CHECK ADD  CONSTRAINT [FK_tblEstoqueMovimentacaoIDProduto] FOREIGN KEY([IDProduto])
REFERENCES [dbo].[tblProduto] ([IDProduto])
GO
ALTER TABLE [dbo].[tblEstoqueMovimentacao] CHECK CONSTRAINT [FK_tblEstoqueMovimentacaoIDProduto]
GO
ALTER TABLE [dbo].[tblFornecedor]  WITH CHECK ADD  CONSTRAINT [FK_TBLFORNCEDORIDPESSOA] FOREIGN KEY([IDPessoaFornecedor])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblFornecedor] CHECK CONSTRAINT [FK_TBLFORNCEDORIDPESSOA]
GO
ALTER TABLE [dbo].[TBLNIVELACESSOUSUARIO]  WITH CHECK ADD  CONSTRAINT [FK_TBLNIVELACESSOUSUARIOIDNIVELACESSO] FOREIGN KEY([IDNIVELACESSO])
REFERENCES [dbo].[TBLNIVELACESSO] ([IDNIVELACESSO])
GO
ALTER TABLE [dbo].[TBLNIVELACESSOUSUARIO] CHECK CONSTRAINT [FK_TBLNIVELACESSOUSUARIOIDNIVELACESSO]
GO
ALTER TABLE [dbo].[TBLNIVELACESSOUSUARIO]  WITH CHECK ADD  CONSTRAINT [FK_TBLNIVELACESSOUSUARIOIDUSUARIO] FOREIGN KEY([IDUSUARIO])
REFERENCES [dbo].[tblUsuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[TBLNIVELACESSOUSUARIO] CHECK CONSTRAINT [FK_TBLNIVELACESSOUSUARIOIDUSUARIO]
GO
ALTER TABLE [dbo].[tblOperacaoSituacao]  WITH CHECK ADD  CONSTRAINT [FK_TBLOPERACAOSITUACAOIDOPERACAO] FOREIGN KEY([IDOperacao])
REFERENCES [dbo].[tblOperacao] ([IDOperacao])
GO
ALTER TABLE [dbo].[tblOperacaoSituacao] CHECK CONSTRAINT [FK_TBLOPERACAOSITUACAOIDOPERACAO]
GO
ALTER TABLE [dbo].[tblOperacaoSituacao]  WITH CHECK ADD  CONSTRAINT [FK_TBLOPERACAOSITUACAOIDSITUACAO] FOREIGN KEY([IDSituacao])
REFERENCES [dbo].[tblSituacao] ([IDSituacao])
GO
ALTER TABLE [dbo].[tblOperacaoSituacao] CHECK CONSTRAINT [FK_TBLOPERACAOSITUACAOIDSITUACAO]
GO
ALTER TABLE [dbo].[tblPedido]  WITH CHECK ADD  CONSTRAINT [FK_IDContasReceber] FOREIGN KEY([IDContasReceber])
REFERENCES [dbo].[tblContasReceber] ([IDContasReceber])
GO
ALTER TABLE [dbo].[tblPedido] CHECK CONSTRAINT [FK_IDContasReceber]
GO
ALTER TABLE [dbo].[tblPedido]  WITH CHECK ADD  CONSTRAINT [FK_TBLPEDIDOIDOPERACAOIDSITUACAO] FOREIGN KEY([IDOperacao], [IDSituacao])
REFERENCES [dbo].[tblOperacaoSituacao] ([IDOperacao], [IDSituacao])
GO
ALTER TABLE [dbo].[tblPedido] CHECK CONSTRAINT [FK_TBLPEDIDOIDOPERACAOIDSITUACAO]
GO
ALTER TABLE [dbo].[tblPedido]  WITH CHECK ADD  CONSTRAINT [FK_TBLPEDIDOTIPOIDPEDIDO] FOREIGN KEY([IDPedidoTipo])
REFERENCES [dbo].[tblPedidoTipo] ([IDPedidoTipo])
GO
ALTER TABLE [dbo].[tblPedido] CHECK CONSTRAINT [FK_TBLPEDIDOTIPOIDPEDIDO]
GO
ALTER TABLE [dbo].[tblPedidoItem]  WITH CHECK ADD  CONSTRAINT [FK_TBLPEDIDOITEMIDPEDIDO] FOREIGN KEY([IDPedido])
REFERENCES [dbo].[tblPedido] ([IDPedido])
GO
ALTER TABLE [dbo].[tblPedidoItem] CHECK CONSTRAINT [FK_TBLPEDIDOITEMIDPEDIDO]
GO
ALTER TABLE [dbo].[tblPedidoItem]  WITH CHECK ADD  CONSTRAINT [FK_TBLPEDIDOITEMIDPRODUTO] FOREIGN KEY([IDProduto])
REFERENCES [dbo].[tblProduto] ([IDProduto])
GO
ALTER TABLE [dbo].[tblPedidoItem] CHECK CONSTRAINT [FK_TBLPEDIDOITEMIDPRODUTO]
GO
ALTER TABLE [dbo].[tblTelefone]  WITH CHECK ADD  CONSTRAINT [FK_TBLTELEFONEIDPESSOA] FOREIGN KEY([IDPessoa])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblTelefone] CHECK CONSTRAINT [FK_TBLTELEFONEIDPESSOA]
GO
ALTER TABLE [dbo].[tblUsuario]  WITH CHECK ADD  CONSTRAINT [FK_TBLUSUAIROIDPESSOA] FOREIGN KEY([IDPessoa])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
GO
ALTER TABLE [dbo].[tblUsuario] CHECK CONSTRAINT [FK_TBLUSUAIROIDPESSOA]
GO
ALTER TABLE [dbo].[tblVendedor]  WITH CHECK ADD  CONSTRAINT [FK_TBLVENDEDORIDPESSOA] FOREIGN KEY([IDPessoaVendedor])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblVendedor] CHECK CONSTRAINT [FK_TBLVENDEDORIDPESSOA]
GO
ALTER TABLE [dbo].[tblTelefone]  WITH CHECK ADD CHECK  (([TipoTelefone]='Comercial' OR [TipoTelefone]='Residencial' OR [TipoTelefone]='Celular'))
GO
ALTER TABLE [dbo].[tblTelefone]  WITH CHECK ADD CHECK  (([TipoTelefone]='Comercial' OR [TipoTelefone]='Residencial' OR [TipoTelefone]='Celular'))
GO
/****** Object:  StoredProcedure [dbo].[uspCadastrarCliente]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCadastrarCliente]
@INintAcao INT = NULL,
@INintIDPessoaCliente INT = NULL OUTPUT,
@INvchNome VARCHAR(50) =  NULL,
@INdecCpfCnpj DECIMAL(14,0) = NULL, 
@INbitAtivo BIT = NULL,
@INdecLimiteMinimo DECIMAL(12,2) = NULL,
@INdecLimiteMaximo DECIMAL(12,2) = NULL,
@INdatDataNascimento DATE = NULL,
@INdatDataCadastro DATE = NULL
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			IF(@INintAcao = 0)
			BEGIN
			IF(EXISTS(SELECT IDPessoa FROM tblPessoa WITH(NOLOCK) JOIN tblCliente WITH(NOLOCK) ON (tblPessoa.IDPessoa = tblCliente.IDPessoaCliente) WHERE CpfCnpj = @INdecCpfCnpj))
				RAISERROR('Já existe cliente com este CPF cadastrado no sistema!',14,1);

				EXEC uspCadastrarPessoa 
				@INintAcao = @INintAcao,
				@INvchNome = @INvchNome,
				@INdecCpfCnpj = @INdecCpfCnpj,
				@INbitAtivo = @INbitAtivo,
				@INintIDPessoa = @INintIDPessoaCliente OUT

				INSERT INTO tblCliente
				(
					IDPessoaCliente,
					DataCadastro,
					LimiteMinimo,
					LimiteMaximo,
					DataNascimento
				)
				VALUES
				(
					@INintIDPessoaCliente,
					@INdatDataCadastro,
					@INdecLimiteMinimo,
					@INdecLimiteMaximo,
					@INdatDataNascimento
				)

				--SET @INintIDPessoaCliente = @@IDENTITY
				SELECT @INintIDPessoaCliente

			END
			ELSE IF(@INintAcao = 1)
			BEGIN
				IF(EXISTS(SELECT IDPessoa FROM tblPessoa WITH(NOLOCK) JOIN tblCliente WITH(NOLOCK) ON (tblPessoa.IDPessoa = tblCliente.IDPessoaCliente) WHERE CpfCnpj = @INdecCpfCnpj AND tblCliente.IDPessoaCliente <> @INintIDPessoaCliente))
					RAISERROR('Já existe cliente com este CPF cadastrado no sistema!',14,1);
				EXEC uspCadastrarPessoa 
				@INintAcao = @INintAcao,
				@INintIDPessoa = @INintIDPessoaCliente,
				@INvchNome = @INvchNome,
				@INdecCpfCnpj = @INdecCpfCnpj,
				@INbitAtivo = @INbitAtivo

				UPDATE
					tblCliente
				SET
					DataCadastro = @INdatDataCadastro,
					LimiteMinimo = @INdecLimiteMinimo,
					LimiteMaximo = @INdecLimiteMaximo,
					DataNascimento = @INdatDataNascimento
				WHERE
					IDPessoaCliente = @INintIDPessoaCliente

				SELECT @INintIDPessoaCliente
			END
			ELSE IF( @INintAcao = 2)
			BEGIN
				IF(EXISTS(SELECT * FROM tblPedido WITH(NOLOCK) WHERE IDPessoaCliente = @INintIDPessoaCliente))
				BEGIN
					UPDATE
						tblPessoa
					SET
						Ativo = 0
					WHERE
						IDPessoa = @INintIDPessoaCliente
					--RAISERROR('Cliente já possui pedidos no sistema. Será INATIVADO.',14,2)
				END
				ELSE
				BEGIN
					DELETE
						tblCliente
					WHERE
						IDPessoaCliente = @INintIDPessoaCliente
				EXEC uspCadastrarPessoa 
				@INintAcao = @INintAcao,
				@INintIDPessoa = NULL,
				@INvchNome = @INintIDPessoaCliente,
				@INdecCpfCnpj = NULL,
				@INbitAtivo = NULL
				END
				SELECT '1' AS Retorno
			END
			
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE(),ERROR_LINE()
	END CATCH
END


GO
/****** Object:  StoredProcedure [dbo].[uspCadastrarContasPagar]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCadastrarContasPagar]
@INintAcao INT,
@INintIDContasPagar INT = OUTPUT,
@INintIDPessoaFornecedor INT = NULL, 
@INdatDataPagamento DATE = NULL,
@INdatDataVencimento DATE = NULL,
@INdatDataLancamento DATE = NULL,
@INdecValor DECIMAL(18,2) = NULL,
@INvchObservacao VARCHAR(250) = NULL,
@INintIDSituacao INT = NULL,
@INintIDOperacao INT = NULL,
@INintIDContasPagarTipo INT = NULL
AS
BEGIN
	IF(@INintAcao = 0)
	BEGIN
		INSERT INTO tblContasPagar
		(
			IDPessoaFornecedor,
			DataPagamento,
			DataLancamento,
			DataVencimento,
			Valor,
			Observacao,
			IDSituacao,
			IDOperacao,
			IDContasPagarTipo
		)
		VALUES
		(
			@INintIDPessoaFornecedor,
			@INdatDataPagamento,
			@INdatDataLancamento,
			@INdatDataVencimento,
			@INdecValor,
			@INvchObservacao,
			@INintIDSituacao,
			@INintIDOperacao,
			@INintIDContasPagarTipo
		)

		SET @INintIDContasPagar = @@IDENTITY
		SELECT @INintIDContasPagar
	END
	ELSE IF(@INintAcao = 1)
	BEGIN
		UPDATE
			tblContasPagar
		SET
			IDPessoaFornecedor =@INintIDPessoaFornecedor,
			DataVencimento = @INdatDataVencimento,
			Valor = @INdecValor,
			Observacao = @INvchObservacao,
			IDContasPagarTipo = @INintIDContasPagarTipo
		WHERE
			IDContasPagar = @INintIDContasPagar
		SELECT @INintIDContasPagar 
	END
		ELSE IF(@INintAcao = 2)
	BEGIN
		DELETE
			tblContasPagar
		WHERE
			IDContasPagar = @INintIDContasPagar

		SELECT @INintIDContasPagar 
	END
END
GO
/****** Object:  StoredProcedure [dbo].[uspCadastrarContasPagarTipo]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspCadastrarContasPagarTipo]
@INintAcao INT,
@INIDContasPagarTipo INT = OUTPUT,
@INvchDescricao VARCHAR(50) = NULL,
@INbitAtivo BIT = NULL
AS
BEGIN
BEGIN TRY
BEGIN TRAN
	SET NOCOUNT ON
	IF(@INintAcao = 0)
	BEGIN
		INSERT INTO tblContasPagarTipo
		(
			Descricao,
			Ativo
		)
		VALUES
		(
			@INvchDescricao,
			@INbitAtivo
		)

		SET @INIDContasPagarTipo = @@IDENTITY
		SELECT @INIDContasPagarTipo
	END
	ELSE IF(@INintAcao = 1)
	BEGIN
		UPDATE
			tblContasPagarTipo
		SET
			Descricao = @INvchDescricao,
			Ativo = @INbitAtivo
		WHERE
			IDContasPagarTipo = @INIDContasPagarTipo

			SELECT @INIDContasPagarTipo
	END
	ELSE IF (@INintAcao = 2)
	BEGIN
		DELETE
			tblContasPagarTipo
		WHERE
			IDContasPagarTipo = @INIDContasPagarTipo

		SELECT @INIDContasPagarTipo
	END
COMMIT TRAN
END TRY
BEGIN CATCH
	ROLLBACK TRAN
	SELECT ERROR_MESSAGE(),ERROR_LINE()
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspCadastrarContasReceber]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCadastrarContasReceber]
@INintAcao INT, 
@INintIDContasReceber INT= NULL,
@INdatDataPagamento DATE = NULL,
@INdecValorTotal DECIMAL(8,2) = NULL,
@INdatDataLancamento DATETIME = NULL,
@INdatDataVencimento DATE = NULL,
@INintIDContasReceberSituacao INT = NULL,
@INintIDPessoaCliente INT = NULL,
@INintIDPessoaVendedor INT = NULL,
@INintIDUsuario INT = NULL,
@INintPedido INT = NULL,
@INintTipoPagamento INT = NULL,
@INintContasReceberOrigem INT = NULL,
@OUTintIDContasReceber INT = NULL OUT
AS
BEGIN
	SET NOCOUNT ON
	IF(@INintAcao = 0)
	BEGIN
		INSERT INTO tblContasReceber
		(
			ValorTotal,
			DataLancamento,
			DataVencimento,
			IDContasReceberSituacao,
			IDPessoaCliente,
			IDPessoaVendedor,
			IDUsuario,
			IDPedido,
			DataPagamento,
			IDTipoPagamento,
			IDContasReceberOrigem
		)
		VALUES
		(
			@INdecValorTotal,
			@INdatDataLancamento,
			@INdatDataVencimento,
			@INintIDContasReceberSituacao,
			@INintIDPessoaCliente,
			@INintIDPessoaVendedor,
			@INintIDUsuario,
			@INintPedido,
			@INdatDataPagamento,
			@INintTipoPagamento,
			@INintContasReceberOrigem
		)

		SET @OUTintIDContasReceber = @@IDENTITY
	END
	ELSE IF(@INintAcao = 1)
	BEGIN
		UPDATE
			tblContasReceber
		SET
			DataVencimento = @INdatDataVencimento,
			IDPessoaCliente = @INintIDPessoaCliente,
			IDPessoaVendedor = @INintIDPessoaVendedor,
			IDTipoPagamento = @INintTipoPagamento,
			IDPedido = @INintPedido
		WHERE
			IDContasReceber = @INintIDContasReceber

		SET @OUTintIDContasReceber = @INintIDContasReceber
	END
	ELSE IF(@INintAcao =2)
	BEGIN
		DELETE
			tblContasReceber
		WHERE
			IDContasReceber = @INintIDContasReceber

		SET @OUTintIDContasReceber = @INintIDContasReceber
	END
END

GO
/****** Object:  StoredProcedure [dbo].[uspCadastrarEmail]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCadastrarEmail]
@INintAcao INT,
@INintEmail INT = NULL,
@INintIDPessoa INT = NULL,
@INvchDescricao VARCHAR(50) = NULL,
@INbitPrincipal BIT = NULL
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			IF(@INintAcao = 0)
			BEGIN
			IF(EXISTS(SELECT IDEmail FROM tblEMail WITH(NOLOCK) WHERE IDPessoa = @INintIDPessoa AND Principal = 1))
			BEGIN
				DECLARE
					@vchEmailPrincipal VARCHAR(50) = (SELECT Descricao FROM tblEMail WITH(NOLOCK) WHERE IDPessoa = @INintIDPessoa AND Principal = 1);
				RAISERROR('Já existe um email como principal, desmarcar o %s!',14,1,@vchEmailPrincipal)
			END
			INSERT INTO tblEMail
			(
				IDPessoa,
				Descricao,
				Principal
			)
			VALUES
			(
				@INintIDPessoa,
				@INvchDescricao,
				@INbitPrincipal
			)
			SELECT @@IDENTITY AS Retorno
			END
			ELSE IF( @INintAcao = 1)
			BEGIN
				UPDATE
					tblEMail
				SET
					Descricao = @INvchDescricao,
					Principal = @INbitPrincipal
				WHERE
					IDEmail = @INintEmail

				SELECT @INintEmail
			END
			ELSE IF(@INintAcao = 2)
			BEGIN
				DELETE
					tblEMail
				WHERE
					IDEmail = @INintEmail
				SELECT '1' AS Retorno
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
	ROLLBACK TRAN
	SELECT ERROR_MESSAGE(),ERROR_LINE()
	END CATCH
END

GO
/****** Object:  StoredProcedure [dbo].[uspCadastrarEndereco]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCadastrarEndereco]
@INbitAcao INT,
@INintIDEndereco INT= NULL,
@INintIDPessoa INT = NULL,
@INvchCidade VARCHAR(50) = NULL,
@INvchLogradouro VARCHAR(100) =NULL,
@INintNumero SMALLINT = NULL,
@INvchComplemento VARCHAR(50) = NULL,
@INvchBairro VARCHAR(80) = NULL,
@INdecCep DECIMAL(9,0) = NULL
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
		IF(@INbitAcao = 0)
		BEGIN
			INSERT INTO tblEndereco
			(
				IDPessoa,
				Logradouro,
				Numero,
				Complemento,
				Bairro,
				Cep,
				Cidade
			)
			VALUES
			(
				@INintIDPessoa,
				@INvchLogradouro,
				@INintNumero,
				@INvchComplemento,
				@INvchBairro,
				@INdecCep,
				@INvchCidade
			)

			SELECT @@IDENTITY AS Retorno
		END
		ELSE IF(@INbitAcao = 1)
		BEGIN
			UPDATE
				tblEndereco
			SET
				Logradouro = @INvchLogradouro,
				Numero = @INintNumero,
				Complemento = @INvchComplemento,
				Bairro = @INvchBairro,
				Cep = @INdecCep,
				Cidade = @INvchCidade
			WHERE
				IDEndereco = @INintIDEndereco

			SELECT @INintIDEndereco
		END
		ELSE IF(@INbitAcao = 2)
		BEGIN
			DELETE
				tblEndereco
			WHERE
				IDEndereco = @INintIDEndereco

			SELECT '1' AS Retorno
		END
	COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_LINE(),ERROR_MESSAGE()
	END CATCH
END


GO
/****** Object:  StoredProcedure [dbo].[uspCadastrarEstoqueMovimentacao]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCadastrarEstoqueMovimentacao]
@INintAcao INT = NULL,
@INdatData DATETIME = NULL,
@INintIDProduto INT = NULL,
@INdecQuantidade DECIMAL(18,2) = NULL,
@INvchOperacao CHAR(1) = NULL
AS
BEGIN
	SET @INdatData = GETDATE();
	IF(@INintAcao = 0)
	BEGIN
		INSERT INTO tblEstoqueMovimentacao
		(
			Data,
			IDProduto,
			Quantidade,
			Operacao
		)
		VALUES
		(
			@INdatData,
			@INintIDProduto,
			@INdecQuantidade,
			@INvchOperacao
		)
		IF(@INvchOperacao = 'C')
		BEGIN
			UPDATE
				tblProduto
			SET
				Quantidade = Quantidade - @INdecQuantidade
			WHERE
				IDProduto = @INintIDProduto
		END
		ELSE IF(@INvchOperacao = 'D')
		BEGIN
			UPDATE
				tblProduto
			SET
				Quantidade = Quantidade + @INdecQuantidade
			WHERE
				IDProduto = @INintIDProduto
		END

		SELECT @@IDENTITY AS Retorno

	END
END
GO
/****** Object:  StoredProcedure [dbo].[uspCadastrarFornecedor]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCadastrarFornecedor]
@INintAcao INT,
@INintIDPessoa INT OUTPUT,
@INvchNome VARCHAR(50) =  NULL,
@INdecCpfCnpj DECIMAL(14,0) = NULL, 
@INbitAtivo BIT = NULL,
@INInscEstadual VARCHAR(15) = NULL,
@INdatDataCadastro DATE = NULL
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			IF(@INintAcao = 0)
			BEGIN
			IF(EXISTS(SELECT IDPessoa FROM tblPessoa WITH(NOLOCK) JOIN tblFornecedor WITH(NOLOCK) ON (tblPessoa.IDPessoa = tblFornecedor.IDPessoaFornecedor) WHERE CpfCnpj = @INdecCpfCnpj))
				RAISERROR('Já existe fornecedor com este CNPJ cadastrado no sistema!',14,1);

				EXEC uspCadastrarPessoa 
				@INintAcao = @INintAcao,
				@INvchNome = @INvchNome,
				@INdecCpfCnpj = @INdecCpfCnpj,
				@INbitAtivo = @INbitAtivo,
				@INintIDPessoa = @INintIDPessoa OUT

				INSERT INTO tblFornecedor
				(
					IDPessoaFornecedor,
					IE,
					DataCadastro
				)
				VALUES
				(
					@INintIDPessoa,
					@INInscEstadual,
					@INdatDataCadastro
				)

				SELECT @INintIDPessoa;

			END
			ELSE IF(@INintAcao = 1)
			BEGIN
				IF(EXISTS(SELECT IDPessoa FROM tblPessoa WITH(NOLOCK) JOIN tblFornecedor WITH(NOLOCK) ON (tblPessoa.IDPessoa = tblFornecedor.IDPessoaFornecedor) WHERE CpfCnpj = @INdecCpfCnpj AND tblFornecedor.IDPessoaFornecedor <> @INintIDPessoa ))
					RAISERROR('Já existe forncedor com este CNPJ cadastrado no sistema!',14,1);
				EXEC uspCadastrarPessoa 
				@INintAcao = @INintAcao,
				@INintIDPessoa = @INintIDPessoa,
				@INvchNome = @INvchNome,
				@INdecCpfCnpj = @INdecCpfCnpj,
				@INbitAtivo = @INbitAtivo

				UPDATE
					tblFornecedor
				SET
					DataCadastro = @INdatDataCadastro,
					IE			 = @INInscEstadual
				WHERE
					IDPessoaFornecedor = @INintIDPessoa

				SELECT @INintIDPessoa
			END
			ELSE IF( @INintAcao = 2)
			BEGIN
				IF(EXISTS(SELECT IDPedido FROM tblPedido WITH(NOLOCK) WHERE IDPessoaCliente = @INintIDPessoa))
				BEGIN
					UPDATE
						tblPessoa
					SET
						Ativo = 0
					WHERE
						IDPessoa = @INintIDPessoa
					--RAISERROR('Cliente já possui pedidos no sistema. Será INATIVADO.',14,2)
					SELECT '1' AS Retorno
						
				END
				ELSE
				BEGIN
					DELETE
						tblFornecedor
					WHERE
						IDPessoaFornecedor = @INintIDPessoa
				EXEC uspCadastrarPessoa 
				@INintAcao = @INintAcao,
				@INintIDPessoa = @INintIDPessoa,
				@INvchNome = NULL,
				@INdecCpfCnpj = NULL,
				@INbitAtivo = NULL
				END
				SELECT '1' AS Retorno

			END
			
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE(),ERROR_LINE()
	END CATCH
END


GO
/****** Object:  StoredProcedure [dbo].[uspCadastrarOperacao]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCadastrarOperacao]
@INintAcao INT,
@INintIDOperacao INT NULL,
@INvchDescricao VARCHAR(20) NULL
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			IF(@INintAcao = 0)
			BEGIN
				INSERT INTO tblSituacao
				(
					
					Descricao
				)
				VALUES
				(
					@INvchDescricao
				)

				SELECT @@IDENTITY AS Retorno
			END
			ELSE IF(@INintAcao = 1)
			BEGIN
				UPDATE
					tblSituacao
				SET
					Descricao = @INvchDescricao
				WHERE
					IDSituacao = @INintIDOperacao

				SELECT @INintIDOperacao;
			END
			ELSE IF( @INintAcao = 2)
			BEGIN
				DELETE
					tblSituacao
				WHERE
					IDSituacao = @INintIDOperacao
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_LINE(),ERROR_MESSAGE()
	END CATCH
END


GO
/****** Object:  StoredProcedure [dbo].[uspCadastrarPedido]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCadastrarPedido]
@INintAcao INT,
@INintIDPedido INT = NULL,
@INintIDPessoaCliente INT = NULL,
@INintIDPessoaVendedor INT = NULL,
@INintIDOperacao INT = NULL,
@INintIDSituacao INT = NULL,
--@INintTipoPagamento INT = NULL,
@INdatDataPedido DATE = NULL,
@INvchObservacao VARCHAR(150)= NULL,
@INintIDPedidoTipo INT NULL = NULL,
@INdecValorTotal DECIMAL(18,2) = NULL
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			DECLARE
				@intExcluido INT = 1,
				@intAberto INT = 2,
				@intFinalizado INT= 3

			IF(@INintAcao = 0)
			BEGIN
				INSERT INTO tblPedido
				(
					IDPessoaCliente,
					IDPessoaVendedor,
					IDOperacao,
					IDSituacao,
					--IDTipoPagamento,
					DataPedido,
					Observacao,
					IDPedidoTipo,
					ValorTotal
				)
				VALUES
				(
					@INintIDPessoaCliente,
					@INintIDPessoaVendedor,
					@INintIDOperacao,
					@INintIDSituacao,
					--@INintTipoPagamento,
					@INdatDataPedido,
					@INvchObservacao,
					@INintIDPedidoTipo,
					@INdecValorTotal
				)

				SELECT @@IDENTITY AS Retorno
			END
			ELSE IF(@INintAcao = 1)
			BEGIN
				UPDATE
					tblPedido
				SET
					IDPessoaCliente = @INintIDPessoaCliente,
					IDPessoaVendedor = @INintIDPessoaVendedor,
					IDOperacao = @INintIDOperacao,
					IDSituacao = @INintIDSituacao,
					--IDTipoPagamento = @INintTipoPagamento,
					DataPedido = @INdatDataPedido,
					IDPedidoTipo = @INintIDPedidoTipo,
					ValorTotal = @INdecValorTotal
				WHERE
					IDPedido = @INintIDPedido
				SELECT @INintIDPedido
			END
			ELSE IF(@INintAcao = 2)
			BEGIN
				IF(EXISTS(SELECT * FROM tblContasReceber WITH(NOLOCK) WHERE IDPedido = @INintIDPedido))
				BEGIN
					RAISERROR('Não é possível excluír pedido, pois existe uma constas a receber!',14,1)
				END
				DELETE
					tblPedidoItem
				WHERE
					IDPedido = @INintIDPedido
				DELETE
					tblPedido
				WHERE
					IDPedido = @INintIDPedido
				SELECT '1' as retorno;
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_LINE(),ERROR_MESSAGE()
	END CATCH
END


GO
/****** Object:  StoredProcedure [dbo].[uspCadastrarPedidoItem]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCadastrarPedidoItem]
@INintAcao INT,
@INintIDPedido INT=NULL,
@INintIDProduto INT = NULL,
@INdecQuantidade DECIMAL(12,0) = NULL,
@INdecPreco DECIMAL(18,2) = NULL
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			IF(@INintAcao = 0)
			BEGIN
				INSERT INTO tblPedidoItem
				(
					IDPedido,
					IDProduto,
					Quantidade,
					Preco
				)
				VALUES
				(
					@INintIDPedido,
					@INintIDProduto,
					@INdecQuantidade,
					@INdecPreco
				)
			SELECT @INintIDPedido AS retorno
			END
			ELSE IF(@INintAcao = 1)
			BEGIN
				UPDATE
					tblPedidoItem
				SET
					Quantidade = @INdecQuantidade,
					Preco = @INdecPreco
				WHERE
					IDPedido = @INintIDPedido AND
					IDProduto = @INintIDProduto
				SELECT @INintIDPedido AS retorno
			END
			ELSE IF(@INintAcao = 2)
			BEGIN
				DELETE
					tblPedidoItem
				WHERE
					IDPedido = @INintIDPedido AND
					IDProduto = @INintIDProduto
				SELECT '1' AS Retorno
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_LINE(),ERROR_MESSAGE()
	END CATCH
END

GO
/****** Object:  StoredProcedure [dbo].[uspCadastrarPedidoSituacao]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCadastrarPedidoSituacao]
@INintIDSituacaoAtual INT =NULL,
@INintIDSituacaoNova INT = NULL,
@INintIDPedido INT = NULL,
@INintIDUsuario INT = NULL,
@INintIDOperacao INT = NULL
AS
BEGIN
	DECLARE
		@IDSituacaoContasReceberAtual INT = NULL,
		@IDContasReceberAtual INT = NULL

		SELECT TOP 1
			@IDSituacaoContasReceberAtual = tblConRec.IDContasReceberSituacao,
			@IDContasReceberAtual = tblConRec.IDContasReceber
		FROM
			tblPedido AS tblPed WITH(NOLOCK)
		JOIN
			tblContasReceber AS tblConRec WITH(NOLOCK) ON (tblPed.IDPedido = tblConRec.IDPedido)
		WHERE
			tblPed.IDPedido = @INintIDPedido
		ORDER BY
			tblConRec.DataLancamento DESC
	BEGIN TRY
	BEGIN TRAN
		DECLARE
		@intIDSituacaoExcluido INT = 1,
		@intIDSituacaoAberto INT = 2,
		@intIDSituacaoFinalizado INT = 3;

		DECLARE
			@intIDOperacaoVenda INT = 1,
			@intIDOperacaoOrcamento INT = 2;

		DECLARE
		--@intIDContasReceber INT = NULL,
		@decValorTotal DECIMAL(8,2) = NULL,
		@intIDPessoaCliente INT = NULL,
		@intIDPessoaVendedor INT = NULL

		IF(@INintIDOperacao = @intIDOperacaoVenda OR @INintIDOperacao = @intIDOperacaoOrcamento)
		BEGIN
			IF(@INintIDSituacaoAtual = @intIDSituacaoAberto AND @INintIDSituacaoNova = @intIDSituacaoExcluido)
			BEGIN
				IF(EXISTS(SELECT TOP 1 IDPedido FROM tblContasReceber WITH(NOLOCK) WHERE IDPedido = @INintIDPedido AND IDContasReceberSituacao IN(1,2) ORDER BY DataLancamento DESC))
					RAISERROR('Para excluir o PEDIDO é preciso EXCLUIR a conta que joi gerada!',14,1);
			
				UPDATE
					tblPedido
				SET
					IDSituacao = @intIDSituacaoExcluido
				WHERE
					IDPedido = @INintIDPedido

				SELECT '1' AS Retorno
			END
			ELSE IF(@INintIDSituacaoAtual = @intIDSituacaoExcluido AND @INintIDSituacaoNova = @intIDSituacaoAberto)
			BEGIN
				UPDATE
					tblPedido
				SET
					IDSituacao = @intIDSituacaoAberto
				WHERE
					IDPedido = @INintIDPedido
				SELECT '1' AS Retorno
			END
			ELSE IF(@INintIDSituacaoAtual = @intIDSituacaoAberto AND @INintIDSituacaoNova = @intIDSituacaoFinalizado)
			BEGIN
				SELECT TOP 1
					@intIDPessoaCliente = tblPed.IDPessoaCliente,
					@intIDPessoaVendedor = tblPed.IDPessoaVendedor,
					@decValorTotal = tblPed.ValorTotal
				FROM
					tblPedido AS tblPed WITH(NOLOCK)
				WHERE
					IDPedido = @INintIDPedido
				UPDATE
					tblPedido
				SET
					IDSituacao = @intIDSituacaoFinalizado,
					IDOperacao = IIF(@INintIDOperacao = @intIDOperacaoVenda, @intIDOperacaoVenda,@intIDOperacaoOrcamento)
				WHERE
					IDPedido = @INintIDPedido


				DECLARE 
					@Data DATETIME = GETDATE(),
					@IDCodigoContasReceber INT = NULL,
					@datDataVencimento DATETIME = DATEADD(DAY,7,GETDATE())

				EXEC uspCadastrarContasReceber
				@INintAcao = 0, 
				@INintIDContasReceber = NULL,
				@INdatDataPagamento = NULL,
				@INdecValorTotal = @decValorTotal,
				@INdatDataLancamento = @Data,
				@INdatDataVencimento = @datDataVencimento,
				@INintIDContasReceberSituacao = 1,
				@INintIDPessoaCliente = @intIDPessoaCliente,
				@INintIDPessoaVendedor = @intIDPessoaVendedor,
				@INintIDUsuario = @INintIDUsuario,
				@INintPedido = @INintIDPedido,
				@INintContasReceberOrigem = 2,
				@OUTintIDContasReceber = @IDCodigoContasReceber OUT

				UPDATE
					tblPedido
				SET
					IDContasReceber = @IDCodigoContasReceber
				WHERE
					IDPedido = @INintIDPedido

				SELECT '1' AS Retorno
			END

			ELSE IF(@INintIDSituacaoAtual = @intIDSituacaoFinalizado AND @INintIDSituacaoNova = @intIDSituacaoExcluido)
			BEGIN
				IF(EXISTS(SELECT TOP 1 IDPedido FROM tblContasReceber WITH(NOLOCK) WHERE IDPedido = @INintIDPedido AND IDContasReceberSituacao IN(1,2) ORDER BY DataLancamento DESC))
					RAISERROR('Para excluir o PEDIDO é preciso EXCLUIR a conta que joi gerada!',14,1);
				UPDATE
					tblPedido
				SET
					IDSituacao = @intIDSituacaoExcluido
				WHERE
					IDPedido = @INintIDPedido
				--IF((SELECT IDContasReceberSituacao FROM tblContasReceber WITH(NOLOCK) WHERE IDContasReceber = @IDContasReceberAtual) <> 2)
				--BEGIN
					--EXEC uspContasReceberSituacao
					--@INintIDContasReceber  = @IDContasReceberAtual,
					--@INintIDSituacaoAtual  = @IDSituacaoContasReceberAtual,
					--@INintIDSituacaoNova   = 3,
					--@INintIDUsuario = NULL
				--END

				SELECT '1' AS Retorno
			END
			ELSE IF(@INintIDSituacaoAtual = @intIDSituacaoFinalizado AND @INintIDSituacaoNova = @intIDSituacaoAberto)
			BEGIN
				--UPDATE
				--	tblPedido
				--SET
				--	IDSituacao = @intIDSituacaoAberto
				--WHERE
				--	IDPedido = @INintIDPedido
				RAISERROR('Para voltar o PEDIDO para ABERTO, exclua o Contas a Receber e volte a situação do Pedido!',14,1);
			END
		END
		COMMIT TRAN 
	END TRY
	BEGIN CATCH
	ROLLBACK TRAN
	SELECT ERROR_MESSAGE()
	END CATCH
END

GO
/****** Object:  StoredProcedure [dbo].[uspCadastrarPessoa]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCadastrarPessoa]
@INintAcao INT,
@INintIDPessoa INT = NULL OUTPUT,
@INvchNome VARCHAR(50) = NULL,
@INdecCpfCnpj DECIMAL(14,0) = NULL,
@INbitAtivo BIT = NULL
AS
BEGIN
	SET NOCOUNT ON
	IF(@INintAcao = 0)
	BEGIN
		--IF(EXISTS(SELECT IDPessoa FROM tblPessoa WITH(NOLOCK) WHERE CpfCnpj = @INdecCpfCnpj))
		--BEGIN
		--	IF(@INdecCpfCnpj=11)
		--		RAISERROR('CPF já cadastro no sistema para outro cliente.',12,1);
		--	ELSE
		--		RAISERROR('CNPJ já cadastro no sistema para outro fornecedor.',12,1);
		--END
		INSERT INTO tblPessoa
		(
			Nome,
			CpfCnpj,
			Ativo
		)
		VALUES
		(
			@INvchNome,
			@INdecCpfCnpj,
			@INbitAtivo
		)
		SET @INintIDPessoa = @@IDENTITY
	END
	ELSE IF(@INintAcao = 1)
	BEGIN
		--IF(EXISTS(SELECT IDPessoa FROM tblPessoa WITH(NOLOCK) WHERE CpfCnpj = @INdecCpfCnpj AND IDPessoa <> @INintIDPessoa))
		--BEGIN
		--	IF(@INdecCpfCnpj=11)
		--		RAISERROR('CPF já cadastro no sistema para outro cliente.',12,1);
		--	ELSE
		--		RAISERROR('CNPJ já cadastro no sistema para outro fornecedor.',12,1);
		--END
		UPDATE
			tblPessoa
		SET
			Nome = @INvchNome,
			CpfCnpj = @INdecCpfCnpj,
			Ativo = @INbitAtivo
		WHERE
			IDPessoa = @INintIDPessoa
	END
	ELSE IF(@INintAcao = 2)
	BEGIN
		DELETE
			tblPessoa
		WHERE
			IDPessoa = @INintIDPessoa
	END

END

GO
/****** Object:  StoredProcedure [dbo].[uspCadastrarProduto]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCadastrarProduto]
@INintAcao INT,
@INintIDProduto INT =NULL,
@INvchDescricao VARCHAR(80) = NULL,
@INbitAtivo BIT = NULL,
@INdecAltura DECIMAL(10,3) = NULL,
@INdecLargura DECIMAL(10,3) =NULL,
@INdecProfundidade DECIMAL(10,3) = NULL,
@INdecCubagem DECIMAL(10,3) = NULL,
@INdecQuanitadeMinina DECIMAL(12,0) = NULL,
@INdecQuantidade DECIMAL(12,0) = NULL,
@INdecPreco DECIMAL(18,2) = NULL
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			IF(@INintAcao = 0)
			BEGIN
				INSERT INTO tblProduto
				(
					Descricao,
					Ativo,
					Largura,
					Altura,
					Profudidade,
					Cubagem,
					QuanitadeMinima,
					Quantidade,
					Preco
				)
				VALUES
				(
					@INvchDescricao,
					@INbitAtivo,
					@INdecLargura,
					@INdecAltura,
					@INdecProfundidade,
					@INdecCubagem,
					@INdecQuanitadeMinina,
					@INdecQuantidade,
					@INdecPreco
				)

				SELECT @@IDENTITY AS Retorno
			END
			ELSE IF(@INintAcao = 1)
			BEGIN
				UPDATE
					tblProduto
				SET
					Descricao = @INvchDescricao,
					Ativo = @INbitAtivo,
					@INdecLargura = @INdecLargura,
					Altura = @INdecAltura,
					Profudidade = @INdecProfundidade,
					Cubagem = @INdecCubagem,
					QuanitadeMinima = @INdecQuanitadeMinina,
					Quantidade = @INdecQuantidade,
					Preco = @INdecPreco
				WHERE
					IDProduto = @INintIDProduto

				SELECT @INintIDProduto;
			END
			ELSE IF(@INintAcao = 2)
			BEGIN
				DELETE
					tblProduto
				WHERE
					IDProduto = @INintIDProduto

				SELECT '1' AS Retorno
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE()
	END CATCH
END


GO
/****** Object:  StoredProcedure [dbo].[uspCadastrarSituacao]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCadastrarSituacao]
@INintAcao INT,
@INintIDSituacao INT NULL,
@INvchDescricao VARCHAR(20) NULL
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			IF(@INintAcao = 0)
			BEGIN
				INSERT INTO tblSituacao
				(
					
					Descricao
				)
				VALUES
				(
					@INvchDescricao
				)

				SELECT @@IDENTITY AS Retorno
			END
			ELSE IF(@INintAcao = 1)
			BEGIN
				UPDATE
					tblSituacao
				SET
					Descricao = @INvchDescricao
				WHERE
					IDSituacao = @INintIDSituacao

				SELECT @INintIDSituacao;
			END
			ELSE IF( @INintAcao = 2)
			BEGIN
				DELETE
					tblSituacao
				WHERE
					IDSituacao = @INintIDSituacao
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_LINE(),ERROR_MESSAGE()
	END CATCH
END


GO
/****** Object:  StoredProcedure [dbo].[uspCadastrarSituacaoOperacao]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCadastrarSituacaoOperacao]
@INintAcao INT,
@INintIDOperacao INT,
@INintIDSituacao INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			IF(@INintAcao = 0)
			BEGIN
			INSERT INTO tblOperacaoSituacao
			(
				IDOperacao,
				IDSituacao
			)
			VALUES
			(
				@INintIDOperacao,
				@INintIDSituacao
			)
			END
			ELSE IF( @INintAcao = 2)
			BEGIN
				DELETE
					tblOperacaoSituacao
				WHERE
					IDOperacao = @INintIDOperacao AND
					IDSituacao = @INintIDSituacao
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_LINE(),ERROR_MESSAGE()
	END CATCH
END


GO
/****** Object:  StoredProcedure [dbo].[uspCadastrarTipoPagamento]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCadastrarTipoPagamento]
@INintAcao INT,
@INintIDTipoPagamento INT = NULL,
@INvchDescricao VARCHAR(40) = NULL,
@InbitAtivo BIT = NULL
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			IF(@INintAcao = 0)
			BEGIN
				INSERT INTO tblTipoPagamento
				(
					Descricao,
					Ativo
				)
				VALUES
				(
					@INvchDescricao,
					@InbitAtivo
				)

				SELECT @@IDENTITY AS Retorno
			END
			ELSE IF(@INintAcao = 1)
			BEGIN
				UPDATE
					tblTipoPagamento
				SET
					Descricao = @INvchDescricao,
					Ativo = @InbitAtivo
				WHERE
					IDTipoPagamento = @INintIDTipoPagamento

					SELECT @INintIDTipoPagamento
			END
			ELSE IF(@INintAcao = 2)
			BEGIN
				DELETE
					tblTipoPagamento
				WHERE
					IDTipoPagamento = @INintIDTipoPagamento

					SELECT '1' AS Retorno
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_LINE(),ERROR_MESSAGE()
	END CATCH
END


GO
/****** Object:  StoredProcedure [dbo].[uspCadastrarVendedor]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCadastrarVendedor]
@INintAcao INT,
@INintIDPessoa INT OUTPUT,
@INvchNome VARCHAR(50) =  NULL,
@INdecCpfCnpj DECIMAL(14,0) = NULL, 
@INbitAtivo BIT = NULL,
@INdatDataCadastro DATE = NULL
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			IF(@INintAcao = 0)
			BEGIN
			IF(EXISTS(SELECT IDPessoa FROM tblPessoa WITH(NOLOCK) JOIN tblVendedor WITH(NOLOCK) ON (tblPessoa.IDPessoa = tblVendedor.IDPessoaVendedor) WHERE CpfCnpj = @INdecCpfCnpj))
				RAISERROR('Já existe vendedor com este CPF cadastrado no sistema!',14,1);

				EXEC uspCadastrarPessoa 
				@INintAcao = @INintAcao,
				@INvchNome = @INvchNome,
				@INdecCpfCnpj = @INdecCpfCnpj,
				@INbitAtivo = @INbitAtivo,
				@INintIDPessoa = @INintIDPessoa OUT

				INSERT INTO tblVendedor
				(
					IDPessoaVendedor,
					DataCadastro
				)
				VALUES
				(
					@INintIDPessoa,
					@INdatDataCadastro
				)

				SELECT @INintIDPessoa;

			END
			ELSE IF(@INintAcao = 1)
			BEGIN
				IF(EXISTS(SELECT IDPessoa FROM tblPessoa WITH(NOLOCK) JOIN tblVendedor WITH(NOLOCK) ON (tblPessoa.IDPessoa = tblVendedor.IDPessoaVendedor) WHERE CpfCnpj = @INdecCpfCnpj AND IDPessoaVendedor <> @INintIDPessoa))
					RAISERROR('Já existe vendedor com este CPF cadastrado no sistema!',14,1);
				EXEC uspCadastrarPessoa 
				@INintAcao = @INintAcao,
				@INintIDPessoa = @INintIDPessoa,
				@INvchNome = @INvchNome,
				@INdecCpfCnpj = @INdecCpfCnpj,
				@INbitAtivo = @INbitAtivo

				UPDATE
					tblVendedor
				SET
					DataCadastro = @INdatDataCadastro
				WHERE
					IDPessoaVendedor = @INintIDPessoa

				SELECT @INintIDPessoa
			END
			ELSE IF( @INintAcao = 2)
			BEGIN
				IF(EXISTS(SELECT IDPessoaVendedor FROM tblPedido WITH(NOLOCK) WHERE IDPessoaVendedor = @INintIDPessoa))
				BEGIN
					UPDATE
						tblPessoa
					SET
						Ativo = 0
					WHERE
						IDPessoa = @INintIDPessoa
					--RAISERROR('Cliente já possui pedidos no sistema. Será INATIVADO.',14,2)
				END
				ELSE
				BEGIN
					DELETE
						tblVendedor
					WHERE
						IDPessoaVendedor = @INintIDPessoa
				EXEC uspCadastrarPessoa 
				@INintAcao = @INintAcao,
				@INintIDPessoa = NULL,
				@INvchNome = @INintIDPessoa,
				@INdecCpfCnpj = NULL,
				@INbitAtivo = NULL
				END

				SELECT '1' AS Retorno
			END
			
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE(),ERROR_LINE()
	END CATCH
END


GO
/****** Object:  StoredProcedure [dbo].[uspContasPagarSituacao]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspContasPagarSituacao]
@INintIDContasPagar INT = NULL,
@INintIDSituacaoAntiga INT = NULL,
@INintIDSituacaoNova INT = NULL
AS
BEGIN
BEGIN TRY
BEGIN TRAN
	DECLARE
	@intExcluido INT = 1,
	@intAberto INT = 2,
	@intPago INT = 4

	IF(@intAberto = @INintIDSituacaoAntiga AND @intPago = @INintIDSituacaoNova)
	BEGIN
		UPDATE
			tblContasPagar
		SET
			DataPagamento = GETDATE(),
			IDSituacao = @intPago
		WHERE
			IDContasPagar = @INintIDContasPagar
		SELECT '1' AS Retorno
	END
	ELSE
	BEGIN
		RAISERROR('Troca de situação não implementada!',14,1);
	END
COMMIT TRAN
END TRY
BEGIN CATCH
	ROLLBACK TRAN
	SELECT ERROR_MESSAGE()
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspContasReceberSituacao]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspContasReceberSituacao]
@INintIDContasReceber INT = NULL,
@INintIDSituacaoAtual INT =NULL,
@INintIDSituacaoNova INT = NULL,
@INintIDUsuario INT = NULL
AS 
BEGIN

	BEGIN TRY
		BEGIN TRAN

			DECLARE 
			@intIDSituacaoAberta INT =1,
			@intIDSituacaoPaga INT = 2,
			@intIDSituacaoExcluida INT = 3;

			DECLARE
				@intIDPedido INT = (SELECT TOP 1 IDPedido FROM tblContasReceber WITH(NOLOCK) WHERE IDContasReceber = @INintIDContasReceber ORDER BY DataLancamento DESC)

			IF(@INintIDSituacaoAtual = @intIDSituacaoAberta   AND @INintIDSituacaoNova = @intIDSituacaoPaga)
			BEGIN
				DECLARE @Data DATE = GETDATE();
				UPDATE
					tblContasReceber
				SET
					IDContasReceberSituacao = @intIDSituacaoPaga
				WHERE
					IDContasReceber = @INintIDContasReceber
			END
			ELSE IF(@INintIDSituacaoAtual = @intIDSituacaoAberta AND @INintIDSituacaoNova= @intIDSituacaoExcluida)
			BEGIN	
				UPDATE
					tblContasReceber
				SET
					IDContasReceberSituacao = @intIDSituacaoExcluida
				WHERE
					IDContasReceber = @INintIDContasReceber

					--SELECT * FROM tblSituacao
					--SELECT * FROM tblOperacao
				IF((SELECT IDPedido FROM tblPedido WITH(NOLOCK) WHERE IDPedido = @intIDPedido) <> 1)
				BEGIN
					EXEC [uspCadastrarPedidoSituacao]
						@INintIDSituacaoAtual  = 3,
						@INintIDSituacaoNova  = 1,
						@INintIDPedido = @intIDPedido,
						@INintIDUsuario = @INintIDUsuario,
						@INintIDOperacao = 1
				END

				SELECT '1' AS Retorno
			END
			ELSE IF(@INintIDSituacaoAtual = @intIDSituacaoExcluida AND @INintIDSituacaoNova= @intIDSituacaoAberta)
			BEGIN
				RAISERROR('Não é possivel voltar de EXCLUÍDO para ABERTO!',14,1);
				--UPDATE
				--	tblContasReceber
				--SET
				--	IDContasReceberSituacao =@intIDSituacaoAberta
				--WHERE
				--	IDContasReceber = @INintIDContasReceber

				--IF(@intIDPedido IS NOT NULL)
				--BEGIN
				--	EXEC [uspCadastrarPedidoSituacao]
				--		@INintIDSituacaoAtual  = 1,
				--		@INintIDSituacaoNova  = 2,
				--		@INintIDPedido = @intIDPedido,
				--		@INintIDUsuario = @INintIDUsuario,
				--		@INintIDOperacao = 1
				--END

			END
			ELSE IF(@INintIDSituacaoAtual = @intIDSituacaoPaga  AND @INintIDSituacaoNova= @intIDSituacaoAberta)
			BEGIN
				UPDATE
					tblContasReceber
				SET
					IDContasReceberSituacao = @intIDSituacaoAberta,
					DataPagamento = NULL,
					ValorPagar = NULL
				WHERE
					IDContasReceber = @INintIDContasReceber

				SELECT '1' AS Retorno
			END
			--ELSE IF(@INintIDSituacaoAtual = @intIDSituacaoExcluida AND @INintIDSituacaoNova= @intIDSituacaoAberta)
			--BEGIN
			--	UPDATE
			--		tblContasReceber
			--	SET
			--		IDContasReceberSituacao = @intIDSituacaoAberta
			--	WHERE
			--		IDContasReceber = @INintIDContasReceber

			--	IF(@intIDPedido IS NOT NULL)
			--	BEGIN
			--		EXEC [uspCadastrarPedidoSituacao]
			--			@INintIDSituacaoAtual  = 1,
			--			@INintIDSituacaoNova  = 2,
			--			@INintIDPedido = @intIDPedido,
			--			@INintIDUsuario = @INintIDUsuario,
			--			@INintIDOperacao = 1
			--	END
			--END
			ELSE
			BEGIN
				RAISERROR('Volta de Situação não Implementada!',14,1);
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE();
	END CATCH
END


GO
/****** Object:  StoredProcedure [dbo].[uspEstoqueConverterProduto]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspEstoqueConverterProduto]
@INintProdutoOriginal INT = NULL,
@INintProdutoDestino INT = NULL,
@INdecQuantidadeOriginal DECIMAL(18,2) = NULL,
@INdecQuantidadeDestino DECIMAL(18,2) = NULL
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			DECLARE
				@decCubagemOriginal DECIMAL(18,2) = NULL,
				@decCubagemDestino DECIMAL(18,2) = NULL,
				@datDate DATETIME = GETDATE();

				SET @decCubagemOriginal = ((SELECT TOP 1 Cubagem FROM tblProduto WITH(NOLOCK) WHERE IDProduto = @INintProdutoOriginal) * @INdecQuantidadeOriginal)
				SET @decCubagemDestino = ((SELECT TOP 1 Cubagem FROM tblProduto WITH(NOLOCK) WHERE IDProduto = @INintProdutoDestino) * @INdecQuantidadeDestino)

				IF(@decCubagemOriginal < @decCubagemDestino)
				BEGIN
					RAISERROR('Produto de Origem não possuem cubagem suficiente para Produto de Destino!',14,1);
				END

				EXEC uspCadastrarEstoqueMovimentacao
				@INintAcao = 0,
				@INdatData  = @datDate,
				@INintIDProduto = @INintProdutoOriginal,
				@INdecQuantidade = @INdecQuantidadeOriginal,
				@INvchOperacao = 'C'

				EXEC uspCadastrarEstoqueMovimentacao
				@INintAcao = 0,
				@INdatData  = @datDate,
				@INintIDProduto = @INintProdutoDestino,
				@INdecQuantidade = @INdecQuantidadeDestino,
				@INvchOperacao = 'D'


				SELECT '1' AS Retorno
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE()
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspFinContasReceberBaixar]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspFinContasReceberBaixar]
@INintIDContasReceber INT = NULL,
@INintIDUsuario INT = NULL,
@INintValorPgar DECIMAL(18,2) = NULL
AS
BEGIN
	DECLARE
		@datData DATE = GETDATE(),
		@intIDSituacaoAberta INT = 1,
		@intIDSituacaoPaga INT = 2,
		@intIDSituacaoExcluida INT = 3
	BEGIN TRY
		BEGIN TRAN
				UPDATE
					tblContasReceber
				SET
					DataPagamento = @datData,
					ValorPagar = @INintValorPgar
				WHERE
					IDContasReceber = @INintIDContasReceber
				EXEC uspContasReceberSituacao 
				@INintIDContasReceber,
				@intIDSituacaoAberta,
				@intIDSituacaoPaga,
				@INintIDUsuario
		SELECT '1' AS Retorno
		COMMIT TRAN
	END TRY
	BEGIN CATCH
	END CATCH
END

GO
/****** Object:  StoredProcedure [dbo].[uspPesquisarCliente]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPesquisarCliente]
@INvchNome VARCHAR(50) =  NULL,
@INbitAtivo BIT =  NULL
AS
BEGIN
	SET NOCOUNT ON

	SELECT
		tblPes.CpfCnpj,
		tblCli.LimiteMaximo,
		tblCli.LimiteMinimo,
		tblCli.DataCadastro,
		tblCli.DataNascimento,
		tblPes.IDPessoa,
		tblPes.Nome,
		tblPes.Ativo
		
	FROM
		tblPessoa AS tblPes WITH(NOLOCK)
	JOIN
		tblCliente AS tblCli WITH(NOLOCK) ON (tblPes.IDPessoa = tblCli.IDPessoaCliente)
	WHERE
		((tblPes.Nome LIKE @INvchNome) OR (@INvchNome IS NULL)) AND
		((tblPes.Ativo = @INbitAtivo) OR (@INbitAtivo IS NULL))
END

GO
/****** Object:  StoredProcedure [dbo].[uspPesquisarContasPagar]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPesquisarContasPagar]
@intIDContasPagar INT = NULL,
@intPessoaFornecedor INT = NULL,
@datDataInicial DATE = NULL,
@datDataFinal DATE = NULL,
@vchIDSituacaoVarios VARCHAR(MAX) = NULL
AS
BEGIN
	SELECT
		tblConPag.IDContasPagar,
		tblConPag.DataLancamento,
		tblConPag.DataPagamento,
		tblConPag.DataVencimento,
		tblConPag.Observacao,
		tblConPag.Valor,
		tblPesFor.IDPessoa,
		tblPesFor.Nome,
		tblOpeSit.IDOperacao,
		tblOpeSit.IDSituacao,
		tblSit.Descricao AS [DescSituacao],
		tblOpe.Descricao AS [DescOperacao],
		tblConPagtip.IDContasPagarTipo,
		tblConPagtip.Descricao AS [DescTipo]
	FROM
		tblContasPagar AS tblConPag WITH(NOLOCK)
	JOIN
		tblContasPagarTipo AS tblConPagtip WITH(NOLOCK) ON (tblConPag.IDContasPagarTipo = tblConPagtip.IDContasPagarTipo)
	JOIN
		tblPessoa AS tblPesFor WITH(NOLOCK) ON (tblConPag.IDPessoaFornecedor = tblPesFor.IDPessoa)
	JOIN
		tblOperacaoSituacao AS tblOpeSit WITH(NOLOCK) ON (tblConPag.IDOperacao = tblOpeSit.IDOperacao AND tblConPag.IDSituacao = tblOpeSit.IDSituacao)
	JOIN
		tblOperacao AS tblOpe WITH(NOLOCK) ON (tblOpeSit.IDOperacao = tblOpe.IDOperacao)
	JOIN
		tblSituacao AS tblSit WITH(NOLOCK) ON (tblOpeSit.IDSituacao = tblSit.IDSituacao)
	WHERE
		((CAST(tblConPag.DataLancamento AS date) BETWEEN @datDataInicial AND @datDataFinal) OR (@datDataInicial IS NULL) OR (@datDataFinal IS NULL)) AND
		((tblConPag.IDContasPagar = @intIDContasPagar) OR (@intIDContasPagar IS NULL)) AND
		(tblConPag.IDSituacao IN(SELECT ID FROM ufnTextoTabelaPontoVirgula(@vchIDSituacaoVarios)) OR (@vchIDSituacaoVarios IS NULL)) AND
		((tblConPag.IDPessoaFornecedor = @intPessoaFornecedor) OR (@intPessoaFornecedor IS NULL))
END
GO
/****** Object:  StoredProcedure [dbo].[uspPesquisarContasPagarSituacao]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPesquisarContasPagarSituacao]
AS
BEGIN
	SELECT
		tblOpeSit.IDSituacao,
		tblSit.Descricao
	FROM
		tblOperacaoSituacao AS tblOpeSit WITH(NOLOCK)
	JOIN
		tblOperacao AS tblOpe WITH(NOLOCK) ON (tblOpeSit.IDOperacao = tblOpe.IDOperacao)
	JOIN
		tblSituacao AS tblSit WITH(NOLOCK) ON (tblOpeSit.IDSituacao = tblSit.IDSituacao)
	WHERE
		tblOpeSit.IDOperacao IN(3)
END
GO
/****** Object:  StoredProcedure [dbo].[uspPesquisarContasPagarTipo]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPesquisarContasPagarTipo]
@INvchDescricao VARCHAR(50) = NULL,
@INbitAtivo BIT = NULL
AS
BEGIN
SET NOCOUNT ON
SELECT
	tblConPagTip.IDContasPagarTipo,
	tblConPagTip.Descricao,
	tblConPagTip.Ativo
FROM
	tblContasPagarTipo AS tblConPagTip WITH(NOLOCK)
WHERE
	((tblConPagTip.Descricao LIKE'%'+ @INvchDescricao +'%') OR (@INvchDescricao IS NULL)) AND
	((tblConPagTip.Ativo = @INbitAtivo) OR (@INbitAtivo IS NULL))
END



GO
/****** Object:  StoredProcedure [dbo].[uspPesquisarContasReceber]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPesquisarContasReceber]
@INintIDContasReceber INT = NULL,
@INintIDPedido INT = NULL,
@INdatDataInicial DATE = NULL,
@INdatDataFinal DATE = NULL,
@INintIDCliente INT = NULL,
@INintIDVendedor INT = NULL,
@INvchVariosIDSituacao VARCHAR(MAX) = NULL
AS
BEGIN
	IF(@INintIDPedido IS NULL)
	BEGIN
		SELECT
		tblConRec.IDContasReceber,
		tblConRec.DataLancamento,
		tblConRec.DataVencimento,
		tblConRec.DataPagamento,
		tblConRec.ValorTotal,
		tblPesCli.IDPessoa AS [IDCliente],
		tblPesCli.Nome AS [NomeCliente],
		tblPesVen.IDPessoa AS [IDVendedor],
		tblPesVen.Nome AS [NomeVendedor],
		tblTipPag.IDTipoPagamento,
		tblTipPag.Descricao,
		tblConRecSit.IDSituacao,
		tblConRecSit.Descricao AS [DescSituacao],
		tblConRecOri.IDContasReceberOrigem,
		tblConRecOri.Descricao AS [DescOrigem]

	FROM
		tblContasReceber AS tblConRec WITH(NOLOCK)
	JOIN
		tblPessoa AS tblPesCli WITH(NOLOCK) ON (tblConRec.IDPessoaCliente = tblPesCli.IDPessoa)
	JOIN
		tblPessoa AS tblPesVen WITH(NOLOCK) ON (tblConRec.IDPessoaVendedor = tblPesVen.IDPessoa)
	LEFT JOIN
		tblTipoPagamento AS tblTipPag WITH(NOLOCK) ON (tblConRec.IDTipoPagamento = tblTipPag.IDTipoPagamento)
	JOIN
		tblContasReceberSituacao AS tblConRecSit WITH(NOLOCK) ON (tblConRec.IDContasReceberSituacao = tblConRecSit.IDSituacao)
	JOIN
		tblContasReceberOrigem AS tblConRecOri WITH(NOLOCK) ON (tblConRec.IDContasReceberOrigem = tblConRecOri.IDContasReceberOrigem)
	WHERE
		((tblConRec.IDContasReceber = @INintIDContasReceber) OR (@INintIDContasReceber IS NULL)) AND
		((tblConRec.IDPessoaCliente = @INintIDCliente) OR (@INintIDCliente IS NULL)) AND
		((tblConRec.IDPessoaVendedor = @INintIDVendedor) OR (@INintIDVendedor IS NULL)) AND
		((CAST(tblConRec.DataLancamento AS DATE) BETWEEN @INdatDataInicial AND @INdatDataFinal) OR (@INdatDataInicial IS NULL) OR (@INdatDataFinal IS NULL)) AND
		((tblConRec.IDContasReceberSituacao IN (SELECT ID FROM ufnTextoTabelaPontoVirgula(@INvchVariosIDSituacao))) OR (@INvchVariosIDSituacao IS NULL))
	END
	ELSE
	BEGIN
		SELECT
		tblConRec.IDContasReceber,
		tblConRec.DataLancamento,
		tblConRec.DataVencimento,
		tblConRec.DataPagamento,
		tblConRec.ValorTotal,
		tblPesCli.IDPessoa AS [IDCliente],
		tblPesCli.Nome AS [NomeCliente],
		tblPesVen.IDPessoa AS [IDVendedor],
		tblPesVen.Nome AS [NomeVendedor],
		tblTipPag.IDTipoPagamento,
		tblTipPag.Descricao,
		tblConRecSit.IDSituacao,
		tblConRecSit.Descricao AS [DescSituacao],
		tblConRecOri.IDContasReceberOrigem,
		tblConRecOri.Descricao AS [DescOrigem]

	FROM
		tblContasReceber AS tblConRec WITH(NOLOCK)
	JOIN
		tblPessoa AS tblPesCli WITH(NOLOCK) ON (tblConRec.IDPessoaCliente = tblPesCli.IDPessoa)
	JOIN
		tblPessoa AS tblPesVen WITH(NOLOCK) ON (tblConRec.IDPessoaVendedor = tblPesVen.IDPessoa)
	LEFT JOIN
		tblTipoPagamento AS tblTipPag WITH(NOLOCK) ON (tblConRec.IDTipoPagamento = tblTipPag.IDTipoPagamento)
	JOIN
		tblContasReceberSituacao AS tblConRecSit WITH(NOLOCK) ON (tblConRec.IDContasReceberSituacao = tblConRecSit.IDSituacao)
	JOIN
		tblContasReceberOrigem AS tblConRecOri WITH(NOLOCK) ON (tblConRec.IDContasReceberOrigem = tblConRecOri.IDContasReceberOrigem)
	WHERE
		tblConRec.IDPedido = @INintIDPedido
	END
END

GO
/****** Object:  StoredProcedure [dbo].[uspPesquisarContasReceberSituacao]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPesquisarContasReceberSituacao]
AS
BEGIN
	SELECT
		IDSituacao,
		Descricao
	FROM
		tblContasReceberSituacao WITH(NOLOCK)
END

GO
/****** Object:  StoredProcedure [dbo].[uspPesquisarEmailPessoa]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPesquisarEmailPessoa]
@INIDPessoa INT
AS
BEGIN
	SET NOCOUNT ON
	SELECT
		IDEmail,
		IDPessoa,
		Descricao,
		Principal
	FROM
		tblEMail WITH(NOLOCK)
	WHERE
		tblEMail.IDPessoa = @INIDPessoa

END

GO
/****** Object:  StoredProcedure [dbo].[uspPesquisarEndereco]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPesquisarEndereco]
@INintIDPessoa INT = NULL
AS
BEGIN
	SELECT
		IDEndereco,
		IDPessoa,
		Logradouro,
		Numero,
		Complemento,
		Bairro,
		Cep,
		Cidade
	FROM
		tblEndereco AS tblEnd WITH(NOLOCK)
	WHERE
		tblEnd.IDPessoa = @INintIDPessoa
END

GO
/****** Object:  StoredProcedure [dbo].[uspPesquisarEnderecoPessoa]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPesquisarEnderecoPessoa]
@INintIDPessoa INT = NULL
AS
BEGIN
	SELECT
		IDEndereco,
		IDPessoa,
		Logradouro,
		Numero,
		Complemento,
		Bairro,
		Cep,
		Cidade
	FROM
		tblEndereco AS tblEnd WITH(NOLOCK)
	WHERE
		tblEnd.IDPessoa = @INintIDPessoa
END

GO
/****** Object:  StoredProcedure [dbo].[uspPesquisarEstoqueMovimentacao]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPesquisarEstoqueMovimentacao]
@INvchDescricaoProduto VARCHAR(80) = NULL,
@INintIDProduto INT = NULL,
@INdataInicial DATE = NULL,
@INdataFinal DATE = NULL
AS
BEGIN
	SELECT
		tblEstMov.IDMovimentacao,
		tblEstMov.Data,
		tblEstMov.Operacao,
		tblPro.IDProduto,
		tblPro.Descricao,
		tblEstMov.Quantidade,
		tblPro.Quantidade AS [Estoque]
	FROM
		tblEstoqueMovimentacao AS tblEstMov WITH(NOLOCK)
	JOIN
		tblProduto AS tblPro WITH(NOLOCK) ON (tblEstMov.IDProduto = tblPro.IDProduto)
	WHERE
		((tblPro.IDProduto = @INintIDProduto) OR (@INintIDProduto IS NULL)) AND
		--((tblPro.Descricao LIKE '&'+@INvchDescricaoProduto+'&') OR (@INvchDescricaoProduto IS NULL)) AND
		((CAST(tblEstMov.Data AS DATE) BETWEEN @INdataInicial AND @INdataFinal) OR (@INdataInicial IS NULL) OR (@INdataFinal IS NULL))
END
GO
/****** Object:  StoredProcedure [dbo].[uspPesquisarFornecedor]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPesquisarFornecedor]
@INvchNome VARCHAR(50) =  NULL,
@INbitAtivo BIT =  NULL
AS
BEGIN
	SELECT
		tblPes.CpfCnpj,
		tblFor.DataCadastro,
		tblFor.IE,
		tblPes.IDPessoa,
		tblPes.Nome,
		tblPes.Ativo
	FROM
		tblPessoa AS tblPes WITH(NOLOCK)
	JOIN
		tblFornecedor AS tblFor WITH(NOLOCK) ON (tblPes.IDPessoa = tblFor.IDPessoaFornecedor)
	WHERE
		((tblPes.Nome LIKE @INvchNome) OR (@INvchNome IS NULL)) AND
		((tblPes.Ativo = @INbitAtivo) OR (@INbitAtivo IS NULL))

END

GO
/****** Object:  StoredProcedure [dbo].[uspPesquisarItemPedido]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPesquisarItemPedido]
@INintIDPedido INT = NULL
AS
BEGIN
	SELECT DISTINCT
		tblPedIte.IDProduto,
		Descricao,
		Ativo,
		QuanitadeMinima,
		Altura,
		Largura,
		Profudidade,
		Cubagem,
		tblPedIte.Preco,
		tblPedIte.Quantidade
	FROM
		tblProduto AS tblPro WITH(NOLOCK)
	JOIN
		tblPedidoItem AS tblPedIte WITH(NOLOCK) ON (tblPro.IDProduto = tblPedIte.IDProduto)
	WHERE
		tblPedIte.IDPedido = @INintIDPedido
END

GO
/****** Object:  StoredProcedure [dbo].[uspPesquisarItensPedido]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPesquisarItensPedido]
@INintIDPedido INT = NULL
AS
BEGIN
	SELECT DISTINCT
		tblPedIte.IDProduto,
		Descricao,
		Ativo,
		QuanitadeMinima,
		Altura,
		Largura,
		Profudidade,
		Cubagem,
		tblPedIte.Preco,
		tblPedIte.Quantidade
	FROM
		tblProduto AS tblPro WITH(NOLOCK)
	JOIN
		tblPedidoItem AS tblPedIte WITH(NOLOCK) ON (tblPro.IDProduto = tblPedIte.IDProduto)
	WHERE
		tblPedIte.IDPedido = @INintIDPedido
END

GO
/****** Object:  StoredProcedure [dbo].[uspPesquisarOperacao]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPesquisarOperacao]
AS
BEGIN
	SELECT
		IDOperacao,
		Descricao
	FROM
		tblOperacao WITH(NOLOCK)
END


GO
/****** Object:  StoredProcedure [dbo].[uspPesquisarOperacaoSituacao]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPesquisarOperacaoSituacao]
AS
BEGIN
	SELECT
		IDOperacao,
		Descricao
	FROM
		tblOperacao WITH(NOLOCK)

	SELECT
		IDSituacao,
		Descricao
	FROM
		tblSituacao WITH(NOLOCK)
END

GO
/****** Object:  StoredProcedure [dbo].[uspPesquisarPedido]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPesquisarPedido]
@INintIDOperacao INT = NULL,
@INintIDPedido INT = NULL,
@INintIDCliente INT = NULL,
@INintIDVendedor INT = NULL,
@INdatDataInicial DATE = NULL,
@INdatDataFinal DATE = NULL,
@INvchIDsSituacao VARCHAR(MAX) = NULL
AS
BEGIN
	SET NOCOUNT ON

	IF(@INintIDPedido IS NULL)
	BEGIN
		SELECT
		tblPed.IDPedido,
		tblPed.DataPedido,
		tblPed.ValorTotal,
		tblPed.Observacao,
		tblPesCli.IDPessoa AS [IDPessoaCliente],
		tblPesCli.Nome AS [NomeCliente],
		tblPesVen.IDPessoa AS [IDPessoaVendedor],
		tblPesVen.Nome AS [NomeVendedor],
		tblOpeSit.IDSituacao,
		tblOpeSit.IDOperacao,
		tblOpe.Descricao AS[DescricaoOperacao],
		tblSit.Descricao AS[DescricaoSituacao],
		tblPedTip.IDPedidoTipo,
		tblPedTip.DescricaoPedidoTipo
	FROM
		tblPedido AS tblPed WITH(NOLOCK)
	JOIN
		tblCliente AS tblCli WITH(NOLOCK) ON (tblPed.IDPessoaCliente = tblCli.IDPessoaCliente)
	JOIN
		tblPessoa AS tblPesCli WITH(NOLOCK) ON (tblCli.IDPessoaCliente = tblPesCli.IDPessoa)
	JOIN
		tblVendedor AS tblVen WITH(NOLOCK) ON (tblPed.IDPessoaVendedor = tblVen.IDPessoaVendedor)
	JOIN
		tblPessoa AS tblPesVen WITH(NOLOCK) ON (tblVen.IDPessoaVendedor = tblPesVen.IDPessoa)
	JOIN
		tblOperacaoSituacao AS tblOpeSit WITH(NOLOCK) ON (tblPed.IDOperacao = tblOpeSit.IDOperacao AND tblPed.IDSituacao = tblOpeSit.IDSituacao)
	JOIN
		tblOperacao AS tblOpe WITH(NOLOCK) ON (tblOpeSit.IDOperacao = tblOpe.IDOperacao)
	JOIN
		tblSituacao AS tblSit WITH(NOLOCK) ON (tblOpeSit.IDSituacao = tblSit.IDSituacao)
	JOIN
		tblPedidoTipo AS tblPedTip ON (tblPed.IDPedidoTipo = tblPedTip.IDPedidoTipo)
	WHERE
		((tblPed.DataPedido BETWEEN @INdatDataInicial AND @INdatDataFinal) OR (@INdatDataInicial IS NULL) OR (@INdatDataFinal IS NULL)) AND
		((tblPed.IDPessoaCliente = @INintIDCliente) OR (@INintIDCliente IS NULL)) AND
		((tblPed.IDPessoaVendedor = @INintIDVendedor) OR (@INintIDVendedor IS NULL)) AND
		(tblPed.IDOperacao = @INintIDOperacao OR (@INintIDOperacao IS NULL)) AND
		((tblPed.IDSituacao IN(SELECT ID FROM ufnTextoTabelaPontoVirgula(@INvchIDsSituacao)) OR (@INvchIDsSituacao IS NULL))) AND
		((tblPed.IDPedido = @INintIDPedido) OR (@INintIDPedido IS NULL))
	END
	ELSE
		BEGIN
			SELECT
			tblPed.IDPedido,
			tblPed.DataPedido,
			tblPed.ValorTotal,
			tblPed.Observacao,
			tblPesCli.IDPessoa AS [IDPessoaCliente],
			tblPesCli.Nome AS [NomeCliente],
			tblPesVen.IDPessoa AS [IDPessoaVendedor],
			tblPesVen.Nome AS [NomeVendedor],
			tblOpeSit.IDSituacao,
			tblOpeSit.IDOperacao,
			tblOpe.Descricao AS[DescricaoOperacao],
			tblSit.Descricao AS[DescricaoSituacao],
			tblPedTip.IDPedidoTipo,
			tblPedTip.DescricaoPedidoTipo
		FROM
			tblPedido AS tblPed WITH(NOLOCK)
		JOIN
			tblCliente AS tblCli WITH(NOLOCK) ON (tblPed.IDPessoaCliente = tblCli.IDPessoaCliente)
		JOIN
			tblPessoa AS tblPesCli WITH(NOLOCK) ON (tblCli.IDPessoaCliente = tblPesCli.IDPessoa)
		JOIN
			tblVendedor AS tblVen WITH(NOLOCK) ON (tblPed.IDPessoaVendedor = tblVen.IDPessoaVendedor)
		JOIN
			tblPessoa AS tblPesVen WITH(NOLOCK) ON (tblVen.IDPessoaVendedor = tblPesVen.IDPessoa)
		JOIN
			tblOperacaoSituacao AS tblOpeSit WITH(NOLOCK) ON (tblPed.IDOperacao = tblOpeSit.IDOperacao AND tblPed.IDSituacao = tblOpeSit.IDSituacao)
		JOIN
			tblOperacao AS tblOpe WITH(NOLOCK) ON (tblOpeSit.IDOperacao = tblOpe.IDOperacao)
		JOIN
			tblSituacao AS tblSit WITH(NOLOCK) ON (tblOpeSit.IDSituacao = tblSit.IDSituacao)
		JOIN
			tblPedidoTipo AS tblPedTip ON (tblPed.IDPedidoTipo = tblPedTip.IDPedidoTipo)
		WHERE
			((tblPed.IDPedido = @INintIDPedido) OR (@INintIDPedido IS NULL))
		END
END

GO
/****** Object:  StoredProcedure [dbo].[uspPesquisarProduto]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPesquisarProduto]
@INintIDProduto INT = NULL,
@INvchDescricao VARCHAR(50),
@INbitAtivo BIT = NULL
AS
BEGIN
	SELECT
		IDProduto,
		Descricao,
		Ativo,
		QuanitadeMinima,
		Altura,
		Largura,
		Profudidade,
		Cubagem,
		Preco
	FROM
		tblProduto AS tblPro WITH(NOLOCK)
	WHERE
		((tblPro.IDProduto = @INintIDProduto) or (@INintIDProduto IS NULL)) AND
		((tblPro.Descricao LIKE '%'+@INvchDescricao+'%') OR (@INvchDescricao IS NULL)) AND
		((tblPro.Ativo = @INbitAtivo) OR (@INbitAtivo IS NULL))
END

GO
/****** Object:  StoredProcedure [dbo].[uspPesquisarSituacao]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPesquisarSituacao]
AS
BEGIN
	SELECT
		IDSituacao,
		Descricao
	FROM
		tblSituacao WITH(NOLOCK)
END

GO
/****** Object:  StoredProcedure [dbo].[uspPesquisarTipoPagamento]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPesquisarTipoPagamento]
@INintIDTipoPagamento INT = NULL,
@INvchDescricao VARCHAR(50) = NULL,
@INbitAtivo BIT = NULL
AS
BEGIN
	SELECT
		tblTipPag.IDTipoPagamento,
		tblTipPag.Descricao,
		tblTipPag.Ativo
	FROM
		tblTipoPagamento AS tblTipPag WITH(NOLOCK)
	WHERE
		((tblTipPag.IDTipoPagamento = @INintIDTipoPagamento) OR (@INintIDTipoPagamento IS NULL)) AND
		((tblTipPag.Descricao LIKE'%'+@INvchDescricao+'%') OR (@INvchDescricao IS NULL)) AND
		((tblTipPag.Ativo = @INbitAtivo) OR (@INbitAtivo IS NULL))
END

GO
/****** Object:  StoredProcedure [dbo].[uspPesquisarVendedor]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPesquisarVendedor]
@INvchNome VARCHAR(50) = NULL,
@INbitAtivo BIT = NULL
AS
BEGIN
	SELECT
		tblPes.IDPessoa,
		tblPes.Nome,
		tblPes.CpfCnpj,
		tblPes.Ativo,
		tblVen.DataCadastro
	FROM
		tblPessoa AS tblPes WITH(NOLOCK)
	JOIN
		tblVendedor AS tblVen WITH(NOLOCK) ON (tblPes.IDPessoa = tblVen.IDPessoaVendedor)
	WHERE
		((tblPes.Nome LIKE '%'+@INvchNome+'%')OR (@INvchNome IS NULL)) AND
		((tblPes.Ativo = @INbitAtivo) OR (@INbitAtivo IS NULL))
END


GO
/****** Object:  StoredProcedure [dbo].[uspRelCliente]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspRelCliente]
@INintIDPessoaCliente INT = NULL,
@INbitAtivo BIT = NULL
AS
BEGIN
 SET NOCOUNT ON;
SELECT
	tblPes.IDPessoa,
	tblPes.Nome,
	tblPes.CpfCnpj,
	CASE tblPes.Ativo WHEN 0 THEN 'NÃO' ELSE 'SIM' END AS Ativo,
	COALESCE(COUNT(tblPed.IDPedido),0) TotalPedidos,
	COALESCE(SUM(tblPed.ValorTotal),0) AS [ValorTotal]
FROM
	tblPessoa AS tblPes WITH(NOLOCK)
JOIN
	tblCliente AS tblCli WITH(NOLOCK) ON (tblPes.IDPessoa = tblCli.IDPessoaCliente)
LEFT JOIN
	tblPedido AS tblPed WITH(NOLOCK) ON (tblPed.IDPessoaCliente = tblPes.IDPessoa)
WHERE
	((tblPes.IDPessoa = @INintIDPessoaCliente) OR (@INintIDPessoaCliente IS NULL)) AND
	((tblPes.Ativo = @INbitAtivo) OR (@INbitAtivo IS NULL)) --AND
	--tblPed.IDSituacao IN(2,3)
GROUP BY
	tblPes.IDPessoa,
	tblPes.Nome,
	tblPes.CpfCnpj,
	tblPes.Ativo
ORDER BY
	tblPes.Nome DESC
END
GO
/****** Object:  StoredProcedure [dbo].[uspRelContasPagarVarias]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspRelContasPagarVarias]
@INintIDPessoaFornecedor INT = NULL,
@INvchIDVariasSituacao VARCHAR(MAX) = NULL
AS
BEGIN 
	SET NOCOUNT ON;
SELECT
	tblConPag.IDContasPagar,
	tblConPag.DataVencimento,
	tblConPag.DataPagamento,
	tblConPag.DataLancamento,
	tblConPag.Valor,
	tblSit.Descricao,
	tblConPag.IDPessoaFornecedor,
	tblPes.Nome,
	tblPes.CpfCnpj
FROM
	tblContasPagar AS tblConPag WITH(NOLOCK)
JOIN
	tblFornecedor AS tblFor WITH(NOLOCK) ON (tblConPag.IDPessoaFornecedor = tblFor.IDPessoaFornecedor)
JOIN
	tblPessoa AS tblPes WITH(NOLOCK) ON (tblConPag.IDPessoaFornecedor = tblPes.IDPessoa)
JOIN
	tblOperacaoSituacao AS tblOpe WITH(NOLOCK) ON (tblConPag.IDOperacao = tblOpe.IDOperacao AND tblConPag.IDSituacao = tblOpe.IDSituacao)
JOIN
	tblSituacao AS tblSit WITH(NOLOCK) ON (tblOpe.IDSituacao = tblSit.IDSituacao)
WHERE
	((tblPes.IDPessoa = @INintIDPessoaFornecedor) OR (@INintIDPessoaFornecedor IS NULL)) AND
	((tblConPag.IDSituacao IN(SELECT ID FROM ufnTextoTabelaPontoVirgula(@INvchIDVariasSituacao))) OR (@INvchIDVariasSituacao IS NULL))
END
GO
/****** Object:  StoredProcedure [dbo].[uspRelContasReceberVarias]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspRelContasReceberVarias]
@INintIDPessoaCliente INT = NULL,
@INvchIDSituacaoVarias VARCHAR(MAX) = NULL
AS
BEGIN
	SET NOCOUNT ON;

	SELECT
		tblConRec.IDContasReceber,
		CAST(tblConRec.DataLancamento AS DATE) AS DataLancamento,
		CAST(tblConRec.DataPagamento AS DATE) AS DataPagamento,
		CAST(tblConRec.DataVencimento AS DATE) AS DataVencimento,
		tblConRec.ValorTotal,
		tblConRec.ValorPagar,
		tblConRecSit.Descricao,
		tblPes.IDPessoa,
		tblPes.Nome
	FROM
		tblContasReceber AS tblConRec WITH(NOLOCK)
	JOIN
		tblPessoa AS tblPes WITH(NOLOCK) ON (tblConRec.IDPessoaCliente = tblPes.IDPessoa)
	JOIN
		tblContasReceberSituacao AS tblConRecSit WITH(NOLOCK) ON (tblConRec.IDContasReceberSituacao = tblConRecSit.IDSituacao)
	JOIN
		tblContasReceberOrigem AS tblConRecOri WITH(NOLOCK) ON (tblConRecOri.IDContasReceberOrigem = tblConRec.IDContasReceberOrigem)
	WHERE
		((tblPes.IDPessoa = @INintIDPessoaCliente) OR (@INintIDPessoaCliente IS NULL)) AND
		((tblConRec.IDContasReceberSituacao IN(SELECT ID FROM ufnTextoTabelaPontoVirgula(@INvchIDSituacaoVarias))) OR (@INvchIDSituacaoVarias IS NULL))
END
GO
/****** Object:  StoredProcedure [dbo].[uspRelFornecedor]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspRelFornecedor]
@INintIDPessoaFornecedor INT = NULL,
@INbitAtivo BIT = NULL
AS
BEGIN
 SET NOCOUNT ON;
SELECT
	tblPes.IDPessoa,
	tblPes.Nome,
	tblPes.CpfCnpj,
	CASE tblPes.Ativo WHEN 0 THEN 'NÃO' ELSE 'SIM' END AS Ativo,
	CAST(tblFor.DataCadastro AS date) AS DataCadastro,
	tblFor.IE
FROM
	tblPessoa AS tblPes WITH(NOLOCK)
JOIN
	tblFornecedor AS tblFor WITH(NOLOCK) ON (tblPes.IDPessoa = tblFor.IDPessoaFornecedor)
WHERE
	((tblPes.IDPessoa = @INintIDPessoaFornecedor) OR (@INintIDPessoaFornecedor IS NULL)) AND
	((tblPes.Ativo = @INbitAtivo) OR (@INbitAtivo IS NULL))
ORDER BY
	tblPes.Nome DESC
END
GO
/****** Object:  StoredProcedure [dbo].[uspRelProdutoTotal]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspRelProdutoTotal]
@INbitAtivo BIT = NULL,
@INintProduto INT = NULL
AS
BEGIN
	SELECT
		tblPro.IDProduto,
		tblPro.Descricao,
		tblPro.Quantidade,
		tblPro.Preco,
		(tblPro.Quantidade * tblPro.Cubagem) AS CubagemTotal
	FROM
		tblProduto AS tblPro WITH(NOLOCK)
	WHERE
		((tblPro.IDProduto = @INintProduto) OR (@INintProduto IS NULL)) AND
		((tblPro.Ativo = @INbitAtivo) OR (@INbitAtivo IS NULL))
END
GO
/****** Object:  StoredProcedure [dbo].[uspRelVenPedido]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspRelVenPedido]
@INintIDPedido INT = NULL
AS
BEGIN
	SET NOCOUNT ON;
	SELECT
		tblPed.IDPedido,
		CONCAT(tblPed.IDPessoaCliente,' - ',tblPesCli.Nome) AS Cliente,
		CONCAT(tblEnd.Logradouro, tblEnd.Bairro,' - ', tblEnd.Numero) AS Endereco,
		tblEnd.Cidade,
		tbEma.Descricao AS Email,
		tblPedTip.DescricaoPedidoTipo,
		tblPed.DataPedido AS DataPedido,
		COALESCE(tblPed.Observacao,'Não há informações.') AS [Observacao],
		tblPesCli.CpfCnpj,
		tblPesVen.Nome AS [NomeVendedor],
		tblPesCli.Nome AS [NomeCliente]
	FROM
		tblPedido AS tblPed WITH(NOLOCK)
	JOIN
		tblPedidoTipo AS tblPedTip WITH(NOLOCK) ON (tblPed.IDPedidoTipo = tblPedTip.IDPedidoTipo)
	JOIN
		tblPessoa AS tblPesCli WITH(NOLOCK) ON (tblPed.IDPessoaCliente = tblPesCli.IDPessoa)
	JOIN
		tblPessoa AS tblPesVen WITH(NOLOCK) ON (tblPed.IDPessoaVendedor = tblPesVen.IDPessoa)
	LEFT JOIN
		tblEndereco AS tblEnd WITH(NOLOCK) ON (tblPed.IDPessoaCliente = tblEnd.IDPessoa AND Principal = 1)
	LEFT JOIN
		tblEMail AS tbEma WITH(NOLOCK) ON (tblPed.IDPessoaCliente = tbEma.IDPessoa AND tbEma.Principal = 1)
	WHERE
		tblPed.IDPedido = @INintIDPedido

	SELECT
		tblPed.IDPedido,
		tblPedIte.IDProduto,
		tblPro.Descricao,
		tblPro.Preco,
		tblPedIte.Quantidade,
		tblPro.Cubagem
	FROM
		tblPedido AS tblPed WITH(NOLOCK)
	JOIN
		tblPedidoItem AS tblPedIte WITH(NOLOCK) ON (tblPed.IDPedido = tblPedIte.IDPedido)
	JOIN
		tblProduto AS tblPro WITH(NOLOCK) ON (tblPedIte.IDProduto = tblPro.IDProduto)
	WHERE
		tblPed.IDPedido = @INintIDPedido

	SELECT
		tblPed.IDPedido,
		SUM(tblPro.Cubagem * tblPedIte.Quantidade) AS TotalCubagem,
		tblPed.ValorTotal
	FROM
		tblPedido AS tblPed WITH(NOLOCK)
	JOIN
		tblPedidoItem AS tblPedIte WITH(NOLOCK) ON (tblPed.IDPedido = tblPedIte.IDPedido)
	JOIN
		tblProduto AS tblPro WITH(NOLOCK) ON (tblPedIte.IDProduto = tblPro.IDProduto)
	WHERE
		tblPed.IDPedido = @INintIDPedido
	GROUP BY
		tblPed.IDPedido,
		tblPed.ValorTotal
END
GO
/****** Object:  StoredProcedure [dbo].[uspUsuarioAcesso]    Script Date: 17/11/2016 00:27:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspUsuarioAcesso]
@INvchUsuario VARCHAR(30) = NULL,
@INvchSenha VARCHAR(30) = NULL
AS
BEGIN
	IF(EXISTS(SELECT TOP 1 Usuario FROM tblUsuario WITH(NOLOCK) WHERE Usuario = @INvchUsuario AND Senha =@INvchSenha))
	BEGIN
		SELECT 1
	END
	ELSE
	BEGIN
		SELECT 0
	END
		
END

GO
USE [master]
GO
ALTER DATABASE [ESMPLUS] SET  READ_WRITE 
GO
