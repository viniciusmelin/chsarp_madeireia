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
using SlnEstagio.Negocio;
using System.Collections;

namespace SlnEstagio.MOD001
{
    public partial class FRM020 : FRMBASE
    {

        #region Forms
        public Cliente cliente = new Cliente();
        NegCliente negCliente = new NegCliente();

        ClienteCollection clienteCollection = new ClienteCollection();
        public FRM020()
        {
            InitializeComponent();
        }

        public FRM020(string texto, bool? ativos)
        {
            InitializeComponent();
            carregar(cbxAtivos);
            txtPesquisar.Text = texto;
            AdicionarColunaTextBoxGrid(dgwColecao, "Pessoa.IDPessoa", "Código", "Código do Cliente", null, 60, DataGridViewContentAlignment.MiddleRight, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Pessoa.Nome", "Nome do Cliente", "Nome do Cliente", null, 250, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaCheckBoxGrid(dgwColecao, "Pessoa.Ativo", "Ativo", "Cliente Ativo", null, 60, DataGridViewContentAlignment.MiddleCenter, DataGridViewContentAlignment.MiddleCenter);
        }
        private void AtualizarGrid(Cliente Cliente, bool booExcluir)
        {
            try
            {
                object FiltroExcluir = null;

                if (booExcluir)
                {
                    FiltroExcluir = (LocalizarFiltroExcluir(dgwColecao) as Cliente).GetChavePrimaria();
                    dgwColecao.DataSource = null;
                    clienteCollection.Remove(Cliente);
                }
                else
                {
                    if (Cliente != null)
                    {
                        var Item = from p in clienteCollection
                                   where p.GetChavePrimaria() == Cliente.GetChavePrimaria()
                                   select p;

                        if (Item.Count() == 1)
                        {
                            Cliente ClienteSelecionado = Item.First();
                            ClienteSelecionado = Cliente;
                        }
                        else
                            clienteCollection.Add(Cliente);
                    }
                    else
                    {
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                        object[] args = new object[3];
                        args[0] = "VMPesquisarCliente";
                        args[1] = this.txtPesquisar.Text;
                        args[2] = cbxAtivos.SelectedValue;
                        backgroundWorker1.RunWorkerAsync(args);
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                    }
                }

                dgwColecao.DataSource = null;
                if (clienteCollection.Count() > 0)
                    dgwColecao.DataSource = clienteCollection.ToList<Cliente>();

                txtRegistros.Text = dgwColecao.Rows.Count.ToString();

                //if (objCliente != null)
                //    LocalizarIndexLinha(dgwColecao, FiltroExcluir == null ? objCliente.GetChavePrimaria() : FiltroExcluir);

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
        private void FRM020_Shown(object sender, EventArgs e)
        {
            try
            {
                AtualizarGrid(null, false);
            }
            catch (Exception)
            {

                throw;
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
                Cliente clienteSelecionado = dgwColecao.GetlinhaSelecionado<Cliente>();
                if (clienteSelecionado == null)
                    return;
                this.cliente = clienteSelecionado;
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
        #endregion
        #region BackGroundWork
        //string mensagembackgroundWor;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("VMPesquisarCliente"))
            {
                this.clienteCollection = negCliente.PesquisarCliente(args[1].ToString(), (bool?)args[2]);
            }
        }
        #endregion

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
