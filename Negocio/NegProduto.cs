using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using SlnEstagio.AcessoDados;
using SlnEstagio.ObjetoTransferencia;

namespace SlnEstagio.Negocio
{
    public class NegProduto
    {
        AcessoDados.AcessoDadosSqlServer AcessoDados = new AcessoDadosSqlServer();
        public string Inserir(Produto Produto)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Inserir);
                AcessoDados.AdicionarParametro("@INintIDProduto", Produto.IDProduto);
                AcessoDados.AdicionarParametro("@INvchDescricao", Produto.Descricao);
                AcessoDados.AdicionarParametro("@INbitAtivo", Produto.Ativo);
                AcessoDados.AdicionarParametro("@INdecAltura", Produto.Altura);
                AcessoDados.AdicionarParametro("@INdecLargura", Produto.Largura);
                AcessoDados.AdicionarParametro("@INdecProfundidade", Produto.Profundidade);
                AcessoDados.AdicionarParametro("@INdecCubagem", Produto.Cubagem);
                AcessoDados.AdicionarParametro("@INdecQuanitadeMinina", Produto.QuantidadeMinina);
                AcessoDados.AdicionarParametro("@INdecQuantidade", Produto.Quantidade);
                AcessoDados.AdicionarParametro("INdecPreco", Produto.Preco);


                return AcessoDados.ExecutarScalar("uspCadastrarProduto", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
        public string Alterar(Produto Produto)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Alterar);
                AcessoDados.AdicionarParametro("@INintIDProduto", Produto.IDProduto);
                AcessoDados.AdicionarParametro("@INvchDescricao", Produto.Descricao);
                AcessoDados.AdicionarParametro("@INbitAtivo", Produto.Ativo);
                AcessoDados.AdicionarParametro("@INdecAltura", Produto.Altura);
                AcessoDados.AdicionarParametro("@INdecLargura", Produto.Largura);
                AcessoDados.AdicionarParametro("@INdecProfundidade", Produto.Profundidade);
                AcessoDados.AdicionarParametro("@INdecCubagem", Produto.Cubagem);
                AcessoDados.AdicionarParametro("@INdecQuanitadeMinina", Produto.QuantidadeMinina);
                AcessoDados.AdicionarParametro("@INdecQuantidade", Produto.Quantidade);
                AcessoDados.AdicionarParametro("INdecPreco", Produto.Preco);

                return AcessoDados.ExecutarScalar("uspCadastrarProduto", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public string Excluir(Produto Produto)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Excluir);
                AcessoDados.AdicionarParametro("@INintIDProduto", Produto.IDProduto);

                return AcessoDados.ExecutarScalar("uspCadastrarProduto", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public ProdutoCollection VMPesquisarProduto(string descricao, int? IDProduto,bool? ativo)
        {
            try
            {
                ProdutoCollection produtoCollection = new ProdutoCollection();
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintIDProduto", IDProduto);
                AcessoDados.AdicionarParametro("@INvchDescricao", descricao);
                AcessoDados.AdicionarParametro("@INbitAtivo", ativo);

                using (DataTable dtbRegistros = AcessoDados.GetDataTable("uspPesquisarProduto", CommandType.StoredProcedure))
                {
                    foreach (DataRow item in dtbRegistros.Rows)
                    {
                        produtoCollection.Add(CarregarItem(item));
                    }
                }

                return produtoCollection;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }

        }

        public DataTable RelProdutoTotal(int? IDProduto, bool? Ativo)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintProduto", IDProduto);
                AcessoDados.AdicionarParametro("@INbitAtivo", Ativo);

                using (DataSet dtbRgistros = AcessoDados.GetDataTables("uspRelProdutoTotal", CommandType.StoredProcedure))
                {
                    return dtbRgistros.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        private Produto CarregarItem(DataRow item)
        {
            Produto produto = new Produto();
            VMDataRow dtRow = new VMDataRow(item);
            produto.IDProduto = dtRow.GetInt("IDProduto");
            produto.Descricao = dtRow.GetStr("Descricao");
            produto.Ativo = dtRow.GetBoo("Ativo");
            produto.Cubagem = dtRow.GetDec("Cubagem");
            produto.Altura = dtRow.GetDec("Altura");
            produto.Profundidade = dtRow.GetDec("Profudidade");
            produto.QuantidadeMinina = dtRow.GetDec("QuanitadeMinima");
            produto.Largura = dtRow.GetDec("Largura");
            produto.Preco = dtRow.GetDec("Preco");

            return produto;
        }
    }
}
