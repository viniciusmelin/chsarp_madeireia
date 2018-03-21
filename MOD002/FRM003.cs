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

namespace SlnEstagio.MOD002
{
    public partial class FRM003 : FRMBASE
    {
        NegPedidoItem negPedidoItem = new NegPedidoItem();
        PedidoItemCollection pedidoItemCollection = new PedidoItemCollection();
        private Pedido pedido;
        public FRM003()
        {
            InitializeComponent();
        }

        public FRM003(Pedido pedido)
        {
            InitializeComponent();
            this.pedido = pedido;
            carregarColunas();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void carregarColunas()
        {
            AdicionarColunaTextBoxGrid(dgwColecao, "Produto.IDProduto", "Código", "Código do Produto", null, 60, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Produto.Descricao", "Descrição", "Descrição do Produto", null, 250, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Produto.Preco", "Valor", "Valor do Produto", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Quantidade", "Quantidade", "Quantidade do Produto", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Produto.Cubagem", "Cubagem", "Cubagem do Produto", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("PesquisarItemPedido"))
            {
                this.pedidoItemCollection = negPedidoItem.PesquisarItemPedido((int)args[1]);
            }
        }

        private void FRM003_Shown(object sender, EventArgs e)
        {
            txtPedido.Text = this.pedido.GetChavePrimaria();
            txtNomeCliente.Text = this.pedido.Cliente.Pessoa.Nome;

            AtualizarGrid(null, false);
        }


        private void AtualizarGrid(PedidoItem PedidoItem, bool booExcluir)
        {
            try
            {
                object FiltroExcluir = null;

                if (booExcluir)
                {
                    FiltroExcluir = (LocalizarFiltroExcluir(dgwColecao) as PedidoItem).GetChavePrimaria();
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
                    else
                    {
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                        object[] args = new object[2];
                        args[0] = "PesquisarItemPedido";
                        args[1] = this.pedido.IDPedido;
                        backgroundWorker1.RunWorkerAsync(args);
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                    }
                }

                dgwColecao.DataSource = null;
                if (pedidoItemCollection.Count() > 0)
                    dgwColecao.DataSource = pedidoItemCollection.ToList<PedidoItem>();

                txtRegistros.Text = dgwColecao.Rows.Count.ToString();

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
    }
}
