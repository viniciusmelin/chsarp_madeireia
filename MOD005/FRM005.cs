using SlnEstagio.Negocio;
using SlnEstagio.ObjetoTransferencia;
using SlnEstagio.WINBASE;
using System;
using System.Collections;
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
    public partial class FRM005 : FRMBASE
    {
        NegContasReceber negContasReceber = new NegContasReceber();
        MODRELATORIO.Relatorio rel = new MODRELATORIO.Relatorio();
        public FRM005()
        {
            InitializeComponent();
        }

        private void FRM005_Shown(object sender, EventArgs e)
        {
            try
            {
                negContasReceber.CarregarComboBox(checkedListBox1);
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
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
        void setarParametros()
        {

            rel.CaminhoRelatorio = "MODRELATORIO.RLDC.REL006.rdlc";
            rel.AdicionarParametro("NomeSistema", "BIRA MADEIRAS");
            rel.AdicionarParametro("NomeModulo", "RELATÓRIO");
            rel.AdicionarParametro("NumeroRelatorio", "006");
            rel.AdicionarParametro("Titulo", "CONTAS A RECEBER");
            rel.AdicionarParametro("SubTitulo", "Relatório de Contas a Receber");

        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {

            try
            {
                btnImprimir.Click -= new EventHandler(btnImprimir_Click);
                StringBuilder stb = new StringBuilder();
                foreach (DictionaryEntry item in checkedListBox1.CheckedItems)
                {
                    if (stb.Length > 0)
                        stb.Append(";");

                    stb.Append(item.Value.ToString());
                }

                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[3];
                args[0] = "Imprimir";
                args[1] = txtCliente.VMPesquisaValor == null ? (int?)null : (txtCliente.VMPesquisaValor as Cliente).Pessoa.IDPessoa;
                args[2] = stb.ToString();
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
                this.rel.DataTable1 = negContasReceber.RelContasReceberVarias((int?)args[1], args[2].ToString());
                setarParametros();
                rel.Imprimir();
            }
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
