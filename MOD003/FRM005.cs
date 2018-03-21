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

namespace SlnEstagio.MOD003
{
    public partial class FRM005 : FRMBASE
    {

        #region Forms
        public ContasPagar ContasPagar { get; internal set; }
        public Fornecedor Fornecedor { get; set; }
        public ContasPagarTipo ContasPagarTipo { get; set; }
        NegContasPagar negContasPagar = new NegContasPagar();
        private Acao Acao { get; set; }
        public FRM005()
        {
            InitializeComponent();
        }
        public FRM005(ContasPagar contasPagar, Acao acao)
        {
            InitializeComponent();
            this.Acao = acao;
            this.ContasPagar = contasPagar;
        }
        private void FRM005_Shown(object sender, EventArgs e)
        {
            try
            {
                if (this.Acao == Acao.INSERIR)
                {
                    dtpDataLancamento.Value = DateTime.Now;
                    this.ContasPagar.DataLancamento = DateTime.Now;

                }
                else if (this.Acao == Acao.ALTERAR || this.Acao == Acao.CONSULTAR)
                {
                    txtCodigo.Text = this.ContasPagar.IDContasPagar.ToString();
                    txtValor.Text = this.ContasPagar.Valor.ToString();
                    dtpDataLancamento.Value = this.ContasPagar.DataLancamento;
                    dtpDataPagamento.Value = this.ContasPagar.DataPagamento == DateTime.MinValue ? (DateTime?)null : this.ContasPagar.DataPagamento;
                    txtContasPagarTipo.Text = this.ContasPagar.ContasPagarTipo.Descricao;
                    txtContasPagarTipo.VMPesquisaValor = this.ContasPagar.ContasPagarTipo;
                    txtFornecedor.Text = this.ContasPagar.Fornecedor.Pessoa.Nome;
                    txtFornecedor.VMPesquisaValor = this.ContasPagar.Fornecedor;
                    txtObservacao.Text = this.ContasPagar.Observacao;

                    this.Name = "ALTERAR CONTAS A PAGAR";
                    if (this.Acao == Acao.CONSULTAR)
                    {
                        this.Name = "CONSULTAR CONTAS A PAGAR";

                    }
                }
            }
            catch (Exception ex)
            {

                Exceptionerro(ex);
            }
        }
        #endregion
        #region Controles
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                btnSalvar.Click -= new EventHandler(btnSalvar_Click);
                if (ValidarCampos(this, false) > 0)
                {
                    return;
                }

                if (txtValor.Equals("0"))
                {
                    ExibirMensagemAlerta("Valor não poder ser zero!");
                    txtValor.Focus();
                    return;
                }
                if (txtValor.Text.Trim() == string.Empty)
                {
                    ExibirMensagemAlerta("Observação não poder estar em branco!");
                    return;
                }

                if (txtContasPagarTipo.VMPesquisaValor == null)
                {
                    ExibirMensagemAlerta("É preciso informar o tipo de Contas a Pagar!");
                    return;
                }
                if (txtFornecedor.VMPesquisaValor == null)
                {
                    ExibirMensagemAlerta("É preciso informar o Fornecedor!");
                    return;
                }

                //this.ContasPagar.DataPagamento = txtDataPagamento.Text == string.Empty ? (DateTime?)null : Convert.ToDateTime(txtDataPagamento.Text);
                this.ContasPagar.DataVencimento = dtpVencimento.Value.Value;
                this.ContasPagar.Valor = Convert.ToDecimal(txtValor.Text);
                this.ContasPagar.Observacao = txtObservacao.Text;
                this.ContasPagar.OperacaoSituacao = new OperacaoSituacao
                {
                    Operacao = new Operacao
                    {
                        IDOperacao = (int)EnumOperacao.PAGAR
                    },

                    Situacao = new Situacao
                    {
                        IDSituacao = (int)EnumSituacao.ABERTO,
                        Descricao = EnumSituacao.ABERTO.ToString()
                    }
                };

                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[2];
                args[0] = "Inserir";
                args[1] = this.ContasPagar;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int retorno;
                if (int.TryParse(mensagembackgroundWor, out retorno))
                {
                    this.ContasPagar.IDContasPagar = retorno;
                    if (this.Acao == Acao.INSERIR)
                        ExibirMensagem("Contas a Pagar cadastrada com sucesso!");
                    else
                        ExibirMensagem("Contas a Pagar alterada com sucesso!");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    if (this.Acao == Acao.INSERIR)
                        ExibirMensagemErro("Não foi possível inserir Contas a Pagar! \n Motivo: " + mensagembackgroundWor);
                    else
                        ExibirMensagemErro("Não foi possível alterar Contas a Pagar! \n Motivo: " + mensagembackgroundWor);
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



        private void btnPesqContasPagarTipo_Click(object sender, EventArgs e)
        {

            try
            {
                btnPesqContasPagarTipo.Click -= new EventHandler(btnPesqContasPagarTipo_Click);
                using (FRM007 frm007 = new FRM007(txtContasPagarTipo.Text))
                {
                    if (frm007.ShowDialog() == DialogResult.OK)
                    {
                        this.ContasPagarTipo = frm007.ContasPagarTipo;
                        txtContasPagarTipo.VMPesquisaValor = frm007.ContasPagarTipo;
                        txtContasPagarTipo.Text = frm007.ContasPagarTipo.Descricao;
                        this.ContasPagar.ContasPagarTipo = this.ContasPagarTipo;
                    }
                }

            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnPesqContasPagarTipo.Click += new EventHandler(btnPesqContasPagarTipo_Click);
            }
        }

        private void txtContasPagarTipo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                txtContasPagarTipo.KeyDown -= new KeyEventHandler(txtContasPagarTipo_KeyDown);

                if (e.KeyCode == Keys.Enter && btnPesqContasPagarTipo.Enabled == true)
                    btnPesqContasPagarTipo_Click(null, null);
                else if (e.KeyCode == Keys.Delete && btnPesqContasPagarTipo.Enabled == true)
                {
                    txtContasPagarTipo.Clear();
                    txtContasPagarTipo.VMPesquisaValor = null;
                }
            }
            catch (Exception ex)
            {

                Exceptionerro(ex);
            }
            finally
            {
                txtContasPagarTipo.KeyDown += new KeyEventHandler(txtContasPagarTipo_KeyDown);
            }
        }

        private void btnPesqFornecedor_Click(object sender, EventArgs e)
        {

            try
            {
                btnPesqFornecedor.Click -= new EventHandler(btnPesqFornecedor_Click);

                using (MOD003.FRM006 frm006 = new MOD003.FRM006(txtFornecedor.Text))
                {
                    if (frm006.ShowDialog() == DialogResult.OK)
                    {
                        this.Fornecedor = frm006.Fornecedor;
                        this.txtFornecedor.Text = frm006.Fornecedor.Pessoa.Nome;
                        this.txtFornecedor.VMPesquisaValor = frm006.Fornecedor;
                        this.ContasPagar.Fornecedor = this.Fornecedor;
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
                else if (e.KeyCode == Keys.Delete && btnPesqFornecedor.Enabled == true)
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        #endregion
        #region BackGroundWork
        string mensagembackgroundWor;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("Inserir"))
            {
                if (this.Acao == Acao.INSERIR)
                    this.mensagembackgroundWor = negContasPagar.Inserir(args[1] as ContasPagar);
                else
                    this.mensagembackgroundWor = negContasPagar.Alterar(args[1] as ContasPagar);
            }
        }
        #endregion
    }
}
