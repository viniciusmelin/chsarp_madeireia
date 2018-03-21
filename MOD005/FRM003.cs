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
    public partial class FRM003 : FRMBASE
    {
        NegContasPagar negContasPagar = new NegContasPagar();
        MODRELATORIO.Relatorio rel = new MODRELATORIO.Relatorio();
        public FRM003()
        {
            InitializeComponent();
        }

        private void FRM003_Shown(object sender, EventArgs e)
        {
            try
            {
                negContasPagar.CarregarComboBoxOperacao(checkedListBox1);
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
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
                args[1] = txtFornecedor.VMPesquisaValor == null ? (int?)null : (txtFornecedor.VMPesquisaValor as Fornecedor).Pessoa.IDPessoa;
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
        void setarParametros()
        {

            rel.CaminhoRelatorio = "MODRELATORIO.RLDC.REL004.rdlc";
            rel.AdicionarParametro("NomeSistema", "BIRA MADEIRAS");
            rel.AdicionarParametro("NomeModulo", "RELATÓRIO");
            rel.AdicionarParametro("NumeroRelatorio", "004");
            rel.AdicionarParametro("Titulo", "CONTAS A PAGAR");
            rel.AdicionarParametro("SubTitulo", "Relatório de Contas a Pagar");

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("Imprimir"))
            {
                rel.DataTable1 = negContasPagar.RelContasPagarVarios((int?)args[1], args[2].ToString());
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
