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

namespace SlnEstagio.MOD001
{
    public partial class FRM007 : FRMBASE
    {
        Cliente cliente = new Cliente();
        Acao acao;
        public Email email = new Email();
        NegEmail negEmail = new NegEmail();

        public FRM007()
        {
            InitializeComponent();
        }

        public FRM007(Cliente cliente, Acao acao)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.acao = acao;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            try
            {
                btnInserir.Click -= new EventHandler(btnInserir_Click);
                this.email.Pessoa = this.cliente.Pessoa;
                this.email.Descricao = txtEmail.Text;
                this.email.Principal = cbxPrincipal.Checked;

                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[3];
                args[0] = "InserirEmailCliente";
                args[1] = this.email;
                args[2] = this.acao;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int retorno;
                if (int.TryParse(mensagembackgroundWor, out retorno))
                {
                    ExibirMensagem("Email cadastrado com sucesso para este cliente.");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    ExibirMensagemErro(this.mensagembackgroundWor);
                    //this.DialogResult = DialogResult.Cancel;
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



        string mensagembackgroundWor;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("InserirEmailCliente"))
            {
                if ((Acao)args[2] == Acao.INSERIR)
                    this.mensagembackgroundWor = this.negEmail.Inserir(args[1] as Email);
                else if ((Acao)args[2] == Acao.ALTERAR)
                    this.mensagembackgroundWor = this.negEmail.Alterar(args[1] as Email);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
           
            this.DialogResult = DialogResult.Cancel;
        }

        private void FRM007_Shown(object sender, EventArgs e)
        {
            if (this.acao == Acao.ALTERAR)
            {
                this.email = this.cliente.Email;
                txtEmail.Text = this.email.Descricao;
                cbxPrincipal.Checked = this.email.Principal;
                this.Text = "ALTERAR EMAIL CLIENTE";
                this.btnInserir.Text = "&SALVAR";
            }
            else if (this.acao == Acao.CONSULTAR)
            {
                txtEmail.Text = this.email.Descricao;
                cbxPrincipal.Checked = this.email.Principal;
                this.Text = "CONSULTAR EMAIL CLIENTE";
            }
        }

    }
}
