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
    public partial class FRM011 : FRMBASE
    {

        #region Forms
        Telefone telefone = new Telefone();
        TelefoneCollection telefoneCollection = new TelefoneCollection();
        Cliente cliente = new Cliente();
        NegTelefone negTelefone = new NegTelefone();
        public FRM011()
        {
            InitializeComponent();
        }

        public FRM011(Cliente cliente)
        {
            InitializeComponent();
            this.telefone.Pessoa = cliente.Pessoa;
        }
        private void FRM011_Shown(object sender, EventArgs e)
        {
            object[] args = new object[2];
            args[0] = "ConsultarTelefoneCliete";
            args[1] = this.cliente.Pessoa.IDPessoa;
            backgroundWorker1.RunWorkerAsync(args);
            while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
        }
        #endregion
        #region Controles
        private void btnInserir_Click(object sender, EventArgs e)
        {

            try
            {
                btnInserir.Click -= new EventHandler(btnInserir_Click);
                using (SlnEstagio.MOD001.FRM012 frm012 = new FRM012(this.telefone, Acao.INSERIR))
                {
                    if (frm012.ShowDialog() == DialogResult.OK)
                        this.telefone = frm012.telefone;
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                btnAlterar.Click -= new EventHandler(btnAlterar_Click);
                Telefone telefoneSelecionado = dgwColecao.GetlinhaSelecionado<Telefone>();
                if (telefoneSelecionado == null)
                    return;

                using (SlnEstagio.MOD001.FRM012 frm012 = new FRM012(telefoneSelecionado, Acao.ALTERAR))
                {
                    if (frm012.ShowDialog() == DialogResult.OK)
                        this.telefone = frm012.telefone;
                }
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
                Telefone telefoneSelecionado = dgwColecao.GetlinhaSelecionado<Telefone>();
                if (telefoneSelecionado == null)
                    return;

                if (ExibirMensagemPergunta("Deseja excluir o telefone deste cliente?", "EXCLUIR TELEFONE") == DialogResult.No)
                    return;

                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[2];
                args[0] = "ExcluirTelefoneCliente";
                args[1] = telefoneSelecionado;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }

                int retono;
                if (int.TryParse(mensagembackgroundWor, out retono))
                {
                    ExibirMensagem("Telefone excluído com sucesso!");
                }
                else
                {
                    ExibirMensagemErro("Não foi possível excluir o telefone deste cliete.");
                }

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
        #endregion
        #region BackGroundWork
        string mensagembackgroundWor;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("ExcluirTelefoneCliente"))
            {
                this.mensagembackgroundWor = negTelefone.Excluir(args[1] as Telefone);
            }
            else if (args[0].Equals("ConsultarTelefoneCliete"))
            {
                this.telefoneCollection = negTelefone.ConsultarTelefonePessoa((int)args[1]);
            }
        }
        #endregion

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
