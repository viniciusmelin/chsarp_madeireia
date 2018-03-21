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
    public partial class FRM025 : FRMBASE
    {
        private Vendedor vendedor;
        private Acao acao;
        EmailCollection emailCollection = new EmailCollection();
        public Email Email { get; internal set; }
        NegEmail negEmail = new NegEmail();
        public FRM025()
        {
            InitializeComponent();
        }

        public FRM025(Vendedor vendedor,Acao acao)
        {
            InitializeComponent();
            this.vendedor = vendedor;
            this.acao = acao;
            if (this.vendedor.Email == null)
                this.vendedor.Email = new Email();
        }

        

        private void btnInserir_Click(object sender, EventArgs e)
        {

            try
            {
                btnInserir.Click -= new EventHandler(btnInserir_Click);
                if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    ExibirMensagemAlerta("É preciso informar o email!");
                    return;
                }
                this.vendedor.Email.Pessoa = this.vendedor.Pessoa;
                this.vendedor.Email.Descricao = txtEmail.Text;
                this.vendedor.Email.Principal = cbxPrincipal.Checked;
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[2];
                args[0] = "EmailVendedor";
                args[1] = this.vendedor.Email;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int resultado;
                if (int.TryParse(mensagembackgroundWor, out resultado))
                {
                    if (acao == Acao.INSERIR)
                    {
                        ExibirMensagem("O email do vendedor foi cadastrado com sucesso");
                        
                        this.vendedor.Email.IDEmail = resultado;
                        this.Email = this.vendedor.Email;
                        this.DialogResult = DialogResult.OK;
                    }
                    if (acao == Acao.ALTERAR)
                    {
                        ExibirMensagem("O email do vendedor foi alterado com sucesso");
                        this.Email = this.vendedor.Email;
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    if (acao == Acao.INSERIR)
                    {
                        ExibirMensagemErro(string.Format("Não foi possivel inserir email do vendedor. \n Motivo: {0}",mensagembackgroundWor));

                    }
                    if (acao == Acao.ALTERAR)
                    {
                        ExibirMensagemErro(string.Format("Não foi possivel alterar email do vendedor. \n Motivo: {0}", mensagembackgroundWor));
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

        string mensagembackgroundWor;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("EmailVendedor"))
            {
                if (acao == Acao.INSERIR)
                    this.mensagembackgroundWor = negEmail.Inserir(args[1] as Email);
                if (acao == Acao.ALTERAR)
                    this.mensagembackgroundWor = negEmail.Alterar(args[1] as Email);
            }
        }

        private void FRM025_Shown(object sender, EventArgs e)
        {
            try
            {
                if (acao == Acao.ALTERAR)
                {
                    txtEmail.Text = this.vendedor.Email.Descricao;
                    cbxPrincipal.Checked = this.vendedor.Email.Principal;
                    this.btnInserir.Text = "&ALTERAR";
                }
                if (acao == Acao.CONSULTAR)
                {
                    txtEmail.Text = this.vendedor.Email.Descricao;
                    cbxPrincipal.Checked = this.vendedor.Email.Principal;
                    this.btnInserir.Visible = btnInserir.Enabled = false;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
