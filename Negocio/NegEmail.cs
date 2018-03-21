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
    public class NegEmail
    {
        AcessoDados.AcessoDadosSqlServer AcessoDados = new AcessoDados.AcessoDadosSqlServer();

        public string Inserir(Email Email)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Inserir);
                AcessoDados.AdicionarParametro("@INintEmail", Email.IDEmail);
                AcessoDados.AdicionarParametro("@INintIDPessoa", Email.Pessoa.IDPessoa);
                AcessoDados.AdicionarParametro("@INvchDescricao", Email.Descricao);
                AcessoDados.AdicionarParametro("@INbitPrincipal", Email.Principal);

               return AcessoDados.ExecutarScalar("uspCadastrarEmail", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public string Alterar(Email Email)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Alterar);
                AcessoDados.AdicionarParametro("@INintEmail", Email.IDEmail);
                AcessoDados.AdicionarParametro("@INintIDPessoa", Email.Pessoa.IDPessoa);
                AcessoDados.AdicionarParametro("@INvchDescricao", Email.Descricao);
                AcessoDados.AdicionarParametro("@INbitPrincipal", Email.Principal);

                return AcessoDados.ExecutarScalar("uspCadastrarEmail", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public string Excluir(Email Email)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Excluir);
                AcessoDados.AdicionarParametro("@INintEmail", Email.IDEmail);

                return AcessoDados.ExecutarScalar("uspCadastrarEmail", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
        public EmailCollection PesquisarEmailPessoa(int IDPessoa)
        {
            EmailCollection emailCollection = new EmailCollection();
            AcessoDados.LimparParametro();
            AcessoDados.AdicionarParametro("@INIDPessoa", IDPessoa);

            using (DataTable dtbRegistro = AcessoDados.GetDataTable("uspPesquisarEmailPessoa", CommandType.StoredProcedure))
            {
                foreach (DataRow dtrItem in dtbRegistro.Rows)
                    emailCollection.Add(CarregarItem(dtrItem));
            }

            return emailCollection;
        }

        private Email CarregarItem(DataRow dtrItem)
        {
            Email email = new Email();
            VMDataRow dtRow = new VMDataRow(dtrItem);
            email.IDEmail = dtRow.GetInt("IDEmail");
            email.Descricao = dtRow.GetStr("Descricao");
            email.Principal = dtRow.GetBoo("Principal");
            email.Pessoa = new Pessoa
            {
                IDPessoa = dtRow.GetInt("IDPessoa")
            };

            return email;

        }

        //public EmailCollection VMPesquisarEmailCliente(Cliente cliente)
        //{
        //    AcessoDados.LimparParametro();
        //    AcessoDados.AdicionarParametro("",cliente.Pessoa.IDPessoa)
        //}
    }
}
