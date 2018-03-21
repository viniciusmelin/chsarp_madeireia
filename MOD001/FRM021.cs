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
    public partial class FRM021 : FRMBASE
    {

        #region Forms
        public Vendedor vendedor = new Vendedor();
        NegVendedor negVendedor = new NegVendedor();
        VendedorCollection vendedorCollection = new VendedorCollection();
        public FRM021()
        {
            InitializeComponent();
        }
        public FRM021(string VMPesquisa, bool? ativos)
        {
            InitializeComponent();
            txtPesquisar.Text = VMPesquisa;
            carregar(cbxAtivo);
            AdicionarColunaTextBoxGrid(dgwColecao, "Pessoa.IDPessoa", "Código", "Código do Vendedor", null, 60, DataGridViewContentAlignment.MiddleRight, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Pessoa.Nome", "Nome do Vendedor", "Nome do Vendedor", null, 350, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaCheckBoxGrid(dgwColecao, "Pessoa.Ativo", "Ativo", "Vendedor Ativo", null, 60, DataGridViewContentAlignment.MiddleCenter, DataGridViewContentAlignment.MiddleCenter);

        }
        private void AtualizarGrid(Vendedor Vendedor, bool booExcluir)
        {
            try
            {
                object FiltroExcluir = null;

                if (booExcluir)
                {
                    FiltroExcluir = (LocalizarFiltroExcluir(dgwColecao) as Vendedor).GetChavePrimaria();
                    dgwColecao.DataSource = null;
                    vendedorCollection.Remove(Vendedor);
                }
                else
                {
                    if (Vendedor != null)
                    {
                        var Item = from p in vendedorCollection
                                   where p.GetChavePrimaria() == Vendedor.GetChavePrimaria()
                                   select p;

                        if (Item.Count() == 1)
                        {
                            Vendedor VendedorSelecionado = Item.First();
                            VendedorSelecionado = Vendedor;
                        }
                        else
                            vendedorCollection.Add(Vendedor);
                    }
                    else
                    {
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                        object[] args = new object[3];
                        args[0] = "ConsultarVendedor";
                        args[1] = txtPesquisar.Text;
                        args[2] = cbxAtivo.SelectedValue;
                        backgroundWorker1.RunWorkerAsync(args);
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                    }
                }

                dgwColecao.DataSource = null;
                if (vendedorCollection.Count() > 0)
                    dgwColecao.DataSource = vendedorCollection.ToList<Vendedor>();

                txtRegistro.Text = dgwColecao.Rows.Count.ToString();

                //if (objVendedor != null)
                //    LocalizarIndexLinha(dgwColecao, FiltroExcluir == null ? objVendedor.GetChavePrimaria() : FiltroExcluir);

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
                Vendedor vendedorSelecionado = dgwColecao.GetlinhaSelecionado<Vendedor>();
                if (vendedorSelecionado == null)
                    return;
                this.vendedor = vendedorSelecionado;
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
        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                txtPesquisar.KeyDown -= new KeyEventHandler(txtPesquisar_KeyDown);
                if (e.KeyCode == Keys.Enter && btnVMPesquisar.Enabled == true)
                    btnVMPesquisar_Click(null, null);
            }
            catch (Exception ex)
            {

                Exceptionerro(ex);
            }
            finally
            {
                txtPesquisar.KeyDown += new KeyEventHandler(txtPesquisar_KeyDown);
            }
        }
        #endregion
        #region BackGroundWork

        //string mensagembackgroundWor;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("ConsultarVendedor"))
            {
                int resultado;
                if (int.TryParse(txtPesquisar.Text, out resultado))
                    this.vendedorCollection = negVendedor.PesquisarVendedor(string.Empty, resultado, (bool?)args[2]);
                else
                    this.vendedorCollection = negVendedor.PesquisarVendedor(args[1].ToString(), (int?)null, (bool?)args[2]);
            }
        }
        #endregion

    }
}
