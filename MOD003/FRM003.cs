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
    public partial class FRM003 : FRMBASE
    {
        NegContasReceber negContasReceber = new NegContasReceber();
        public ContasaReceber contasReceber { get; internal set; }
        NegTipoPagamento negTipoPagamento = new NegTipoPagamento();
        public FRM003( ContasaReceber contasReceber)
        {
            InitializeComponent();

            this.contasReceber = contasReceber;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {

            try
            {
                btnFechar.Click -= new EventHandler(btnFechar_Click);
                this.DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnFechar.Click += new EventHandler(btnFechar_Click);
            }
        }

        private void FRM003_Shown(object sender, EventArgs e)
        {
            try
            {
                negTipoPagamento.CarregarComboListTipoPagamento(cbxTipoPgamento);
                txtCodigoCliente.Text = this.contasReceber.Cliente.Pessoa.GetChavePrimaria();
                txtNomeCliente.Text = this.contasReceber.Cliente.Pessoa.Nome;
                txtValorTotal.Text = this.contasReceber.ValorTotal.ToString();
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            try
            {
                txtDesconto.Leave -= new EventHandler(txtDesconto_Leave);
                decimal desconto = 0;
                decimal total = 0;
                if (string.IsNullOrEmpty(txtDesconto.Text) || txtDesconto.Equals("0"))
                {
                    txtValorPagar.Text = this.contasReceber.ValorTotal.ToString();
                    return;
                }
                if (rbtPorcentagem.Checked)
                {
                    desconto = Convert.ToDecimal(txtDesconto.Text);

                    total = this.contasReceber.ValorTotal -((this.contasReceber.ValorTotal * desconto) / 100);

                    txtValorPagar.Text = Convert.ToString(total);
                }
                else
                {
                    desconto = Convert.ToDecimal(txtDesconto.Text);

                    total = (this.contasReceber.ValorTotal - desconto);

                    txtValorPagar.Text = Convert.ToString(total);
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                txtDesconto.Leave += new EventHandler(txtDesconto_Leave);
            }
        }

        private void btnBaixar_Click(object sender, EventArgs e)
        {

            try
            {
                btnBaixar.Click -= new EventHandler(btnBaixar_Click);
                if (cbxTipoPgamento.SelectedValue == null)
                {
                    ExibirMensagem("É obrigatório escolher um TIPO DE PAGAMENTO!");
                    cbxTipoPgamento.Focus();
                    return;
                }

                this.contasReceber.TipoPagamento = new TipoPagamento
                {
                    IDTipoPagamento = (int)cbxTipoPgamento.SelectedValue,
                    Descricao = cbxTipoPgamento.SelectedText
                };
                this.contasReceber.ValorPagar = Convert.ToDecimal(txtValorPagar.Text);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[3];
                args[0] = "EfetuarBaixa";
                args[1] = this.contasReceber;
                args[2] = (int?)null;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int resultado;
                if (int.TryParse(mensagembackgroundWor, out resultado))
                {
                    ExibirMensagem("Baixa de Conta efetuada com sucesso!");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    ExibirMensagemErro("Não foi possível efetuar baixa de conta.\n Motivo: " + mensagembackgroundWor);
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
                this.mensagembackgroundWor = negContasReceber.EfetuarBaixa(args[1] as ContasaReceber,(int?)args[2]);
            }
            else if (args[0].Equals(""))
            {
                //this.mensagembackgroundWor = 
            }
            else if (args[0].Equals(""))
            {
                //this.mensagembackgroundWor = 
            }
        }

        private void rbtPorcentagem_CheckedChanged(object sender, EventArgs e)
        {
            txtDesconto_Leave(null, null);
        }
    }
}
