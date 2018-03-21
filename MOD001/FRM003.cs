using SlnEstagio.WINBASE;
using System;
using SlnEstagio.Negocio;
using SlnEstagio.ObjetoTransferencia;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;

namespace SlnEstagio.MOD001
{

    public partial class FRM003 : FRMBASE
    {

        #region Forms
        NegCliente negCliente = new NegCliente();
        Cliente cliente = new Cliente();
        ClienteCollection clienteCollection = new ClienteCollection();
        public FRM003()
        {
            InitializeComponent();
            AdicionarColunaTextBoxGrid(dgwColecao, "Pessoa.IDPessoa", "Código", "Código do Cliente", null, 60, DataGridViewContentAlignment.MiddleRight, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Pessoa.Nome", "Nome do Cliente", "Nome do Cliente", null, 350, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Pessoa.CpfCnpj", "CPF", "CPF do Cliente", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "DataCadastro", "Dt.Cadas.", "Data de Cadastro do Cliente", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "DataNascimento", "Dt.Nasc.", "Data de Nascimento do Cliente", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaCheckBoxGrid(dgwColecao, "Pessoa.Ativo", "Ativo", "Cliente Ativo", null, 60, DataGridViewContentAlignment.MiddleCenter, DataGridViewContentAlignment.MiddleCenter);
            AdicionarColunaTextBoxGrid(dgwColecao, "LimiteMinimo", "Lim. Minimo", "Limite Minimo do Cliente", null, 100, DataGridViewContentAlignment.MiddleRight, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "LimiteMaximo", "Lim. Maxímo", "Limite Maxímo do Cliente", null, 100, DataGridViewContentAlignment.MiddleRight, DataGridViewContentAlignment.MiddleLeft);
            carregar(cbxAtivos);
        }
        #endregion
        #region Controles
        private void btnInserir_Click(object sender, EventArgs e)
        {

            try
            {
                btnInserir.Click -= new EventHandler(btnInserir_Click);
                using (SlnEstagio.MOD001.FRM002 frm002 = new FRM002(null,Acao.INSERIR))
                {
                    if (frm002.ShowDialog() == DialogResult.OK)
                    {
                        this.cliente = frm002.cliente;
                        AtualizarGrid(this.cliente, false);
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
                Cliente clienteSelecionado = dgwColecao.GetlinhaSelecionado<Cliente>();

                if (clienteSelecionado == null)
                    return;

                using (SlnEstagio.MOD001.FRM002 frm002 = new FRM002(clienteSelecionado, Acao.ALTERAR))
                {
                    if (frm002.ShowDialog() == DialogResult.OK)
                    {
                        this.cliente = frm002.cliente;
                        AtualizarGrid(this.cliente, false);
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
                Cliente clienteSelecionado = dgwColecao.GetlinhaSelecionado<Cliente>();
                if (clienteSelecionado == null)
                    return;

                if (MessageBox.Show("Deseja excluir o cliente selecinado?", "Excluir Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    return;

                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[2];
                args[0] = "ExcluirCliente";
                args[1] = clienteSelecionado;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }

                int retorno;

                if (int.TryParse(mensagembackgroundWor, out retorno))
                {
                    if (retorno == 1)
                    {
                        ExibirMensagemAlerta("Cliente possui pedido não pode ser excluído, será desativado.");
                    }
                    else
                    {
                        ExibirMensagem("Cliente excluído com sucesso!");
                        AtualizarGrid(clienteSelecionado, true);
                    }
                }
                else
                {
                    ExibirMensagemErro("Não foi possível excluir Cliente! \n Motivo: " + mensagembackgroundWor);
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
        private void btnVMPesquisar_Click(object sender, EventArgs e)
        {

            try
            {
                btnPesquisar.Click -= new EventHandler(btnVMPesquisar_Click);
                if (string.IsNullOrEmpty(txtVMPesquisar.Text))
                {
                    ExibirMensagem("Informar conteudo para VMPesquisa!");
                    txtVMPesquisar.Focus();
                }
                AtualizarGrid(null, false);
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnPesquisar.Click += new EventHandler(btnVMPesquisar_Click);
            }
        }


        private void AtualizarGrid(Cliente Cliente, bool booExcluir)
        {
            try
            {
                object FiltroExcluir = null;

                if (booExcluir)
                {
                    FiltroExcluir = (LocalizarFiltroExcluir(dgwColecao) as Cliente).GetChavePrimaria();
                    dgwColecao.DataSource = null;
                    clienteCollection.Remove(Cliente);
                }
                else
                {
                    if (Cliente != null)
                    {
                        var Item = from p in clienteCollection
                                   where p.GetChavePrimaria() == Cliente.GetChavePrimaria()
                                   select p;

                        if (Item.Count() == 1)
                        {
                            Cliente ClienteSelecionado = Item.First();
                            ClienteSelecionado = Cliente;
                        }
                        else
                            clienteCollection.Add(Cliente);
                    }
                    else
                    {
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                        object[] args = new object[3];
                        args[0] = "VMPesquisarCliente";
                        args[1] = txtVMPesquisar.Text;
                        args[2] = cbxAtivos.SelectedValue;
                        backgroundWorker1.RunWorkerAsync(args);
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                    }
                }

                dgwColecao.DataSource = null;
                if (clienteCollection.Count() > 0)
                    dgwColecao.DataSource = clienteCollection;

                txtRegistro.Text = dgwColecao.Rows.Count.ToString();

                //if (objCliente != null)
                //    LocalizarIndexLinha(dgwColecao, FiltroExcluir == null ? objCliente.GetChavePrimaria() : FiltroExcluir);

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
        private void btnEndereco_Click(object sender, EventArgs e)
        {

            try
            {
                btnEndereco.Click -= new EventHandler(btnEndereco_Click);
                Cliente clienteSelecionado = dgwColecao.GetlinhaSelecionado<Cliente>();
                if (clienteSelecionado == null)
                    return;

                using (SlnEstagio.MOD001.FRM004 frm004 = new FRM004(clienteSelecionado))
                {
                    frm004.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnEndereco.Click += new EventHandler(btnEndereco_Click);
            }
        }
        private void btnEmail_Click(object sender, EventArgs e)
        {
            try
            {
                btnEmail.Click -= new EventHandler(btnEmail_Click);
                Cliente clienteSelecionado = dgwColecao.GetlinhaSelecionado<Cliente>();

                if (clienteSelecionado == null)
                    return;
                using (SlnEstagio.MOD001.FRM006 frm006 = new FRM006(clienteSelecionado))
                {
                    frm006.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnEmail.Click += new EventHandler(btnEmail_Click);
            }
        }
        private void txtVMPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                txtVMPesquisar.KeyDown -= new KeyEventHandler(txtVMPesquisar_KeyDown);
                if (e.KeyCode == Keys.Enter && btnPesquisar.Enabled == true)
                    btnVMPesquisar_Click(null, null);
            }
            catch (Exception ex)
            {

                Exceptionerro(ex);
            }
            finally
            {
                txtVMPesquisar.KeyDown += new KeyEventHandler(txtVMPesquisar_KeyDown);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region BackGroundWork
        string mensagembackgroundWor;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("VMPesquisarCliente"))
            {
                this.clienteCollection = this.negCliente.PesquisarCliente(args[1].ToString(), (bool?)args[2]);
            }
            else if (args[0].Equals("ExcluirCliente"))
            {
                this.mensagembackgroundWor = negCliente.Excluir(args[1] as Cliente);
            }
            else if (args[0].Equals(""))
            {
                //this.mensagembackgroundWor = 
            }
        }

        #endregion

        private void FRM003_Shown(object sender, EventArgs e)
        {
            try
            {
                carregar(cbxAtivos);
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
        }
    }
}
