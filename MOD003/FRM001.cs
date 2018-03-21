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
    public partial class FRM001 : FRMBASE
    {
        #region Forms
        public EnumSituacaoContasReceber Situacao { get; internal set; }
        ContasaReceber contasReceber = new ContasaReceber();
        ContasReceberCollection ContasReceberCollection = new ContasReceberCollection();
        NegContasReceber negContasReceber = new NegContasReceber();
        public FRM001()
        {
            InitializeComponent();
            carregarColunas();
        }
        void carregarColunas()
        {
            AdicionarColunaTextBoxGrid(dgwColecao, "IDContasaReceber", "Código", "Código do Contas a Receber", null, 60, DataGridViewContentAlignment.MiddleRight, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "DataLancamento", "Dt. Lanç.", "Data de Lançamento do Contas a Receber", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "DataVencimento", "Dt. Venc.", "Data de Vencimento do Contas a Receber", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "DataPagamento", "Dt. Pag.", "Data de Pagamento do Contas a Receber", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "ValorTotal", "V.Total", "Valor Total do Contas a Receber", null, 100, DataGridViewContentAlignment.MiddleRight, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Cliente.Pessoa.IDPessoa", "Cód.", "Código do Cliente", null, 60, DataGridViewContentAlignment.MiddleRight, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Cliente.Pessoa.Nome", "Nome do Cliente", "Nome do Cliente", null, 250, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Vendedor.Pessoa.IDPessoa", "Cód.", "Código do Vendedor", null, 60, DataGridViewContentAlignment.MiddleRight, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Vendedor.Pessoa.Nome", "Nome do Vendedor", "Nome do Vendedor", null, 250, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            //AdicionarColunaTextBoxGrid(dgwColecao, "ContasReceberSituacao.IDContasReceberSituacao", "Nome do Cliente", "Nome do Vendedor", null, 250, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "ContasReceberSituacao.Descricao", "Situação", "Situação da Conta", null, 80, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            //AdicionarColunaTextBoxGrid(dgwColecao, "TipoPedido.Descricao", "Tipo", "Tipo do Pedido", null, 250, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
        }
        private void AtualizarGrid(ContasaReceber ContasaReceber, bool booExcluir)
        {
            try
            {
                object FiltroExcluir = null;

                if (booExcluir)
                {
                    FiltroExcluir = (LocalizarFiltroExcluir(dgwColecao) as ContasaReceber).GetChavePrimaria();
                    dgwColecao.DataSource = null;
                    ContasReceberCollection.Remove(ContasaReceber);
                }
                else
                {
                    if (ContasaReceber != null)
                    {
                        var Item = from p in ContasReceberCollection
                                   where p.GetChavePrimaria() == ContasaReceber.GetChavePrimaria()
                                   select p;

                        if (Item.Count() == 1)
                        {
                            ContasaReceber ContasaReceberSelecionado = Item.First();
                            ContasaReceberSelecionado = ContasaReceber;
                        }
                        else
                            ContasReceberCollection.Add(ContasaReceber);
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

                        object[] args = new object[7];
                        args[0] = "ConsultarContasaReceber";
                        args[1] = dtpDataInicial.Value;
                        args[2] = dtpDataFinal.Value;
                        args[3] = txtCliente.VMPesquisaValor == null ? (int?)null : (txtCliente.VMPesquisaValor as Cliente).Pessoa.IDPessoa;
                        args[4] = txtVendedor.VMPesquisaValor == null ? (int?)null : (txtVendedor.VMPesquisaValor as Vendedor).Pessoa.IDPessoa;
                        args[5] = stb.ToString();
                        args[6] = txtcodigo.Text == "0" ? (int?)null : Convert.ToInt32(txtcodigo.Text);

                        backgroundWorker1.RunWorkerAsync(args);
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                    }
                }

                dgwColecao.DataSource = null;
                if (ContasReceberCollection.Count() > 0)
                    dgwColecao.DataSource = ContasReceberCollection.ToList<ContasaReceber>();

                txtRegistro.Text = dgwColecao.Rows.Count.ToString();
                txtValorTotal.Text = ContasReceberCollection.Sum(t => t.ValorTotal).ToString();

                //if (objContasaReceber != null)
                //    LocalizarIndexLinha(dgwColecao, FiltroExcluir == null ? objContasaReceber.GetChavePrimaria() : FiltroExcluir);

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
        private void FRM001_Shown(object sender, EventArgs e)
        {
            try
            {
                negContasReceber.CarregarComboBox(checkedListBox1);
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

        private void btnInserir_Click(object sender, EventArgs e)
        {

            try
            {
                btnInserir.Click -= new EventHandler(btnInserir_Click);
                using (MOD003.FRM002 frm002 = new FRM002(null, Acao.INSERIR))
                {
                    if (frm002.ShowDialog() == DialogResult.OK)
                    {
                        this.contasReceber = frm002.contasReceber;
                        AtualizarGrid(this.contasReceber, false);
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
        private void btnSituacao_Click(object sender, EventArgs e)
        {

            try
            {
                btnSituacao.Click -= new EventHandler(btnSituacao_Click);
                ContasaReceber contasReceberSelcionado = dgwColecao.GetlinhaSelecionado<ContasaReceber>();
                if (contasReceberSelcionado == null)
                {
                    ExibirMensagem("Nenhuma Contas a Receber foi selecionado!");
                    return;
                }

                if (contasReceberSelcionado.ContasReceberSituacao.IDContasReceberSituacao == (int)EnumSituacaoContasReceber.PAGA)
                {
                    if (ExibirMensagemPergunta("Deseja voltar a situação de PAGA para ABERTA?", "ALTERAR SITUAÇÃO") != DialogResult.Yes)
                        return;

                    this.Situacao = EnumSituacaoContasReceber.ABERTA;
                }

                if (contasReceberSelcionado.ContasReceberSituacao.IDContasReceberSituacao == (int)EnumSituacaoContasReceber.EXCLUÍDA)
                {
                    ExibirMensagem("Não é possível voltar Situação de EXCLUÍDA para ABERTO!");
                    return;
                }

                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[5];
                args[0] = "ALterarSituacao";
                args[1] = contasReceberSelcionado.IDContasaReceber;
                args[2] = contasReceberSelcionado.ContasReceberSituacao.IDContasReceberSituacao;
                args[3] = (int)this.Situacao;
                args[4] = (int?)null;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int resultado;
                if (int.TryParse(mensagembackgroundWor, out resultado))
                {
                    ExibirMensagem("A conta selecionado foi alterada com sucesso!");

                }
                else
                {
                    ExibirMensagemErro("Não foi possível alterar a conta selecionada!.\n Motivo: " + mensagembackgroundWor);
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnSituacao.Click += new EventHandler(btnSituacao_Click);
            }
        }

        private void btnEfetuarBaixa_Click(object sender, EventArgs e)
        {

            try
            {
                btnEfetuarBaixa.Click -= new EventHandler(btnEfetuarBaixa_Click);

                ContasaReceber contasReceberSelecionado = dgwColecao.GetlinhaSelecionado<ContasaReceber>();

                if (contasReceberSelecionado == null)
                {
                    ExibirMensagem("Nenhuma conta foi selecionada!");
                    return;
                }

                if (contasReceberSelecionado.ContasReceberSituacao.IDContasReceberSituacao != (int)EnumSituacaoContasReceber.ABERTA)
                {
                    ExibirMensagem("Só é possível BAIXAR contas na situação ABERTA!");
                    return;
                }

                using (MOD003.FRM003 frm003 = new FRM003(contasReceberSelecionado))
                {
                    if (frm003.ShowDialog() == DialogResult.OK)
                    {
                        this.contasReceber = frm003.contasReceber;
                        AtualizarGrid(this.contasReceber, false);
                    }
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnEfetuarBaixa.Click += new EventHandler(btnEfetuarBaixa_Click);
            }
        }
        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                btnExcluir.Click -= new EventHandler(btnExcluir_Click);
                ContasaReceber contasReceberSelecionado = dgwColecao.GetlinhaSelecionado<ContasaReceber>();
                if (contasReceberSelecionado == null)
                {
                    ExibirMensagem("Nenhum Contas a Receber foi selecionada!");
                    return;
                }

                if (contasReceberSelecionado.ContasReceberSituacao.IDContasReceberSituacao == (int)EnumSituacaoContasReceber.ABERTA)
                {
                    if (ExibirMensagemPergunta("Deseja excluir conta selecionada?", "ALTERAR SITUAÇÃO") != DialogResult.Yes)
                        return;
                    this.Situacao = EnumSituacaoContasReceber.EXCLUÍDA;
                }

                if (contasReceberSelecionado.ContasReceberSituacao.IDContasReceberSituacao == (int)EnumSituacaoContasReceber.EXCLUÍDA)
                {
                    ExibirMensagem("Não é possível excluir!");
                    return;
                }
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[5];
                args[0] = "ALterarSituacao";
                args[1] = contasReceberSelecionado.IDContasaReceber;
                args[2] = contasReceberSelecionado.ContasReceberSituacao.IDContasReceberSituacao;
                args[3] = (int)this.Situacao;
                args[4] = (int?)null;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int retorno;
                if (int.TryParse(mensagembackgroundWor, out retorno))
                {
                    ExibirMensagem("Contas a Receber foi excluída com sucesso!");
                    AtualizarGrid(contasReceberSelecionado, true);
                }
                else
                {
                    ExibirMensagemErro("Não foi possível excluir o contasr receber. Motivo: " + mensagembackgroundWor);
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                btnAlterar.Click -= new EventHandler(btnAlterar_Click);
                ContasaReceber contasReceberSelecionado = dgwColecao.GetlinhaSelecionado<ContasaReceber>();
                if (contasReceberSelecionado == null)
                {
                    ExibirMensagem("Nenhuma Contas a Receber foi selecionada");
                    return;
                }

                if (contasReceberSelecionado.ContasReceberSituacao.IDContasReceberSituacao == (int)EnumSituacaoContasReceber.EXCLUÍDA)
                {
                    ExibirMensagem("Não é possível ALTERAR!");
                    return;
                }
                if (contasReceberSelecionado.ContasReceberOrigem.IDContasReceberOrigem == (int)EnumContasReceberOrigem.AUTOMÁTICO)
                {
                    ExibirMensagem("Esta Contas a Receber não poder ser alterada!. \n Motivo : O lançamento foi feito AUTOMÁTICO.");
                    return;
                }

                using (MOD003.FRM002 frm002 = new FRM002(contasReceberSelecionado, Acao.ALTERAR))
                {
                    if (frm002.ShowDialog() == DialogResult.OK)
                    {
                        this.contasReceber = frm002.contasReceber;
                        AtualizarGrid(this.contasReceber, false);
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
        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                txtCliente.KeyDown -= new KeyEventHandler(txtCliente_KeyDown);
                if (e.KeyCode == Keys.Enter && btnPesqCliente.Enabled == true)
                    btnPesqCliente_Click(null, null);
                else if (e.KeyCode == Keys.Delete && btnPesqCliente.Enabled == true)
                {
                    txtCliente.Clear();
                    txtCliente.VMPesquisaValor = null;
                    txtCliente.Focus();
                }

            }
            catch (Exception ex)
            {

                Exceptionerro(ex);
            }
            finally
            {
                txtCliente.KeyDown -= new KeyEventHandler(txtCliente_KeyDown);
            }
        }

        private void txtVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                txtVendedor.KeyDown -= new KeyEventHandler(txtVendedor_KeyDown);

                if (e.KeyCode == Keys.Enter && btnPesqVendedor.Enabled == true)
                {
                    btnPesqVendedor_Click(null, null);
                }
                else if (e.KeyCode == Keys.Delete && btnPesqVendedor.Enabled == true)
                {
                    txtVendedor.Clear();
                    txtVendedor.VMPesquisaValor = null;
                }

            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                txtVendedor.KeyDown += new KeyEventHandler(txtVendedor_KeyDown);
            }
        }
        #endregion
        #region BackGroundWork
        string mensagembackgroundWor;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            /*
             *              args[1] = dtpDataInicial.Value;
                            args[2] = dtpDataFinal.Value;
                            args[3] = txtCliente.VMPesquisaValor == null ? (int?)null : (txtCliente.VMPesquisaValor as Cliente).Pessoa.IDPessoa;
                            args[4] = txtVendedor.VMPesquisaValor == null ? (int?)null : (txtVendedor.VMPesquisaValor as Vendedor).Pessoa.IDPessoa;
                            args[5] = stb.ToString();
                            args[6] = txtcodigo.Text;
             */
            object[] args = (object[])e.Argument;

            if (args[0].Equals("ConsultarContasaReceber"))
            {
                this.ContasReceberCollection = negContasReceber.Pesquisar((DateTime?)args[1], (DateTime?)args[2], (int?)args[3], (int?)args[4], args[5].ToString(), (int?)args[6], (int?)null);
            }
            else if (args[0].Equals("ExcluirContasReceber"))
            {
                this.mensagembackgroundWor = negContasReceber.Excluir(args[1] as ContasaReceber);
            }
            else if (args[0].Equals("ALterarSituacao"))
            {
                this.mensagembackgroundWor = negContasReceber.AlterarSituacao((int)args[1], (int)args[2], (int)args[3], (int?)args[4]);
            }
        }
        #endregion

    }
}
