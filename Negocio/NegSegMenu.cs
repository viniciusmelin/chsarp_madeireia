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
    class NegSegMenu
    {
        AcessoDados.AcessoDadosSqlServer AcessoDados = new AcessoDadosSqlServer();
        public string Inserir(SegMenu Menu)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Inserir);
                AcessoDados.AdicionarParametro("@INintIDMenu", Menu.IDMenu);
                AcessoDados.AdicionarParametro("@INintIDModulo", Menu.Modulo.IDModulo);
                AcessoDados.AdicionarParametro("@INvchDescricao", Menu.Descricao);



                return AcessoDados.ExecutarScalar("uspCadastrarSegMenu", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
        public string Alterar(SegMenu Menu)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Alterar);
                AcessoDados.AdicionarParametro("@INintIDMenu", Menu.IDMenu);
                AcessoDados.AdicionarParametro("@INintIDModulo", Menu.Modulo.IDModulo);
                AcessoDados.AdicionarParametro("@INvchDescricao", Menu.Descricao);



                return AcessoDados.ExecutarScalar("uspCadastrarSegMenu", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
        public string Excluir(SegMenu Menu)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Excluir);
                AcessoDados.AdicionarParametro("@INintIDMenu", Menu.IDMenu);
                AcessoDados.AdicionarParametro("@INintIDModulo", Menu.Modulo.IDModulo);
                AcessoDados.AdicionarParametro("@INvchDescricao", Menu.Descricao);



                return AcessoDados.ExecutarScalar("uspCadastrarSegMenu", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

    }
}
