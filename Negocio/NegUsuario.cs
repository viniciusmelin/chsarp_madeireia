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
   public class NegUsuario
    {
        AcessoDados.AcessoDadosSqlServer AcessoDados = new AcessoDadosSqlServer();
        public string Inserir(Usuario Usuario)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Inserir);
                AcessoDados.AdicionarParametro("@INintIDPessoa", Usuario.Pessoa.IDPessoa);
                AcessoDados.AdicionarParametro("@INvchUsuario", Usuario.Login);
                AcessoDados.AdicionarParametro("@INvchSenha", Usuario.Senha);
                AcessoDados.AdicionarParametro("@INintIDUsuario", Usuario.IDUsuario);


                return AcessoDados.ExecutarScalar("uspCadastrarUsuario", CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Falha ao executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public string Alterar(Usuario Usuario)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Alterar);
                AcessoDados.AdicionarParametro("@INintIDPessoa", Usuario.Pessoa.IDPessoa);
                AcessoDados.AdicionarParametro("@INvchUsuario", Usuario.Login);
                AcessoDados.AdicionarParametro("@INvchSenha", Usuario.Senha);
                AcessoDados.AdicionarParametro("@INintIDUsuario", Usuario.IDUsuario);


                return AcessoDados.ExecutarScalar("uspCadastrarUsuario", CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Falha ao executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public string Excluir(Usuario Usuario)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Excluir);
                AcessoDados.AdicionarParametro("@INintIDPessoa", Usuario.Pessoa.IDPessoa);
                AcessoDados.AdicionarParametro("@INvchUsuario", Usuario.Login);
                AcessoDados.AdicionarParametro("@INvchSenha", Usuario.Senha);
                AcessoDados.AdicionarParametro("@INintIDUsuario", Usuario.IDUsuario);


                return AcessoDados.ExecutarScalar("uspCadastrarUsuario", CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Falha ao executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public bool UsuarioAcesso(string usuario , string senha)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INvchUsuario", usuario);
                AcessoDados.AdicionarParametro("@INvchSenha", senha);

                return Convert.ToBoolean(AcessoDados.ExecutarScalar("uspUsuarioAcesso", CommandType.StoredProcedure));
            }
            catch (Exception ex)
            {

                throw new Exception("Falha ao executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
    }
}
