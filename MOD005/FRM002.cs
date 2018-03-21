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
    public partial class FRM002 : FRMBASE
    {
        MODRELATORIO.Relatorio rel = new MODRELATORIO.Relatorio();
        NegCliente negCliente = new NegCliente();
        public FRM002()
        {
            InitializeComponent();
            carregar(cbxAtivo);
        }

        void setarParametros()
        {

            rel.CaminhoRelatorio = "MODRELATORIO.RLDC.REL001.rdlc";
            rel.AdicionarParametro("NomeSistema", "BIRA MADEIRAS");
            rel.AdicionarParametro("NomeModulo", "RELATÓRIO");
            rel.AdicionarParametro("NumeroRelatorio", "001");
            rel.AdicionarParametro("Titulo", "CLIENTES");
            rel.AdicionarParametro("SubTitulo", "Relatório de Clientes");

        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {

            try
            {
                btnImprimir.Click -= new EventHandler(btnImprimir_Click);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[3];
                args[0] = "Imprimir";
                args[1] = txtCliente.VMPesquisaValor == null ? (int?)null: (txtCliente.VMPesquisaValor as Cliente).Pessoa.IDPessoa;
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
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("Imprimir"))
            {
                this.rel.DataTable1 = negCliente.RelCliente((int?)args[1], (bool?)args[2]);
                setarParametros();
                rel.Imprimir();
            }

        }

        private void btnPesqCliente_Click(object sender, EventArgs e)
        {

            try
            {
                btnPesqCliente.Click -= new EventHandler(btnPesqCliente_Click);
                using (SlnEstagio.MOD001.FRM020 frm020 = new MOD001.FRM020(txtCliente.Text, null))
                {
                    if (frm020.ShowDialog() == DialogResult.OK)
                    {
                        txtCliente.VMPesquisaValor = frm020.cliente;
                        txtCliente.Text = frm020.cliente.Pessoa.Nome;
                    }
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnPesqCliente.Click += new EventHandler(btnPesqCliente_Click);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                txtCliente.KeyDown -= new KeyEventHandler(txtCliente_KeyDown);
                if (e.KeyCode == Keys.Enter && btnPesqCliente.Enabled == true)
                    btnPesqCliente_Click(null, null);
                else if (e.KeyCode == Keys.Delete && btnPesqCliente.Enabled == true)
                {
                    txtCliente.VMPesquisaValor = null;
                    txtCliente.Clear();
                    txtCliente.Focus();
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                txtCliente.KeyDown += new KeyEventHandler(txtCliente_KeyDown);
            }
        }
    }
}
