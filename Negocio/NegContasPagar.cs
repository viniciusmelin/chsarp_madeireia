using SlnEstagio.AcessoDados;
using SlnEstagio.ObjetoTransferencia;
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
    public class NegContasPagar
    {
        AcessoDados.AcessoDadosSqlServer AcessoDados = new AcessoDados.AcessoDadosSqlServer();

        public string Inserir(ContasPagar contasPagar)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Inserir);
                AcessoDados.AdicionarParametro("@INintIDContasPagar", contasPagar.IDContasPagar);
                AcessoDados.AdicionarParametro("@INintIDPessoaFornecedor", contasPagar.Fornecedor.Pessoa.IDPessoa);
                AcessoDados.AdicionarParametro("@INdatDataPagamento", contasPagar.DataPagamento);
                AcessoDados.AdicionarParametro("@INdatDataLancamento", contasPagar.DataLancamento);
                AcessoDados.AdicionarParametro("@INdatDataVencimento", contasPagar.DataVencimento);
                AcessoDados.AdicionarParametro("@INdecValor", contasPagar.Valor);
                AcessoDados.AdicionarParametro("@INvchObservacao", contasPagar.Observacao);
                AcessoDados.AdicionarParametro("@INintIDSituacao", contasPagar.OperacaoSituacao.Situacao.IDSituacao);
                AcessoDados.AdicionarParametro("@INintIDOperacao", contasPagar.OperacaoSituacao.Operacao.IDOperacao);
                AcessoDados.AdicionarParametro("@INintIDContasPagarTipo", contasPagar.ContasPagarTipo.IDContasPagarTipo);
                return AcessoDados.ExecutarScalar("uspCadastrarContasPagar", System.Data.CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public string Alterar(ContasPagar contasPagar)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Alterar);
                AcessoDados.AdicionarParametro("@INintIDContasPagar", contasPagar.IDContasPagar);
                AcessoDados.AdicionarParametro("@INintIDPessoaFornecedor", contasPagar.Fornecedor.Pessoa.IDPessoa);
               // AcessoDados.AdicionarParametro(IN"@datDataPagamento", contasPagar.DataPagamento);
                AcessoDados.AdicionarParametro("@INdatDataVencimento", contasPagar.DataVencimento);
                AcessoDados.AdicionarParametro("@INdecValor", contasPagar.Valor);
                AcessoDados.AdicionarParametro("@INvchObservacao", contasPagar.Observacao);
                AcessoDados.AdicionarParametro("@INintIDSituacao", contasPagar.OperacaoSituacao.Situacao.IDSituacao);
                AcessoDados.AdicionarParametro("@INintIDOperacao", contasPagar.OperacaoSituacao.Operacao.IDOperacao);
                AcessoDados.AdicionarParametro("@INintIDContasPagarTipo", contasPagar.ContasPagarTipo.IDContasPagarTipo);
                return AcessoDados.ExecutarScalar("uspCadastrarContasPagar", System.Data.CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public string Excluir(int IDContasPagar)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Excluir);
                AcessoDados.AdicionarParametro("@INintIDContasPagar", IDContasPagar);
                return AcessoDados.ExecutarScalar("uspCadastrarContasPagar", System.Data.CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public string EfetuarBaixa(int idContasPagar, int situcaoAntiga, int situacaoNova)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintIDContasPagar", idContasPagar);
                AcessoDados.AdicionarParametro("@INintIDSituacaoAntiga", situcaoAntiga);
                AcessoDados.AdicionarParametro("@INintIDSituacaoNova", situacaoNova);
                return AcessoDados.ExecutarScalar("uspContasPagarSituacao", CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public ContasPagarCollection Pesquisar(int? IDContasPagar, int? IDPessoaFornecedor, DateTime? DataInicial, DateTime? DataFinal,string IDSitucaoVarios)
        {
            ContasPagarCollection contasPagarCollection = new ContasPagarCollection();
            AcessoDados.LimparParametro();
            AcessoDados.AdicionarParametro("@intIDContasPagar", IDContasPagar);
            AcessoDados.AdicionarParametro("@intPessoaFornecedor", IDPessoaFornecedor);
            AcessoDados.AdicionarParametro("@datDataInicial", DataInicial);
            AcessoDados.AdicionarParametro("@datDataFinal", DataFinal);
            AcessoDados.AdicionarParametro("@vchIDSituacaoVarios", IDSitucaoVarios);

            using (DataTable dtRegistros = AcessoDados.GetDataTable("uspPesquisarContasPagar", CommandType.StoredProcedure))
            {
                foreach (DataRow dtritem in dtRegistros.Rows)
                    contasPagarCollection.Add(CarregarItem(dtritem));
            }

            return contasPagarCollection;

        }

        private ContasPagar CarregarItem(DataRow dtritem)
        {
            VMDataRow dtRow = new VMDataRow(dtritem);
            ContasPagar novoitem = new ContasPagar();
            novoitem.IDContasPagar = dtRow.GetInt("IDContasPagar");
            novoitem.DataLancamento = dtRow.GetDat("DataLancamento");
            novoitem.DataPagamento = dtRow.GetDat("DataPagamento");
            novoitem.DataVencimento = dtRow.GetDat("DataVencimento");
            novoitem.Observacao = dtRow.GetStr("Observacao");
            novoitem.Valor = dtRow.GetDec("Valor");
            novoitem.ContasPagarTipo = new ContasPagarTipo
            {
                IDContasPagarTipo = dtRow.GetInt("IDContasPagarTipo"),
                Descricao = dtRow.GetStr("DescTipo")
            };
            novoitem.OperacaoSituacao = new OperacaoSituacao
            {
                Operacao = new Operacao
                {
                    IDOperacao = dtRow.GetInt("IDOperacao"),
                    Descricao = dtRow.GetStr("DescOperacao")
                },
                Situacao = new Situacao
                {
                    IDSituacao = dtRow.GetInt("IDSituacao"),
                    Descricao = dtRow.GetStr("DescSituacao")
                }
            };
            novoitem.Fornecedor = new Fornecedor
            {
                Pessoa = new Pessoa
                {
                    IDPessoa = dtRow.GetInt("IDPessoa"),
                    Nome = dtRow.GetStr("Nome")
                }
            };

            return novoitem;
        }


        public void CarregarComboBoxOperacao(CheckedListBox ckblistBox)
        {
            try
            {
                OperacaoSituacaoCollection operacaoSituacaoCollection = new OperacaoSituacaoCollection();
                AcessoDados.LimparParametro();
                using (DataTable dtbRegistro = AcessoDados.GetDataTable("uspPesquisarContasPagarSituacao", CommandType.StoredProcedure))
                {
                    foreach (DataRow item in dtbRegistro.Rows)
                        operacaoSituacaoCollection.Add(carregarItemOperacaoSituacao(item));
                }

                ckblistBox.DisplayMember = "key";
                ckblistBox.ValueMember = "value";
                foreach (OperacaoSituacao item in operacaoSituacaoCollection)
                    ckblistBox.Items.Add(new DictionaryEntry(item.Situacao.Descricao, item.Situacao.IDSituacao), true);

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel carregar.\nMotivo: " + ex.Message);
            }

        }
        private OperacaoSituacao carregarItemOperacaoSituacao(DataRow item)
        {
            OperacaoSituacao operacaoSituacao = new OperacaoSituacao();
            VMDataRow dtRow = new VMDataRow(item);

            operacaoSituacao.Situacao = new Situacao
            {
                IDSituacao = dtRow.GetInt("IDSituacao"),
                Descricao = dtRow.GetStr("Descricao")
            };

            return operacaoSituacao;
        }

        public DataTable RelContasPagarVarios(int? IDPessoa, string IDSituacaoVarias)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintIDPessoaFornecedor", IDPessoa);
                AcessoDados.AdicionarParametro("@INvchIDVariasSituacao", IDSituacaoVarias);

                using (DataSet dtbRgistros = AcessoDados.GetDataTables("uspRelContasPagarVarias", CommandType.StoredProcedure))
                {
                    return dtbRgistros.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
    }
}
