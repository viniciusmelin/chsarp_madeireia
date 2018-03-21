using SlnEstagio.AcessoDados;
using SlnEstagio.ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.Negocio
{
    public class NegEstoqueMovimentacao
    {
        AcessoDados.AcessoDadosSqlServer AcessoDados = new AcessoDadosSqlServer();

        public string Inserir(int IDProduto, decimal Quantidade, string Operacao)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Inserir);
                //AcessoDados.AdicionarParametro("@INdatData", null);
                AcessoDados.AdicionarParametro("@INintIDProduto", IDProduto);
                AcessoDados.AdicionarParametro("@INdecQuantidade", Quantidade);
                AcessoDados.AdicionarParametro("@INvchOperacao", Operacao);

                return AcessoDados.ExecutarScalar("uspCadastrarEstoqueMovimentacao", CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public EstoqueMovimentacaoCollection Consultar(int? IDProduto, DateTime? dataInicial, DateTime? dataFinal, string DescProduto)
        {
            try
            {
                EstoqueMovimentacaoCollection colecao = new EstoqueMovimentacaoCollection();
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INvchDescricaoProduto", DescProduto);
                AcessoDados.AdicionarParametro("@INintIDProduto", IDProduto);
                AcessoDados.AdicionarParametro("@INdataInicial", dataInicial);
                AcessoDados.AdicionarParametro("@INdataFinal", dataFinal);

                using (DataTable dtbRegistro = AcessoDados.GetDataTable("uspPesquisarEstoqueMovimentacao", CommandType.StoredProcedure))
                {
                    foreach (DataRow item in dtbRegistro.Rows)
                    {
                        colecao.Add(CarregarItem(item));
                    }
                }

                return colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public string ConverteEstoque(int IDProdutoOriginal, int IDProdutoDestino, decimal QuantidadeOriginal, decimal QuantidadeDestino)
        {
            try
            {
                AcessoDados.LimparParametro();
               
                AcessoDados.AdicionarParametro("@INintProdutoOriginal", IDProdutoOriginal);
                AcessoDados.AdicionarParametro("@INintProdutoDestino", IDProdutoDestino);
                AcessoDados.AdicionarParametro("@INdecQuantidadeOriginal", QuantidadeOriginal);
                AcessoDados.AdicionarParametro("@INdecQuantidadeDestino", QuantidadeDestino);

                return AcessoDados.ExecutarScalar("uspEstoqueConverterProduto", CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        private EstoqueMovimentacao CarregarItem(DataRow item)
        {
            EstoqueMovimentacao estoque = new EstoqueMovimentacao();
            VMDataRow dtRow = new VMDataRow(item);

            estoque.IDMovimentacao = dtRow.GetInt("IDMovimentacao");
            estoque.Data = dtRow.GetDat("Data");
            estoque.Quantidade = dtRow.GetDec("Quantidade");
            estoque.Operacao = dtRow.GetStr("Operacao");
            estoque.Produto = new Produto
            {
                IDProduto = dtRow.GetInt("IDProduto"),
                Descricao = dtRow.GetStr("Descricao"),
                Quantidade = dtRow.GetDec("Estoque")
            };

            return estoque;
        }
    }
}
