using SlnEstagio.AcessoDados;
using SlnEstagio.ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.Negocio
{
   public class NegContasPagarTipo
    {
        AcessoDados.AcessoDadosSqlServer AcessoDados = new AcessoDadosSqlServer();
        public string Inserir(ContasPagarTipo contasPagarTipo)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Inserir);
                AcessoDados.AdicionarParametro("@INIDContasPagarTipo", contasPagarTipo.IDContasPagarTipo);
                AcessoDados.AdicionarParametro("@INvchDescricao", contasPagarTipo.Descricao);
                AcessoDados.AdicionarParametro("@INbitAtivo", contasPagarTipo.Ativo);
                return AcessoDados.ExecutarScalar("uspCadastrarContasPagarTipo", System.Data.CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public string Alterar(ContasPagarTipo contasPagarTipo)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Alterar);
                AcessoDados.AdicionarParametro("@INIDContasPagarTipo", contasPagarTipo.IDContasPagarTipo);
                AcessoDados.AdicionarParametro("@INvchDescricao", contasPagarTipo.Descricao);
                AcessoDados.AdicionarParametro("@INbitAtivo", contasPagarTipo.Ativo);
                return AcessoDados.ExecutarScalar("uspCadastrarContasPagarTipo", System.Data.CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public string Excluir(ContasPagarTipo contasPagarTipo)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Excluir);
                AcessoDados.AdicionarParametro("@INIDContasPagarTipo", contasPagarTipo.IDContasPagarTipo);
                return AcessoDados.ExecutarScalar("uspCadastrarContasPagarTipo", System.Data.CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ContasPagarTipoCollection Pesquisar(string texto, bool? ativo)
        {
            ContasPagarTipoCollection colecao = new ContasPagarTipoCollection();
            AcessoDados.LimparParametro();
            AcessoDados.AdicionarParametro("@INvchDescricao", texto);
            AcessoDados.AdicionarParametro("@INbitAtivo", ativo);
            using (DataTable dtbRegistros = AcessoDados.GetDataTable("uspPesquisarContasPagarTipo", CommandType.StoredProcedure))
            {
                foreach (DataRow dtrItem in dtbRegistros.Rows)
                    colecao.Add(CarregarItem(dtrItem));
            }

            return colecao;
        }

        private ContasPagarTipo CarregarItem(DataRow dtrItem)
        {
            ContasPagarTipo novo = new ContasPagarTipo();
            VMDataRow dtDataRow = new VMDataRow(dtrItem);

            novo.IDContasPagarTipo = dtDataRow.GetInt("IDContasPagarTipo");
            novo.Descricao = dtDataRow.GetStr("Descricao");
            novo.Ativo = dtDataRow.GetBoo("Ativo");

            return novo;
        }
    }
}
