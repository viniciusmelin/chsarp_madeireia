using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SlnEstagio.AcessoDados;
using SlnEstagio.ObjetoTransferencia;
using System.Data;
using System.Collections;
using System.Windows.Forms;
using SlnEstagio.WINBASE;

namespace SlnEstagio.Negocio
{
    public class NegCliente
    {
        AcessoDados.AcessoDadosSqlServer AcessoDados = new AcessoDadosSqlServer();
        
        public string Inserir(Cliente cliente)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Inserir);
                AcessoDados.AdicionarParametro("@INintIDPessoaCliente", cliente.Pessoa.IDPessoa);
                AcessoDados.AdicionarParametro("@INvchNome", cliente.Pessoa.Nome);
                AcessoDados.AdicionarParametro("@INdecCpfCnpj", cliente.Pessoa.CpfCnpj);
                AcessoDados.AdicionarParametro("@INbitAtivo", cliente.Pessoa.Ativo);
                AcessoDados.AdicionarParametro("@INdecLimiteMinimo", cliente.LimiteMinino);
                AcessoDados.AdicionarParametro("@INdecLimiteMaximo", cliente.LimiteMaximo);
                AcessoDados.AdicionarParametro("@INdatDataNascimento", cliente.DataNascimento);
                AcessoDados.AdicionarParametro("@INdatDataCadastro", cliente.DataCadastro);


                return AcessoDados.ExecutarScalar("uspCadastrarCliente", CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Falha ao executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public string Alterar(Cliente cliente)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Alterar);
                AcessoDados.AdicionarParametro("@INintIDPessoaCliente", cliente.Pessoa.IDPessoa);
                AcessoDados.AdicionarParametro("@INvchNome", cliente.Pessoa.Nome);
                AcessoDados.AdicionarParametro("@INdecCpfCnpj", cliente.Pessoa.CpfCnpj);
                AcessoDados.AdicionarParametro("@INbitAtivo", cliente.Pessoa.Ativo);
                AcessoDados.AdicionarParametro("@INdecLimiteMinimo", cliente.LimiteMinino);
                AcessoDados.AdicionarParametro("@INdecLimiteMaximo", cliente.LimiteMaximo);
                //AcessoDados.AdicionarParametro("@INbitAtivo", cliente.Pessoa.Ativo);
                AcessoDados.AdicionarParametro("@INdatDataNascimento", cliente.DataNascimento);
                AcessoDados.AdicionarParametro("@INdatDataCadastro", cliente.DataCadastro);


                return AcessoDados.ExecutarScalar("uspCadastrarCliente", CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Falha ao executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public string Excluir(Cliente cliente)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Excluir);
                AcessoDados.AdicionarParametro("@INintIDPessoaCliente", cliente.Pessoa.IDPessoa);


                return AcessoDados.ExecutarScalar("uspCadastrarCliente", CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Falha ao executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public ClienteCollection PesquisarCliente( string VMPesquisa, bool? ativo)
        {
            ClienteCollection clienteCollection = new ClienteCollection();
            AcessoDados.LimparParametro();
            AcessoDados.AdicionarParametro("@INvchNome", VMPesquisa);
            AcessoDados.AdicionarParametro("@INbitAtivo", ativo);

            using (DataTable dtbRegistro = AcessoDados.GetDataTable("uspPesquisarCliente", CommandType.StoredProcedure))
            {
                foreach (DataRow dtrItem in dtbRegistro.Rows)
                    clienteCollection.Add(CarregarItem(dtrItem));
            }

            return clienteCollection;
        }

        private Cliente CarregarItem(DataRow dtrItem)
        {
            Cliente cliente = new Cliente();
            VMDataRow dtRow = new VMDataRow(dtrItem);
            cliente.LimiteMaximo = dtRow.GetDec("LimiteMaximo");
            cliente.DataCadastro = dtRow.GetDat("DataCadastro");
            cliente.LimiteMinino = dtRow.GetDec("LimiteMinimo");
            cliente.DataNascimento = dtRow.GetDat("DataNascimento");
            cliente.Pessoa = new Pessoa
            {
                IDPessoa = dtRow.GetInt("IDPessoa"),
                Nome = dtRow.GetStr("Nome"),
                CpfCnpj = dtRow.GetDec("CpfCnpj"),
                Ativo = dtRow.GetBoo("Ativo")
            };

            return cliente;
        }

        public ClienteCollection VMPesquisarClienteEndereco(Cliente cliente)
        {
            throw new NotImplementedException();
        }
        public void carregarComboBoxCliente(VMComboBox combobox, string texto)
        {
            List<DictionaryEntry> lista = new List<DictionaryEntry>();
            lista.Add(new DictionaryEntry { Key = "TODOS", Value = null });
            lista.Add(new DictionaryEntry { Key = "SIM", Value = 1 });
            lista.Add(new DictionaryEntry { Key = "NÃO", Value = 0 });

            combobox.ValueMember = "Value";
            combobox.DisplayMember = "key";
            combobox.DataSource = lista;


        }
        public DataTable RelCliente(int? IDPessoa, bool? Ativo)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintIDPessoaCliente", IDPessoa);
                AcessoDados.AdicionarParametro("@INbitAtivo", Ativo);

                using (DataSet dtbRgistros = AcessoDados.GetDataTables("uspRelCliente", CommandType.StoredProcedure))
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
