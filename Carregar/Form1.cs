using SlnEstagio.MOD001;
using SlnEstagio.Negocio;
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

namespace SlnEstagio.Carregar
{
    public partial class Form1 : FRMBASE
    {
        NegUsuario negUsuario = new NegUsuario();
        bool usuariopermissao = new bool();
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnCancelar_Click(object sender, EventArgs e)
        {

            try
            {
                btnCancelar.Click -= new EventHandler(btnCancelar_Click);
                Application.Exit();
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnCancelar.Click += new EventHandler(btnCancelar_Click);
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            try
            {
                btnEntrar.Click -= new EventHandler(btnEntrar_Click);
                if (string.IsNullOrEmpty(txtSenha.Text) || (string.IsNullOrEmpty(txtUsuario.Text)))
                {
                    ExibirMensagemErro("O campos usário e senha não podem ser nulos.");
                    return;
                }

                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[3];
                args[0] = "ValidarUsuario";
                args[1] = txtUsuario.Text;
                args[2] = txtSenha.Text;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                if (!usuariopermissao)
                {
                    ExibirMensagem("Usuário ou senha inválido.");
                    return;
                }


                

            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnEntrar.Click += new EventHandler(btnEntrar_Click);
            }
        }

        #region Forms

        #endregion
        #region Controles

        #endregion
        #region BackGroundWork

        #endregion

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("ValidarUsuario"))
            {
                this.usuariopermissao = negUsuario.UsuarioAcesso(args[1].ToString(), args[2].ToString());
            }
        }
    }
}
