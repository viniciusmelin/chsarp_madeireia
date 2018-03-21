using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlnEstagio.ObjetoTransferencia;
using SlnEstagio.WINBASE;
using SlnEstagio.Negocio;

namespace SlnEstagio.MOD001
{
    public partial class FRM026 : FRMBASE
    {
        #region Forms
        public Vendedor vendedor { get; internal set; }
        NegVendedor negVendedor = new NegVendedor();
        NegEmail negEmail = new NegEmail();

        EmailCollection emailCollection = new EmailCollection();
        public FRM026()
        {
            InitializeComponent();
        }

        public FRM026(Vendedor vendedor)
        {
            InitializeComponent();
            this.vendedor = vendedor;
            AdicionarColunaTextBoxGrid(dgwColecao, "IDEmail", "Email", "Código do Email", null, 250, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Descricao", "Email", "Email do Cliente", null, 500, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaCheckBoxGrid(dgwColecao, "Principal", "Principal", "Email Principal do Cliente", null, 80, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);

            dgwColecao.Columns[0].Visible = false;
        }
        private void FRM026_Shown(object sender, EventArgs e)
        {
            try
            {
                txtNomeCliente.Text = this.vendedor.Pessoa.Nome;
                AtualizarGrid(null, false);
            }
            catch (Exception ex)
            {

                Exceptionerro(ex);
            }
        }
        private void AtualizarGrid(Email Email, bool booExcluir)
        {
            try
            {
                object FiltroExcluir = null;

                if (booExcluir)
                {
                    FiltroExcluir = (LocalizarFiltroExcluir(dgwColecao) as Email).GetChavePrimaria();
                    dgwColecao.DataSource = null;
                    emailCollection.Remove(Email);
                }
                else
                {
                    if (Email != null)
                    {
                        var Item = from p in emailCollection
                                   where p.GetChavePrimaria() == Email.GetChavePrimaria()
                                   select p;

                        if (Item.Count() == 1)
                        {
                            Email EmailSelecionado = Item.First();
                            EmailSelecionado = Email;
                        }
                        else
                            emailCollection.Add(Email);
                    }
                    else
                    {
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                        object[] args = new object[2];
                        args[0] = "ConsultarEmail";
                        args[1] = this.vendedor.Pessoa.IDPessoa;
                        backgroundWorker1.RunWorkerAsync(args);
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                    }
                }

                dgwColecao.DataSource = null;
                if (emailCollection.Count() > 0)
                    dgwColecao.DataSource = emailCollection.ToList<Email>();

                txtRegistro.Text = dgwColecao.Rows.Count.ToString();

                //if (objEmail != null)
                //    LocalizarIndexLinha(dgwColecao, FiltroExcluir == null ? objEmail.GetChavePrimaria() : FiltroExcluir);

                dgwColecao.Update();
                dgwColecao.Refresh();

                if (dgwColecao.RowCount > 0)
                    dgwColecao.Focus();

            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
        }
        #endregion
        #region Controles
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {

            try
            {
                btnInserir.Click -= new EventHandler(btnInserir_Click);
                using (SlnEstagio.MOD001.FRM025 frm025 = new FRM025(this.vendedor, Acao.INSERIR))
                {
                    if (frm025.ShowDialog() == DialogResult.OK)
                    {
                        this.vendedor.Email = frm025.Email;
                        AtualizarGrid(this.vendedor.Email, false);
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                btnAlterar.Click -= new EventHandler(btnAlterar_Click);

                this.vendedor.Email = dgwColecao.GetlinhaSelecionado<Email>();
                if (this.vendedor.Email == null)
                {
                    ExibirMensagem("Escolher o e-mail para ser alterado!");
                    return;
                }
                

                using (SlnEstagio.MOD001.FRM025 frm025 = new FRM025(this.vendedor, Acao.ALTERAR))
                {
                    if (frm025.ShowDialog() == DialogResult.OK)
                    {
                        this.vendedor.Email = frm025.Email;
                        AtualizarGrid(this.vendedor.Email, false);
                    }
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
                Email emailSelecionado = dgwColecao.GetlinhaSelecionado<Email>();
                if (emailSelecionado == null)
                {
                    //ExibirMensagem("Nenhum email foi selecionado!");
                    return;
                }

                if (ExibirMensagemPergunta("Deseja realmente excluir o email selecionado", "Excluir EMAIL") != DialogResult.Yes)
                    return;

                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[2];
                args[0] = "ExcluirEmail";
                args[1] = emailSelecionado;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int resultado;
                if (int.TryParse(mensagembackgroundWor, out resultado))
                {
                    ExibirMensagem("O email selecionado foi excluido com sucesso!");
                    AtualizarGrid(emailSelecionado, true);
                }
                else
                {
                    ExibirMensagemErro(string.Format("Não foi possível excluir Email selecionado.\n Motivo: {0}", mensagembackgroundWor));
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

            if (args[0].Equals("ExcluirEmail"))
            {
                this.mensagembackgroundWor = negEmail.Excluir(args[1] as Email);
            }
            else if (args[0].Equals("ConsultarEmail"))
            {
                this.emailCollection = negEmail.PesquisarEmailPessoa((int)args[1]);
            }
        }
        #endregion
    }
}