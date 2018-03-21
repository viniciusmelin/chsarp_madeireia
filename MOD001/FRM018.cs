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
    public partial class FRM018 : FRMBASE
    {
        #region Forms
        NegEndereco negEndereco = new NegEndereco();
        Acao acao;
        //Fornecedor forncedor = new Fornecedor();
         public Endereco endereco = new Endereco();
        public FRM018()
        {
            InitializeComponent();
        }
        public FRM018(Endereco endereco, Acao acao)
        {
            InitializeComponent();
            this.endereco = endereco;
            this.acao = acao;
        }
        private void FRM018_Shown(object sender, EventArgs e)
        {
            if (this.acao == Acao.CONSULTAR || this.acao == Acao.ALTERAR)
            {
                txtFornecedor.Text = this.endereco.Pessoa.Nome;
                txtLogradouro.Text = this.endereco.Logradouro;
                txtBairro.Text = this.endereco.Bairro;
                txtnumero.Text = this.endereco.Numero.ToString();
                txtComplemento.Text = this.endereco.Complemento;
                txtCep.Text = this.endereco.Cep.ToString();
                txtCidade.Text = this.endereco.Cidade.ToString();

                this.Text = "ALTERAR ENDEREÇO FORNECEDOR";

                if (this.acao == Acao.CONSULTAR)
                {
                    this.Text = "CONSULTAR ENDEREÇO FORNECEDOR";
                    this.btnSalvar.Visible = false;
                    this.btnFechar.Text = "&FECHAR";
                }

            }
        }
        #endregion
        #region Controles

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                btnSalvar.Click -= new EventHandler(btnSalvar_Click);
                this.endereco.Logradouro = txtLogradouro.Text;
                this.endereco.Bairro = txtBairro.Text;
                this.endereco.Numero = Convert.ToInt32(txtnumero.Text);
                this.endereco.Complemento = txtComplemento.Text;
                this.endereco.Cep = Convert.ToDecimal(txtCep.Text);
                //this.forncedor.Endereco.Cidade = txtCidade.Text;
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[3];
                args[0] = "InserirEnderecoFornecedor";
                args[1] = this.endereco;
                args[2] = this.acao;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int retorno;
                if (int.TryParse(mensagembackgroundWor, out retorno))
                {
                    if (this.acao == Acao.INSERIR)
                    {
                        ExibirMensagem("Foi cadastrado com sucesso o endereço para fornecedor.");
                        this.endereco.IDEndereco = retorno;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        ExibirMensagem("Foi alterado com sucesso o endereço para fornecedor.");
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    if (this.acao == Acao.INSERIR)
                    {
                        ExibirMensagemErro("Não foi possível cadastrar o endereço para fornecedor.");

                    }
                    else
                    {
                        ExibirMensagemErro("Não foi possível alterar o endereço para fornecedor.");
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
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        #endregion
        #region BackGroundWork
        string mensagembackgroundWor;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            mensagembackgroundWor = string.Empty;
            object[] args = (object[])e.Argument;

            if (args[0].Equals("InserirEnderecoFornecedor"))
            {
                //if ((Acao)args[2] == Acao.INSERIR)
                //    this.mensagembackgroundWor = this.negEndereco.Inserir(args[2] as Endereco);
                //else if ((Acao)args[2] == Acao.ALTERAR)
                //    this.mensagembackgroundWor = this.negEndereco.Alterar(args[2] as Endereco);
            }
        }
        #endregion
    }
}
