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
    public partial class FRM010 : FRMBASE
    {
        public Usuario usuario = new Usuario();
        public FRM010()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                btnSalvar.Click -= new EventHandler(btnSalvar_Click);
                if (string.IsNullOrEmpty(txtUsuario.Text))
                {
                    return;
                }
                if (string.IsNullOrEmpty(txtSenha.Text))
                    return;

                if(ValidarCampos(this,true)>0)
                {
                    ExibirMensagemAlerta("Preencher todos os campos obrigatórios!");
                    return;
                }

                if(txtSenha.Text.Trim() != txtSenhaRepitida.Text.Trim())
                {
                    ExibirMensagemAlerta("Senha digita não confere");
                    txtSenha.Clear();
                    txtSenhaRepitida.Clear();
                    txtSenha.Focus();
                    return;
                }
                this.usuario.Login = txtUsuario.Text;
                this.usuario.Senha = txtSenha.Text;
                this.usuario.Pessoa = txtPessoa.VMPesquisaValor == null ? null : (txtPessoa.VMPesquisaValor as Pessoa);

                int retorno;
                if(int.TryParse(mensagembackgroundWor, out retorno))
                {
                    ExibirMensagem("Usuário cadastrado com sucesso.");

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

        private void btnPesqPessoa_Click(object sender, EventArgs e)
        {

        }



        string mensagembackgroundWor;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals(""))
            {
                //this.mensagembackgroundWor = 
            }
            else if (args[0].Equals(""))
            {
                //this.mensagembackgroundWor = 
            }
            else if (args[0].Equals(""))
            {
                //this.mensagembackgroundWor = 
            }
        }
    }
}
