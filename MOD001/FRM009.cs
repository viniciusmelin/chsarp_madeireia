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
    public partial class FRM009 : FRMBASE
    {
        Usuario usuario = new Usuario();
        public FRM009()
        {
            InitializeComponent();
            carregar(cbxAtivos);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            try
            {
                btnInserir.Click -= new EventHandler(btnInserir_Click);
                using (SlnEstagio.MOD001.FRM010 frm010 = new FRM010())
                {
                    if (frm010.ShowDialog() == DialogResult.OK)
                    {
                        this.usuario = frm010.usuario;
                        
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVMPesquisar_Click(object sender, EventArgs e)
        {

            try
            {
                btnVMPesquisar.Click -= new EventHandler(btnVMPesquisar_Click);
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                btnAlterar.Click -= new EventHandler(btnAlterar_Click);
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                btnExcluir.Click -= new EventHandler(btnExcluir_Click);
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
    }
}
