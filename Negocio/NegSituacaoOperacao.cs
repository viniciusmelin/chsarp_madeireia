using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using SlnEstagio.AcessoDados;
using SlnEstagio.ObjetoTransferencia;
using System.Windows.Forms;
using System.Collections;

namespace SlnEstagio.Negocio
{
   public class NegSituacaoOperacao
    {
        AcessoDados.AcessoDadosSqlServer AcessoDados = new AcessoDadosSqlServer();
        public string Inserir(OperacaoSituacao OperacaoSituacao)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Inserir);
                AcessoDados.AdicionarParametro("@INintIDOperacao", OperacaoSituacao.Operacao.IDOperacao);
                AcessoDados.AdicionarParametro("@INintIDSituacao", OperacaoSituacao.Situacao.IDSituacao);


                return AcessoDados.ExecutarScalar("uspCadastrarSituacaoOperacao", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public string Alterar(OperacaoSituacao OperacaoSituacao)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Alterar);
                AcessoDados.AdicionarParametro("@INintIDOperacao", OperacaoSituacao.Operacao.IDOperacao);
                AcessoDados.AdicionarParametro("@INintIDSituacao", OperacaoSituacao.Situacao.IDSituacao);


                return AcessoDados.ExecutarScalar("uspCadastrarSituacaoOperacao", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
        public string Excluir(OperacaoSituacao OperacaoSituacao)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Excluir);
                AcessoDados.AdicionarParametro("@INintIDOperacao", OperacaoSituacao.Operacao.IDOperacao);
                AcessoDados.AdicionarParametro("@INintIDSituacao", OperacaoSituacao.Situacao.IDSituacao);


                return AcessoDados.ExecutarScalar("uspCadastrarSituacaoOperacao", CommandType.StoredProcedure).ToString();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public void CarregarComboList(ComboBox cbx, CheckedListBox ckdlistbx)
        {
            OperacaoCollection operacaoCollection = new OperacaoCollection();
            SituacaoCollection situacaoCollection = new SituacaoCollection();
            AcessoDados.LimparParametro();

            using (DataSet dtbRegistros = AcessoDados.GetDataTables("uspPesquisarOperacaoSituacao", CommandType.StoredProcedure))
            {
                foreach (DataRow item in dtbRegistros.Tables[0].Rows)
                {
                    operacaoCollection.Add(CarregarItem(item));
                }
                
                foreach (DataRow item in dtbRegistros.Tables[1].Rows)
                {
                    situacaoCollection.Add(CarregarItemSit(item));
                }
            }
            Dictionary<string, int?> lista = new Dictionary<string, int?>();
            lista.Add("TODOS", null);
            foreach (Operacao item in operacaoCollection)
            {
                lista.Add(item.Descricao, item.IDOperacao);
            }
            
            cbx.ValueMember = "Value";
            cbx.DisplayMember = "Key";
            cbx.DataSource = new BindingSource(lista, null);
            cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx.SelectedIndex = 0;

            //Dictionary<string, int> listaSituacao = new Dictionary<string, int>();
            ckdlistbx.DisplayMember = "key";
            ckdlistbx.ValueMember = "value";
            foreach (Situacao item in situacaoCollection)
            {
                ckdlistbx.Items.Add(new DictionaryEntry(item.Descricao,item.IDSituacao),true);
            }

        }

        private Operacao CarregarItem(DataRow item)
        {
            VMDataRow dtRow = new VMDataRow(item);
            Operacao operacao = new Operacao();

            operacao.IDOperacao = dtRow.GetInt("IDOperacao");
            operacao.Descricao = dtRow.GetStr("Descricao");

            return operacao;
        }

        private Situacao CarregarItemSit(DataRow item)
        {
            VMDataRow dtRow = new VMDataRow(item);
            Situacao situacao = new Situacao();
            situacao.IDSituacao = dtRow.GetInt("IDSituacao");
            situacao.Descricao = dtRow.GetStr("Descricao");

            return situacao;
        }
    }
}
