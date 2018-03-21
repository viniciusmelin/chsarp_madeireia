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
    public class NegFornecedor
    {
        AcessoDados.AcessoDadosSqlServer AcessoDados = new AcessoDadosSqlServer();

        public string Inserir(Fornecedor fornecedor)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Inserir);
                AcessoDados.AdicionarParametro("@INintIDPessoa", fornecedor.Pessoa.IDPessoa);
                AcessoDados.AdicionarParametro("@INvchNome", fornecedor.Pessoa.Nome);
                AcessoDados.AdicionarParametro("@INdecCpfCnpj", fornecedor.Pessoa.CpfCnpj);
                AcessoDados.AdicionarParametro("@INbitAtivo", fornecedor.Pessoa.Ativo);
                AcessoDados.AdicionarParametro("@INInscEstadual", fornecedor.IE);
                AcessoDados.AdicionarParametro("@INdatDataCadastro", fornecedor.DataCadastro);


                return AcessoDados.ExecutarScalar("uspCadastrarFornecedor", CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Falha ao executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public string Alterar(Fornecedor fornecedor)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Alterar);
                AcessoDados.AdicionarParametro("@INintIDPessoa", fornecedor.Pessoa.IDPessoa);
                AcessoDados.AdicionarParametro("@INvchNome", fornecedor.Pessoa.Nome);
                AcessoDados.AdicionarParametro("@INdecCpfCnpj", fornecedor.Pessoa.CpfCnpj);
                AcessoDados.AdicionarParametro("@INbitAtivo", fornecedor.Pessoa.Ativo);
                AcessoDados.AdicionarParametro("@INInscEstadual", fornecedor.IE);
                AcessoDados.AdicionarParametro("@INdatDataCadastro", fornecedor.DataCadastro);


                return AcessoDados.ExecutarScalar("uspCadastrarFornecedor", CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Falha ao executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public string Excluir(Fornecedor fornecedor)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Excluir);
                AcessoDados.AdicionarParametro("@INintIDPessoa", fornecedor.Pessoa.IDPessoa);
                AcessoDados.AdicionarParametro("@INvchNome", fornecedor.Pessoa.Nome);
                AcessoDados.AdicionarParametro("@INdecCpfCnpj", fornecedor.Pessoa.CpfCnpj);
                AcessoDados.AdicionarParametro("@INbitAtivo", fornecedor.Pessoa.Ativo);
                AcessoDados.AdicionarParametro("@INInscEstadual", fornecedor.IE);
                AcessoDados.AdicionarParametro("@INdatDataCadastro", fornecedor.DataCadastro);


                return AcessoDados.ExecutarScalar("uspCadastrarFornecedor", CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Falha ao executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public FornecedorCollection VMPesquisarFornecedorID(int retorno, bool? ativo)
        {
            throw new NotImplementedException();
        }

        public FornecedorCollection VMPesquisarFornecedorID(string descricao, bool? ativo)
        {
            try
            {
                FornecedorCollection fornecedorCollection = new FornecedorCollection();
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INvchNome", descricao);
                AcessoDados.AdicionarParametro("@INbitAtivo", ativo);

                using (DataTable dtbRegistro = AcessoDados.GetDataTable("uspPesquisarFornecedor", CommandType.StoredProcedure))
                {
                    foreach (DataRow dtRow in dtbRegistro.Rows)
                    {
                        fornecedorCollection.Add(carregarItem(dtRow));
                    }
                }
                return fornecedorCollection;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        private Fornecedor carregarItem(DataRow dtRow)
        {
            VMDataRow dtrRow = new VMDataRow(dtRow);
            Fornecedor forncedor = new Fornecedor();

            forncedor.Pessoa = new Pessoa
            {
                IDPessoa = dtrRow.GetInt("IDPessoa"),
                Nome = dtrRow.GetStr("Nome"),
                Ativo = dtrRow.GetBoo("Ativo"),
                CpfCnpj = dtrRow.GetDec("CpfCnpj")
            };
            forncedor.DataCadastro = dtrRow.GetDat("DataCadastro");
            forncedor.IE = dtrRow.GetStr("IE");

            return forncedor;

        }

        public DataTable RelFornecedor(int? IDPessoa, bool? Ativo)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintIDPessoaFornecedor", IDPessoa);
                AcessoDados.AdicionarParametro("@INbitAtivo", Ativo);

                using (DataSet dtbRgistros = AcessoDados.GetDataTables("uspRelFornecedor", CommandType.StoredProcedure))
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
