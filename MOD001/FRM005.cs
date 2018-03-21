using SlnEstagio.ObjetoTransferencia;
using SlnEstagio.WINBASE;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using SlnEstagio.Negocio;
namespace SlnEstagio.MOD001
{
    public partial class FRM005 : FRMBASE
    {
        public Cliente cliente = new Cliente();
        NegCliente negCliente = new NegCliente();
        NegEndereco negEndereco = new NegEndereco();
        Endereco endereco = new Endereco();
        Acao acao;
        public FRM005()
        {
            InitializeComponent();
        }

        public FRM005(Cliente cliente, Acao acao)
        {
            InitializeComponent();

            this.cliente = cliente;
            this.acao = acao;
        }

        //public FRM005(Endereco endereco, Acao acao)
        //{
        //    InitializeComponent();
        //    this.endereco = endereco;
        //    this.acao = acao;
        //}

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                btnSalvar.Click -= new EventHandler(btnSalvar_Click);
                if (this.cliente.Endereco == null)
                {
                    this.cliente.Endereco = new Endereco();
                }
                this.cliente.Endereco.Logradouro = txtLogradouro.Text;
                this.cliente.Endereco.Bairro = txtBairro.Text;
                this.cliente.Endereco.Cidade = txtCidade.Text;
                this.cliente.Endereco.Complemento = txtComplemento.Text;
                this.cliente.Endereco.Numero = Convert.ToInt32(txtnumero.Text);
                this.cliente.Endereco.Cep = Convert.ToDecimal(txtCep.Text);

                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }

                if (ValidarCampos(this, true)>0)
                {
                    ExibirMensagem("Preencher os campos obrigatórios!");
                    return;
                }

                object[] args = new object[4];
                args[0] = "SalvarClienteEndereco";
                args[1] = this.cliente.Endereco;
                args[2] = this.acao;
                args[3] = this.cliente.Pessoa.IDPessoa;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int retorno;
                if (int.TryParse(mensagembackgroundWor, out retorno))
                {
                    ExibirMensagem("Endereço do cliente cadastrado com sucesso!");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    ExibirMensagemErro("Não foi possível cadastrar endereço para cliente.");
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

        private void FRM005_Shown(object sender, EventArgs e)
        {
            try
            {
                txtCliente.Text = this.cliente.Pessoa.IDPessoa.ToString() + " - " + this.cliente.Pessoa.Nome;
                if (this.acao == Acao.ALTERAR)
                {
                    this.Text = "ALTERAR ENDEREÇO CLIENTE";
                    btnFechar.Text = "&CANCELAR";
                    txtLogradouro.Text = this.cliente.Endereco.Logradouro;
                    txtBairro.Text = this.cliente.Endereco.Bairro;
                    txtCep.Text = this.cliente.Endereco.Cep.ToString();
                    txtComplemento.Text = this.cliente.Endereco.Complemento;
                    txtnumero.Text = this.cliente.Endereco.Numero.ToString();
                    txtCidade.Text = this.cliente.Endereco.Cidade;
                }
                else if (this.acao == Acao.CONSULTAR)
                {
                    this.Text = "CONSULTAR ENDEREÇO CLIENTE";
                    btnSalvar.Enabled = false;
                    btnSalvar.Visible = false;
                    btnFechar.Text = "&FECHAR";
                    txtLogradouro.Text = this.cliente.Endereco.Logradouro;
                    txtBairro.Text = this.cliente.Endereco.Bairro;
                    txtCep.Text = this.cliente.Endereco.Cep.ToString();
                    txtComplemento.Text = this.cliente.Endereco.Complemento;
                    txtnumero.Text = this.cliente.Endereco.Numero.ToString();
                    txtCidade.Text = this.cliente.Endereco.Cidade;
                }
            }
            catch (Exception ex)
            {

                Exceptionerro(ex);
            }
        }


        string mensagembackgroundWor;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("SalvarClienteEndereco"))
            {
                if ((Acao)args[2] == Acao.INSERIR)
                    this.mensagembackgroundWor = negEndereco.Inserir(args[1] as Endereco, (int)args[3]);
                else if ((Acao)args[2] == Acao.ALTERAR)
                    this.mensagembackgroundWor = negEndereco.Alterar(args[1] as Endereco, (int)args[3]);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
