using System;
using SlnEstagio.WINBASE;
using SlnEstagio.ObjetoTransferencia;
using System.Windows.Forms;
using System.Linq;
using System.ComponentModel;
using SlnEstagio.Negocio;

namespace SlnEstagio.MOD002
{
    public partial class FRM002 : FRMBASE
    {

        #region Forms
        NegPedido negPedido = new NegPedido();
        NegPedidoItem negPedidoItem = new NegPedidoItem();
        private Produto produto { get; set; }
        public Pedido pedido;
        public PedidoItem pedidoItem = new PedidoItem();
        PedidoItemCollection pedidoItemCollection = new PedidoItemCollection();
        Cliente cliente = new Cliente();
        Vendedor vendedor = new Vendedor();
        Acao acao;
        public FRM002()
        {
            InitializeComponent();
            carregarColunas();
        }

        public FRM002(Pedido pedido, Acao acao)
        {
            InitializeComponent();
            this.pedido = pedido;
            if (pedido == null)
                this.pedido = new Pedido();
            this.acao = acao;
            carregarColunas();
            
        }
        private void FRM002_Shown(object sender, EventArgs e)
        {
            try
            {
                //negTipoPagamento.CarregarComboListTipoPagamento(cbxTipoPagamento);
               

                if (this.acao == Acao.ALTERAR)
                {
                    if (this.pedido.OpercaoSituacao.Operacao.IDOperacao == (int)EnumOperacao.VENDA)
                    {
                        rbtPedido.Checked = true;
                        rbtOrcamento.Checked = !rbtPedido.Checked;
                    }
                    else
                    {
                        rbtOrcamento.Checked = true;
                        rbtPedido.Checked = !rbtOrcamento.Checked;
                    }

                    txtCliente.Text = this.pedido.Cliente.Pessoa.Nome;
                    txtCliente.VMPesquisaValor = this.pedido.Cliente;
                    txtVendedor.Text = this.pedido.Vendedor.Pessoa.Nome;
                    txtVendedor.VMPesquisaValor = this.pedido.Vendedor;
                    while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                    object[] args = new object[5];
                    args[0] = "PesquisarItemPedido";
                    args[1] = this.pedido.IDPedido;
                    backgroundWorker1.RunWorkerAsync(args);
                    while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                }

                AtualizarGrid(null, false);
            }
            catch (Exception ex)
            {

                Exceptionerro(ex);
            }
        }
        void carregarColunas()
        {
            AdicionarColunaTextBoxGrid(dgwColecao, "Produto.IDProduto", "Código", "Código do Produto", null, 60, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Produto.Descricao", "Descrição", "Descrição do Produto", null, 250, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Produto.Preco", "Valor", "Valor do Produto", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Quantidade", "Quantidade", "Quantidade do Produto", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Produto.Cubagem", "Cubagem", "Cubagem do Produto", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);

        }
        private void AtualizarGrid(PedidoItem PedidoItem, bool booExcluir)
        {
            try
            {
                object FiltroExcluir = null;

                if (booExcluir)
                {
                    FiltroExcluir = (LocalizarFiltroExcluir(dgwColecao) as PedidoItem).Produto.GetChavePrimaria();
                    dgwColecao.DataSource = null;
                    pedidoItemCollection.Remove(PedidoItem);
                }
                else
                {
                    if (PedidoItem != null)
                    {
                        var Item = from p in pedidoItemCollection
                                   where p.GetChavePrimaria() == PedidoItem.GetChavePrimaria()
                                   select p;

                        if (Item.Count() == 1)
                        {
                            PedidoItem PedidoItemSelecionado = Item.First();
                            PedidoItemSelecionado = PedidoItem;
                        }
                        else
                            pedidoItemCollection.Add(PedidoItem);
                    }
                    //else
                    //{
                    //    while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                    //    object[] args = new object[2];
                    //    args[0] = "ConsultarPedidoItem";
                    //    backgroundWorker1.RunWorkerAsync(args);
                    //    while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                    //}
                }

                dgwColecao.DataSource = null;
                if (pedidoItemCollection.Count() > 0)
                    dgwColecao.DataSource = pedidoItemCollection.ToList<PedidoItem>();

                txtRegistro.Text = dgwColecao.Rows.Count.ToString();
                txtCubagemTotal.Text = pedidoItemCollection.Sum(t => t.Quantidade * t.Produto.Cubagem).ToString();
                txtValorTotal.Text = pedidoItemCollection.Sum(t => t.Quantidade * t.Produto.Preco).ToString();

                //if (objPedidoItem != null)
                //    LocalizarIndexLinha(dgwColecao, FiltroExcluir == null ? objPedidoItem.GetChavePrimaria() : FiltroExcluir);

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
        private void btnPesqCliente_Click(object sender, EventArgs e)
        {

            try
            {
                btnPesqCliente.Click -= new EventHandler(btnPesqCliente_Click);
                using (SlnEstagio.MOD001.FRM020 frm020 = new MOD001.FRM020(txtCliente.Text, null))
                {
                    if (frm020.ShowDialog() == DialogResult.OK)
                    {
                        txtCliente.VMPesquisaValor = frm020.cliente;
                        txtCliente.Text = frm020.cliente.Pessoa.Nome;
                    }
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnPesqCliente.Click += new EventHandler(btnPesqCliente_Click);
            }
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                txtCliente.KeyDown -= new KeyEventHandler(txtCliente_KeyDown);
                if (e.KeyCode == Keys.Enter)
                {
                    btnPesqCliente_Click(null, null);
                }
                else if (e.KeyCode == Keys.Delete)
                {
                    txtCliente.VMPesquisaValor = null;
                    txtCliente.Clear();
                    txtCliente.Focus();
                }
            }
            catch (Exception ex)
            {

                Exceptionerro(ex);
            }
            finally
            {
                txtCliente.KeyDown += new KeyEventHandler(txtCliente_KeyDown);
            }
        }

        private void txtVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                txtVendedor.KeyDown -= new KeyEventHandler(txtVendedor_KeyDown);
                if (e.KeyCode == Keys.Enter)
                {
                    btnPesqVendedor_Click(null, null);
                }
                else if (e.KeyCode == Keys.Delete)
                {
                    txtVendedor.VMPesquisaValor = null;
                    txtVendedor.Clear();
                    txtVendedor.Focus();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                txtVendedor.KeyDown += new KeyEventHandler(txtVendedor_KeyDown);
            }
        }

        private void btnPesqVendedor_Click(object sender, EventArgs e)
        {

            try
            {
                btnPesqVendedor.Click -= new EventHandler(btnPesqVendedor_Click);
                using (MOD001.FRM021 frm021 = new MOD001.FRM021(txtVendedor.Text, null))
                {
                    if (frm021.ShowDialog() == DialogResult.OK)
                    {
                        this.txtVendedor.VMPesquisaValor = frm021.vendedor;
                        txtVendedor.Text = frm021.vendedor.Pessoa.Nome;
                    }
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnPesqVendedor.Click += new EventHandler(btnPesqVendedor_Click);
            }
        }

        private void btnPesqProduto_Click(object sender, EventArgs e)
        {

            try
            {
                btnPesqProduto.Click -= new EventHandler(btnPesqProduto_Click);
                if (txtCliente.VMPesquisaValor == null || txtVendedor.VMPesquisaValor == null)
                {
                    ExibirMensagem("Não é possível inserir produto enquanto cliente e vendedor estiver vazio!");
                }
                using (MOD001.FRM023 frm023 = new MOD001.FRM023(txtProduto.Text, null))
                {
                    if (frm023.ShowDialog() == DialogResult.OK)
                    {
                        txtProduto.VMPesquisaValor = frm023.produto;
                        txtProduto.Text = frm023.produto.Descricao;
                    }
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnPesqProduto.Click += new EventHandler(btnPesqProduto_Click);
            }
        }

        private void txtProduto_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                txtProduto.KeyDown -= new KeyEventHandler(txtProduto_KeyDown);
                if (e.KeyCode == Keys.Enter)
                {
                    btnPesqProduto_Click(null, null);
                    this.produto = txtProduto.VMPesquisaValor as Produto;
                }
                else if (e.KeyCode == Keys.Delete)
                {
                    this.txtProduto.VMPesquisaValor = null;
                    txtProduto.Clear();
                    txtProduto.Focus();
                    this.produto = null;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                txtProduto.KeyDown += new KeyEventHandler(txtProduto_KeyDown);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                btnSalvar.Click -= new EventHandler(btnSalvar_Click);
                if (this.pedidoItemCollection.Count <= 0)
                {
                    ExibirMensagemErro("Não nenhum produto para ser registrado!");
                    txtProduto.Focus();
                    return;
                }
                this.pedido.Cliente = txtCliente.VMPesquisaValor as Cliente;
                this.pedido.Vendedor = txtVendedor.VMPesquisaValor as Vendedor;
                this.pedido.DataPedido = DateTime.Now;
                this.pedido.ValorTotal = Convert.ToDecimal(txtValorTotal.Text);
                rbtTipoPedido_CheckedChanged(null, null);
                int resultado;
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[5];
                args[0] = "SalvarPedido";
                args[1] = this.pedido;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                if (int.TryParse(mensagembackgroundWor, out resultado))
                {
                    this.pedido.IDPedido = resultado;
                    while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                    args = new object[3];
                    args[0] = "SalvarItemPedido";
                    args[1] = this.pedidoItemCollection;
                    args[2] = resultado;
                    backgroundWorker1.RunWorkerAsync(args);
                    while (backgroundWorker1.IsBusy) { Application.DoEvents(); }

                    if (int.TryParse(mensagembackgroundWor, out resultado))
                    {
                        ExibirMensagem(String.Format("O {0} foi registrado com sucesso!", this.pedido.OpercaoSituacao.Operacao.Descricao));
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                        ExibirMensagemErro(String.Format("Não foi possível registrar o {0}.", this.pedido.OpercaoSituacao.Operacao.Descricao));
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnSalvar.Click += new EventHandler(btnSalvar_Click);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {

            try
            {
                btnInserir.Click -= new EventHandler(btnInserir_Click);
                if (txtProduto.VMPesquisaValor == null)
                {
                    ExibirMensagem("Nenhum produto selecioando!");
                    txtProduto.Focus();
                    return;
                }

                this.pedidoItem.Produto = new Produto();
                this.pedidoItem.Produto = this.produto;
                this.pedidoItem.Quantidade = Convert.ToDecimal(txtQuantidade.Text);

                AtualizarGrid(this.pedidoItem, false);
                limparAdicionar();
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

        void limparAdicionar()
        {
            this.txtProduto.VMPesquisaValor = null;
            txtProduto.Clear();
            txtQuantidade.Clear();
            txtProduto.Focus();
        }
        private void txtQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    btnInserir_Click(null, null);
            }
            catch (Exception ex)
            {

                Exceptionerro(ex);
            }
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                btnAlterar.Click -= new EventHandler(btnAlterar_Click);

                PedidoItem ItemSelecionado = dgwColecao.GetlinhaSelecionado<PedidoItem>();

                if (ItemSelecionado == null)
                {
                    ExibirMensagem("Nenhum item selecioando!");
                    return;
                }

                //PedidoItem t = (from c in pedidoItemCollection where c.Produto == ItemSelecionado.Produto select c).First();
                this.produto = ItemSelecionado.Produto;
                txtProduto.VMPesquisaValor = this.produto;
                txtProduto.Text = this.produto.Descricao;
                txtQuantidade.Text = ItemSelecionado.Quantidade.ToString();

                AtualizarGrid(ItemSelecionado, true);
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
                PedidoItem itemSelecionado = dgwColecao.GetlinhaSelecionado<PedidoItem>();
                if (itemSelecionado == null)
                {
                    ExibirMensagem("Nenhum produto foi selecionado!");
                    return;
                }
                if (ExibirMensagemPergunta("Deseja excluir o produto do","ttt") != DialogResult.Yes)
                    return;

                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[3];
                args[0] = "ExcluirItemPedido";
                args[1] = this.pedido.IDPedido;
                args[2] = itemSelecionado.Produto.IDProduto;
                backgroundWorker1.RunWorkerAsync(args);
                int resultado;
                if (int.TryParse(mensagembackgroundWor, out resultado))
                {
                    pedidoItemCollection.Remove(itemSelecionado);
                    AtualizarGrid(itemSelecionado, true);
                }
                else
                {
                    ExibirMensagemErro("Não foi possível excluir produto!");
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

        private void rbtTipoPedido_CheckedChanged(object sender, EventArgs e)
        {
            this.pedido.TipoPedido = new TipoPedido();
            if (rbtOrcamento.Checked)
            {
                this.pedido.TipoPedido.IDTipoPedido = (int)EnumTipoPedido.ORÇAMENTO;
                this.pedido.TipoPedido.Descricao = EnumTipoPedido.ORÇAMENTO.ToString();
                this.pedido.OpercaoSituacao = new OperacaoSituacao
                {
                    Operacao = new Operacao
                    {
                        IDOperacao = (int)EnumOperacao.ORÇAMENTO,
                        Descricao = EnumOperacao.ORÇAMENTO.ToString()

                    },
                    Situacao = new Situacao
                    {
                        IDSituacao = (int)EnumSituacao.ABERTO,
                        Descricao = EnumSituacao.ABERTO.ToString()
                    }
                };

            }
            else if (rbtPedido.Checked)
            {
                this.pedido.TipoPedido.IDTipoPedido = (int)EnumTipoPedido.PEDIDO;
                this.pedido.TipoPedido.Descricao = EnumTipoPedido.PEDIDO.ToString();
                this.pedido.OpercaoSituacao = new OperacaoSituacao
                {
                    Operacao = new Operacao
                    {
                        IDOperacao = (int)EnumOperacao.VENDA,
                        Descricao = EnumOperacao.VENDA.ToString()
                    },
                    Situacao = new Situacao
                    {
                        IDSituacao = (int)EnumSituacao.ABERTO,
                        Descricao = EnumSituacao.ABERTO.ToString()
                        
                    }
                };
            }
        }
        #endregion
        #region BackGroundWork

        string mensagembackgroundWor;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            mensagembackgroundWor = string.Empty;
            object[] args = (object[])e.Argument;

            if (args[0].Equals("SalvarPedido"))
            {
                if (this.acao == Acao.INSERIR)
                    this.mensagembackgroundWor = negPedido.Inserir(args[1] as Pedido);
                else if (this.acao == Acao.ALTERAR)
                    this.mensagembackgroundWor = negPedido.Alterar(args[1] as Pedido);
            }
            else if (args[0].Equals("SalvarItemPedido"))
            {
                if (this.acao == Acao.INSERIR)
                    this.mensagembackgroundWor = negPedidoItem.Inserir(args[1] as PedidoItemCollection, (int)args[2]);
                else if (this.acao == Acao.ALTERAR)
                    this.mensagembackgroundWor = negPedidoItem.Alterar(args[1] as PedidoItemCollection, (int)args[2]);
            }
            else if (args[0].Equals("PesquisarItemPedido"))
            {
                this.pedidoItemCollection = negPedidoItem.PesquisarItemPedido((int)args[1]);
            }
            else if (args[0].Equals("ExcluirItemPedido"))
            {
                this.mensagembackgroundWor = negPedidoItem.Excluir((int)args[1], (int)args[2]);
            }
        }

        #endregion
    }
}
