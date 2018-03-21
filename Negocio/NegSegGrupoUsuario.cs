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
    public class NegSegGrupoUsuario
    {
        AcessoDados.AcessoDadosSqlServer AcessoDados = new AcessoDadosSqlServer();
        public string Inserir(SegGrupoUsuario SegGrupoUsuario)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Inserir);
                AcessoDados.AdicionarParametro("@INintIDUsuario", SegGrupoUsuario.Usuario.IDUsuario);
                AcessoDados.AdicionarParametro("@INintIDGrupo", SegGrupoUsuario.SegGrupo.IDGrupo);

                return AcessoDados.ExecutarScalar("uspCadastrarSegGrupoUsuario", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
        public string Alterar(SegGrupoUsuario SegGrupoUsuario)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Alterar);
                AcessoDados.AdicionarParametro("@INintIDUsuario", SegGrupoUsuario.Usuario.IDUsuario);
                AcessoDados.AdicionarParametro("@INintIDGrupo", SegGrupoUsuario.SegGrupo.IDGrupo);

                return AcessoDados.ExecutarScalar("uspCadastrarSegGrupoUsuario", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
        public string Excluir(SegGrupoUsuario SegGrupoUsuario)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Excluir);
                AcessoDados.AdicionarParametro("@INintIDUsuario", SegGrupoUsuario.Usuario.IDUsuario);
                AcessoDados.AdicionarParametro("@INintIDGrupo", SegGrupoUsuario.SegGrupo.IDGrupo);

                return AcessoDados.ExecutarScalar("uspCadastrarSegGrupoUsuario", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
    }
}
