using SlnEstagio.Negocio;
using SlnEstagio.ObjetoTransferencia;
using SlnEstagio.WINBASE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlnEstagio.MOD003
{
    public partial class FRM004 : FRMBASE
    {
        #region Forms
        ContasPagar contasPagar = new ContasPagar();
        ContasPagarCollection contasPagarCollection = new ContasPagarCollection();
        NegContasPagar negContasPagar = new NegContasPagar();
        string IdSituacaoVarios = string.Empty;
        public Fornecedor fornecedor { get; set; }
        public FRM004()
        {
            InitializeComponent();
            carregarColunas();
        }
        private void FRM004_Shown(object sender, EventArgs e)
        {
            try
            {
                negContasPagar.CarregarComboBoxOperacao(checkedListBox1);
            }
            catch (Exception ex)
            {

                Exceptionerro(ex);
            }
        }
        private void AtualizarGrid(ContasPagar ContasPagar, bool booExcluir)
        {
            try
            {
                object FiltroExcluir = null;

                if (booExcluir)
                {
                    FiltroExcluir = (LocalizarFiltroExcluir(dgwColecao) as ContasPagar).GetChavePrimaria();
                    dgwColecao.DataSource = null;
                    contasPagarCollection.Remove(ContasPagar);
                }
                else
                {
                    if (ContasPagar != null)
                    {
                        var Item = from p in contasPagarCollection
                                   where p.GetChavePrimaria() == ContasPagar.GetChavePrimaria()
                                   select p;

                        if (Item.Count() == 1)
                        {
                            ContasPagar ContasPagarSelecionado = Item.First();
                            ContasPagarSelecionado = ContasPagar;
                        }
                        else
                            contasPagarCollection.Add(ContasPagar);
                    }
                    else
                    {

                        StringBuilder stb = new StringBuilder();
                        foreach (DictionaryEntry item in checkedListBox1.CheckedItems)
                        {
                            if (stb.Length > 0)
                                stb.Append(";");

                            stb.Append(item.Value.ToString());
                        }
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                        object[] args = new object[8];
                        args[0] = "ConsultarContasPagar";
                        args[1] = dtpDataInicial.Value;
                        args[2] = dtpDataFinal.Value;
                        args[3] = this.txtFornecedor.VMPesquisaValor == null ? (int?)null : (txtFornecedor.VMPesquisaValor as Fornecedor).Pessoa.IDPessoa;
                        args[4] = txtcodigo.Text.Equals("0") ? (int?)null : Convert.ToInt32(txtcodigo.Text);
                        args[5] = stb.ToString();
                        backgroundWorker1.RunWorkerAsync(args);
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                    }
                }

                dgwColecao.DataSource = null;
                if (contasPagarCollection.Count() > 0)
                    dgwColecao.DataSource = contasPagarCollection.ToList<ContasPagar>();

                txtRegistro.Text = dgwColecao.Rows.Count.ToString();
                txtValorTotal.Text = contasPagarCollection.Sum(t => t.Valor).ToString();

                //if (objContasPagar != null)
                //    LocalizarIndexLinha(dgwColecao, FiltroExcluir == null ? objContasPagar.GetChavePrimaria() : FiltroExcluir);

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
        void carregarColunas()
        {
            AdicionarColunaTextBoxGrid(dgwColecao, "IDContasPagar", "Código", "Código do Contas a Pagar", null, 60, DataGridViewContentAlignment.MiddleRight, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "DataLancamento", "Dt. Lanç.", "Data de Lançamento do Contas a Pagar", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "DataVencimento", "Dt. Venc.", "Data de Vencimento do Contas a Pagar", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "DataPagamento", "Dt. Pag.", "Data de Pagamento do Contas a Pagar", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Valor", "V.Total", "Valor Total do Contas a Pagar", null, 100, DataGridViewContentAlignment.MiddleRight, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Fornecedor.Pessoa.IDPessoa", "Cód.", "Código do Fornecedor", null, 60, DataGridViewContentAlignment.MiddleRight, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Fornecedor.Pessoa.Nome", "Nome do Fornecedor", "Nome do Fornecedor", null, 350, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "OperacaoSituacao.Situacao.Descricao", "Situação", "Situação do Contas a Pagar", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "ContasPagarTipo.IDContasPagarTipo", "Tipo", "Tipo de Contas a Pagar", null, 60, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "ContasPagarTipo.Descricao", "Desc.Tipo", "Descrição do Tipo de Contas a Pagar", null, 250, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            //AdicionarColunaTextBoxGrid(dgwColecao, "TipoPedido.Descricao", "Tipo", "Tipo do Pedido", null, 250, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
        }
        #endregion
        #region Controles
        private void btnExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                btnExcluir.Click -= new EventHandler(btnExcluir_Click);

                ContasPagar contasPagarSelecionado = dgwColecao.GetlinhaSelecionado<ContasPagar>();

                if (contasPagarSelecionado == null)
                    return;

                if(contasPagarSelecionado.OperacaoSituacao.Situacao.IDSituacao == (int)EnumSituacao.PAGO)
                {
                    ExibirMensagemAlerta("Não é possível excluir uma conta na situação Paga!");
                    return;
                }

                if (contasPagarSelecionado.OperacaoSituacao.Situacao.IDSituacao == (int)EnumSituacao.EXCLUÍDO)
                {
                    ExibirMensagemAlerta("Não é possível excluir uma conta na situação Excluído!");
                    return;
                }

                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[2];
                args[0] = "ExcluirContasPagar";
                args[1] = contasPagarSelecionado.IDContasPagar;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int retorno;
                if (int.TryParse(mensagembackgroundWor, out retorno))
                {
                    ExibirMensagem("Contas a Pagar foi excluída com sucesso!");
                    AtualizarGrid(contasPagarSelecionado, true);
                }
                else
                {
                    ExibirMensagemErro("Não foi possível excluir está contas a pagar!");
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
        private void btnInserir_Click(object sender, EventArgs e)
        {

            try
            {
                btnInserir.Click -= new EventHandler(btnInserir_Click);

                using (MOD003.FRM005 frm005 = new FRM005(new ContasPagar(), Acao.INSERIR))
                {
                    if (frm005.ShowDialog() == DialogResult.OK)
                        AtualizarGrid(frm005.ContasPagar, false);
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                btnAlterar.Click -= new EventHandler(btnAlterar_Click);

                ContasPagar contasPagarSelecionado = dgwColecao.GetlinhaSelecionado<ContasPagar>();

                if (contasPagarSelecionado == null)
                    return;

                if (contasPagarSelecionado.OperacaoSituacao.Situacao.IDSituacao == (int)EnumSituacao.PAGO)
                {
                    ExibirMensagemAlerta("Não é possível alterar uma conta na situação Paga!");
                    return;
                }

                if (contasPagarSelecionado.OperacaoSituacao.Situacao.IDSituacao == (int)EnumSituacao.EXCLUÍDO)
                {
                    ExibirMensagemAlerta("Não é possível alterar uma conta a pagar na situação Excluído!");
                    return;
                }

                using (FRM005 frm005 = new FRM005(contasPagarSelecionado, Acao.ALTERAR))
                {
                    if (frm005.ShowDialog() == DialogResult.OK)
                        AtualizarGrid(frm005.ContasPagar, false);
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
        private void btnPesqFornecedor_Click(object sender, EventArgs e)
        {

            try
            {
                btnPesqFornecedor.Click -= new EventHandler(btnPesqFornecedor_Click);

                using (MOD003.FRM006 frm006 = new FRM006(txtFornecedor.Text))
                {
                    if (frm006.ShowDialog() == DialogResult.OK)
                    {
                        this.txtFornecedor.VMPesquisaValor = frm006.Fornecedor;
                        this.txtFornecedor.Text = frm006.Fornecedor.Pessoa.Nome;
                    }
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnPesqFornecedor.Click += new EventHandler(btnPesqFornecedor_Click);
            }
        }

        private void txtFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                txtFornecedor.KeyDown -= new KeyEventHandler(txtFornecedor_KeyDown);
                if (e.KeyCode == Keys.Enter && btnPesqFornecedor.Enabled == true)
                    btnPesqFornecedor_Click(null, null);
                else if (e.KeyCode == Keys.Delete && btnPesqFornecedor.Enabled == false)
                {
                    txtFornecedor.Clear();
                    txtFornecedor.VMPesquisaValor = null;
                    txtFornecedor.Focus();
                }
            }
            catch (Exception ex)
            {

                Exceptionerro(ex);
            }
            finally
            {
                txtFornecedor.KeyDown += new KeyEventHandler(txtFornecedor_KeyDown);
            }
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEfetuarPagamento_Click(object sender, EventArgs e)
        {

            try
            {
                btnEfetuarPagamento.Click -= new EventHandler(btnEfetuarPagamento_Click);

                ContasPagar contasPagarSel = dgwColecao.GetlinhaSelecionado<ContasPagar>();

                if (contasPagarSel.OperacaoSituacao.Situacao.IDSituacao == (int)EnumSituacao.EXCLUÍDO)
                {
                    ExibirMensagemAlerta("Não é possível efetuar baixa de conta a pagar na situação Excluído!");
                    return;
                }
                if (contasPagarSel.OperacaoSituacao.Situacao.IDSituacao == (int)EnumSituacao.PAGO)
                {
                    //ExibirMensagemAlerta("Não é possível efetuar baixa de conta a pagar na situação Excluído!");
                    return;
                }


                if (contasPagarSel == null)
                    return;

                using (MOD003.FRM008 frm008 = new FRM008(contasPagarSel))
                {
                    if (frm008.ShowDialog() == DialogResult.OK)
                    {
                        AtualizarGrid(frm008.ContasPagar, false);
                    }
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnEfetuarPagamento.Click += new EventHandler(btnEfetuarPagamento_Click);
            }
        }
        #endregion
        #region BackGroundWork
        string mensagembackgroundWor;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("ConsultarContasPagar"))
            {
                this.contasPagarCollection = negContasPagar.Pesquisar((int?)args[4], (int?)args[3], (DateTime?)args[1], (DateTime?)args[2], args[5].ToString());
            }
            else if (args[0].Equals("ExcluirContasPagar"))
            {
                this.mensagembackgroundWor = this.negContasPagar.Excluir((int)args[1]);
            }
        }
        #endregion

        
    }
}
