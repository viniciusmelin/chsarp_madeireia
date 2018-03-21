USE [master]
GO
/****** Object:  Database [ESMPLUS]    Script Date: 29/08/2016 22:52:09 ******/
CREATE DATABASE [ESMPLUS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ESMPLUS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.LOCALHOST\MSSQL\DATA\ESMPLUS.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ESMPLUS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.LOCALHOST\MSSQL\DATA\ESMPLUS_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
/****** Object:  Table [dbo].[tblCliente]    Script Date: 29/08/2016 22:52:09 ******/
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
/****** Object:  Table [dbo].[tblContasReceber]    Script Date: 29/08/2016 22:52:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblContasReceber](
	[IDContasReceber] [int] IDENTITY(1,1) NOT NULL,
	[DataPagamento] [date] NULL,
	[ValorTotal] [decimal](8, 2) NULL,
	[DataLancamento] [date] NULL,
	[DataVencimento] [date] NULL,
	[IDContasReceberSituacao] [int] NOT NULL,
	[IDPessoaCliente] [int] NOT NULL,
	[IDPessoaVendedor] [int] NOT NULL,
	[IDUsuario] [int] NULL,
	[IDPedido] [int] NOT NULL,
 CONSTRAINT [PK_TBLCONTASRECEBERIDCONTASRECEBER] PRIMARY KEY CLUSTERED 
(
	[IDContasReceber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblContasReceberSituacao]    Script Date: 29/08/2016 22:52:09 ******/
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
/****** Object:  Table [dbo].[tblEMail]    Script Date: 29/08/2016 22:52:09 ******/
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
/****** Object:  Table [dbo].[tblEndereco]    Script Date: 29/08/2016 22:52:09 ******/
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
 CONSTRAINT [PK_TBLENDERECOIDENDERECO] PRIMARY KEY CLUSTERED 
(
	[IDEndereco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblEstoque]    Script Date: 29/08/2016 22:52:09 ******/
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
/****** Object:  Table [dbo].[tblFornecedor]    Script Date: 29/08/2016 22:52:09 ******/
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
/****** Object:  Table [dbo].[TBLNIVELACESSO]    Script Date: 29/08/2016 22:52:09 ******/
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
/****** Object:  Table [dbo].[TBLNIVELACESSOUSUARIO]    Script Date: 29/08/2016 22:52:09 ******/
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
/****** Object:  Table [dbo].[tblOperacao]    Script Date: 29/08/2016 22:52:09 ******/
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
/****** Object:  Table [dbo].[tblOperacaoSituacao]    Script Date: 29/08/2016 22:52:09 ******/
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
/****** Object:  Table [dbo].[tblPedido]    Script Date: 29/08/2016 22:52:09 ******/
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
	[IDTipoPagamento] [int] NOT NULL,
	[DataPedido] [datetime] NOT NULL,
	[Observacao] [varchar](100) NULL,
	[IDPedidoTipo] [int] NOT NULL,
	[ValorTotal] [decimal](8, 2) NULL,
 CONSTRAINT [PK_TBLPEDIDOIDPEDIDO] PRIMARY KEY CLUSTERED 
(
	[IDPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPedidoItem]    Script Date: 29/08/2016 22:52:09 ******/
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
/****** Object:  Table [dbo].[tblPedidoTipo]    Script Date: 29/08/2016 22:52:09 ******/
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
/****** Object:  Table [dbo].[tblPessoa]    Script Date: 29/08/2016 22:52:09 ******/
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
/****** Object:  Table [dbo].[tblProduto]    Script Date: 29/08/2016 22:52:09 ******/
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
/****** Object:  Table [dbo].[tblSituacao]    Script Date: 29/08/2016 22:52:09 ******/
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
/****** Object:  Table [dbo].[tblTelefone]    Script Date: 29/08/2016 22:52:09 ******/
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
/****** Object:  Table [dbo].[tblTipoPagamento]    Script Date: 29/08/2016 22:52:09 ******/
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
/****** Object:  Table [dbo].[tblUsuario]    Script Date: 29/08/2016 22:52:09 ******/
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
/****** Object:  Table [dbo].[tblVendedor]    Script Date: 29/08/2016 22:52:09 ******/
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
ALTER TABLE [dbo].[tblCliente]  WITH CHECK ADD  CONSTRAINT [FK_TBLCLIENTEIDPESSOA] FOREIGN KEY([IDPessoaCliente])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblCliente] CHECK CONSTRAINT [FK_TBLCLIENTEIDPESSOA]
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
ALTER TABLE [dbo].[tblContasReceber]  WITH CHECK ADD  CONSTRAINT [FK_TBLCONTASRECEBERIDPESSOACLIENTE] FOREIGN KEY([IDPessoaCliente])
REFERENCES [dbo].[tblCliente] ([IDPessoaCliente])
GO
ALTER TABLE [dbo].[tblContasReceber] CHECK CONSTRAINT [FK_TBLCONTASRECEBERIDPESSOACLIENTE]
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
ALTER TABLE [dbo].[tblPedido]  WITH CHECK ADD  CONSTRAINT [FK_TBLPEDIDOIDOPERACAOIDSITUACAO] FOREIGN KEY([IDOperacao], [IDSituacao])
REFERENCES [dbo].[tblOperacaoSituacao] ([IDOperacao], [IDSituacao])
GO
ALTER TABLE [dbo].[tblPedido] CHECK CONSTRAINT [FK_TBLPEDIDOIDOPERACAOIDSITUACAO]
GO
ALTER TABLE [dbo].[tblPedido]  WITH CHECK ADD  CONSTRAINT [FK_TBLPEDIDOIDPESSOACLIENTE] FOREIGN KEY([IDPessoaCliente])
REFERENCES [dbo].[tblCliente] ([IDPessoaCliente])
GO
ALTER TABLE [dbo].[tblPedido] CHECK CONSTRAINT [FK_TBLPEDIDOIDPESSOACLIENTE]
GO
ALTER TABLE [dbo].[tblPedido]  WITH CHECK ADD  CONSTRAINT [FK_TBLPEDIDOIDPESSOAVENDEDOR] FOREIGN KEY([IDPessoaVendedor])
REFERENCES [dbo].[tblVendedor] ([IDPessoaVendedor])
GO
ALTER TABLE [dbo].[tblPedido] CHECK CONSTRAINT [FK_TBLPEDIDOIDPESSOAVENDEDOR]
GO
ALTER TABLE [dbo].[tblPedido]  WITH CHECK ADD  CONSTRAINT [FK_TBLPEDIDOIDTIPOPAGAMENTO] FOREIGN KEY([IDTipoPagamento])
REFERENCES [dbo].[tblTipoPagamento] ([IDTipoPagamento])
GO
ALTER TABLE [dbo].[tblPedido] CHECK CONSTRAINT [FK_TBLPEDIDOIDTIPOPAGAMENTO]
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
/****** Object:  StoredProcedure [dbo].[uspCadastrarCliente]    Script Date: 29/08/2016 22:52:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCadastrarCliente]
@INintAcao INT,
@INintIDPessoaCliente INT OUTPUT,
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

				SELECT @INintIDPessoaCliente;

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
			END
			
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE(),ERROR_LINE()
	END CATCH
END

GO
/****** Object:  StoredProcedure [dbo].[uspCadastrarContasReceber]    Script Date: 29/08/2016 22:52:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCadastrarContasReceber]
@INintAcao INT, 
@INintIDContasReceber INT NULL,
@INdatDataPagamento DATE NULL,
@INdecValorTotal DECIMAL(8,2) NULL,
@INdatDataLancamento DATE NULL,
@INdatDataVencimento DATE NULL,
@INintIDContasReceberSituacao INT NULL,
@INintIDPessoaCliente INT NULL,
@INintIDPessoaVendedor INT NULL,
@INintIDUsuario INT NULL,
@INintPedido INT NULL
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
			DataPagamento
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
			@INdatDataPagamento
		)

		SELECT @@IDENTITY AS Retorno
	END
	ELSE IF(@INintAcao = 2)
	BEGIN
	IF(EXISTS(SELECT IDContasReceber FROM tblContasReceber WITH(NOLOCK) WHERE IDContasReceber = @INintIDContasReceber))	
	BEGIN
		UPDATE
			tblContasReceber
		SET
			ValorTotal = @INdecValorTotal
		WHERE
			IDContasReceber =@INintIDContasReceber
	END
	END
END
GO
/****** Object:  StoredProcedure [dbo].[uspCadastrarEmail]    Script Date: 29/08/2016 22:52:09 ******/
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
/****** Object:  StoredProcedure [dbo].[uspCadastrarEndereco]    Script Date: 29/08/2016 22:52:09 ******/
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
		END
	COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_LINE(),ERROR_MESSAGE()
	END CATCH
END

GO
/****** Object:  StoredProcedure [dbo].[uspCadastrarFornecedor]    Script Date: 29/08/2016 22:52:09 ******/
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
				RAISERROR('Já existe fornecedor com este CPF cadastrado no sistema!',14,1);

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
					RAISERROR('Já existe forncedor com este CPF cadastrado no sistema!',14,1);
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
			END
			
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE(),ERROR_LINE()
	END CATCH
END

GO
/****** Object:  StoredProcedure [dbo].[uspCadastrarOperacao]    Script Date: 29/08/2016 22:52:09 ******/
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
/****** Object:  StoredProcedure [dbo].[uspCadastrarPedido]    Script Date: 29/08/2016 22:52:09 ******/
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
@INintTipoPagamento INT = NULL,
--@INintIDOrcamento INT NULL,
@INdatDataPedido DATE = NULL,
@INvchObservacao VARCHAR(150)= NULL,
@INintIDPedidoTipo INT NULL = NULL
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
		SET @INintTipoPagamento = 1
		SET @INintIDPedidoTipo = 1
			IF(@INintAcao = 0)
			BEGIN
				INSERT INTO tblPedido
				(
					IDPessoaCliente,
					IDPessoaVendedor,
					IDOperacao,
					IDSituacao,
					IDTipoPagamento,
					DataPedido,
					Observacao,
					IDPedidoTipo
				)
				VALUES
				(
					@INintIDPessoaCliente,
					@INintIDPessoaVendedor,
					@INintIDOperacao,
					@INintIDSituacao,
					@INintTipoPagamento,
					@INdatDataPedido,
					@INvchObservacao,
					@INintIDPedidoTipo
				)

				SELECT @@IDENTITY AS Retorno
			END
			ELSE IF(@INintAcao = 1)
			BEGIN
				UPDATE
					tblPedido
				SET
					IDPessoaCliente = @INintIDPessoaCliente,
					IDOperacao = @INintIDOperacao,
					IDSituacao = @INintIDSituacao,
					IDTipoPagamento = @INintTipoPagamento,
					DataPedido = @INdatDataPedido
				WHERE
					IDPedido = @INintIDPedido
			END
			ELSE IF(@INintAcao = 2)
			BEGIN
				DELETE
					tblPedido
				WHERE
					IDPedido = @INintIDPedido
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_LINE(),ERROR_MESSAGE()
	END CATCH
END

GO
/****** Object:  StoredProcedure [dbo].[uspCadastrarPedidoItem]    Script Date: 29/08/2016 22:52:09 ******/
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
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_LINE(),ERROR_MESSAGE()
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspCadastrarPedidoSituacao]    Script Date: 29/08/2016 22:52:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCadastrarPedidoSituacao]
@INintIDSituacaoAtual INT =NULL,
@INintIDSituacaoNova INT = NULL,
@INintIDPedido INT = NULL,
@INintIDPessoaCliente INT = NULL,
@INintIDPessoaVendedor INT = NULL,
@INintIDUsuario INT = NULL,
@INdecValorTotal DECIMAL(8,2) = NULL,
@INintPedido INT = NULL
AS
BEGIN
	BEGIN TRY
	BEGIN TRAN
		DECLARE
		@intIDSituacaoExcluido INT = 1,
		@intIDSituacaoAberto INT = 2,
		@intIDSituacaoFinalizado INT = 3

		DECLARE
		@intIDContasReceber INT = NULL,
		@decValorTotal DECIMAL(8,2) = NULL



		IF(@INintIDSituacaoAtual = @intIDSituacaoAberto AND @INintIDSituacaoNova = @intIDSituacaoExcluido)
		BEGIN
			--EXEC uspCadastrarPedido
			--@INintAcao = 2,
			--@INintIDPedido = @INintIDPedido,
			--@INintIDPessoaCliente = NULL,
			--@INintIDPessoaVendedor = NULL,
			--@INintIDOperacao = NULL,
			--@INintIDSituacao = NULL,
			--@INintTipoPagamento = NULL,
			----@INintIDOrcamento INT NULL,
			--@INdatDataPedido = NULL,
			--@INvchObservacao = NULL,
			--@INintIDPedidoTipo = NULL
			UPDATE
				tblPedido
			SET
				IDSituacao = @intIDSituacaoExcluido
			WHERE
				IDPedido = @INintIDPedido
		END
		ELSE IF(@INintIDSituacaoAtual = @intIDSituacaoAberto AND @INintIDSituacaoNova = @intIDSituacaoFinalizado)
		BEGIN
			UPDATE
				tblPedido
			SET
				IDSituacao = @intIDSituacaoFinalizado
			WHERE
				IDPedido = @INintIDPedido

			EXEC @intIDContasReceber = uspCadastrarContasReceber
			@INintAcao = 1, 
			@INintIDContasReceber = NULL,
			@INdatDataPagamento = NULL,
			@INdecValorTotal = @INdecValorTotal,
			@INdatDataLancamento = GETDATE,
			@INdatDataVencimento = NULL,
			@INintIDContasReceberSituacao = 1,
			@INintIDPessoaCliente = @INintIDPessoaCliente,
			@INintIDPessoaVendedor = @INintIDPessoaVendedor,
			@INintIDUsuario = @INintIDUsuario,
			@INintPedido = @INintPedido
		END
		ELSE IF(@INintIDSituacaoAtual = @intIDSituacaoFinalizado AND @INintIDSituacaoNova = @intIDSituacaoAberto)
		BEGIN
			IF(EXISTS(SELECT IDPedido FROM tblContasReceber WITH(NOLOCK) WHERE IDPedido = @INintPedido AND IDContasReceberSituacao = 2))
				RAISERROR('Pedido não pode ser excluído.\n Existe uma conta a receber para este pedido',14,1);

			SET @intIDContasReceber = (SELECT IDContasReceber FROM tblContasReceber WITH(NOLOCK) WHERE IDPedido = @INintIDPedido)
				
			UPDATE
				tblContasReceber
			SET
				IDContasReceberSituacao = 3
			WHERE
				IDContasReceber = @intIDContasReceber
		END
	COMMIT TRAN 
	END TRY
	BEGIN CATCH
	ROLLBACK TRAN
	SELECT ERROR_MESSAGE()
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspCadastrarPessoa]    Script Date: 29/08/2016 22:52:09 ******/
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
		IF(EXISTS(SELECT IDPessoa FROM tblPessoa WITH(NOLOCK) WHERE CpfCnpj = @INdecCpfCnpj))
		BEGIN
			IF(@INdecCpfCnpj=11)
				RAISERROR('CPF já cadastro no sistema para outro cliente.',12,1);
			ELSE
				RAISERROR('CNPJ já cadastro no sistema para outro fornecedor.',12,1);
		END
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
		IF(EXISTS(SELECT IDPessoa FROM tblPessoa WITH(NOLOCK) WHERE CpfCnpj = @INdecCpfCnpj AND IDPessoa <> @INintIDPessoa))
		BEGIN
			IF(@INdecCpfCnpj=11)
				RAISERROR('CPF já cadastro no sistema para outro cliente.',12,1);
			ELSE
				RAISERROR('CNPJ já cadastro no sistema para outro fornecedor.',12,1);
		END
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
/****** Object:  StoredProcedure [dbo].[uspCadastrarProduto]    Script Date: 29/08/2016 22:52:09 ******/
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
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_LINE(),ERROR_MESSAGE()
	END CATCH
