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
using SlnEstagio.Negocio;

namespace SlnEstagio.MOD001
{
    public partial class FRM008 : FRMBASE
    {
        #region Forms
        Fornecedor fornecedor = new Fornecedor();
        NegFornecedor negFornecedor = new NegFornecedor();
        FornecedorCollection fornecedorCollection = new FornecedorCollection();
        public FRM008()
        {
            InitializeComponent();
            AdicionarColunaTextBoxGrid(dgwColecao, "Pessoa.IDPessoa", "Código", "Código do Fornecedor", null, 60, DataGridViewContentAlignment.MiddleRight, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Pessoa.Nome", "Nome do Cliente", "Nome do Fornecedor", null, 250, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Pessoa.CpfCnpj", "CNPJ", "CNPJ do Fornecedor", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "DataCadastro", "Dt. Cadastro", "Data de Cadastro do Fornecedor", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "IE", "Insc.Inst.", "Inscrição Estadual do Fornecedor", null, 100, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaCheckBoxGrid(dgwColecao, "Pessoa.Ativo", "Ativo", "Cliente Ativo", null, 60, DataGridViewContentAlignment.MiddleCenter, DataGridViewContentAlignment.MiddleCenter);
            carregar(cbxAtivo);
        }
        #endregion
        #region Controles
        private void btnInserir_Click(object sender, EventArgs e)
        {

            try
            {
                btnInserir.Click -= new EventHandler(btnInserir_Click);
                using (SlnEstagio.MOD001.FRM016 frm016 = new FRM016(new Fornecedor(), Acao.INSERIR))
                {
                    if (frm016.ShowDialog() == DialogResult.OK)
                    {
                        this.fornecedor = frm016.fornecedor;
                        AtualizarGrid(this.fornecedor, false);
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
                Fornecedor fornecedorSelecionado = dgwColecao.GetlinhaSelecionado<Fornecedor>();
                if (fornecedorSelecionado == null)
                    return;
                using (SlnEstagio.MOD001.FRM016 frm016 = new FRM016(fornecedorSelecionado, Acao.ALTERAR))
                {
                    if (frm016.ShowDialog() == DialogResult.OK)
                    {
                        this.fornecedor = frm016.fornecedor;
                        AtualizarGrid(this.fornecedor, false);
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
                Fornecedor fornecedorSelecionado = dgwColecao.GetlinhaSelecionado<Fornecedor>();
                if (fornecedorSelecionado == null)
                    return;
                if (ExibirMensagemPergunta("Deseja excluir este fornecedor?", "EXCLUIR FORNECEDOR") == DialogResult.No)
                    return;

                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[2];
                args[0] = "ExcluirFornecedor";
                args[1] = fornecedorSelecionado;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int retorno;
                if (int.TryParse(mensagembackgroundWor, out retorno))
                {
                    ExibirMensagem("O forncedor foi excluído com sucesso!");
                    AtualizarGrid(fornecedorSelecionado, true);
                }
                else
                    ExibirMensagemErro("O fornecedor não pode ser excluído!");
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

        private void btnVMPesquisar_Click(object sender, EventArgs e)
        {

            try
            {
                btnPesquisar.Click -= new EventHandler(btnVMPesquisar_Click);
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


        private void AtualizarGrid(Fornecedor Fornecedor, bool booExcluir)
        {
            try
            {
                object FiltroExcluir = null;

                if (booExcluir)
                {
                    FiltroExcluir = (LocalizarFiltroExcluir(dgwColecao) as Fornecedor).GetChavePrimaria();
                    dgwColecao.DataSource = null;
                    fornecedorCollection.Remove(Fornecedor);
                }
                else
                {
                    if (Fornecedor != null)
                    {
                        var Item = from p in fornecedorCollection
                                   where p.GetChavePrimaria() == Fornecedor.GetChavePrimaria()
                                   select p;

                        if (Item.Count() == 1)
                        {
                            Fornecedor FornecedorSelecionado = Item.First();
                            FornecedorSelecionado = Fornecedor;
                        }
                        else
                            fornecedorCollection.Add(Fornecedor);
                    }
                    else
                    {
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                        object[] args = new object[3];
                        args[0] = "VMPesquisarFornecedor";
                        args[1] = txtVMPesquisar.Text;
                        args[2] = cbxAtivo.SelectedValue;
                        backgroundWorker1.RunWorkerAsync(args);
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                    }
                }

                dgwColecao.DataSource = null;
                if (fornecedorCollection.Count() > 0)
                    dgwColecao.DataSource = fornecedorCollection.ToList<Fornecedor>();

                txtRegistro.Text = dgwColecao.Rows.Count.ToString();

                //if (objFornecedor != null)
                //    LocalizarIndexLinha(dgwColecao, FiltroExcluir == null ? objFornecedor.GetChavePrimaria() : FiltroExcluir);

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
        private void btnEmail_Click(object sender, EventArgs e)
        {

            try
            {
                btnEmail.Click -= new EventHandler(btnEmail_Click);
                Fornecedor fornecedorSelecioando = dgwColecao.GetlinhaSelecionado<Fornecedor>();
                if (fornecedorSelecioando == null)
                    return;

                using (SlnEstagio.MOD001.FRM015 frm015 = new FRM015(fornecedorSelecioando))
                {
                    frm015.ShowDialog();
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
        #endregion
        #region BackGroundWork
        string mensagembackgroundWor;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("VMPesquisarFornecedor"))
            {
                int retorno;
                if (int.TryParse(args[1].ToString(), out retorno))
                    this.fornecedorCollection = negFornecedor.VMPesquisarFornecedorID(retorno, (bool?)args[2]);
                else
                    this.fornecedorCollection = negFornecedor.VMPesquisarFornecedorID(args[1].ToString(), (bool?)args[2]);
            }
            else if (args[0].Equals("ExcluirFornecedor"))
            {
                this.mensagembackgroundWor = negFornecedor.Excluir(args[1] as Fornecedor);
            }
        }
        #endregion

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
    }
}
