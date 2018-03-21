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
    public partial class FRM029 : FRMBASE
    {
        NegTipoPagamento negTipoPagamento = new NegTipoPagamento();
        public TipoPagamento tipoPagamento { get; set; }
        public Acao Acao { get; set; }
        public FRM029(TipoPagamento tipoPagamento, Acao acao)
        {
            InitializeComponent();

            this.tipoPagamento = tipoPagamento;
            this.Acao = acao;

            if (this.tipoPagamento == null)
                this.tipoPagamento = new TipoPagamento();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                btnSalvar.Click -= new EventHandler(btSalvar_Click);
                if (string.IsNullOrEmpty(txtDescricao.Text))
                {
                    ExibirMensagem("Descrição não poder estar vazio!");
                    return;
                }
                //this.tipoPagamento.IDTipoPagamento = Convert.ToInt32(txtCodigo.Text);
                this.tipoPagamento.Descricao = txtDescricao.Text;
                this.tipoPagamento.Ativo = rbtSim.Checked;
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[2];
                args[0] = "SalvarTipoPagamento";
                args[1] = this.tipoPagamento;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int resultado;
                if (int.TryParse(mensagembackgroundWor, out resultado))
                {
                    this.tipoPagamento.IDTipoPagamento = resultado;
                    ExibirMensagem("Pagamento regsitrado com sucesso!");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    ExibirMensagemErro("Não foi possivel registrar Tipo de Pagamento.\n Motivo: "+mensagembackgroundWor);
                }

            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnSalvar.Click += new EventHandler(btSalvar_Click);
            }
        }

        string mensagembackgroundWor;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("SalvarTipoPagamento"))
            {
                if (this.Acao == Acao.INSERIR)
                    this.mensagembackgroundWor = negTipoPagamento.Inserir(args[1] as TipoPagamento);
                else if (this.Acao == Acao.ALTERAR)
                    this.mensagembackgroundWor = negTipoPagamento.Alterar(args[1] as TipoPagamento);
            }
        }

        private void FRM029_Shown(object sender, EventArgs e)
        {
            try
            {
                if (this.Acao == Acao.ALTERAR || this.Acao == Acao.CONSULTAR)
                {
                    txtCodigo.Text = this.tipoPagamento.GetChavePrimaria();
                    txtDescricao.Text = this.tipoPagamento.Descricao;
                    rbtSim.Checked = this.tipoPagamento.Ativo;
                    rbtNao.Checked = !rbtSim.Checked;

                    if (this.Acao == Acao.CONSULTAR)
                    {
                        this.btnSalvar.Enabled = this.btnSalvar.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
        }
    }
}
