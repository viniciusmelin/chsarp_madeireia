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
    public partial class FRM002 : FRMBASE
    {
        #region Forms
        ClienteCollection clienteCollection = new ClienteCollection();
        public Cliente cliente = new Cliente();
        NegCliente negCliente = new NegCliente();
        Acao acao = new Acao();
        private void FRM002_Shown(object sender, EventArgs e)
        {
            try
            {
                if (this.acao == Acao.CONSULTAR)
                {
                    this.Text = "CONSULTAR CLIENTE";
                    this.btnSalvarCliente.Enabled = false;
                    this.btnSalvarCliente.Visible = false;
                    this.btnFecharCliente.Text = "FECHAR";
                }
                else if (this.acao == Acao.ALTERAR)
                {
                    Text = "ALTERAR CLIENTE";
                    //txtNome.ReadOnly = true;

                    txtcodigocliente.Text = cliente.Pessoa.GetChavePrimaria();
                    txtNome.Text = cliente.Pessoa.Nome;
                    rbtSim.Checked = cliente.Pessoa.Ativo;
                    rbtNao.Checked = !rbtSim.Checked;
                    dtpDataCadastro.Value = cliente.DataCadastro;
                    dtpDataNascimento.Value = cliente.DataNascimento;
                    txtLimiteMaxCliente.Text = cliente.LimiteMaximo.ToString();
                    txtLimiteMinCliente.Text = cliente.LimiteMaximo.ToString();
                    txtCpf.Text = this.cliente.Pessoa.CpfCnpj.ToString();
                }


            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
        }
        public FRM002()
        {
            InitializeComponent();
        }
        public FRM002(Cliente cliente, Acao acao)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.acao = acao;
            if (this.cliente == null)
                this.cliente = new Cliente { Pessoa = new Pessoa() };
        }
        #endregion
        #region Controles
        private void btnFecharCliente_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {

            try
            {
                btnSalvarCliente.Click -= new EventHandler(btnSalvarCliente_Click);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }


                if (ValidarCampos(gbInformacoesCliente, false) > 0)
                {
                    ExibirMensagem("Preencher os campos necessários!");
                    return;
                }

                //cliente.Pessoa = new Pessoa();
                cliente.Pessoa.Nome = this.txtNome.Text;
                cliente.Pessoa.CpfCnpj = Convert.ToDecimal(this.txtCpf.Text);
                cliente.DataNascimento = dtpDataNascimento.Value;
                cliente.DataCadastro = dtpDataCadastro.Value;
                cliente.Pessoa.Ativo = rbtSim.Checked;
                cliente.LimiteMaximo = Convert.ToDecimal(txtLimiteMaxCliente.Text);
                cliente.LimiteMinino = Convert.ToDecimal(txtLimiteMinCliente.Text);
                object[] args = new object[3];
                args[0] = "InserirCliente";
                args[1] = this.cliente;
                args[2] = this.acao;
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int retorno;

                if (int.TryParse(mensagem, out retorno))
                {
                    this.cliente.Pessoa.IDPessoa = retorno;
                    if (acao == Acao.ALTERAR)
                        ExibirMensagem("Cliente foi alterado com sucesso!");
                    else if (acao == Acao.INSERIR)
                        ExibirMensagem("Cliente foi cadastrado com sucesso!");
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    if (acao == Acao.ALTERAR)
                        ExibirMensagemErro("Não foi possível alterar o cliente! \n Motivo: " + mensagem);
                    else if (acao == Acao.INSERIR)
                        ExibirMensagem("Não foi possível cadastrar o cliente! \n Motivo: " + mensagem);
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnSalvarCliente.Click += new EventHandler(btnSalvarCliente_Click);
            }

        }
        #endregion
        #region BackGroundWork
        string mensagem;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("InserirCliente"))
            {
                if ((int)args[2] == (int)Acao.INSERIR)
                    this.mensagem = negCliente.Inserir(args[1] as Cliente);
                else if ((int)args[2] == (int)Acao.ALTERAR)
                    this.mensagem = negCliente.Alterar((args[1] as Cliente));
            }
        }
        #endregion
    }
}
