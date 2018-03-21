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

namespace SlnEstagio.MOD004
{
    public partial class FRM001 : FRMBASE
    {
        EstoqueMovimentacaoCollection estoqueMovimentacaoCollection = new EstoqueMovimentacaoCollection();
        EstoqueMovimentacao estoqueMovimentacao = new EstoqueMovimentacao();
        NegEstoqueMovimentacao negMovimentacao = new NegEstoqueMovimentacao();
        public Produto ProdutoPesquisa { get; set; }
        public Produto ProdutoPesquisaMovimentar { get; set; }
        public Produto ProdutoPesquisaTransformarOrigem { get; set; }
        public Produto ProdutoPesquisaTransformarDestino { get; set; }
        public FRM001()
        {
            InitializeComponent();
            carregarColunas();
        }

        void carregarColunas()
        {
            AdicionarColunaTextBoxGrid(dgwColecao, "IDMovimentacao", "Código", "Código da Movimentação", null, 60, DataGridViewContentAlignment.MiddleRight, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Data", "Dt. Mov.", "Data de Movimentação Estoque", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Operacao", "Ope.", "Operação realizada C = Crédtio D = Débito", null, 60, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Quantidade", "Quantidade", "Quantidade Movimentada", null, 80, DataGridViewContentAlignment.MiddleRight, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Produto.IDProduto", "Cód.", "Código do Produto", null, 60, DataGridViewContentAlignment.MiddleRight, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Produto.Descricao", "Descricão", "Descrição do Produto", null, 250, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Produto.Quantidade", "Estoque", "Quantidade em Estoque", null, 60, DataGridViewContentAlignment.MiddleRight, DataGridViewContentAlignment.MiddleLeft);
            
        }
        private void btnPesqProdutoPesquisar_Click(object sender, EventArgs e)
        {

            try
            {
                btnPesqProdutoPesquisar.Click -= new EventHandler(btnPesqProdutoPesquisar_Click);
                using (SlnEstagio.MOD001.FRM023 frm023 = new MOD001.FRM023(txtProdutoPesquisar.Text, null))
                {
                    if (frm023.ShowDialog() == DialogResult.OK)
                    {
                        txtProdutoPesquisar.VMPesquisaValor = frm023.produto;
                        txtProdutoPesquisar.Text = frm023.produto.Descricao;
                    }
                }

            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnPesqProdutoPesquisar.Click += new EventHandler(btnPesqProdutoPesquisar_Click);
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


        private void AtualizarGrid(EstoqueMovimentacao EstoqueMovimentacao, bool booExcluir)
        {
            try
            {
                object FiltroExcluir = null;

                if (booExcluir)
                {
                    FiltroExcluir = (LocalizarFiltroExcluir(dgwColecao) as EstoqueMovimentacao).GetChavePrimaria();
                    dgwColecao.DataSource = null;
                    estoqueMovimentacaoCollection.Remove(EstoqueMovimentacao);
                }
                else
                {
                    if (EstoqueMovimentacao != null)
                    {
                        var Item = from p in estoqueMovimentacaoCollection
                                   where p.GetChavePrimaria() == EstoqueMovimentacao.GetChavePrimaria()
                                   select p;

                        if (Item.Count() == 1)
                        {
                            EstoqueMovimentacao EstoqueMovimentacaoSelecionado = Item.First();
                            EstoqueMovimentacaoSelecionado = EstoqueMovimentacao;
                        }
                        else
                            estoqueMovimentacaoCollection.Add(EstoqueMovimentacao);
                    }
                    else
                    {
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                        object[] args = new object[5];
                        args[0] = "ConsultarEstoqueMovimentacao";
                        args[1] = dtpInicial.Value;
                        args[2] = dtpFinal.Value;
                        args[3] = (txtProdutoPesquisar.VMPesquisaValor as Produto) == null ? (int?)null: (txtProdutoPesquisar.VMPesquisaValor as Produto).IDProduto;
                        backgroundWorker1.RunWorkerAsync(args);
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                    }
                }

                dgwColecao.DataSource = null;
                if (estoqueMovimentacaoCollection.Count() > 0)
                    dgwColecao.DataSource = estoqueMovimentacaoCollection.ToList<EstoqueMovimentacao>();

                txtRegistro.Text = dgwColecao.Rows.Count.ToString();
                txtDebito.Text = estoqueMovimentacaoCollection.Where(o => o.Operacao == "D").Count().ToString();
                txtCredito.Text = estoqueMovimentacaoCollection.Where(o => o.Operacao == "C").Count().ToString();


                //if (objEstoqueMovimentacao != null)
                //    LocalizarIndexLinha(dgwColecao, FiltroExcluir == null ? objEstoqueMovimentacao.GetChavePrimaria() : FiltroExcluir);

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

        private void btnMovimentar_Click(object sender, EventArgs e)
        {

            try
            {
                btnMovimentar.Click -= new EventHandler(btnMovimentar_Click);
                if (txtProdutoMovimentacao.VMPesquisaValor == null)
                {
                    ExibirMensagemErro("Favor escolher produto para Movimentação!");
                    txtProdutoMovimentacao.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtQuantidadeMovimentacao.Text) || txtQuantidadeMovimentacao.Equals("0"))
                {
                    ExibirMensagemErro("Quantidade não pode ser zerada");
                    txtQuantidadeMovimentacao.Focus();
                    return;
                }
                this.estoqueMovimentacao.Produto = new Produto();
                this.estoqueMovimentacao.Produto = (txtProdutoMovimentacao.VMPesquisaValor as Produto);
                this.estoqueMovimentacao.Quantidade = Convert.ToDecimal(txtQuantidadeMovimentacao.Text);
                
                this.estoqueMovimentacao.Operacao = cbxOperacao.SelectedIndex ==0 ? "D": "C";

                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                Object[] args = new object[5];
                args[0] = "MovimentarProduto";
                args[1] = this.estoqueMovimentacao.Produto.IDProduto;
                args[2] = this.estoqueMovimentacao.Quantidade;
                args[3] = this.estoqueMovimentacao.Operacao;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int resultado;
                if (int.TryParse(mensagembackgroundWor, out resultado))
                {
                    ExibirMensagem("Movimentação de Estoque realizada com Sucesso!");
                    AtualizarGrid(null, false);
                }
                else
                {
                    ExibirMensagemErro("Não foi possível realizar movimentção de Estoque. \n Motivo: "+mensagembackgroundWor);
                }


            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnMovimentar.Click += new EventHandler(btnMovimentar_Click);
            }
        }

        private void btnTransformar_Click(object sender, EventArgs e)
        {

            try
            {
                btnTransformar.Click -= new EventHandler(btnTransformar_Click);

                if (txtProdutoOrigem.VMPesquisaValor == null)
                {
                    ExibirMensagemAlerta("É obrigatório escolher um produto de Origem!");
                    txtProdutoOrigem.Focus();
                    return;
                }

                if (txtProdutoDestino.VMPesquisaValor == null)
                {
                    ExibirMensagemAlerta("É obrigatório escolher um produto de Destino!");
                    txtProdutoDestino.Focus();
                    return;
                }
                decimal quantidadeOrigem;
                decimal quantidadeDestino;
                if (decimal.TryParse(txtQuantidadeOriginal.Text, out quantidadeOrigem))
                    if (quantidadeOrigem == decimal.Zero)
                    {
                        ExibirMensagemAlerta("Quantidade não poder ser menor ou igual a zero!");
                        txtQuantidadeOriginal.Focus();
                        return;
                    }
                if (decimal.TryParse(txtQuantidadeDestino.Text, out quantidadeDestino))
                    if(quantidadeDestino == decimal.Zero)
                    {
                        ExibirMensagemAlerta("Quantidade não poder ser menor ou igual a zero!");
                        txtQuantidadeDestino.Focus();
                        return;
                    }

                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[6];
                args[0] = "TransformarProduto";
                args[1] = (txtProdutoOrigem.VMPesquisaValor as Produto).IDProduto;
                args[2] = quantidadeOrigem;//Convert.ToDecimal(txtProdutoOrigem.Text);
                args[3] = (txtProdutoDestino.VMPesquisaValor as Produto).IDProduto;
                args[4] = quantidadeDestino;// Convert.ToDecimal(txtQuantidadeDestino.Text);
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int resultado;
                if(int.TryParse(mensagembackgroundWor, out resultado))
                {
                    ExibirMensagem("Conversão de Produto realizada com sucesso!");
                }
                else
                {
                    ExibirMensagemErro("Não foi possível realizar a conversão de Produto. \n Motivo: "+mensagembackgroundWor);
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnTransformar.Click += new EventHandler(btnTransformar_Click);
            }
        }


        string mensagembackgroundWor;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            /*
                        args[1] = dtpInicial.Value;
                        args[2] = dtpFinal.Value;
                        args[3] = (txtProdutoPesquisar.VMPesquisaValor as Produto).IDProduto;
             */
            object[] args = (object[])e.Argument;

            if (args[0].Equals("MovimentarProduto"))
            {
                this.mensagembackgroundWor = negMovimentacao.Inserir((int)args[1], (decimal)args[2], args[3].ToString());
            }
            else if (args[0].Equals("ConsultarEstoqueMovimentacao"))
            {
                this.estoqueMovimentacaoCollection = this.negMovimentacao.Consultar((int?)args[3], (DateTime?)args[1], (DateTime?)args[2], string.Empty);
            }
            else if (args[0].Equals("TransformarProduto"))
            {
                //args[0] = "TransformarProduto";
                //args[1] = (txtProdutoOrigem.VMPesquisaValor as Produto).IDProduto;
                //args[2] = quantidadeOrigem;//Convert.ToDecimal(txtProdutoOrigem.Text);
                //args[3] = (txtProdutoDestino.VMPesquisaValor as Produto).IDProduto;
                //args[4] = txtQuantidadeDestino;// Convert.ToDecimal(txtQuantidadeDestino.Text);
                this.mensagembackgroundWor = negMovimentacao.ConverteEstoque((int)args[1], (int)args[3], (decimal)args[2], (decimal)args[4]);
            }
        }

        private void txtProdutoPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && btnPesqProdutoPesquisar.Enabled == true)
                btnPesqProdutoPesquisar_Click(null, null);
            else if (e.KeyCode == Keys.Delete && btnPesqProdutoPesquisar.Enabled == true)
            {
                txtProdutoPesquisar.VMPesquisaValor = null;
                txtProdutoPesquisar.Clear();
            }
        }

        private void btnPesqProdutoOriginal_Click(object sender, EventArgs e)
        {

            try
            {
                btnPesqProdutoOriginal.Click -= new EventHandler(btnPesqProdutoOriginal_Click);
                using (SlnEstagio.MOD001.FRM023 frm023 = new MOD001.FRM023(txtProdutoOrigem.Text, null))
                {
                    if (frm023.ShowDialog() == DialogResult.OK)
                    {
                        txtProdutoOrigem.VMPesquisaValor = frm023.produto;
                        txtProdutoOrigem.Text = frm023.produto.Descricao;
                        txtCubagemOrigem.Text = frm023.produto.Cubagem.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnPesqProdutoOriginal.Click += new EventHandler(btnPesqProdutoOriginal_Click);
            }
        }

        private void txtProdutoOrigem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && btnPesqProdutoOriginal.Enabled == true)
                btnPesqProdutoOriginal_Click(null, null);
            else if (e.KeyCode == Keys.Delete && btnPesqProdutoOriginal.Enabled == true)
            {
                txtProdutoOrigem.VMPesquisaValor = null;
                txtProdutoOrigem.Clear();
                txtCubagemOrigem.Clear();
            }
        }

        private void btnPesqProdutoDestino_Click(object sender, EventArgs e)
        {

            try
            {
                btnPesqProdutoDestino.Click -= new EventHandler(btnPesqProdutoDestino_Click);
                using (SlnEstagio.MOD001.FRM023 frm023 = new MOD001.FRM023(txtProdutoDestino.Text, null))
                {
                    if (frm023.ShowDialog() == DialogResult.OK)
                    {
                        txtProdutoDestino.VMPesquisaValor = frm023.produto;
                        txtProdutoDestino.Text = frm023.produto.Descricao;
                        txtCubagemDestino.Text = frm023.produto.Cubagem.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnPesqProdutoDestino.Click += new EventHandler(btnPesqProdutoDestino_Click);
            }
        }

        private void txtProdutoDestino_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && btnPesqProdutoDestino.Enabled == true)
                btnPesqProdutoDestino_Click(null, null);
            else if (e.KeyCode == Keys.Delete && btnPesqProdutoDestino.Enabled == true)
            {
                txtCubagemDestino.Clear();
                txtCubagemDestino.VMPesquisaValor = null;
                txtCubagemOrigem.Clear();
            }
        }

        private void btnPesqProdutoMovimentacao_Click(object sender, EventArgs e)
        {

            try
            {
                btnPesqProdutoMovimentacao.Click -= new EventHandler(btnPesqProdutoMovimentacao_Click);
                using (SlnEstagio.MOD001.FRM023 frm023 = new MOD001.FRM023(txtProdutoMovimentacao.Text, null))
                {
                    if (frm023.ShowDialog() == DialogResult.OK)
                    {
                        txtProdutoMovimentacao.VMPesquisaValor = frm023.produto;
                        txtProdutoMovimentacao.Text = frm023.produto.Descricao;
                    }
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnPesqProdutoMovimentacao.Click += new EventHandler(btnPesqProdutoMovimentacao_Click);
            }
        }

        private void txtProdutoMovimentacao_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && btnPesqProdutoMovimentacao.Enabled == true)
                    btnPesqProdutoMovimentacao_Click(null, null);
                else if (e.KeyCode == Keys.Delete && btnPesqProdutoMovimentacao.Enabled == true)
                {
                    txtProdutoMovimentacao.VMPesquisaValor = null;
                    txtProdutoMovimentacao.Clear();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FRM001_Shown(object sender, EventArgs e)
        {
            try
            {
                cbxOperacao.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                Exceptionerro(ex);
            }
        }
    }
}
