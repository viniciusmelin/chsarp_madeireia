using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using SlnEstagio.ObjetoTransferencia;
using SlnEstagio.AcessoDados;

namespace SlnEstagio.Negocio
{
    public class NegOperacao
    {
        AcessoDados.AcessoDadosSqlServer AcessoDados = new AcessoDadosSqlServer();
        public string Inserir(Operacao Operacao)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Inserir);
                AcessoDados.AdicionarParametro("@INintIDOperacao", Operacao.IDOperacao);
                AcessoDados.AdicionarParametro("@INvchDescricao", Operacao.Descricao);


                return AcessoDados.ExecutarScalar("uspCadastrarOpercao", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
        public string Alterar(Operacao Operacao)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Alterar);
                AcessoDados.AdicionarParametro("@INintIDOperacao", Operacao.IDOperacao);
                AcessoDados.AdicionarParametro("@INvchDescricao", Operacao.Descricao);


                return AcessoDados.ExecutarScalar("uspCadastrarOpercao", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public string Excluir(Operacao Operacao)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Excluir);
                AcessoDados.AdicionarParametro("@INintIDOperacao", Operacao.IDOperacao);
                AcessoDados.AdicionarParametro("@INvchDescricao", Operacao.Descricao);


                return AcessoDados.ExecutarScalar("uspCadastrarOpercao", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
    }
}
