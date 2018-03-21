using SlnEstagio.ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlnEstagio.WINBASE;
using SlnEstagio.Negocio;

namespace SlnEstagio.MOD001
{
    public partial class FRM023 : FRMBASE
    {
        public Produto produto = new Produto();
        NegProduto negProduto = new NegProduto();
        ProdutoCollection produtoCollection = new ProdutoCollection();
        public FRM023()
        {
            InitializeComponent();
        }
        public FRM023(string VMPesquisa, bool? ativos)
        {
            InitializeComponent();
            AdicionarColunaTextBoxGrid(dgwColecao, "IDProduto", "Código", "Código do Produto", null, 60, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Descricao", "Descrição", "Descrição do Produto", null, 250, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaCheckBoxGrid(dgwColecao, "Ativo", "Ativo", "Produto Ativo", null, 80, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Cubagem", "Cubagem", "Cubagem do Produto", null, 250, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            txtVMPesquisar.Text = VMPesquisa;
            carregar(cbxAtivo);
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

        private void AtualizarGrid(Produto Produto, bool booExcluir)
        {
            try
            {
                object FiltroExcluir = null;

                if (booExcluir)
                {
                    FiltroExcluir = (LocalizarFiltroExcluir(dgwColecao) as Produto).GetChavePrimaria();
                    dgwColecao.DataSource = null;
                    produtoCollection.Remove(Produto);
                }
                else
                {
                    if (Produto != null)
                    {
                        var Item = from p in produtoCollection
                                   where p.GetChavePrimaria() == Produto.GetChavePrimaria()
                                   select p;

                        if (Item.Count() == 1)
                        {
                            Produto ProdutoSelecionado = Item.First();
                            ProdutoSelecionado = Produto;
                        }
                        else
                            produtoCollection.Add(Produto);
                    }
                    else
                    {
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                        object[] args = new object[3];
                        args[0] = "ConsultarProduto";
                        args[1] = txtVMPesquisar.Text;
                        args[2] = cbxAtivo.SelectedValue;
                        backgroundWorker1.RunWorkerAsync(args);
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                    }
                }

                dgwColecao.DataSource = null;
                if (produtoCollection.Count() > 0)
                    dgwColecao.DataSource = produtoCollection.ToList<Produto>();

                txtRegistro.Text = dgwColecao.Rows.Count.ToString();

                //if (objProduto != null)
                //    LocalizarIndexLinha(dgwColecao, FiltroExcluir == null ? objProduto.GetChavePrimaria() : FiltroExcluir);

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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("ConsultarProduto"))
            {
                int retorno;
                if (int.TryParse(args[1].ToString(), out retorno))
                    this.produtoCollection = negProduto.VMPesquisarProduto(string.Empty, retorno, (bool?)args[2]);
                else
                    this.produtoCollection = negProduto.VMPesquisarProduto(args[1].ToString(), null, (bool?)args[2]);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {

            try
            {
                btnSelecionar.Click -= new EventHandler(btnSelecionar_Click);
                Produto produtoSelecionado = dgwColecao.GetlinhaSelecionado<Produto>();

                if(produtoSelecionado == null)
                {
                    ExibirMensagem("Nenhum produto Selecionado!");
                    return;
                }
                this.produto = produtoSelecionado;
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

        private void txtVMPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                txtVMPesquisar.KeyDown -= new KeyEventHandler(txtVMPesquisar_KeyDown);

                if (e.KeyCode == Keys.Enter && btnVMPesquisar.Enabled == true)
                {
                    btnVMPesquisar_Click(null, null);
                }
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
    }
}
