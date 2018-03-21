using SlnEstagio.Negocio;
using SlnEstagio.ObjetoTransferencia;
using SlnEstagio.WINBASE;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SlnEstagio.MOD001
{
    public partial class FRM014 : FRMBASE
    {

        #region Forms
        public Produto produto = new Produto();
        NegProduto negProduto = new NegProduto();
        Acao acao;
        public FRM014()
        {
            InitializeComponent();
        }

        public FRM014(Produto produto, Acao acao)
        {
            InitializeComponent();

            this.produto = produto == null ? new Produto(): produto;
            this.acao = acao;
        }
        private void FRM014_Shown(object sender, EventArgs e)
        {

            if (this.acao == Acao.ALTERAR || this.acao == Acao.CONSULTAR)
            {
                txtAltura.Text = this.produto.Altura.ToString();
                txtCodigo.Text = this.produto.GetChavePrimaria();
                txtDescricao.Text = this.produto.Descricao;
                txtLargura.Text = this.produto.Largura.ToString();
                rbtSim.Checked = this.produto.Ativo;
                txtProfundidade.Text = this.produto.Profundidade.ToString();
                lblCubagem.Text = this.produto.Cubagem.ToString();
                txtQuanMin.Text = this.produto.QuantidadeMinina.ToString();
                txtPreco.Text = this.produto.Preco.ToString();
                this.Text = "ALTERAR PRODUTO";

                if (this.acao == Acao.CONSULTAR)
                {
                    this.Text = "CONSULTAR PRODUTO";
                    this.btnCancelar.Text = "&FECHAR";
                }
            }
        }
        #endregion
        #region Controles
        private void btnFechar_Click(object sender, EventArgs e)
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
                    ExibirMensagem("Preencher todos os campos!");
                    return;
                }
                decimal preco;
                if(!decimal.TryParse(txtPreco.Text, out preco) || preco ==0)
                {
                    ExibirMensagemAlerta("O preço do produto não poder ser Zero!");
                    txtPreco.Focus();
                    return;
                }
                this.produto.Descricao = txtDescricao.Text;
                this.produto.Altura = Convert.ToDecimal(txtAltura.Text);
                this.produto.QuantidadeMinina = Convert.ToDecimal(txtQuanMin.Text);
                this.produto.Profundidade = Convert.ToDecimal(txtProfundidade.Text);
                this.produto.Largura = Convert.ToDecimal(txtLargura.Text);
                this.produto.Ativo = rbtSim.Checked;
                this.produto.Cubagem = (this.produto.Altura * this.produto.Largura * this.produto.Profundidade);
                this.produto.Preco = preco;
                lblCubagem.Text = this.produto.Cubagem.ToString();

                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[3];
                args[0] = "InserirProduto";
                args[1] = this.produto;
                args[2] = this.acao;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int retorno;
                if (int.TryParse(mensagembackgroundWor, out retorno))
                {
                    if (this.acao == Acao.INSERIR)
                    {
                        ExibirMensagem("Produto cadastrado com sucesso!");
                        this.produto.IDProduto = retorno;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        ExibirMensagem("Produto alterado com sucesso!");
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    if (this.acao == Acao.INSERIR)
                    {
                        ExibirMensagemErro("Não foi possível cadastrar produto!");
                        this.DialogResult = DialogResult.Cancel;
                    }
                    else
                    {
                        ExibirMensagem("Não foi possível alterar produto!");
                        this.DialogResult = DialogResult.Cancel;
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

            if (args[0].Equals("InserirProduto"))
            {
                if ((Acao)args[2] == Acao.INSERIR)
                    this.mensagembackgroundWor = negProduto.Inserir(args[1] as Produto);
                else if ((Acao)args[2] == Acao.ALTERAR)
                    this.mensagembackgroundWor = negProduto.Alterar(args[1] as Produto);
            }
        }
        #endregion

        private void txtCubagemTotal_Leave(object sender, EventArgs e)
        {
            decimal resultado;
            resultado =(Convert.ToDecimal(txtAltura.Text) * (Convert.ToDecimal(txtLargura.Text) * (Convert.ToDecimal(txtProfundidade.Text))));
            lblCubagem.Text = string.Format("CUBAGEM: {0}", resultado);
        }
    }
}
