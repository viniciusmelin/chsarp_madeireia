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
    public partial class FRM024 : FRMBASE
    {
        #region Forms
        Vendedor vendedor = new Vendedor();
        VendedorCollection vendedorCollection = new VendedorCollection();
        NegVendedor negVendedor = new NegVendedor();
        public FRM024()
        {
            InitializeComponent();
            AdicionarColunaTextBoxGrid(dgwColecao, "Pessoa.IDPessoa", "Código", "Código do Vendedor", null, 60, DataGridViewContentAlignment.MiddleRight, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Pessoa.Nome", "Nome do Cliente", "Nome do Vendedor", null, 450, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Pessoa.CpfCnpj", "CPF", "CPF do Vendedor", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaCheckBoxGrid(dgwColecao, "Pessoa.Ativo", "Ativo", "Vendedor Ativo", null, 60, DataGridViewContentAlignment.MiddleCenter, DataGridViewContentAlignment.MiddleCenter);
            carregar(cbxAtivos);
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
                        args[1] = txtVMPesquisar.Text;
                        args[2] = cbxAtivos.SelectedValue;
                        backgroundWorker1.RunWorkerAsync(args);
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                    }
                }

                dgwColecao.DataSource = null;
                if (vendedorCollection.Count() > 0)
                    dgwColecao.DataSource = vendedorCollection.ToList<Vendedor>();

                txtRegistros.Text = dgwColecao.Rows.Count.ToString();

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
        private void btnEmail_Click(object sender, EventArgs e)
        {

            try
            {
                btnEmail.Click -= new EventHandler(btnEmail_Click);
                this.vendedor= dgwColecao.GetlinhaSelecionado<Vendedor>();
                if(this.vendedor ==null)
                {
                    ExibirMensagem("Favor selecionar algum vendedor!");
                    return;
                }
                using (SlnEstagio.MOD001.FRM026 frm026 = new FRM026(this.vendedor))
                {
                    frm026.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnEmail.Click += new EventHandler(btnEmail_Click);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                btnExcluir.Click -= new EventHandler(btnExcluir_Click);
                Vendedor vendedorSelecionado = dgwColecao.GetlinhaSelecionado<Vendedor>();
                if (vendedorSelecionado == null)
                {
                    ExibirMensagem("Favor selecionar o vendedor que deseja excluir!");
                    return;
                }

                if (ExibirMensagemPergunta("Deseja realmente excluir o vendedor selecionado?", "Excluir Vendedor") != DialogResult.Yes)
                    return;

                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[2];
                args[0] = "ExcluirVendedor";
                args[1] = vendedorSelecionado; ;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int resultado;
                if (int.TryParse(mensagembackgroundWor, out resultado))
                {
                    ExibirMensagem("O vendedor foi excluído com sucesso!");
                    AtualizarGrid(vendedorSelecionado, true);
                }
                else
                {
                    ExibirMensagemErro("Não foi possível excluir vendedor selecioanado!");
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
        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                btnAlterar.Click -= new EventHandler(btnAlterar_Click);

                Vendedor vendedoSelecionado = dgwColecao.GetlinhaSelecionado<Vendedor>();
                if (vendedoSelecionado == null)
                {
                    ExibirMensagem("Favor selecionar um vendedor!");
                    return;
                }

                using (MOD001.FRM027 frm027 = new FRM027(vendedoSelecionado, Acao.ALTERAR))
                {
                    if (frm027.ShowDialog() == DialogResult.OK)
                    {
                        this.vendedor = frm027.vendedor;
                        AtualizarGrid(this.vendedor, false);
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

        private void btnInserir_Click(object sender, EventArgs e)
        {

            try
            {
                btnInserir.Click -= new EventHandler(btnInserir_Click);
                using (MOD001.FRM027 frm027 = new FRM027(null, Acao.INSERIR))
                {
                    if (frm027.ShowDialog() == DialogResult.OK)
                    {
                        this.vendedor = frm027.vendedor;
                        AtualizarGrid(this.vendedor, false);
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
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
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

            if (args[0].Equals("ConsultarVendedor"))
            {
                int resultado;
                if (int.TryParse(args[1].ToString(), out resultado))
                    this.vendedorCollection = this.negVendedor.PesquisarVendedor(string.Empty, resultado, (bool?)args[2]);
                else
                    this.vendedorCollection = this.negVendedor.PesquisarVendedor(args[1].ToString(), (int?)null, (bool?)args[2]);
            }
            else if (args[0].Equals("ExcluirVendedor"))
            {
                this.mensagembackgroundWor = this.negVendedor.Excluir(args[1] as Vendedor);
            }
        }
        #endregion


    }
}
