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
    public class NegSegForm
    {
        AcessoDados.AcessoDadosSqlServer AcessoDados = new AcessoDadosSqlServer();
        public string Inserir(SegForm SegForm)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Inserir);
                AcessoDados.AdicionarParametro("@INintIDForm", SegForm.IDForm);
                AcessoDados.AdicionarParametro("@INintIDMenu", SegForm.SegMenu.IDMenu);
                AcessoDados.AdicionarParametro("@INintIDModulo", SegForm.Modulo.IDModulo);
                AcessoDados.AdicionarParametro("@INvchDescricao", SegForm.Descricao);

                return AcessoDados.ExecutarScalar("uspCadastrarSegForm", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
        public string Alterar(SegForm SegForm)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Alterar);
                AcessoDados.AdicionarParametro("@INintIDForm", SegForm.IDForm);
                AcessoDados.AdicionarParametro("@INintIDMenu", SegForm.SegMenu.IDMenu);
                AcessoDados.AdicionarParametro("@INintIDModulo", SegForm.Modulo.IDModulo);
                AcessoDados.AdicionarParametro("@INvchDescricao", SegForm.Descricao);

                return AcessoDados.ExecutarScalar("uspCadastrarSegForm", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
        public string Excluir(SegForm SegForm)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Excluir);
                AcessoDados.AdicionarParametro("@INintIDForm", SegForm.IDForm);
                AcessoDados.AdicionarParametro("@INintIDMenu", SegForm.SegMenu.IDMenu);
                AcessoDados.AdicionarParametro("@INintIDModulo", SegForm.Modulo.IDModulo);
                AcessoDados.AdicionarParametro("@INvchDescricao", SegForm.Descricao);

                return AcessoDados.ExecutarScalar("uspCadastrarSegForm", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
    }
}
