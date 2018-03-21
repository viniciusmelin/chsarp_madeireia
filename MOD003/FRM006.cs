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
    public partial class FRM006 : FRMBASE
    {

        #region Forms
        public FRM006()
        {
            InitializeComponent();
            CarregarColuna();
            carregar(cbxAtivo);
        }

        NegFornecedor negFornecedor = new NegFornecedor();
        public Fornecedor Fornecedor { get; internal set; }
        FornecedorCollection fornecedorCollection = new FornecedorCollection();

        public FRM006(string pesquisa)
        {
            InitializeComponent();
            txtVMPesquisar.Text = pesquisa;
            carregar(cbxAtivo);
            CarregarColuna();
        }
        private void AtualizarGrid(Fornecedor Fornecedor, bool booExcluir)
        {
            try
            {
                object FiltroExcluir = null;

                if (booExcluir)
                {
                    FiltroExcluir = (LocalizarFiltroExcluir(dgwColecao) as Fornecedor).GetChavePrimaria();
                    dgwColecao.DataSource = null;
                    fornecedorCollection.Remove(Fornecedor);
                }
                else
                {
                    if (Fornecedor != null)
                    {
                        var Item = from p in fornecedorCollection
                                   where p.GetChavePrimaria() == Fornecedor.GetChavePrimaria()
                                   select p;

                        if (Item.Count() == 1)
                        {
                            Fornecedor FornecedorSelecionado = Item.First();
                            FornecedorSelecionado = Fornecedor;
                        }
                        else
                            fornecedorCollection.Add(Fornecedor);
                    }
                    else
                    {
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                        object[] args = new object[3];
                        args[0] = "ConsultarFornecedor";
                        args[1] = txtVMPesquisar.Text;
                        args[2] = cbxAtivo.SelectedValue;
                        backgroundWorker1.RunWorkerAsync(args);
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                    }
                }

                dgwColecao.DataSource = null;
                if (fornecedorCollection.Count() > 0)
                    dgwColecao.DataSource = fornecedorCollection.ToList<Fornecedor>();

                txtRegistro.Text = dgwColecao.Rows.Count.ToString();

                //if (objFornecedor != null)
                //    LocalizarIndexLinha(dgwColecao, FiltroExcluir == null ? objFornecedor.GetChavePrimaria() : FiltroExcluir);

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
        #endregion
        #region Controles
        void CarregarColuna()
        {
            AdicionarColunaTextBoxGrid(dgwColecao, "Pessoa.IDPessoa", "Código", "Código do Fornecedor", null, 60, DataGridViewContentAlignment.MiddleRight, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Pessoa.Nome", "Nome do Cliente", "Nome do Fornecedor", null, 250, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Pessoa.CpfCnpj", "CNPJ", "CNPJ do Fornecedor", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaCheckBoxGrid(dgwColecao, "Pessoa.Ativo", "Ativo", "Cliente Ativo", null, 60, DataGridViewContentAlignment.MiddleCenter, DataGridViewContentAlignment.MiddleCenter);
        }

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
                Fornecedor fornecedorSelecionado = dgwColecao.GetlinhaSelecionado<Fornecedor>();

                if (fornecedorSelecionado == null)
                    return;

                this.Fornecedor = fornecedorSelecionado;
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

            if (args[0].Equals("ConsultarFornecedor"))
            {
                this.fornecedorCollection = negFornecedor.VMPesquisarFornecedorID(args[1].ToString(), (bool?)args[2]);
            }
        }
        #endregion

    }
}
