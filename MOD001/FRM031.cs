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
    public partial class FRM031 : FRMBASE
    {
        #region Forms
        public ContasPagarTipo contasPagarTipo = new ContasPagarTipo();
        NegContasPagarTipo negContasPagarTipo = new NegContasPagarTipo();
        public Acao Acao { get; set; }
        public FRM031()
        {
            InitializeComponent();
        }

        public FRM031(ContasPagarTipo contasPagarTipo, Acao acao)
        {
            InitializeComponent();
            this.contasPagarTipo = contasPagarTipo;
            this.Acao = acao;
        }
        private void FRM031_Shown(object sender, EventArgs e)
        {
            try
            {
                if (this.Acao == Acao.ALTERAR || this.Acao == Acao.CONSULTAR)
                {
                    txtCodigo.Text = this.contasPagarTipo.IDContasPagarTipo.ToString();
                    txtDescricao.Text = this.contasPagarTipo.Descricao;
                    rbtSim.Checked = this.contasPagarTipo.Ativo;
                    rbtNao.Checked = !rbtSim.Checked;
                    this.Text = "ALTERAR CONTAS A PAGAR TIPO";

                    if (this.Acao == Acao.CONSULTAR)
                    {
                        this.Text = "CONSULTAR CONTAS A PAGAR TIPO";
                        btnSalvar.Enabled = btnSalvar.Visible = false;
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
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                btnSalvar.Click -= new EventHandler(btnSalvar_Click);

                if (string.IsNullOrEmpty(txtDescricao.Text))
                {
                    ExibirMensagemAlerta("A descrição não pode estar em branco!");
                    return;
                }

                contasPagarTipo.Descricao = txtDescricao.Text;
                contasPagarTipo.Ativo = rbtSim.Checked;
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[2];
                args[0] = "Salvar";
                args[1] = contasPagarTipo;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int retorno;
                if (int.TryParse(mensagembackgroundWor, out retorno))
                {
                    if (this.Acao == Acao.INSERIR)
                    {
                        contasPagarTipo.IDContasPagarTipo = retorno;
                        ExibirMensagem("Contas a Pagar Tipo cadastrado com sucesso!");
                        this.DialogResult = DialogResult.OK;
                    }
                    else if (this.Acao == Acao.ALTERAR)
                    {
                        ExibirMensagem("Contas a Pagar Tipo alterado com sucesso!");
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    if (this.Acao == Acao.INSERIR)
                    {
                        ExibirMensagemErro("Não foi possível cadastar Contas a Pagar Tipo" + mensagembackgroundWor);
                    }
                    else if (this.Acao == Acao.ALTERAR)
                    {
                        ExibirMensagemErro("Não foi possível alterar Contas a Pagar Tipo" + mensagembackgroundWor);
                    }
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
        #endregion
        #region BackGroundWork
        string mensagembackgroundWor;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("Salvar"))
            {
                if (this.Acao == Acao.INSERIR)
                    this.mensagembackgroundWor = negContasPagarTipo.Inserir(args[1] as ContasPagarTipo);
                else
                    this.mensagembackgroundWor = negContasPagarTipo.Alterar(args[1] as ContasPagarTipo);
            }
        }
        #endregion
    }
}
