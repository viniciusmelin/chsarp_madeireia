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
    public class NegPedidoItem
    {
        AcessoDados.AcessoDadosSqlServer AcessoDados = new AcessoDadosSqlServer();
        public string Inserir(PedidoItem PedidoItem)
        {
            try
            {

                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Inserir);
                AcessoDados.AdicionarParametro("@INintIDPedido", PedidoItem.Pedido.IDPedido);
                AcessoDados.AdicionarParametro("@INintIDProduto", PedidoItem.Produto.IDProduto);
                AcessoDados.AdicionarParametro("@INdecQuantidade", PedidoItem.Quantidade);
                AcessoDados.AdicionarParametro("@INdecPreco", PedidoItem.Produto.Preco);


                return AcessoDados.ExecutarScalar("uspCadastrarPedidoItem", CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public string Inserir(PedidoItemCollection pedidoItemCollection, int IDPedido)
        {
            try
            {
                foreach (PedidoItem PedidoItem in pedidoItemCollection)
                {
                    AcessoDados.LimparParametro();
                    AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Inserir);
                    AcessoDados.AdicionarParametro("@INintIDPedido", IDPedido);
                    AcessoDados.AdicionarParametro("@INintIDProduto", PedidoItem.Produto.IDProduto);
                    AcessoDados.AdicionarParametro("@INdecQuantidade", PedidoItem.Quantidade);
                    AcessoDados.AdicionarParametro("@INdecPreco", PedidoItem.Produto.Preco);
                    AcessoDados.ExecutarScalar("uspCadastrarPedidoItem", CommandType.StoredProcedure);
                }



                return "1";
            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public string Alterar(PedidoItemCollection PedidoItemCollection,int IDPedido)
        {
            try
            {
                foreach (PedidoItem PedidoItem in PedidoItemCollection)
                {
                    AcessoDados.LimparParametro();
                    AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Alterar);
                    AcessoDados.AdicionarParametro("@INintIDPedido",IDPedido);
                    AcessoDados.AdicionarParametro("@INintIDProduto", PedidoItem.Produto.IDProduto);
                    AcessoDados.AdicionarParametro("@INdecQuantidade", PedidoItem.Quantidade);
                    AcessoDados.ExecutarScalar("uspCadastrarPedidoItem", CommandType.StoredProcedure);
                }

                return "1";
            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
        public string Excluir(int IDPedido, int IDProduto)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Excluir);
                AcessoDados.AdicionarParametro("@INintIDPedido", IDPedido);
                AcessoDados.AdicionarParametro("@INintIDProduto",IDProduto);

                return AcessoDados.ExecutarScalar("uspCadastrarPedidoItem", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public PedidoItemCollection PesquisarItemPedido(int IDPedido)
        {
            PedidoItemCollection pedidoItemCollection = new PedidoItemCollection();
            AcessoDados.LimparParametro();
            AcessoDados.AdicionarParametro("@INintIDPedido", IDPedido);


            using (DataTable dtbRegistro = AcessoDados.GetDataTable("uspPesquisarItemPedido", CommandType.StoredProcedure))
            {
                foreach (DataRow item in dtbRegistro.Rows)
                {
                    pedidoItemCollection.Add(CarregarItem(item));
                }
            }

            return pedidoItemCollection;
        }

        private PedidoItem CarregarItem(DataRow item)
        {
            VMDataRow dtRow = new VMDataRow(item);
            PedidoItem pedidoItem = new PedidoItem();

            pedidoItem.Produto = new Produto
            {
                IDProduto = dtRow.GetInt("IDProduto"),
                Descricao = dtRow.GetStr("Descricao"),
                Ativo = dtRow.GetBoo("Ativo"),
                Cubagem = dtRow.GetDec("Cubagem"),
                Altura = dtRow.GetDec("Altura"),
                Profundidade = dtRow.GetDec("Profudidade"),
                QuantidadeMinina = dtRow.GetDec("QuanitadeMinima"),
                Largura = dtRow.GetDec("Largura"),
                Preco = dtRow.GetDec("Preco")
            };

            pedidoItem.Quantidade = dtRow.GetDec("Quantidade");

            return pedidoItem;
        }
    }
}
