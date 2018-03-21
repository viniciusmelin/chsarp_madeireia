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
    public partial class FRM006 : FRMBASE
    {
        Cliente cliente = new Cliente();
        Email email = new Email();
        NegEmail negEmail = new NegEmail();
        EmailCollection emailCollection = new EmailCollection();
        public FRM006()
        {
            InitializeComponent();
        }

        public FRM006(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            AdicionarColunaTextBoxGrid(dgwColecao, "IDEmail", "Email", "Código do Email", null, 250, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Descricao", "Email", "Email do Cliente", null, 250, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaCheckBoxGrid(dgwColecao, "Principal", "Principal", "Email Principal do Cliente", null, 80, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);


            dgwColecao.Columns[0].Visible = false;
        }

        private void FRM006_Shown(object sender, EventArgs e)
        {
            try
            {
                txtNomeCliente.Text = this.cliente.Pessoa.Nome;
                //while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                //object[] args = new object[2];
                //args[0] = "VMPesquisarClienteEmail";
                //args[1] = this.cliente.Pessoa.IDPessoa;
                //backgroundWorker1.RunWorkerAsync(args);
                //while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                AtualizarGrid(null, false);
            }
            catch (Exception ex)
            {

                Exceptionerro(ex);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                btnAlterar.Click -= new EventHandler(btnAlterar_Click);
                this.cliente.Email = dgwColecao.GetlinhaSelecionado<Email>();
                if (this.cliente.Email == null)
                    return;

                using (SlnEstagio.MOD001.FRM007 frm007 = new FRM007(this.cliente,Acao.ALTERAR))
                {
                    if (frm007.ShowDialog() == DialogResult.OK)
                        this.email = frm007.email;
                }
                AtualizarGrid(null, false);
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
                        args[0] = "VMPesquisarClienteEmail";
                        args[1] = this.cliente.Pessoa.IDPessoa;
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
        private void btnInserir_Click(object sender, EventArgs e)
        {

            try
            {
                btnInserir.Click -= new EventHandler(btnInserir_Click);
                using (SlnEstagio.MOD001.FRM007 frm007 = new FRM007(this.cliente,Acao.INSERIR))
                {
                    if (frm007.ShowDialog() == DialogResult.OK)
                    {
                        this.cliente.Email = frm007.email;
                    }
                        
                }

                AtualizarGrid(this.cliente.Email, false);
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                btnExcluir.Click -= new EventHandler(btnExcluir_Click);
                Email emailSelecionado = dgwColecao.GetlinhaSelecionado<Email>();


                if (emailSelecionado == null)
                    return;
                if (ExibirMensagemPergunta("Deseja excluir o Email deste cliente.", "Excluir Email") == DialogResult.No)
                    return;
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[2];
                args[0] = "ExcluirEmailCliente";
                args[1] = emailSelecionado;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }

                int retorno;
                if(int.TryParse(mensagembackgroundWor,out retorno))
                {
                    ExibirMensagem("Email do Cliente excluído com sucesso.");
                }
                else
                {
                    ExibirMensagemErro("Não foi possível excluir email selecionado.");
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


        string mensagembackgroundWor;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("ExcluirEmailCliente"))
            {
                this.mensagembackgroundWor = this.negEmail.Excluir(args[1] as Email);
            }
            else if (args[0].Equals("VMPesquisarClienteEmail"))
            {
                this.emailCollection = negEmail.PesquisarEmailPessoa((int)args[1]);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
