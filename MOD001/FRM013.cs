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
    public partial class FRM013 : FRMBASE
    {
        #region Forms
        Produto produto = new Produto();
        NegProduto negProduto = new NegProduto();
        ProdutoCollection produtoCollection = new ProdutoCollection();
        public FRM013()
        {
            InitializeComponent();
            AdicionarColunaTextBoxGrid(dgwColecao, "IDProduto", "Código", "Código do Produto", null, 60, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Descricao", "Descrição", "Descrição do Produto", null, 250, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaCheckBoxGrid(dgwColecao, "Ativo", "Ativo", "Produto Ativo", null, 80, DataGridViewContentAlignment.MiddleCenter, DataGridViewContentAlignment.MiddleCenter);
            AdicionarColunaTextBoxGrid(dgwColecao, "QuantidadeMinina", "Q. Miníma", "Quantidade Miníma do Produto", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Altura", "Altura(CM)", "Altura do Produto", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Profundidade", "Profundidade(CM)", "Profundidade do Produto", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Largura", "Largura(CM)", "Largura do Produto", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Cubagem", "Cubagem", "Cubagem do Produto", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            carregar(cbxAtivos);
        }
        #endregion

        #region Controles
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVMPesquisar_Click(object sender, EventArgs e)
        {

            try
            {
                btnVMPesquisar.Click -= new EventHandler(btnVMPesquisar_Click);
                if (string.IsNullOrEmpty(txtVMPesquisar.Text))
                {
                    ExibirMensagem("Informar valor para Pesquisa!");
                    txtVMPesquisar.Focus();
                    return;
                }
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
                        args[0] = "VMPesquisarProduto";
                        args[1] = txtVMPesquisar.Text;
                        args[2] = cbxAtivos.SelectedValue;
                        backgroundWorker1.RunWorkerAsync(args);
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                    }
                }

                dgwColecao.DataSource = null;
                if (produtoCollection.Count() > 0)
                    dgwColecao.DataSource = produtoCollection.ToList<Produto>();

                txtRegistros.Text = dgwColecao.Rows.Count.ToString();

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
        private void btnInseir_Click(object sender, EventArgs e)
        {

            try
            {
                btnInseir.Click -= new EventHandler(btnInseir_Click);
                using (SlnEstagio.MOD001.FRM014 frm014 = new FRM014(null, Acao.INSERIR))
                {
                    if (frm014.ShowDialog() == DialogResult.OK)
                    {
                        this.produto = frm014.produto;
                        AtualizarGrid(this.produto, false);
                    }
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnInseir.Click += new EventHandler(btnInseir_Click);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                btnAlterar.Click -= new EventHandler(btnAlterar_Click);
                Produto produtoSelecionado = dgwColecao.GetlinhaSelecionado<Produto>();
                if (produtoSelecionado == null)
                    return;
                using (SlnEstagio.MOD001.FRM014 frm014 = new FRM014(produtoSelecionado, Acao.ALTERAR))
                {
                    if (frm014.ShowDialog() == DialogResult.OK)
                    {
                        this.produto = frm014.produto;
                        AtualizarGrid(this.produto, false);
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                btnExcluir.Click -= new EventHandler(btnExcluir_Click);
                Produto produtoSeleciodo = dgwColecao.GetlinhaSelecionado<Produto>();
                if (produtoSeleciodo == null)
                    return;
                if (ExibirMensagemPergunta("Deseja excluir este produto?", "EXCLUSÃO PRODUTO") == DialogResult.No)
                    return;

                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[2];
                args[0] = "ExcluirProduto";
                args[1] = produtoSeleciodo;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int retorno;
                if (int.TryParse(mensagembackgroundWor, out retorno))
                {
                    ExibirMensagem("Produto foi excluído com sucesso!");
                    AtualizarGrid(produtoSeleciodo, true);
                }
                else
                {
                    ExibirMensagemErro("Não foi possível excluir produto esta relacionado com outras informações contidas no banco de dados! \n Favor Inativar o Produto.\n Motivo: "+mensagembackgroundWor);
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
        #endregion
        #region BackGroundWork
        string mensagembackgroundWor;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("VMPesquisarProduto"))
            {
                int retorno;
                if(!int.TryParse(args[1].ToString(), out retorno))
                    this.produtoCollection = negProduto.VMPesquisarProduto(args[1].ToString(), (int?)null,(bool?)args[2]);
                else
                    this.produtoCollection = negProduto.VMPesquisarProduto(string.Empty, (int?)args[1], (bool?)args[2]);
            }
            else if (args[0].Equals("ExcluirProduto"))
            {
                this.mensagembackgroundWor = negProduto.Excluir(args[1] as Produto);
            }
        }

        #endregion

        private void txtVMPesquisar_KeyDown(object sender, KeyEventArgs e)
        {

            try
            {
                txtVMPesquisar.KeyDown -= new  KeyEventHandler(txtVMPesquisar_KeyDown);
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
    }
}
