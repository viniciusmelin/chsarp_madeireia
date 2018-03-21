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
    public partial class FRM017 : FRMBASE
    {
        #region Forms
        Fornecedor fornecedor = new Fornecedor();
        NegEmail negEmail = new NegEmail();
        Acao acao;
       public Email email = new Email();

        public FRM017()
        {
            InitializeComponent();
        }

        public FRM017( Fornecedor fornecedor, Acao acao)
        {
            InitializeComponent();
            this.fornecedor = fornecedor;
            this.acao = acao;
            //if(this.fornecedor)
        }
        private void FRM017_Shown(object sender, EventArgs e)
        {
            if (this.acao == Acao.ALTERAR || this.acao == Acao.CONSULTAR)
            {
                this.email = this.fornecedor.Email;
                txtEmail.Text = this.fornecedor.Email.Descricao;
                cbxPrincipal.Checked = this.fornecedor.Email.Principal;
                this.Text = "ALTERAR EMAIL FORNECEDOR";
                if (this.acao == Acao.CONSULTAR)
                {
                    this.Text = "CONSULTAR EMAIL FORNECEDOR";
                    this.btnSalvar.Visible = false;
                    btnFechar.Text = "&FECHAR";
                }
            }
        }
        #endregion
        #region Controles
        private void btnInserir_Click(object sender, EventArgs e)
        {

            try
            {
                btnSalvar.Click -= new EventHandler(btnInserir_Click);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                this.email.Pessoa = this.fornecedor.Pessoa;
                this.email.Descricao = txtEmail.Text;
                this.email.Principal = cbxPrincipal.Checked;
                object[] args = new object[3];
                args[0] = "InserirEmailFornecedor";
                args[1] = this.email;
                args[2] = this.acao;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int retorno;
                if (int.TryParse(mensagembackgroundWor, out retorno))
                {
                    if (this.acao == Acao.INSERIR)
                    {
                        ExibirMensagem("Email cadastrado com sucesso!");
                        this.email.IDEmail = retorno;
                        this.DialogResult = DialogResult.OK;
                    }
                    else if (this.acao == Acao.ALTERAR)
                    {
                        ExibirMensagem("Email alterado com sucesso!");
                        //this.email.IDEmail = retorno;
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    if (this.acao == Acao.INSERIR)
                    {
                        ExibirMensagemErro("Não foi possível cadastrar email para fornecedor! \n Motivo: "+mensagembackgroundWor);
                        this.email.IDEmail = retorno;
                    }
                    else if (this.acao == Acao.ALTERAR)
                    {
                        ExibirMensagem("Não foi possível alterar email para fornecedor! \n Motivo: "+mensagembackgroundWor);
                        this.email.IDEmail = retorno;
                    }
                }


            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnSalvar.Click += new EventHandler(btnInserir_Click);
            }
        }
        #endregion
        #region BackGroundWork

        string mensagembackgroundWor;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("InserirEmailFornecedor"))
            {
                if ((Acao)args[2] == Acao.INSERIR)
                    this.mensagembackgroundWor = negEmail.Inserir(args[1] as Email);
                else if ((Acao)args[2] == Acao.ALTERAR)
                    this.mensagembackgroundWor = negEmail.Alterar(args[1] as Email);
            }
        }
        #endregion

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
