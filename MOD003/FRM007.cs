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
using SlnEstagio.ObjetoTransferencia;
using SlnEstagio.Negocio;

namespace SlnEstagio.MOD003
{
    public partial class FRM007 : FRMBASE
    {
        #region Forms
        public ContasPagarTipo ContasPagarTipo { get; internal set; }
        ContasPagarTipoCollection contasPagarTipoCollection = new ContasPagarTipoCollection();
        NegContasPagarTipo negContasPagarTipo = new NegContasPagarTipo();
        public FRM007(string pesquisa)
        {
            InitializeComponent();
            txtVMPesquisar.Text = pesquisa;
            carregar(cbxAtivo);
            CarregarColuna();
        }
        private void AtualizarGrid(ContasPagarTipo ContasPagarTipo, bool booExcluir)
        {
            try
            {
                object FiltroExcluir = null;

                if (booExcluir)
                {
                    FiltroExcluir = (LocalizarFiltroExcluir(dgwColecao) as ContasPagarTipo).GetChavePrimaria();
                    dgwColecao.DataSource = null;
                    contasPagarTipoCollection.Remove(ContasPagarTipo);
                }
                else
                {
                    if (ContasPagarTipo != null)
                    {
                        var Item = from p in contasPagarTipoCollection
                                   where p.GetChavePrimaria() == ContasPagarTipo.GetChavePrimaria()
                                   select p;

                        if (Item.Count() == 1)
                        {
                            ContasPagarTipo ContasPagarTipoSelecionado = Item.First();
                            ContasPagarTipoSelecionado = ContasPagarTipo;
                        }
                        else
                            contasPagarTipoCollection.Add(ContasPagarTipo);
                    }
                    else
                    {
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                        object[] args = new object[3];
                        args[0] = "ConsultarContasPagarTipo";
                        args[1] = txtVMPesquisar.Text;
                        args[2] = cbxAtivo.SelectedValue;
                        backgroundWorker1.RunWorkerAsync(args);
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                    }
                }

                dgwColecao.DataSource = null;
                if (contasPagarTipoCollection.Count() > 0)
                    dgwColecao.DataSource = contasPagarTipoCollection.ToList<ContasPagarTipo>();

                txtRegistro.Text = dgwColecao.Rows.Count.ToString();

                //if (objContasPagarTipo != null)
                //    LocalizarIndexLinha(dgwColecao, FiltroExcluir == null ? objContasPagarTipo.GetChavePrimaria() : FiltroExcluir);

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
        void CarregarColuna()
        {
            AdicionarColunaTextBoxGrid(dgwColecao, "IDContasPagarTipo", "Código", "Código do Contas a Pagar Tipo", null, 60, DataGridViewContentAlignment.MiddleRight, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Descricao", "Descrição", "Descrição do Contas a Pagar Tipo", null, 320, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaCheckBoxGrid(dgwColecao, "Ativo", "Ativo", "Ativo", null, 60, DataGridViewContentAlignment.MiddleCenter, DataGridViewContentAlignment.MiddleCenter);
        }
        #endregion
        #region Controles
        private void btnVMPesquisar_Click(object sender, EventArgs e)
        {

            try
            {
                btnVMPesquisar.Click -= new EventHandler(btnVMPesquisar_Click);

                AtualizarGrid(null, false);
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnVMPesquisar.Click += new EventHandler(btnVMPesquisar_Click);
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {

            try
            {
                btnSelecionar.Click -= new EventHandler(btnSelecionar_Click);

                ContasPagarTipo tipoSelecionado = dgwColecao.GetlinhaSelecionado<ContasPagarTipo>();

                if (tipoSelecionado == null)
                    return;

                this.ContasPagarTipo = tipoSelecionado;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnSelecionar.Click += new EventHandler(btnSelecionar_Click);
            }
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void txtVMPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                txtVMPesquisar.KeyDown -= new KeyEventHandler(txtVMPesquisar_KeyDown);
                if (e.KeyCode == Keys.Enter && btnVMPesquisar.Enabled == true)
                    btnVMPesquisar_Click(null, null);
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
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("ConsultarContasPagarTipo"))
            {
               this.contasPagarTipoCollection = negContasPagarTipo.Pesquisar(args[1].ToString(), (bool?)args[2]);
            }
        }
        #endregion


    }
}
