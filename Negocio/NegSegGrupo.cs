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
    public class NegSegGrupo
    {
        AcessoDados.AcessoDadosSqlServer AcessoDados = new AcessoDadosSqlServer();
        public string Inserir(SegGrupo SegGrupo)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Inserir);
                AcessoDados.AdicionarParametro("@INintIDGrupo", SegGrupo.IDGrupo);
                AcessoDados.AdicionarParametro("@INvchDescricao", SegGrupo.Descricao);

                return AcessoDados.ExecutarScalar("uspCadastrarSegGrupo", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
        public string Alterar(SegGrupo SegGrupo)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Alterar);
                AcessoDados.AdicionarParametro("@INintIDGrupo", SegGrupo.IDGrupo);
                AcessoDados.AdicionarParametro("@INvchDescricao", SegGrupo.Descricao);

                return AcessoDados.ExecutarScalar("uspCadastrarSegGrupo", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
        public string Excluir(SegGrupo SegGrupo)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Excluir);
                AcessoDados.AdicionarParametro("@INintIDGrupo", SegGrupo.IDGrupo);
                AcessoDados.AdicionarParametro("@INvchDescricao", SegGrupo.Descricao);

                return AcessoDados.ExecutarScalar("uspCadastrarSegGrupo", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

    }
}
