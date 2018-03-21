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
    public class NegOrcamentoItem
    {
        AcessoDados.AcessoDadosSqlServer AcessoDados = new AcessoDadosSqlServer();
        public string Inserir(OrcamentoItem OrcamentoItem)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Inserir);
                AcessoDados.AdicionarParametro("@INintIDOrcamento", OrcamentoItem.Orcamento.IDOrcamento);
                AcessoDados.AdicionarParametro("@INintIDProduto", OrcamentoItem.Produto.IDProduto);
                AcessoDados.AdicionarParametro("@INdecQuantidade", OrcamentoItem.Quantidade);



                return AcessoDados.ExecutarScalar("uspCadastrarOrcamentoItem", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
        public string Alterar(OrcamentoItem OrcamentoItem)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Alterar);
                AcessoDados.AdicionarParametro("@INintIDOrcamento", OrcamentoItem.Orcamento.IDOrcamento);
                AcessoDados.AdicionarParametro("@INintIDProduto", OrcamentoItem.Produto.IDProduto);
                AcessoDados.AdicionarParametro("@INdecQuantidade", OrcamentoItem.Quantidade);



                return AcessoDados.ExecutarScalar("uspCadastrarOrcamentoItem", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
        public string Excluir(OrcamentoItem OrcamentoItem)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Excluir);
                AcessoDados.AdicionarParametro("@INintIDOrcamento", OrcamentoItem.Orcamento.IDOrcamento);
                AcessoDados.AdicionarParametro("@INintIDProduto", OrcamentoItem.Produto.IDProduto);
                AcessoDados.AdicionarParametro("@INdecQuantidade", OrcamentoItem.Quantidade);



                return AcessoDados.ExecutarScalar("uspCadastrarOrcamentoItem", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
    }
}
