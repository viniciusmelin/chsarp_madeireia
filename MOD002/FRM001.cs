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
using SlnEstagio.ObjetoTransferencia;
using SlnEstagio.Negocio;
using System.Collections;

namespace SlnEstagio.MOD002
{
    public partial class FRM001 : FRMBASE
    {
        #region Forms
        MODRELATORIO.Relatorio relatorio = new MODRELATORIO.Relatorio();
        Pedido pedido = new Pedido();
        PedidoCollection pedidoCollection = new PedidoCollection();
        NegPedido negPedido = new NegPedido();
        NegSituacaoOperacao negSituacaoOperacao = new NegSituacaoOperacao();
        Vendedor vendedor = new Vendedor();
        DataSet dataSet = new DataSet();
        private EnumSituacao Situacao { get; set; }
        public FRM001()
        {
            InitializeComponent();
            negSituacaoOperacao.CarregarComboList(this.cbxOperacao, this.checkedListBox1);

            carregarColunas();
        }
        void carregarColunas()
        {
            AdicionarColunaTextBoxGrid(dgwColecao, "IDPedido", "Código", "Código do Pedido", null, 60, DataGridViewContentAlignment.MiddleRight, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "DataPedido", "Dt. Pedido", "Data de Cadastro do Pedido", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "ValorTotal", "Valot Total", "Valor Total do Pedido", null, 100, DataGridViewContentAlignment.MiddleRight, DataGridViewContentAlignment.MiddleRight);
            AdicionarColunaTextBoxGrid(dgwColecao, "Cliente.Pessoa.IDPessoa", "Cód.", "Código do Cliente", null, 60, DataGridViewContentAlignment.MiddleRight, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Cliente.Pessoa.Nome", "Nome do Cliente", "Nome do Cliente", null, 250, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Vendedor.Pessoa.IDPessoa", "Cód.", "Código do Vendedor", null, 60, DataGridViewContentAlignment.MiddleRight, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Vendedor.Pessoa.Nome", "Nome do Vendedor", "Nome do Vendedor", null, 250, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "OpercaoSituacao.Operacao.Descricao", "Operação", "Operação do Pedido", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "OpercaoSituacao.Situacao.Descricao", "Situação", "Situação do Pedido", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            //AdicionarColunaTextBoxGrid(dgwColecao, "TipoPedido.Descricao", "Tipo", "Tipo do Pedido", null, 250, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
        }

        private void AtualizarGrid(Pedido Pedido, bool booExcluir)
        {
            try
            {
                object FiltroExcluir = null;

                if (booExcluir)
                {
                    FiltroExcluir = (LocalizarFiltroExcluir(dgwColecao) as Pedido).GetChavePrimaria();
                    dgwColecao.DataSource = null;
                    pedidoCollection.Remove(Pedido);
                }
                else
                {
                    if (Pedido != null)
                    {
                        var Item = from p in pedidoCollection
                                   where p.GetChavePrimaria() == Pedido.GetChavePrimaria()
                                   select p;

                        if (Item.Count() == 1)
                        {
                            Pedido PedidoSelecionado = Item.First();
                            PedidoSelecionado = Pedido;
                        }
                        else
                            pedidoCollection.Add(Pedido);
                    }
                    else
                    {
                        StringBuilder stbSituacao = new StringBuilder();
                        foreach (DictionaryEntry item in checkedListBox1.CheckedItems)
                        {
                            if (stbSituacao.Length > 0)
                                stbSituacao.Append(";");

                            stbSituacao.Append(item.Value.ToString());
                        }
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                        object[] args = new object[10];
                            /*
                             * 1 pedido
                             * 2 dt inicial
                             * 3 dt final
                             * 4 idcliente
                             * 5 idvendedor
                             * 6 idoperacao
                             * 7 idsituacao
                             */
                            args[0] = "ConsultarPedido";
                            args[1] = txtpedido.Text == "0" ? (int?)null : Convert.ToInt32(txtpedido.Text);
                            args[2] = dtpDataInicial.Value;
                            args[3] = dtpDataFinal.Value;
                            args[4] = txtCliente.VMPesquisaValor == null ? (int?)null : (txtCliente.VMPesquisaValor as Cliente).Pessoa.IDPessoa;
                            args[5] = txtVendedor.VMPesquisaValor == null ? (int?)null : (txtVendedor.VMPesquisaValor as Vendedor).Pessoa.IDPessoa;
                            args[6] = cbxOperacao.SelectedValue;
                            args[7] = stbSituacao.ToString();

                        backgroundWorker1.RunWorkerAsync(args);
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                    }
                }

                dgwColecao.DataSource = null;
                if (pedidoCollection.Count() > 0)
                    dgwColecao.DataSource = pedidoCollection.ToList<Pedido>();

                txtRegistros.Text = dgwColecao.Rows.Count.ToString();
                txtValorTotal.Text = this.pedidoCollection.Sum(t => t.ValorTotal).ToString();

                //if (objPedido != null)
                //    LocalizarIndexLinha(dgwColecao, FiltroExcluir == null ? objPedido.GetChavePrimaria() : FiltroExcluir);

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
        private void btnItens_Click(object sender, EventArgs e)
        {

            try
            {
                btnItens.Click -= new EventHandler(btnItens_Click);
                Pedido pedidoSelecionado = dgwColecao.GetlinhaSelecionado<Pedido>();
                if (pedidoSelecionado == null)
                {
                    ExibirMensagem("Nenhum pedido selecionado!");
                    return;
                }

                using (MOD002.FRM003 frm003 = new FRM003(pedidoSelecionado))
                {
                    frm003.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnItens.Click += new EventHandler(btnItens_Click);
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                btnAlterar.Click -= new EventHandler(btnAlterar_Click);
                Pedido pedidoSelecionado = dgwColecao.GetlinhaSelecionado<Pedido>();

                if (pedidoSelecionado == null)
                    return;
                if (pedidoSelecionado.OpercaoSituacao.Situacao.IDSituacao != (int)EnumSituacao.ABERTO)
                {
                    ExibirMensagem("Não é possível alterar pedido que não esteja aberto");
                    return;
                }


                using (SlnEstagio.MOD002.FRM002 frm002 = new FRM002(pedidoSelecionado, Acao.ALTERAR))
                {
                    if (frm002.ShowDialog() == DialogResult.OK)
                    {
                        this.pedido = frm002.pedido;
                        AtualizarGrid(this.pedido, false);
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
                using (SlnEstagio.MOD002.FRM002 frm002 = new FRM002(new Pedido(), Acao.INSERIR))
                {
                    if (frm002.ShowDialog() == DialogResult.OK)
                    {
                        this.pedido = frm002.pedido;
                        AtualizarGrid(this.pedido, false);
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                btnExcluir.Click -= new EventHandler(btnExcluir_Click);
                Pedido pedidoSelecionado = dgwColecao.GetlinhaSelecionado<Pedido>();

                if (pedidoSelecionado == null)
                    return;

                if (pedidoSelecionado.OpercaoSituacao.Situacao.IDSituacao == (int)EnumSituacao.EXCLUÍDO)
                {
                    ExibirMensagem("Não é possível excluir!");
                    return;
                }

                if (pedidoSelecionado.OpercaoSituacao.Situacao.IDSituacao == (int)EnumSituacao.FINALIZADO)
                {
                    if (ExibirMensagemPergunta("Deseja excluir o pedido selecionado?.", "EXCLUIR PEDIDO") != DialogResult.Yes)
                        return;

                    this.Situacao = EnumSituacao.EXCLUÍDO;
                }

                if (pedidoSelecionado.OpercaoSituacao.Situacao.IDSituacao == (int)EnumSituacao.ABERTO)
                {
                    if (ExibirMensagemPergunta("Deseja excluir o pedido selecionado?", "EXCLUIR PEDIDO") != DialogResult.Yes)
                        return;

                    this.Situacao = EnumSituacao.EXCLUÍDO;
                }

                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[6];
                args[0] = "AlterarSituacaoPedido";
                args[1] = pedidoSelecionado.IDPedido;
                args[2] = pedidoSelecionado.OpercaoSituacao.Situacao.IDSituacao;
                args[3] = (int)this.Situacao;
                args[4] = pedidoSelecionado.OpercaoSituacao.Operacao.IDOperacao;
                args[5] = (int?)null;
                backgroundWorker1.RunWorkerAsync(args);
                int retorno;
                if (int.TryParse(mensagembackgroundWor, out retorno))
                {
                    ExibirMensagem("Pedido foi excluído com sucesso.");
                    AtualizarGrid(pedidoSelecionado, false);
                }
                else
                {
                    ExibirMensagemErro("Não foi possível mudar situação! \n Motivo: "+ mensagembackgroundWor);
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesqCliente_Click(object sender, EventArgs e)
        {

            try
            {
                btnPesqCliente.Click -= new EventHandler(btnPesqCliente_Click);
                using (SlnEstagio.MOD001.FRM020 frm020 = new MOD001.FRM020(txtCliente.Text, null))
                {
                    if (frm020.ShowDialog() == DialogResult.OK)
                        txtCliente.VMPesquisaValor = frm020.cliente;
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
            if (e.KeyValue.Equals(Keys.Enter))
            {
                btnPesqCliente_Click(null, null);
                txtCliente.Text = (txtCliente.VMPesquisaValor as Cliente).Pessoa.Nome;
            }
            else if (e.KeyValue.Equals(Keys.Delete))
            {
                txtCliente.VMPesquisaValor = null;
                txtCliente.Clear();
                txtCliente.Focus();
            }
        }

        private void txtVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(Keys.Enter))
            {
                btnPesqCliente_Click(null, null);
                txtVendedor.Text = (txtVendedor.VMPesquisaValor as Vendedor).Pessoa.Nome;
            }
            else if (e.KeyValue.Equals(Keys.Delete))
            {
                txtVendedor.VMPesquisaValor = null;
                txtVendedor.Clear();
                txtVendedor.Focus();
            }
        }

        private void btnPesqVendedor_Click(object sender, EventArgs e)
        {

            try
            {
                btnPesqVendedor.Click -= new EventHandler(btnPesqVendedor_Click);
                using (SlnEstagio.MOD001.FRM021 frm021 = new MOD001.FRM021(txtVendedor.Text, null))
                {
                    if (frm021.ShowDialog() == DialogResult.OK)
                        this.vendedor = frm021.vendedor;
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
        private void btnSitucao_Click(object sender, EventArgs e)
        {

            try
            {
                btnSitucao.Click -= new EventHandler(btnSitucao_Click);
                Pedido pedidoSelecioando = dgwColecao.GetlinhaSelecionado<Pedido>();
                if (pedidoSelecioando == null)
                {
                    ExibirMensagem("Nenhum pedido foi selecioando!");
                    return;
                }

                if (pedidoSelecioando.OpercaoSituacao.Situacao.IDSituacao == (int)EnumSituacao.EXCLUÍDO)
                {
                    if (ExibirMensagemPergunta("Deseja mudar a situação de Excluído para Aberto?", "Mudar Situação") != DialogResult.Yes)
                        return;
                    this.Situacao = EnumSituacao.ABERTO;
                }

                if (pedidoSelecioando.OpercaoSituacao.Situacao.IDSituacao == (int)EnumSituacao.ABERTO)
                {
                    if (ExibirMensagemPergunta("Deseja mudar a situação de Aberto para Finalizado?", "Mudar Situação") != DialogResult.Yes)
                        return;
                    this.Situacao = EnumSituacao.FINALIZADO;
                }
                if (pedidoSelecioando.OpercaoSituacao.Situacao.IDSituacao == (int)EnumSituacao.FINALIZADO)
                {
                    if (ExibirMensagemPergunta("Deseja mudar a situação de Finalizado para ABERTO?", "Mudar Situação") != DialogResult.Yes)
                        return;
                    this.Situacao = EnumSituacao.ABERTO;
                }
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[6];
                args[0] = "AlterarSituacaoPedido";
                args[1] = pedidoSelecioando.IDPedido;
                args[2] = pedidoSelecioando.OpercaoSituacao.Situacao.IDSituacao;
                args[3] = (int)this.Situacao;
                args[4] = pedidoSelecioando.OpercaoSituacao.Operacao.IDOperacao;
                args[5] = (int?)null;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int retorno;
                if (int.TryParse(mensagembackgroundWor, out retorno))
                {
                    ExibirMensagem(string.Format("{0} foi alterada com sucesso!", pedidoSelecioando.OpercaoSituacao.Operacao.Descricao));
                }
                else
                {
                    ExibirMensagemErro(string.Format("Não foi possível alterar {0}! \n Motivo: {1}", pedidoSelecioando.OpercaoSituacao.Operacao.Descricao, mensagembackgroundWor));
                }

            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnSitucao.Click += new EventHandler(btnSitucao_Click);
            }
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {

            try
            {
                btnImprimir.Click -= new EventHandler(btnImprimir_Click);

                Pedido pedidoSelecionado = dgwColecao.GetlinhaSelecionado<Pedido>();
                if (pedidoSelecionado == null)
                    return;
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[2];
                args[0] = "ImprimirRelatorio";
                args[1] = pedidoSelecionado.IDPedido;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }

            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnImprimir.Click += new EventHandler(btnImprimir_Click);
            }
        }
        void SetarParametos()
        {
            relatorio.CaminhoRelatorio = "MODRELATORIO.RLDC.REL002.rdlc";
            relatorio.AdicionarParametro("NomeSistema", "BIRA MADEIRAS");
            relatorio.AdicionarParametro("NomeModulo", "VENDAS");
            relatorio.AdicionarParametro("NumeroRelatorio", "002");
            relatorio.AdicionarParametro("Titulo", "PRODUTOS");
            relatorio.AdicionarParametro("SubTitulo", "PRODUTOS");
        }
        #endregion
        #region BackGroundWork
        string mensagembackgroundWor;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            /*
             * 1 pedido
             * 2 dt inicial
             * 3 dt final
             * 4 idcliente
             * 5 idvendedor
             * 6 idoperacao
             * 7 idsituacao
             */
            object[] args = (object[])e.Argument;

            if (args[0].Equals("ExcluirPedido"))
            {
                this.mensagembackgroundWor = string.Empty;
                this.mensagembackgroundWor = negPedido.Excluir(args[1] as Pedido);
            }
            else if (args[0].Equals("ConsultarPedido"))
            {
                this.pedidoCollection = negPedido.ConsultarPedido((int?)args[1], (DateTime?)args[2], (DateTime?)args[3], (int?)args[4], (int?)args[5], (int?)args[6], args[7].ToString());
            }
            else if (args[0].Equals("AlterarSituacaoPedido"))
            {
                /*
                args[0] = "AlterarSituacaoPedido";
                args[1] = pedidoSelecioando.IDPedido;
                args[2] = pedidoSelecioando.OpercaoSituacao.Situacao.IDSituacao;
                args[3] = (int)EnumSituacao.FINALIZADO;
                args[4] = pedidoSelecioando.OpercaoSituacao.Operacao.IDOperacao;
                args[5] = (int?)null;
                 */
                this.mensagembackgroundWor = negPedido.AlterarSituacao((int)args[1], (int)args[2], (int)args[3], (int)args[4], (int?)args[5]);
            }
            else if (args[0].Equals("ImprimirRelatorio"))
            {
                this.dataSet = negPedido.RelVendasImprimir((int)args[1]);
                this.relatorio.DataTable1 = this.dataSet.Tables[0];
                this.relatorio.DataTable2 = this.dataSet.Tables[1];
                this.relatorio.DataTable3 = this.dataSet.Tables[2];
                SetarParametos();
                relatorio.Imprimir();
            }
        }
        #endregion
    }
}
