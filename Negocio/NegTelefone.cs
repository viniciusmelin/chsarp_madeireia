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
    public class NegTelefone
    {
        AcessoDados.AcessoDadosSqlServer AcessoDados = new AcessoDadosSqlServer();
        public string Inserir(Telefone Telefone)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Inserir);
                AcessoDados.AdicionarParametro("@INintIDTelefone", Telefone.IDTelefone);
                AcessoDados.AdicionarParametro("@INintNumero", Telefone.Numero);
                AcessoDados.AdicionarParametro("@INbitPrincipal", Telefone.Principal);
                AcessoDados.AdicionarParametro("@INintIDPessoa", Telefone.Pessoa.IDPessoa);
                AcessoDados.AdicionarParametro("@INvchTipoTelefone", Telefone.TipoTelefone);

                return AcessoDados.ExecutarScalar("uspCadastrarTelefone", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
        public string Alterar(Telefone Telefone)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Alterar);
                AcessoDados.AdicionarParametro("@INintIDTelefone", Telefone.IDTelefone);
                AcessoDados.AdicionarParametro("@INintNumero", Telefone.Numero);
                AcessoDados.AdicionarParametro("@INbitPrincipal", Telefone.Principal);
                AcessoDados.AdicionarParametro("@INintIDPessoa", Telefone.Pessoa.IDPessoa);
                AcessoDados.AdicionarParametro("@INvchTipoTelefone", Telefone.TipoTelefone);

                return AcessoDados.ExecutarScalar("uspCadastrarTelefone", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
        public string Excluir(Telefone Telefone)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Excluir);
                AcessoDados.AdicionarParametro("@INintIDTelefone", Telefone.IDTelefone);
                AcessoDados.AdicionarParametro("@INintNumero", Telefone.Numero);
                AcessoDados.AdicionarParametro("@INbitPrincipal", Telefone.Principal);
                AcessoDados.AdicionarParametro("@INintIDPessoa", Telefone.Pessoa.IDPessoa);
                AcessoDados.AdicionarParametro("@INvchTipoTelefone", Telefone.TipoTelefone);

                return AcessoDados.ExecutarScalar("uspCadastrarTelefone", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public TelefoneCollection ConsultarTelefonePessoa(int IDPessoa)
        {
            throw new NotImplementedException();
        }
    }
}
