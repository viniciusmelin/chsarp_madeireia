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
    public class NegSegFormControleAcesso
    {
        AcessoDados.AcessoDadosSqlServer AcessoDados = new AcessoDadosSqlServer();
        public string Inserir(SegFormControleAcesso SegFormControleAcesso)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Inserir);
                AcessoDados.AdicionarParametro("@INintIDModulo", SegFormControleAcesso.Modulo.IDModulo);
                AcessoDados.AdicionarParametro("@INintIDForm", SegFormControleAcesso.SegForm.IDForm);
                AcessoDados.AdicionarParametro("@INintIDBotao", SegFormControleAcesso.SegControle.IDBotao);
                AcessoDados.AdicionarParametro("@INintIDGrupo", SegFormControleAcesso.SegGrupo.IDGrupo);
                AcessoDados.AdicionarParametro("@INbitAtivo", SegFormControleAcesso.Ativo);


                return AcessoDados.ExecutarScalar("uspCadastrarSegFormControleAcesso", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
        public string Alterar(SegFormControleAcesso SegFormControleAcesso)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Alterar);
                AcessoDados.AdicionarParametro("@INintIDModulo", SegFormControleAcesso.Modulo.IDModulo);
                AcessoDados.AdicionarParametro("@INintIDForm", SegFormControleAcesso.SegForm.IDForm);
                AcessoDados.AdicionarParametro("@INintIDBotao", SegFormControleAcesso.SegControle.IDBotao);
                AcessoDados.AdicionarParametro("@INintIDGrupo", SegFormControleAcesso.SegGrupo.IDGrupo);
                AcessoDados.AdicionarParametro("@INbitAtivo", SegFormControleAcesso.Ativo);


                return AcessoDados.ExecutarScalar("uspCadastrarSegFormControleAcesso", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
        public string Excluir(SegFormControleAcesso SegFormControleAcesso)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Excluir);
                AcessoDados.AdicionarParametro("@INintIDModulo", SegFormControleAcesso.Modulo.IDModulo);
                AcessoDados.AdicionarParametro("@INintIDForm", SegFormControleAcesso.SegForm.IDForm);
                AcessoDados.AdicionarParametro("@INintIDBotao", SegFormControleAcesso.SegControle.IDBotao);
                AcessoDados.AdicionarParametro("@INintIDGrupo", SegFormControleAcesso.SegGrupo.IDGrupo);
                AcessoDados.AdicionarParametro("@INbitAtivo", SegFormControleAcesso.Ativo);


                return AcessoDados.ExecutarScalar("uspCadastrarSegFormControleAcesso", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
    }
}