END

GO
/****** Object:  StoredProcedure [dbo].[uspCadastrarSituacao]    Script Date: 29/08/2016 22:52:09 ******/
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
/****** Object:  StoredProcedure [dbo].[uspCadastrarSituacaoOperacao]    Script Date: 29/08/2016 22:52:09 ******/
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
/****** Object:  StoredProcedure [dbo].[uspCadastrarTipoPagamento]    Script Date: 29/08/2016 22:52:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCadastrarTipoPagamento]
@INintAcao INT,
@INintIDTipoPagamento INT NULL,
@INvchDescricao VARCHAR(40) NULL,
@InbitAtivo BIT NULL
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
			END
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_LINE(),ERROR_MESSAGE()
	END CATCH
END

GO
/****** Object:  StoredProcedure [dbo].[uspCadastrarVendedor]    Script Date: 29/08/2016 22:52:09 ******/
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
			END
			
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE(),ERROR_LINE()
	END CATCH
END

GO
/****** Object:  StoredProcedure [dbo].[uspPesquisarCliente]    Script Date: 29/08/2016 22:52:09 ******/
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
/****** Object:  StoredProcedure [dbo].[uspPesquisarEmailPessoa]    Script Date: 29/08/2016 22:52:09 ******/
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
/****** Object:  StoredProcedure [dbo].[uspPesquisarEndereco]    Script Date: 29/08/2016 22:52:09 ******/
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
/****** Object:  StoredProcedure [dbo].[uspPesquisarEnderecoPessoa]    Script Date: 29/08/2016 22:52:09 ******/
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
/****** Object:  StoredProcedure [dbo].[uspPesquisarFornecedor]    Script Date: 29/08/2016 22:52:09 ******/
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
/****** Object:  StoredProcedure [dbo].[uspPesquisarProduto]    Script Date: 29/08/2016 22:52:09 ******/
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
/****** Object:  StoredProcedure [dbo].[uspPesquisarVendedor]    Script Date: 29/08/2016 22:52:09 ******/
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
/****** Object:  StoredProcedure [dbo].[uspUsuarioAcesso]    Script Date: 29/08/2016 22:52:09 ******/
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
