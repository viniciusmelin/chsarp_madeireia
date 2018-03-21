using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using SlnEstagio.AcessoDados;
using SlnEstagio.ObjetoTransferencia;
using System.Windows.Forms;

namespace SlnEstagio.Negocio
{
    public class NegTipoPagamento
    {
        AcessoDados.AcessoDadosSqlServer AcessoDados = new AcessoDadosSqlServer();
        public string Inserir(TipoPagamento TipoPagamento)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Inserir);
                AcessoDados.AdicionarParametro("@INintIDTipoPagamento", TipoPagamento.IDTipoPagamento);
                AcessoDados.AdicionarParametro("@INvchDescricao", TipoPagamento.Descricao);
                AcessoDados.AdicionarParametro("@InbitAtivo", TipoPagamento.Ativo);


                return AcessoDados.ExecutarScalar("uspCadastrarTipoPagamento", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
        public string Alterar(TipoPagamento TipoPagamento)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Alterar);
                AcessoDados.AdicionarParametro("@INintIDTipoPagamento", TipoPagamento.IDTipoPagamento);
                AcessoDados.AdicionarParametro("@INvchDescricao", TipoPagamento.Descricao);
                AcessoDados.AdicionarParametro("@InbitAtivo", TipoPagamento.Ativo);


                return AcessoDados.ExecutarScalar("uspCadastrarTipoPagamento", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
        public string Excluir(TipoPagamento TipoPagamento)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Excluir);
                AcessoDados.AdicionarParametro("@INintIDTipoPagamento", TipoPagamento.IDTipoPagamento);
                //AcessoDados.AdicionarParametro("@INvchDescricao", TipoPagamento.Descricao);
                //AcessoDados.AdicionarParametro("@InbitAtivo", TipoPagamento.Ativo);


                return AcessoDados.ExecutarScalar("uspCadastrarTipoPagamento", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public void CarregarComboListTipoPagamento(ComboBox cbx)
        {
            Dictionary<string, int?> lista = new Dictionary<string, int?>();
            TipoPagamentoCollection TipoPagamento = new TipoPagamentoCollection();
            TipoPagamento = PesquisarTipoPagamento((int?)null,null,(bool?)null);
            foreach (TipoPagamento item in TipoPagamento)
            {
                lista.Add(item.Descricao, item.IDTipoPagamento);
            }
            cbx.ValueMember = "Value";
            cbx.DisplayMember = "key";
            cbx.DataSource = new BindingSource(lista, null);
            cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx.SelectedIndex = 0;

        }

        public TipoPagamentoCollection PesquisarTipoPagamento(int? IDTipoPagamento, string Descricao, bool? ativo)
        {
            TipoPagamentoCollection TipoPagamentoCollection = new TipoPagamentoCollection();
            AcessoDados.LimparParametro();
            AcessoDados.AdicionarParametro("@INintIDTipoPagamento",IDTipoPagamento);
            AcessoDados.AdicionarParametro("@INvchDescricao",Descricao);
            AcessoDados.AdicionarParametro("@INbitAtivo", ativo);
            using (DataTable dtbRegistro = AcessoDados.GetDataTable("uspPesquisarTipoPagamento", CommandType.StoredProcedure))
            {
                foreach (DataRow item in dtbRegistro.Rows)
                {
                    TipoPagamentoCollection.Add(CarregarItem(item));
                }
            }
            return TipoPagamentoCollection;
        }

        private TipoPagamento CarregarItem(DataRow item)
        {
            VMDataRow dtRow = new VMDataRow(item);
            TipoPagamento TipoPagamento = new TipoPagamento();
            TipoPagamento.IDTipoPagamento = dtRow.GetInt("IDTipoPagamento");
            TipoPagamento.Descricao = dtRow.GetStr("Descricao");
            TipoPagamento.Ativo = dtRow.GetBoo("Ativo");

            return TipoPagamento;
        }
    }
}
