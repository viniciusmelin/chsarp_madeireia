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
    public partial class FRM015 : FRMBASE
    {

        #region Forms
        Email email = new Email();
        NegEmail negEmail = new NegEmail();
        Fornecedor fornecedor = new Fornecedor();
        EmailCollection emailCollection = new EmailCollection();
        public FRM015()
        {
            InitializeComponent();
        }

        public FRM015(Fornecedor fornecedor)
        {
            InitializeComponent();
            this.fornecedor = fornecedor;
            AdicionarColunaTextBoxGrid(dgwColecao, "IDEmail", "Código", "Código do Email", null, 60, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Descricao", "Email", "Email do Cliente", null, 400, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaCheckBoxGrid(dgwColecao, "Principal", "Principal", "Email Principal do Cliente", null, 80, DataGridViewContentAlignment.MiddleCenter, DataGridViewContentAlignment.MiddleCenter);


            dgwColecao.Columns[0].Visible = false;
        }
        private void FRM015_Shown(object sender, EventArgs e)
        {
            try
            {
                txtRazaoSocial.Text = this.fornecedor.Pessoa.Nome;
                AtualizarGrid(null, false);
            }
            catch (Exception ex)
            {

                Exceptionerro(ex);
            }
            

            //backgroundWorker1.RunWorkerAsync(args);
            //while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
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
                        args[0] = "ConsultarEmailFornecedor";
                        args[1] = this.fornecedor.Pessoa.IDPessoa;
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
        private void btnInserir_Click(object sender, EventArgs e)
        {

            try
            {
                btnInserir.Click -= new EventHandler(btnInserir_Click);
                using (SlnEstagio.MOD001.FRM017 frm017 = new FRM017(this.fornecedor, Acao.INSERIR))
                {
                    if (frm017.ShowDialog() == DialogResult.OK)
                        this.email = frm017.email;
                }

                AtualizarGrid(this.email, false);

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

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                btnAlterar.Click -= new EventHandler(btnAlterar_Click);
                this.fornecedor.Email = dgwColecao.GetlinhaSelecionado<Email>();
                if (this.fornecedor == null)
                    return;

                using (SlnEstagio.MOD001.FRM017 frm017 = new FRM017(this.fornecedor, Acao.ALTERAR))
                {
                    if (frm017.ShowDialog() == DialogResult.OK)
                    {
                        AtualizarGrid(frm017.email, false);
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

                Email emailSelecioando = dgwColecao.GetlinhaSelecionado<Email>();
                if (emailSelecioando == null)
                    return;

                if (ExibirMensagemPergunta("Deseja excluir o email deste fornecedor", "EXCLUIR E-MAIL") == DialogResult.No)
                    return;

                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[3];
                args[0] = "ExcluirEmailFornecedor";
                args[1] = emailSelecioando;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int retorno;
                if (int.TryParse(mensagembackgroundWor, out retorno))
                {
                    ExibirMensagem("Email excluído com sucesso!");
                    AtualizarGrid(emailSelecioando, true);
                }
                else
                    ExibirMensagemErro("Não foi possível excluir e-mail! \n Motivo: "+mensagembackgroundWor);


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

            if (args[0].Equals("ExcluirEmailFornecedor"))
            {
                this.mensagembackgroundWor = this.negEmail.Excluir(args[1] as Email);
            }
            else if (args[0].Equals("ConsultarEmailFornecedor"))
            {
                this.emailCollection = this.negEmail.PesquisarEmailPessoa((int)args[1]);
            }
        }
        #endregion
    }
}
