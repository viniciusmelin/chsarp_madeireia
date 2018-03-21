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
    public partial class FRM027 : FRMBASE
    {

        #region Forms
        public Vendedor vendedor { get; internal set; }
        Acao acao;
        public FRM027()
        {
            InitializeComponent();
        }

        public FRM027(Vendedor vendedor, Acao acao)
        {
            InitializeComponent();
            this.vendedor = vendedor;
            this.acao = acao;
            if (this.vendedor == null)
            {
                this.vendedor = new Vendedor { Pessoa = new Pessoa() };
            }
        }
        NegVendedor negVendedor = new NegVendedor();





        private void FRM027_Shown(object sender, EventArgs e)
        {
            try
            {
                if (acao == Acao.ALTERAR)
                {
                    txtcodigocliente.Text = this.vendedor.Pessoa.IDPessoa.ToString();
                    txtCpf.Text = this.vendedor.Pessoa.CpfCnpj.ToString();
                    dtpDataCadastro.Value = this.vendedor.DataCadastro;
                    rbtSim.Checked = this.vendedor.Pessoa.Ativo;
                    rbtNao.Checked = !rbtSim.Checked;
                    txtNome.Text = this.vendedor.Pessoa.Nome;
                    this.btnSalvar.Text = "&ALTERAR";
                    this.Text = "ALTERAR VENDEDOR";
                }
                if (acao == Acao.CONSULTAR)
                {
                    txtcodigocliente.Text = this.vendedor.Pessoa.IDPessoa.ToString();
                    txtCpf.Text = this.vendedor.Pessoa.CpfCnpj.ToString();
                    dtpDataCadastro.Value = this.vendedor.DataCadastro;
                    rbtSim.Checked = this.vendedor.Pessoa.Ativo;
                    rbtNao.Checked = !rbtSim.Checked;
                    txtNome.Text = this.vendedor.Pessoa.Nome;
                    this.btnSalvar.Enabled = this.btnSalvar.Visible = false;
                    this.Text = "CONSULTAR VENDEDOR";
                }
            }
            catch (Exception ex)
            {

                Exceptionerro(ex);
            }
        }

        #endregion
        #region Controles
        private void btnFecharCliente_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                btnSalvar.Click -= new EventHandler(btnSalvar_Click);
                this.vendedor.Pessoa.Nome = txtNome.Text;
                this.vendedor.Pessoa.Ativo = rbtSim.Checked;
                this.vendedor.DataCadastro = dtpDataCadastro.Value;

                if (string.IsNullOrEmpty(txtCpf.Text))
                {
                    ExibirMensagemAlerta("O CPF não poder ser vazio");
                    return;
                }
                this.vendedor.Pessoa.CpfCnpj = Convert.ToDecimal(txtCpf.Text);

                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    ExibirMensagemAlerta("O Nome do vendedor não pode ser vazio");
                    return;
                }

                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[2];
                args[0] = "SalvarVendedor";
                args[1] = this.vendedor;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int resultado;
                if (int.TryParse(mensagembackgroundWor, out resultado))
                {
                    if (this.acao == Acao.INSERIR)
                    {
                        this.vendedor.Pessoa.IDPessoa = resultado;
                        ExibirMensagem("O vendedor foi cadastrado com sucesso!");
                        this.DialogResult = DialogResult.OK;
                    }
                    if (this.acao == Acao.ALTERAR)
                    {
                        ExibirMensagem("O vendedor foi alterado com sucesso!");
                        this.DialogResult = DialogResult.OK;
                    }

                }
                else
                {
                    if (this.acao == Acao.INSERIR)
                    {
                        ExibirMensagemErro(string.Format("Não foi possível inserir vendedor! \n Motivo: {0}", mensagembackgroundWor));
                    }
                    if (this.acao == Acao.ALTERAR)
                    {
                        ExibirMensagemErro(string.Format("Não foi possível alterar vendedor! \n Motivo: {0}", mensagembackgroundWor));
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

            if (args[0].Equals("SalvarVendedor"))
            {
                if (acao == Acao.INSERIR)
                    this.mensagembackgroundWor = negVendedor.Inserir(args[1] as Vendedor);
                else
                    this.mensagembackgroundWor = negVendedor.Alterar(args[1] as Vendedor);
            }
        }
        #endregion
    }
}
