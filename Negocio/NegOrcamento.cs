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
    public class NegOrcamento
    {
        AcessoDados.AcessoDadosSqlServer AcessoDados = new AcessoDadosSqlServer();
        public string Inserir(Orcamento Orcamento)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Inserir);
                AcessoDados.AdicionarParametro("@INintIDOrcamento", Orcamento.IDOrcamento);
                AcessoDados.AdicionarParametro("@INintIDTipoPagamento", Orcamento.TipoPagamento.IDTipoPagamento);
                AcessoDados.AdicionarParametro("@INintIDOperacao", Orcamento.OperacaoSituacao.Operacao.IDOperacao);
                AcessoDados.AdicionarParametro("@INintIDSituacao", Orcamento.OperacaoSituacao.Situacao.IDSituacao);
                AcessoDados.AdicionarParametro("@INvchObservacao", Orcamento.Observacao);


                return AcessoDados.ExecutarScalar("uspCadastrarOrcamento", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
        public string Alterar(Orcamento Orcamento)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Alterar);
                AcessoDados.AdicionarParametro("@INintIDOrcamento", Orcamento.IDOrcamento);
                AcessoDados.AdicionarParametro("@INintIDTipoPagamento", Orcamento.TipoPagamento.IDTipoPagamento);
                AcessoDados.AdicionarParametro("@INintIDOperacao", Orcamento.OperacaoSituacao.Operacao.IDOperacao);
                AcessoDados.AdicionarParametro("@INintIDSituacao", Orcamento.OperacaoSituacao.Situacao.IDSituacao);
                AcessoDados.AdicionarParametro("@INvchObservacao", Orcamento.Observacao);


                return AcessoDados.ExecutarScalar("uspCadastrarOrcamento", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
        public string Excluir(Orcamento Orcamento)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Excluir);
                AcessoDados.AdicionarParametro("@INintIDOrcamento", Orcamento.IDOrcamento);
                AcessoDados.AdicionarParametro("@INintIDTipoPagamento", Orcamento.TipoPagamento.IDTipoPagamento);
                AcessoDados.AdicionarParametro("@INintIDOperacao", Orcamento.OperacaoSituacao.Operacao.IDOperacao);
                AcessoDados.AdicionarParametro("@INintIDSituacao", Orcamento.OperacaoSituacao.Situacao.IDSituacao);
                AcessoDados.AdicionarParametro("@INvchObservacao", Orcamento.Observacao);


                return AcessoDados.ExecutarScalar("uspCadastrarOrcamento", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
    }
}
