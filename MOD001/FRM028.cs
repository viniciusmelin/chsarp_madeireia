using SlnEstagio.Negocio;
using SlnEstagio.ObjetoTransferencia;
using SlnEstagio.WINBASE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlnEstagio.MOD001
{
    public partial class FRM028 : FRMBASE
    {
        #region Forms
        NegTipoPagamento negTipoPagamento = new NegTipoPagamento();
        TipoPagamentoCollection tipoPagamentoCollection = new TipoPagamentoCollection();
        TipoPagamento tipoPagamento = new TipoPagamento();
        public FRM028()
        {
            InitializeComponent();
            CarregarColuas();
            carregar(cbxAtivos);
        }
        private void AtualizarGrid(TipoPagamento TipoPagamento, bool booExcluir)
        {
            try
            {
                object FiltroExcluir = null;

                if (booExcluir)
                {
                    FiltroExcluir = (LocalizarFiltroExcluir(dgwColecao) as TipoPagamento).GetChavePrimaria();
                    dgwColecao.DataSource = null;
                    tipoPagamentoCollection.Remove(TipoPagamento);
                }
                else
                {
                    if (TipoPagamento != null)
                    {
                        var Item = from p in tipoPagamentoCollection
                                   where p.GetChavePrimaria() == TipoPagamento.GetChavePrimaria()
                                   select p;

                        if (Item.Count() == 1)
                        {
                            TipoPagamento TipoPagamentoSelecionado = Item.First();
                            TipoPagamentoSelecionado = TipoPagamento;
                        }
                        else
                            tipoPagamentoCollection.Add(TipoPagamento);
                    }
                    else
                    {
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                        object[] args = new object[3];
                        args[0] = "ConsultarTipoPagamento";
                        args[1] = txtVMPesquisar.Text;
                        args[2] = (bool?)cbxAtivos.SelectedValue;
                        backgroundWorker1.RunWorkerAsync(args);
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                    }
                }

                dgwColecao.DataSource = null;
                if (tipoPagamentoCollection.Count() > 0)
                    dgwColecao.DataSource = tipoPagamentoCollection.ToList<TipoPagamento>();

                txtRegistros.Text = dgwColecao.Rows.Count.ToString();

                //if (objTipoPagamento != null)
                //    LocalizarIndexLinha(dgwColecao, FiltroExcluir == null ? objTipoPagamento.GetChavePrimaria() : FiltroExcluir);

                dgwColecao.Update();
                dgwColecao.Refresh();

                if (dgwColecao.RowCount > 0)
                    dgwColecao.Focus();

            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
        }

        void CarregarColuas()
        {
            AdicionarColunaTextBoxGrid(dgwColecao, "IDTipoPagamento", "Código", "Código do Tipo de Pagamento", null, 60, DataGridViewContentAlignment.MiddleRight, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Descricao", "Descrição", "Descrição Tipo Pagamento", null, 400, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaCheckBoxGrid(dgwColecao, "Ativo", "Ativo", "Cliente Ativo", null, 60, DataGridViewContentAlignment.MiddleCenter, DataGridViewContentAlignment.MiddleCenter);
        }
        #endregion
        #region Controles
        private void btnExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                btnExcluir.Click -= new EventHandler(btnExcluir_Click);
                TipoPagamento tipoPagamentoSelecionado = dgwColecao.GetlinhaSelecionado<TipoPagamento>();
                if (tipoPagamentoSelecionado == null)
                {
                    ExibirMensagem("Nenhum pagamento selecionado!");
                    return;
                }

                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[2];
                args[0] = "ExcluirTipoPagamento";
                args[1] = tipoPagamentoSelecionado;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int resultado;
                if (int.TryParse(mensagembackgroundWor, out resultado))
                {
                    ExibirMensagem("O pagamento foi excluído com sucesso!");
                    AtualizarGrid(tipoPagamentoSelecionado, true);
                }
                else
                {
                    ExibirMensagemErro("Não foi possível excluir Pagamento.\n Motivo: " + mensagembackgroundWor);
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnExcluir.Click += new EventHandler(btnExcluir_Click);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            try
            {
                btnPesquisar.Click -= new EventHandler(btnPesquisar_Click);
                AtualizarGrid(null, false);
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnPesquisar.Click += new EventHandler(btnPesquisar_Click);
            }
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {

            try
            {
                btnFechar.Click -= new EventHandler(btnFechar_Click);
                this.Close();
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnFechar.Click += new EventHandler(btnFechar_Click);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            try
            {
                btnInserir.Click -= new EventHandler(btnInserir_Click);
                using (MOD001.FRM029 frm029 = new FRM029(null, Acao.INSERIR))
                {
                    if (frm029.ShowDialog() == DialogResult.OK)
                    {
                        this.tipoPagamento = frm029.tipoPagamento;
                        AtualizarGrid(this.tipoPagamento, false);

                    }
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnInserir.Click += new EventHandler(btnInserir_Click);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                btnAlterar.Click -= new EventHandler(btnAlterar_Click);
                TipoPagamento tipoPagamentoSelecionado = dgwColecao.GetlinhaSelecionado<TipoPagamento>();
                if (tipoPagamentoSelecionado == null)
                {
                    ExibirMensagem("Nenhum pagamento foi selecionado!");
                    return;
                }
                using (MOD001.FRM029 frm029 = new FRM029(tipoPagamentoSelecionado, Acao.ALTERAR))
                {
                    if (frm029.ShowDialog() == DialogResult.OK)
                    {
                        this.tipoPagamento = frm029.tipoPagamento;
                        AtualizarGrid(this.tipoPagamento, false);
                    }
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnAlterar.Click += new EventHandler(btnAlterar_Click);
            }
        }
        private void txtVMPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                txtVMPesquisar.KeyDown -= new KeyEventHandler(txtVMPesquisar_KeyDown);
                if (e.KeyCode == Keys.Enter && btnPesquisar.Enabled == true)
                    btnPesquisar_Click(null, null);
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                txtVMPesquisar.KeyDown += new KeyEventHandler(txtVMPesquisar_KeyDown);
            }
        }

        #endregion
        #region BackGroundWork
        string mensagembackgroundWor;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("ConsultarTipoPagamento"))
            {
                int resultado;
                if (int.TryParse(args[1].ToString(), out resultado))
                    this.tipoPagamentoCollection = negTipoPagamento.PesquisarTipoPagamento(resultado, string.Empty, (bool?)args[2]);
                else
                    this.tipoPagamentoCollection = negTipoPagamento.PesquisarTipoPagamento((int?)null, args[1].ToString(), (bool?)args[2]);
            }
            else if (args[0].Equals("ExcluirTipoPagamento"))
            {
                this.mensagembackgroundWor = negTipoPagamento.Excluir(args[1] as TipoPagamento);
            }
        }
        #endregion

        
    }
}
