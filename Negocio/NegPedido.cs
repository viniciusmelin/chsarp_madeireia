using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SlnEstagio.ObjetoTransferencia;
using SlnEstagio.AcessoDados;

namespace SlnEstagio.Negocio
{
    public class NegPedido
    {
        AcessoDados.AcessoDadosSqlServer AcessoDados = new AcessoDadosSqlServer();
        NegPedidoItem negPedidoItem = new NegPedidoItem();
        public string Inserir(Pedido Pedido)
        {
            try
            {
                
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Inserir);
                AcessoDados.AdicionarParametro("@INintIDPessoaCliente", Pedido.Cliente.Pessoa.IDPessoa);
                AcessoDados.AdicionarParametro("@INintIDPessoaVendedor", Pedido.Vendedor.Pessoa.IDPessoa);
                AcessoDados.AdicionarParametro("@INintIDOperacao", Pedido.OpercaoSituacao.Operacao.IDOperacao);
                AcessoDados.AdicionarParametro("@INintIDSituacao", Pedido.OpercaoSituacao.Situacao.IDSituacao);
                AcessoDados.AdicionarParametro("@INdatDataPedido", Pedido.DataPedido);
                //AcessoDados.AdicionarParametro("@INintTipoPagamento", Pedido.TipoPagamento.IDTipoPagamento);
                AcessoDados.AdicionarParametro("@INintIDPedidoTipo", Pedido.TipoPedido.IDTipoPedido);
                AcessoDados.AdicionarParametro("@INdecValorTotal", Pedido.ValorTotal);

                return AcessoDados.ExecutarScalar("uspCadastrarPedido", CommandType.StoredProcedure).ToString();
                

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
        public string Alterar(Pedido Pedido)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Alterar);
                AcessoDados.AdicionarParametro("@INintIDPedido", Pedido.IDPedido);
                AcessoDados.AdicionarParametro("@INintIDPessoaCliente", Pedido.Cliente.Pessoa.IDPessoa);
                AcessoDados.AdicionarParametro("@INintIDPessoaVendedor", Pedido.Vendedor.Pessoa.IDPessoa);
                AcessoDados.AdicionarParametro("@INintIDOperacao", Pedido.OpercaoSituacao.Operacao.IDOperacao);
                AcessoDados.AdicionarParametro("@INintIDSituacao", Pedido.OpercaoSituacao.Situacao.IDSituacao);
                AcessoDados.AdicionarParametro("@INdatDataPedido", Pedido.DataPedido);
                //AcessoDados.AdicionarParametro("@INintTipoPagamento", Pedido.TipoPagamento.IDTipoPagamento);
                AcessoDados.AdicionarParametro("@INintIDPedidoTipo", Pedido.TipoPedido.IDTipoPedido);
                AcessoDados.AdicionarParametro("@INdecValorTotal", Pedido.ValorTotal);

                return AcessoDados.ExecutarScalar("uspCadastrarPedido", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
        public string Excluir(Pedido Pedido)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Excluir);
                AcessoDados.AdicionarParametro("@INintIDPedido", Pedido.IDPedido);

                return AcessoDados.ExecutarScalar("uspCadastrarPedido", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public Pedido ConsultarPedidoporID(int IDPedido)
        {
            return ConsultarPedido(IDPedido, null, null, null, null, null, string.Empty).FirstOrDefault();
        }

        public PedidoCollection ConsultarPedido(int? IDPedido, DateTime? dataInicial, DateTime? DataFinal, int? IDCliente, int? IDVendedor, int? IDOperacao, string VariosIDSituacao)
        {
            PedidoCollection pedidoCollection = new PedidoCollection();
            AcessoDados.LimparParametro();
            AcessoDados.AdicionarParametro("@INintIDOperacao",IDOperacao);
            AcessoDados.AdicionarParametro("@INintIDPedido",IDPedido);
            AcessoDados.AdicionarParametro("@INintIDCliente",IDCliente);
            AcessoDados.AdicionarParametro("@INintIDVendedor",IDVendedor);
            AcessoDados.AdicionarParametro("@INdatDataInicial",dataInicial);
            AcessoDados.AdicionarParametro("@INdatDataFinal",DataFinal);
            AcessoDados.AdicionarParametro("@INvchIDsSituacao",VariosIDSituacao);

            using (DataTable dtbRegistros = AcessoDados.GetDataTable("uspPesquisarPedido", CommandType.StoredProcedure))
            {
                foreach (DataRow dtrItem in dtbRegistros.Rows)
                {
                    pedidoCollection.Add(CarregarItem(dtrItem));
                }
            }
            return pedidoCollection;
        }

        public string AlterarSituacao(int IDPedido, int IDSituacaolAtual, int IDSituacaoNova, int IDOperacao, int? IDUsuario)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintIDSituacaoAtual", IDSituacaolAtual);
                AcessoDados.AdicionarParametro("@INintIDSituacaoNova", IDSituacaoNova);
                AcessoDados.AdicionarParametro("@INintIDPedido", IDPedido);
                AcessoDados.AdicionarParametro("@INintIDUsuario", IDUsuario);
                AcessoDados.AdicionarParametro("@INintIDOperacao", IDOperacao);

                return AcessoDados.ExecutarScalar("uspCadastrarPedidoSituacao", CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        private Pedido CarregarItem(DataRow dtrItem)
        {
            VMDataRow dtRow = new VMDataRow(dtrItem);
            Pedido pedido = new Pedido();
            pedido.IDPedido = dtRow.GetInt("IDPedido");
            pedido.DataPedido = dtRow.GetDat("DataPedido");
            pedido.ValorTotal = dtRow.GetDec("ValorTotal");
            pedido.Observacao = dtRow.GetStr("Observacao");
            pedido.Cliente = new Cliente
            {
                Pessoa = new Pessoa
                {
                    IDPessoa = dtRow.GetInt("IDPessoaCliente"),
                    Nome = dtRow.GetStr("NomeCliente")
                }

            };
            pedido.Vendedor = new Vendedor
            {
                Pessoa = new Pessoa
                {
                    IDPessoa = dtRow.GetInt("IDPessoaVendedor"),
                    Nome = dtRow.GetStr("NomeVendedor")

                }
            };
            pedido.OpercaoSituacao = new OperacaoSituacao
            {
                Operacao = new Operacao
                {
                    IDOperacao = dtRow.GetInt("IDOperacao"),
                    Descricao = dtRow.GetStr("DescricaoOperacao")
                },
                Situacao = new Situacao
                {
                    IDSituacao = dtRow.GetInt("IDSituacao"),
                    Descricao = dtRow.GetStr("DescricaoSituacao")
                }
            };
            pedido.TipoPedido = new TipoPedido
            {
                IDTipoPedido = dtRow.GetInt("IDPedidoTipo"),
                Descricao = dtRow.GetStr("DescricaoPedidoTipo")
            };

            //pedido.TipoPagamento = new TipoPagamento
            //{
            //    IDTipoPagamento = dtRow.GetInt("IDTipoPagamento"),
            //    Descricao = dtRow.GetStr("Descricao")
            //};

            return pedido;
        }

        public DataSet RelVendasImprimir(int IDPedido)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintIDPedido", IDPedido);

                using (DataSet dtbRegistros = AcessoDados.GetDataTables("uspRelVenPedido", CommandType.StoredProcedure))
                    return dtbRegistros;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }
}
