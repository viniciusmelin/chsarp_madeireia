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
    public partial class FRM004 : FRMBASE
    {

        #region Forms
        Cliente cliente = new Cliente();
        NegCliente negCliente = new NegCliente();
        ClienteCollection clienteCollection = new ClienteCollection();
        EnderecoCollection enderecoCollection = new EnderecoCollection();
        NegEndereco negEndereco = new NegEndereco();
        public Endereco endereco = new Endereco();

        public FRM004()
        {
            InitializeComponent();
        }
        public FRM004(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;

            AdicionarColunaTextBoxGrid(dgwColecao, "Pessoa.IDPessoa", "Código", "Código do Endereço", null, 60, DataGridViewContentAlignment.MiddleRight, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "IDEndereco", "Código", "Código do Endereço", null, 60, DataGridViewContentAlignment.MiddleRight, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Logradouro","Logradouro", "Descrição do Logradouro", null, 250, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Numero", "Número", "Número do Cliente", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Complemento", "Complemento", "Complemento do Endereço", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Cep", "CEP", "Cep do Cliente", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);

            dgwColecao.Columns[0].Visible = false;
        }
        #endregion
        #region Controles
        private void btnInserir_Click(object sender, EventArgs e)
        {

            try
            {
                btnInserir.Click -= new EventHandler(btnInserir_Click);
                using (SlnEstagio.MOD001.FRM005 frm005 = new FRM005(this.cliente,Acao.INSERIR))
                {
                    if (frm005.ShowDialog() == DialogResult.OK)
                    {
                        this.cliente = frm005.cliente;
                        AtualizarGrid(this.cliente.Endereco, false);
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
                Endereco enderecoSelecionado = dgwColecao.GetlinhaSelecionado<Endereco>();
                if (enderecoSelecionado == null)
                    return;
                using (SlnEstagio.MOD001.FRM005 frm005 = new FRM005(this.cliente,Acao.ALTERAR))
                {
                    this.cliente.Endereco = enderecoSelecionado;
                    if (frm005.ShowDialog() == DialogResult.OK)
                    {
                        this.cliente = frm005.cliente;
                        AtualizarGrid(this.cliente.Endereco, false);
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
                Endereco enderecoSelecionado = dgwColecao.GetlinhaSelecionado<Endereco>();
                if (enderecoSelecionado == null)
                    return;

                if (ExibirMensagemPergunta("Deseja excluir o endereço deste cliente?", "Excluir Endereço") == DialogResult.No)
                    return;

                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[2];
                args[0] = "ExcluirCliente";
                args[1] = enderecoSelecionado;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int retorno;
                if (int.TryParse(mensagembackgroundWor, out retorno))
                {
                    ExibirMensagem("Endereço excluído com sucesso deste cliente.");
                    AtualizarGrid(enderecoSelecionado, true);
                }
                else
                {
                    ExibirMensagemErro(mensagembackgroundWor);
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
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void AtualizarGrid(Endereco Endereco, bool booExcluir)
        {
            try
            {
                object FiltroExcluir = null;

                if (booExcluir)
                {
                    FiltroExcluir = (LocalizarFiltroExcluir(dgwColecao) as Endereco).GetChavePrimaria();
                    dgwColecao.DataSource = null;
                    enderecoCollection.Remove(Endereco);
                }
                else
                {
                    if (Endereco != null)
                    {
                        var Item = from p in enderecoCollection
                                   where p.GetChavePrimaria() == Endereco.GetChavePrimaria()
                                   select p;

                        if (Item.Count() == 1)
                        {
                            Endereco EnderecoSelecionado = Item.First();
                            EnderecoSelecionado = Endereco;
                        }
                        else
                            enderecoCollection.Add(Endereco);
                    }
                    else
                    {
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                        object[] args = new object[2];
                        args[0] = "VMPesquisarEnderecoCliente";
                        args[1] = this.cliente.Pessoa.IDPessoa;
                        backgroundWorker1.RunWorkerAsync(args);
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                    }
                }

                dgwColecao.DataSource = null;
                if (enderecoCollection.Count() > 0)
                    dgwColecao.DataSource = enderecoCollection.ToList<Endereco>();

                txtRegistro.Text = dgwColecao.Rows.Count.ToString();

                //if (objEndereco != null)
                //    LocalizarIndexLinha(dgwColecao, FiltroExcluir == null ? objEndereco.GetChavePrimaria() : FiltroExcluir);

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
        private void FRM004_Shown(object sender, EventArgs e)
        {
            try
            {
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[2];
                args[0] = "VMPesquisarEnderecoCliente";
                args[1] = this.cliente.Pessoa.IDPessoa;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                txtRazaoSocial.Text = this.cliente.Pessoa.Nome;
                AtualizarGrid(null, false);
            }
            catch (Exception ex)
            {

                Exceptionerro(ex);
            }
        }
        #endregion
        #region BackGroundWork
        string mensagembackgroundWor;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("VMPesquisarEnderecoCliente"))
            {
                this.enderecoCollection = this.negEndereco.PesquisarEnderecoPessoa((int)args[1]);
            }
            else if (args[0].Equals("ExcluirCliente"))
            {
                this.mensagembackgroundWor = this.negEndereco.Excluir(args[1] as Endereco);
            }
        }

        #endregion

    }
}
