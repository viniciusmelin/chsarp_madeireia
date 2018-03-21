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
    public class NegSegControle
    {
        AcessoDados.AcessoDadosSqlServer AcessoDados = new AcessoDadosSqlServer();
        public string Inserir(SegControle SegControle)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Inserir);
                AcessoDados.AdicionarParametro("@INintIDBotao", SegControle.IDBotao);
                AcessoDados.AdicionarParametro("@INvchDescricao", SegControle.Descricao);
                AcessoDados.AdicionarParametro("@INintIDForm", SegControle.SegForm.IDForm);

                return AcessoDados.ExecutarScalar("uspCadastrarSegControle", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
        public string Alterar(SegControle SegControle)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Alterar);
                AcessoDados.AdicionarParametro("@INintIDBotao", SegControle.IDBotao);
                AcessoDados.AdicionarParametro("@INvchDescricao", SegControle.Descricao);
                AcessoDados.AdicionarParametro("@INintIDForm", SegControle.SegForm.IDForm);

                return AcessoDados.ExecutarScalar("uspCadastrarSegControle", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
        public string Excluir(SegControle SegControle)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Excluir);
                AcessoDados.AdicionarParametro("@INintIDBotao", SegControle.IDBotao);
                AcessoDados.AdicionarParametro("@INvchDescricao", SegControle.Descricao);
                AcessoDados.AdicionarParametro("@INintIDForm", SegControle.SegForm.IDForm);

                return AcessoDados.ExecutarScalar("uspCadastrarSegControle", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
    }
}
