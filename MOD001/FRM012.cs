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
    public partial class FRM012 : FRMBASE
    {
        #region Forms
        public Telefone telefone = new Telefone();
        NegTelefone negTelefone = new NegTelefone();
        Acao acao;
        public FRM012()
        {
            InitializeComponent();
        }
        public FRM012(Telefone telefone, Acao acao)
        {
            InitializeComponent();
            this.telefone = telefone;
            this.acao = acao;
        }
        private void FRM012_Shown(object sender, EventArgs e)
        {
            if (this.acao == Acao.ALTERAR || this.acao == Acao.CONSULTAR)
            {
                txtNumero.Text = this.telefone.Numero.ToString();
                cbxTipoTelefone.SelectedValue = this.telefone.TipoTelefone;
                ckbxPrincipal.Checked = this.telefone.Principal;
                this.Text = "ALTERAR TELEFONE CLIENTE";

                if (this.acao == Acao.CONSULTAR)
                {
                    this.Text = "CONSULTAR TELEFONE CLIENTE";
                    btnSalvar.Visible = false;
                    panel1.Visible = false;
                    txtNumero.Enabled = false;
                    cbxTipoTelefone.Enabled = false;
                    btnFechar.Text = "&FECHAR";
                }
            }
        }
        #endregion
        #region Controles
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                btnSalvar.Click -= new EventHandler(btnSalvar_Click);
                this.telefone.TipoTelefone = cbxTipoTelefone.Text;
                this.telefone.Numero = Convert.ToDecimal(txtNumero.Text);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[3];
                args[0] = "InserirTelefoneCliente";
                args[1] = this.telefone;
                args[2] = this.acao;
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int retorno;
                if (int.TryParse(mensagembackgroundWor, out retorno))
                {
                    if (this.acao == Acao.INSERIR)
                    {
                        ExibirMensagem("Telefone cadastrado com sucesso!");
                        this.telefone.IDTelefone = retorno;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        ExibirMensagem("Telefone alterado com sucesso!");
                        this.telefone.IDTelefone = retorno;
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    if (this.acao == Acao.INSERIR)
                    {
                        ExibirMensagemErro("Não foi possivel cadastrar telefone.");
                        this.DialogResult = DialogResult.Cancel;
                    }
                    else
                    {
                        ExibirMensagemErro("Não foi possivel alterar telefone.");
                        this.DialogResult = DialogResult.Cancel;
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

            if (args[0].Equals("InserirTelefoneCliente"))
            {
                if ((Acao)args[2] == Acao.INSERIR)
                    this.mensagembackgroundWor = negTelefone.Inserir(args[1] as Telefone);
                else if ((Acao)args[2] == Acao.ALTERAR)
                    this.mensagembackgroundWor = negTelefone.Alterar(args[1] as Telefone);
            }
        }

        #endregion


    }
}
