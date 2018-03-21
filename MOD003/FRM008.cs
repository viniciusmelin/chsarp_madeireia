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

namespace SlnEstagio.MOD003
{
    public partial class FRM008 : FRMBASE
    {
        public ContasPagar ContasPagar { get; set; }
        NegContasPagar negContasPagar = new NegContasPagar();
        public FRM008(ContasPagar contaspagar)
        {
            InitializeComponent();
            this.ContasPagar = contaspagar;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FRM008_Shown(object sender, EventArgs e)
        {
            try
            {
                txtCodigo.Text = this.ContasPagar.IDContasPagar.ToString();
                txtFornecedor.Text = string.Concat(this.ContasPagar.Fornecedor.Pessoa.IDPessoa, "-", this.ContasPagar.Fornecedor.Pessoa.Nome);
                txtContasPagarTipo.Text = this.ContasPagar.ContasPagarTipo.Descricao;
                txtValor.Text = this.ContasPagar.Valor.ToString();
                txtDataLancamento.Text = this.ContasPagar.DataLancamento.ToString("dd/mm/yyyy");
                txtDataVencimento.Text = this.ContasPagar.DataVencimento.ToString("dd/mm/yyyy");
                //txtDataPagamento.Text = this.ContasPagar.DataPagamento == DateTime.MinValue ? DateTime.Now.ToString("dd/mm/yyyy") : this.ContasPagar.DataPagamento.Value.Date.ToString();
                txtDataPagamento.Text = this.ContasPagar.DataPagamento == null ? DateTime.Now.ToString("dd/mm/yyyy") : this.ContasPagar.DataPagamento.ToString();
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
        }

        private void btnBaixar_Click(object sender, EventArgs e)
        {

            try
            {
                btnBaixar.Click -= new EventHandler(btnBaixar_Click);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[4];
                args[0] = "EfetuarBaixa";
                args[1] = this.ContasPagar.IDContasPagar;
                args[2] = this.ContasPagar.OperacaoSituacao.Situacao.IDSituacao;
                args[3] = (int)EnumSituacao.PAGO;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int retorno;
                if (int.TryParse(mensagembackgroundWor, out retorno))
                {
                    this.ContasPagar.OperacaoSituacao.Situacao = new Situacao
                    {
                        IDSituacao = (int)EnumSituacao.PAGO,
                        Descricao = EnumSituacao.PAGO.ToString()
                    };

                    ExibirMensagem("Baixa efetuada com sucesso!");
                    this.ContasPagar.DataPagamento = DateTime.Now;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    ExibirMensagemErro("Não foi possível efetuar baixa! \n Motivo: " + mensagembackgroundWor);
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnBaixar.Click += new EventHandler(btnBaixar_Click);
            }
        }


        string mensagembackgroundWor;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("EfetuarBaixa"))
            {
                this.mensagembackgroundWor = negContasPagar.EfetuarBaixa((int)args[1], (int)args[2], (int)args[3]);
            }
        }
    }
}
