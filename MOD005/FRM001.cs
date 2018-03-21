using SlnEstagio.Negocio;
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
using SlnEstagio.MOD003;

namespace SlnEstagio.MOD005
{
    public partial class FRM001 : FRMBASE
    {
        NegFornecedor negFornecedor = new NegFornecedor();
        MODRELATORIO.Relatorio rel = new MODRELATORIO.Relatorio();
        public FRM001()
        {
            InitializeComponent();
            carregar(cbxAtivo);
        }

        void setarParametros()
        {
            
            rel.CaminhoRelatorio = "MODRELATORIO.RLDC.REL003.rdlc";
            rel.AdicionarParametro("NomeSistema", "BIRA MADEIRAS");
            rel.AdicionarParametro("NomeModulo", "RELATÓRIO");
            rel.AdicionarParametro("NumeroRelatorio", "003");
            rel.AdicionarParametro("Titulo", "FORNECEDORES");
            rel.AdicionarParametro("SubTitulo", "Relatório Fornecedores");

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("ImprimirRelatorio"))
            {
                this.rel.DataTable1 = negFornecedor.RelFornecedor((int?)args[1], (bool?)args[2]);
                setarParametros();
                rel.Imprimir();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            try
            {
                btnImprimir.Click -= new EventHandler(btnImprimir_Click);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[3];
                args[0] = "ImprimirRelatorio";
                args[1] = txtFornecedor.VMPesquisaValor == null ? (int?)null : (txtFornecedor.VMPesquisaValor as Fornecedor).Pessoa.IDPessoa;
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

        private void btnPesqFornecedor_Click(object sender, EventArgs e)
        {

            try
            {
                btnPesqFornecedor.Click -= new EventHandler(btnPesqFornecedor_Click);
                using (MOD003.FRM006 frm006 = new FRM006(txtFornecedor.Text))
                {
                    if (frm006.ShowDialog() == DialogResult.OK)
                    {
                        this.txtFornecedor.VMPesquisaValor = frm006.Fornecedor;
                        this.txtFornecedor.Text = frm006.Fornecedor.Pessoa.Nome;
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
                    txtFornecedor.VMPesquisaValor = null;
                    txtFornecedor.Clear();
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
            this.Close();
        }
    }
}
