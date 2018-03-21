using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SlnEstagio.AcessoDados;
using SlnEstagio.ObjetoTransferencia;
using System.Data;

namespace SlnEstagio.Negocio
{
   public class NegCidade
    {
        AcessoDados.AcessoDadosSqlServer AcessoDados = new AcessoDadosSqlServer();
        public string Inserir(Cidade Cidade)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Inserir);
                AcessoDados.AdicionarParametro("@INintIDCidade", Cidade.IDCidade);
                AcessoDados.AdicionarParametro("@INvchDescricao", Cidade.Descricao);
                AcessoDados.AdicionarParametro("@INintSigla", Cidade.Sigla);


                return AcessoDados.ExecutarScalar("uspCadastrarCidade", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public string Alterar(Cidade Cidade)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Alterar);
                AcessoDados.AdicionarParametro("@INintIDCidade", Cidade.IDCidade);
                AcessoDados.AdicionarParametro("@INvchDescricao", Cidade.Descricao);
                AcessoDados.AdicionarParametro("@INintSigla", Cidade.Sigla);


                return AcessoDados.ExecutarScalar("uspCadastrarCidade", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
        public string Excluir(Cidade Cidade)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Excluir);
                AcessoDados.AdicionarParametro("@INintIDCidade", Cidade.IDCidade);
                AcessoDados.AdicionarParametro("@INvchDescricao", Cidade.Descricao);
                AcessoDados.AdicionarParametro("@INintSigla", Cidade.Sigla);


                return AcessoDados.ExecutarScalar("uspCadastrarCidade", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

    }
}
