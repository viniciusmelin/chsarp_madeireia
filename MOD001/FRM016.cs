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
    public partial class FRM016 : FRMBASE
    {
        #region Forms
        public Fornecedor fornecedor = new Fornecedor();
        NegFornecedor negFornecedor = new NegFornecedor();
        FornecedorCollection forncedorCollection = new FornecedorCollection();
        Acao acao;
        public FRM016()
        {
            InitializeComponent();
        }
        public FRM016(Fornecedor fornecedor, Acao acao)
        {
            InitializeComponent();
            this.fornecedor = fornecedor;
            this.acao = acao;

            if (this.fornecedor.Pessoa == null)
                this.fornecedor.Pessoa = new Pessoa();
        }
        #endregion
        #region Controles
        private void FRM016_Shown(object sender, EventArgs e)
        {
            if (this.acao == Acao.CONSULTAR || this.acao == Acao.ALTERAR)
            {
                txtcodigo.Text = this.fornecedor.Pessoa.GetChavePrimaria();
                dtpDataCadastro.Value = this.fornecedor.DataCadastro;
                txtNome.Text = this.fornecedor.Pessoa.Nome;
                rbtSim.Checked = this.fornecedor.Pessoa.Ativo;
                rbtNao.Checked = !rbtSim.Checked;
                txtCpf.Text = this.fornecedor.Pessoa.CpfCnpj.ToString();
                txtInscEstadual.Text = this.fornecedor.IE;
                this.Text = "ALTERAR FORNECEDOR";
                if (this.acao == Acao.CONSULTAR)
                {
                    this.Text = "CONSULTAR FORNECEDOR";
                    this.btnFechar.Text = "&FECHAR";
                    btnSalvar.Visible = false;
                }
            }
        }
        private void btnFecharCliente_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                btnSalvar.Click -= new EventHandler(btnSalvar_Click);

                if (ValidarCampos(this, true) > 0)
                {
                    ExibirMensagemAlerta("Preencher todos os campos!");
                    return;
                }
                this.fornecedor.Pessoa.Nome = txtNome.Text;
                this.fornecedor.Pessoa.CpfCnpj = Convert.ToDecimal(txtCpf.Text);
                this.fornecedor.Pessoa.Ativo = rbtSim.Checked;
                this.fornecedor.IE = txtInscEstadual.Text;
                this.fornecedor.DataCadastro = dtpDataCadastro.Value;
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[3];
                args[0] = "InserirFornecedor";
                args[1] = this.fornecedor;
                args[2] = this.acao;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int retorno;
                if (int.TryParse(mensagembackgroundWor, out retorno))
                {
                    if (this.acao == Acao.INSERIR)
                    {
                        this.fornecedor.Pessoa.IDPessoa = retorno;
                        ExibirMensagem("Fornecedor cadastrado com sucesso!");
                        this.DialogResult = DialogResult.OK;

                    }
                    else if (this.acao == Acao.ALTERAR)
                    {
                        ExibirMensagem("Fornecedor alterado com sucesso!");
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    if (this.acao == Acao.INSERIR)
                    {
                        ExibirMensagemErro("Não foi possível cadastrar fornecedor.");


                    }
                    else if (this.acao == Acao.ALTERAR)
                    {
                        ExibirMensagemErro("Não foi possível alterar fornecedor.");
                    }
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnSalvar.Click += new EventHandler(btnSalvar_Click);
            }
        }
        #endregion
        #region BackGroundWork
        string mensagembackgroundWor;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("InserirFornecedor"))
            {
                if ((Acao)args[2] == Acao.INSERIR)
                    this.mensagembackgroundWor = negFornecedor.Inserir(args[1] as Fornecedor);
                else if ((Acao)args[2] == Acao.ALTERAR)
                    this.mensagembackgroundWor = negFornecedor.Alterar(args[1] as Fornecedor);
            }
        }
        #endregion
    }
}
