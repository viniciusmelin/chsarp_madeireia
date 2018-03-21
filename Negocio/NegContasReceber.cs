using SlnEstagio.AcessoDados;
using SlnEstagio.ObjetoTransferencia;
using SlnEstagio.WINBASE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlnEstagio.Negocio
{
    public class NegContasReceber
    {
        AcessoDados.AcessoDadosSqlServer acessoDados = new AcessoDados.AcessoDadosSqlServer();

        public string Inserir(ContasaReceber contasReceber)
        {
            try
            {
                acessoDados.LimparParametro();
                acessoDados.AdicionarParametro("@INintAcao", (int)Acao.INSERIR);
                acessoDados.AdicionarParametro("@INdecValorTotal", contasReceber.ValorTotal);
                acessoDados.AdicionarParametro("@INdatDataLancamento", contasReceber.DataLancamento);
                acessoDados.AdicionarParametro("@INdatDataVencimento", contasReceber.DataLancamento);
                acessoDados.AdicionarParametro("@INintIDContasReceberSituacao", contasReceber.ContasReceberSituacao.IDContasReceberSituacao);
                acessoDados.AdicionarParametro("@INintIDPessoaCliente", contasReceber.Cliente.Pessoa.IDPessoa);
                acessoDados.AdicionarParametro("@INintIDPessoaVendedor", contasReceber.Vendedor.Pessoa.IDPessoa);
                //acessoDados.AdicionarParametro("@INintIDUsuario", (int?)null);
                //acessoDados.AdicionarParametro("@INintPedido", (int?)null);
                //acessoDados.AdicionarParametro("@INintTipoPagamento", (int?)null);
                acessoDados.AdicionarParametro("@INintContasReceberOrigem", contasReceber.ContasReceberOrigem.IDContasReceberOrigem);

                return acessoDados.ExecutarScalar("uspCadastrarContasReceber", CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public string Alterar(ContasaReceber contasReceber)
        {
            try
            {
                acessoDados.LimparParametro();
                acessoDados.AdicionarParametro("@INintAcao", (int)Acao.ALTERAR);
                acessoDados.AdicionarParametro("@INintIDContasReceber", contasReceber.IDContasaReceber);
                acessoDados.AdicionarParametro("@INdecValorTotal", contasReceber.ValorTotal);
                acessoDados.AdicionarParametro("@INdatDataLancamento", contasReceber.DataLancamento);
                acessoDados.AdicionarParametro("@INdatDataVencimento", contasReceber.DataLancamento);
                acessoDados.AdicionarParametro("@INintIDContasReceberSituacao", contasReceber.ContasReceberSituacao.IDContasReceberSituacao);
                acessoDados.AdicionarParametro("@INintIDPessoaCliente", contasReceber.Cliente.Pessoa.IDPessoa);
                acessoDados.AdicionarParametro("@INintIDPessoaVendedor", contasReceber.Vendedor.Pessoa.IDPessoa);
                acessoDados.AdicionarParametro("@INintIDUsuario", (int?)null);
                acessoDados.AdicionarParametro("@INintPedido", (int?)null);
                acessoDados.AdicionarParametro("@INintTipoPagamento", (int?)null);

                return acessoDados.ExecutarScalar("uspCadastrarContasReceber", CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public DataTable RelContasReceberVarias(int? IDPessoa, string IDSituacaoVarias)
        {
            try
            {
                acessoDados.LimparParametro();
                acessoDados.AdicionarParametro("@INintIDPessoaCliente", IDPessoa);
                acessoDados.AdicionarParametro("@INvchIDSituacaoVarias", IDSituacaoVarias);

                using (DataSet dtbRgistros = acessoDados.GetDataTables("uspRelContasReceberVarias", CommandType.StoredProcedure))
                {
                    return dtbRgistros.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public string Excluir(ContasaReceber contasReceber)
        {
            try
            {
                acessoDados.LimparParametro();
                acessoDados.AdicionarParametro("@INintAcao", (int)Acao.EXCLUIR);
                acessoDados.AdicionarParametro("@INintIDContasReceber", contasReceber.IDContasaReceber);

                return acessoDados.ExecutarScalar("uspCadastrarContasReceber", CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public ContasReceberCollection Pesquisar(DateTime? dataInicial, DateTime? dataFinal, int? IDCliente, int? IDVendedor, string VariosIDSituacao, int? IDContasReceber, int? IDPedido)
        {
            try
            {
                ContasReceberCollection contasReceberCollection = new ContasReceberCollection();
                acessoDados.LimparParametro();
                acessoDados.AdicionarParametro("@INintIDContasReceber", IDContasReceber);
                acessoDados.AdicionarParametro("@INintIDPedido", IDPedido);
                acessoDados.AdicionarParametro("@INdatDataInicial", dataInicial);
                acessoDados.AdicionarParametro("@INdatDataFinal", dataFinal);
                acessoDados.AdicionarParametro("@INintIDCliente", IDCliente);
                acessoDados.AdicionarParametro("@INintIDVendedor", IDVendedor);
                acessoDados.AdicionarParametro("@INvchVariosIDSituacao", VariosIDSituacao);

                using (DataTable dtbRegistro = acessoDados.GetDataTable("uspPesquisarContasReceber", CommandType.StoredProcedure))
                {
                    foreach (DataRow Item in dtbRegistro.Rows)
                        contasReceberCollection.Add(carregarItem(Item));
                }

                return contasReceberCollection;
            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public string EfetuarBaixa(ContasaReceber contasaReceber, int? IDUsuario)
        {
            try
            {
                acessoDados.LimparParametro();
                acessoDados.AdicionarParametro("@INintIDContasReceber", contasaReceber.IDContasaReceber);
                acessoDados.AdicionarParametro("@INintValorPgar", contasaReceber.ValorPagar);
                acessoDados.AdicionarParametro("@INintIDUsuario", IDUsuario);

                return acessoDados.ExecutarScalar("uspFinContasReceberBaixar", CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        private ContasaReceber carregarItem(DataRow item)
        {
            ContasaReceber contasReceber = new ContasaReceber();
            VMDataRow dtRow = new VMDataRow(item);

            contasReceber.IDContasaReceber = dtRow.GetInt("IDContasReceber");
            contasReceber.DataLancamento = dtRow.GetDat("DataLancamento");
            contasReceber.DataVencimento = dtRow.GetDat("DataVencimento");
            contasReceber.DataPagamento = dtRow.GetDatNull("DataPagamento");
            contasReceber.ValorTotal = dtRow.GetDec("ValorTotal");
            contasReceber.ContasReceberSituacao = new ContasReceberSitucao
            {
                IDContasReceberSituacao = dtRow.GetInt("IDSituacao"),
                Descricao = dtRow.GetStr("DescSituacao")
            };
            contasReceber.Cliente = new Cliente
            {
                Pessoa = new Pessoa
                {
                    IDPessoa = dtRow.GetInt("IDCliente"),
                    Nome = dtRow.GetStr("NomeCliente")
                }
            };
            contasReceber.Vendedor = new Vendedor
            {
                Pessoa = new Pessoa
                {
                    IDPessoa = dtRow.GetInt("IDVendedor"),
                    Nome = dtRow.GetStr("NomeVendedor")
                }
            };

            contasReceber.TipoPagamento = new TipoPagamento
            {
                IDTipoPagamento = dtRow.GetInt("IDTipoPagamento"),
                Descricao = dtRow.GetStr("Descricao")
            };

            contasReceber.ContasReceberOrigem = new ContasReceberOrigem
            {
                IDContasReceberOrigem = dtRow.GetInt("IDContasReceberOrigem"),
                Descricao = dtRow.GetStr("DescOrigem")
            };

            return contasReceber;
        }

        public void CarregarComboBox(CheckedListBox ckblistBox)
        {
            try
            {
                ContasReceberSituacaoCollection contasReceberSituacaoCollection = new ContasReceberSituacaoCollection();
                acessoDados.LimparParametro();

                using (DataTable dtbRegistro = acessoDados.GetDataTable("uspPesquisarContasReceberSituacao", CommandType.StoredProcedure))
                {
                    foreach (DataRow item in dtbRegistro.Rows)
                        contasReceberSituacaoCollection.Add(carregarItemSituacao(item));
                }

                ckblistBox.DisplayMember = "key";
                ckblistBox.ValueMember = "value";
                foreach (ContasReceberSitucao item in contasReceberSituacaoCollection)
                    ckblistBox.Items.Add(new DictionaryEntry(item.Descricao, item.IDContasReceberSituacao), true);

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel carregar.\nMotivo: " + ex.Message);
            }

        }
        private ContasReceberSitucao carregarItemSituacao(DataRow item)
        {
            ContasReceberSitucao contasReceberSitucao = new ContasReceberSitucao();
            VMDataRow dtRow = new VMDataRow(item);

            contasReceberSitucao.IDContasReceberSituacao = dtRow.GetInt("IDSituacao");
            contasReceberSitucao.Descricao = dtRow.GetStr("Descricao");

            return contasReceberSitucao;
        }

        public string AlterarSituacao(int IDContasReceber, int IDSituacaoAtual, int IDSituacaoNova, int? IDUsuario)
        {
            try
            {
                acessoDados.LimparParametro();
                acessoDados.AdicionarParametro("@INintIDContasReceber", IDContasReceber);
                acessoDados.AdicionarParametro("@INintIDSituacaoAtual", IDSituacaoAtual);
                acessoDados.AdicionarParametro("@INintIDSituacaoNova", IDSituacaoNova);
                acessoDados.AdicionarParametro("@INintIDUsuario", IDUsuario);

                return acessoDados.ExecutarScalar("uspContasReceberSituacao", CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
    }
}
