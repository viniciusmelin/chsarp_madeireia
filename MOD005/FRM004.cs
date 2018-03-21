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

namespace SlnEstagio.MOD005
{
    public partial class FRM004 : FRMBASE
    {
        MODRELATORIO.Relatorio rel = new MODRELATORIO.Relatorio();
        NegProduto negProduto = new NegProduto();
        public FRM004()
        {
            InitializeComponent();
            carregar(cbxAtivo);
        }

        private void txtProduto_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                txtProduto.KeyDown -= new KeyEventHandler(txtProduto_KeyDown);
                if (e.KeyCode == Keys.Enter && btnPesqProduto.Enabled == true)
                    btnPesqProduto_Click(null, null);
                else if (e.KeyCode == Keys.Delete && btnPesqProduto.Enabled == true)
                {
                    txtProduto.VMPesquisaValor = null;
                    txtProduto.Clear();
                    txtProduto.Focus();
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                txtProduto.KeyDown += new KeyEventHandler(txtProduto_KeyDown);
            }
        }

        private void btnPesqProduto_Click(object sender, EventArgs e)
        {

            try
            {
                btnPesqProduto.Click -= new EventHandler(btnPesqProduto_Click);
                using (MOD001.FRM023 frm023 = new MOD001.FRM023(txtProduto.Text, null))
                {
                    if (frm023.ShowDialog() == DialogResult.OK)
                    {
                        txtProduto.VMPesquisaValor = frm023.produto;
                        txtProduto.Text = frm023.produto.Descricao;
                    }
                }

            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnPesqProduto.Click += new EventHandler(btnPesqProduto_Click);
            }
        }
        void setarParametros()
        {

            rel.CaminhoRelatorio = "MODRELATORIO.RLDC.REL005.rdlc";
            rel.AdicionarParametro("NomeSistema", "BIRA MADEIRAS");
            rel.AdicionarParametro("NomeModulo", "RELATÓRIO");
            rel.AdicionarParametro("NumeroRelatorio", "005");
            rel.AdicionarParametro("Titulo", "PRODUTOS");
            rel.AdicionarParametro("SubTitulo", "Relatório de PRODUTOS");

        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {

            try
            {
                btnImprimir.Click -= new EventHandler(btnImprimir_Click);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[3];
                args[0] = "Imprimir";
                args[1] = txtProduto.VMPesquisaValor == null ? (int?)null : (txtProduto.VMPesquisaValor as Produto).IDProduto;
                args[2] = cbxAtivo.SelectedValue;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }

            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnImprimir.Click += new EventHandler(btnImprimir_Click);
            }
        }


        string mensagembackgroundWor;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("Imprimir"))
            {
                rel.DataTable1 = negProduto.RelProdutoTotal((int?)args[1], (bool?)args[2]);
                setarParametros();
                rel.Imprimir();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
