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
   public class NegEndereco
    {
        AcessoDados.AcessoDadosSqlServer AcessoDados = new AcessoDadosSqlServer();

        public string Inserir(Endereco Endereco, int IDPessoa)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INbitAcao", (int)AcaoBD.Inserir);
                AcessoDados.AdicionarParametro("@INintIDEndereco", Endereco.IDEndereco);
                AcessoDados.AdicionarParametro("@INintIDPessoa", IDPessoa);
                AcessoDados.AdicionarParametro("@INvchCidade", Endereco.Cidade);
                AcessoDados.AdicionarParametro("@INvchLogradouro", Endereco.Logradouro);
                AcessoDados.AdicionarParametro("@INintNumero", Endereco.Numero);
                AcessoDados.AdicionarParametro("@INvchComplemento", Endereco.Complemento);
                AcessoDados.AdicionarParametro("@INvchBairro", Endereco.Bairro);
                AcessoDados.AdicionarParametro("@INdecCep", Endereco.Cep);

                return AcessoDados.ExecutarScalar("uspCadastrarEndereco", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
        public string Alterar(Endereco Endereco , int IDPessoa)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INbitAcao", (int)AcaoBD.Alterar);
                AcessoDados.AdicionarParametro("@INintIDEndereco", Endereco.IDEndereco);
                AcessoDados.AdicionarParametro("@INintIDPessoa", IDPessoa);
                AcessoDados.AdicionarParametro("@INvchCidade", Endereco.Cidade);
                AcessoDados.AdicionarParametro("@INvchLogradouro", Endereco.Logradouro);
                AcessoDados.AdicionarParametro("@INintNumero", Endereco.Numero);
                AcessoDados.AdicionarParametro("@INvchComplemento", Endereco.Complemento);
                AcessoDados.AdicionarParametro("@INvchBairro", Endereco.Bairro);
                AcessoDados.AdicionarParametro("@INdecCep", Endereco.Cep);

                return AcessoDados.ExecutarScalar("uspCadastrarEndereco", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
        public string Excluir(Endereco Endereco)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INbitAcao", (int)AcaoBD.Excluir);
                AcessoDados.AdicionarParametro("@INintIDEndereco", Endereco.IDEndereco);

                return AcessoDados.ExecutarScalar("uspCadastrarEndereco", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public EnderecoCollection VMPesquisarEnderecoFornecedor(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }

        public EnderecoCollection PesquisarEnderecoPessoa(int IDPessoa)
        {
            EnderecoCollection enderecoCollection = new EnderecoCollection();
            AcessoDados.LimparParametro();
            AcessoDados.AdicionarParametro("@INintIDPessoa", IDPessoa);

            using (DataTable dtbRegistro = AcessoDados.GetDataTable("uspPesquisarEnderecoPessoa", CommandType.StoredProcedure))
            {
                foreach (DataRow dtrItem in dtbRegistro.Rows)
                {
                    enderecoCollection.Add(CarregarItem(dtrItem));
                }
            }

            return enderecoCollection;
        }

        private Endereco CarregarItem(DataRow dtrItem)
        {
            Endereco endereco = new Endereco();
            VMDataRow dtrRow = new VMDataRow(dtrItem);

            endereco.IDEndereco = dtrRow.GetInt("IDEndereco");
            endereco.Logradouro = dtrRow.GetStr("Logradouro");
            endereco.Numero = dtrRow.GetInt("Numero");
            endereco.Complemento = dtrRow.GetStr("Complemento");
            endereco.Bairro = dtrRow.GetStr("Bairro");
            endereco.Cep = dtrRow.GetDec("Cep");
            endereco.Cidade = dtrRow.GetStr("Cidade");
            endereco.Pessoa = new Pessoa
            {
                IDPessoa = dtrRow.GetInt("IDPessoa")
            };

            return endereco;

        }
    }
}
