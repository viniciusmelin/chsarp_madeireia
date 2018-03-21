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
    public partial class FRM002 : FRMBASE
    {
        NegPedido negPedido = new NegPedido();
        NegContasReceber negContasReceber = new NegContasReceber();
        Pedido pedido;
        public ContasaReceber contasReceber { get; internal set; }
        public Acao acao { get; internal set; }
        public FRM002()
        {
            InitializeComponent();
        }
        public FRM002(ContasaReceber contasReceber, Acao acao)
        {
            InitializeComponent();
            this.contasReceber = contasReceber;
            this.acao = acao;
            if (this.contasReceber == null)
                this.contasReceber = new ContasaReceber();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                btnSalvar.Click -= new EventHandler(btnSalvar_Click);
                if (txtCliente.VMPesquisaValor == null)
                {
                    ExibirMensagem("É preciso informar um cliente!");
                    txtCliente.Focus();
                    return;
                }
                if (txtCliente.VMPesquisaValor == null)
                {
                    ExibirMensagem("É preciso informar um valor!");
                    txtCliente.Focus();
                    return;
                }

                decimal valor;
                if (!decimal.TryParse(txtValor.Text, out valor) || valor == 0)
                {
                    ExibirMensagemAlerta("Valor não poder ser menor ou igual á zero!");
                    txtValor.Focus();
                    return;
                }
                this.contasReceber.DataLancamento = dtpDataLancamento.Value.Value;
                this.contasReceber.DataVencimento = dtpDataVencimento.Value.Value;
                this.contasReceber.DataPagamento = dtpDataPagamento.Value;
                this.contasReceber.ValorTotal = valor;
                this.contasReceber.Cliente = new Cliente
                {
                    Pessoa = (txtCliente.VMPesquisaValor as Cliente).Pessoa
                };
                this.contasReceber.Vendedor = new Vendedor
                {
                    Pessoa = (txtVendedor.VMPesquisaValor as Vendedor).Pessoa
                };
                //this.contasReceber.Vendedor = ;
                //this.contasReceber.TipoPagamento = new TipoPagamento
                //{
                //    IDTipoPagamento = (int)cbxTipoPagamento.SelectedValue,
                //    Descricao = cbxTipoPagamento.SelectedText
                //};
                this.contasReceber.ContasReceberOrigem = new ContasReceberOrigem
                {
                    IDContasReceberOrigem = (int)EnumContasReceberOrigem.MANUAL,
                    Descricao = EnumContasReceberOrigem.MANUAL.ToString()
                };
                this.contasReceber.ContasReceberSituacao = new ContasReceberSitucao
                {
                    IDContasReceberSituacao = (int)EnumSituacaoContasReceber.ABERTA,
                    Descricao = EnumSituacaoContasReceber.ABERTA.ToString()
                };
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[2];
                args[0] = "SalvarContasReceber";
                args[1] = this.contasReceber;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int resultado;
                if (int.TryParse(mensagembackgroundWor, out resultado))
                {
                    this.contasReceber.IDContasaReceber = resultado;
                    ExibirMensagem("Contas Receber foi cadastrada com sucesso!");
                    this.DialogResult = DialogResult.OK;
                    
                }
                else
                {
                    ExibirMensagemErro("Não foi possível cadastrar o contas a receber! \n Motivo: "+ mensagembackgroundWor);
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


        private void btnPesqCliente_Click(object sender, EventArgs e)
        {

            try
            {
                btnPesqCliente.Click -= new EventHandler(btnPesqCliente_Click);

                using (SlnEstagio.MOD001.FRM020 frm020 = new MOD001.FRM020(txtCliente.Text, null))
                {
                    if (frm020.ShowDialog() == DialogResult.OK)
                    {
                        txtCliente.VMPesquisaValor = frm020.cliente;
                        txtCliente.Text = frm020.cliente.Pessoa.Nome;
                    }
                }

            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnPesqCliente.Click += new EventHandler(btnPesqCliente_Click);
            }
        }


        string mensagembackgroundWor;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("PesquisarPedido"))
            {
                this.pedido = negPedido.ConsultarPedidoporID((int)args[1]);
            }
            else if (args[0].Equals("SalvarContasReceber"))
            {
                if (this.acao == Acao.INSERIR)
                    this.mensagembackgroundWor = negContasReceber.Inserir(args[1] as ContasaReceber);
                else if (this.acao == Acao.ALTERAR)
                    this.mensagembackgroundWor = negContasReceber.Alterar(args[1] as ContasaReceber);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                txtCliente.KeyDown -= new KeyEventHandler(txtCliente_KeyDown);

                if (e.KeyCode == Keys.Enter && btnPesqCliente.Enabled == true)
                    btnPesqCliente_Click(null, null);
                else if (e.KeyCode == Keys.Enter && btnPesqCliente.Enabled == true)
                {
                    txtCliente.Clear();
                    txtCliente.VMPesquisaValor = null;
                    txtCliente.Focus();
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                txtCliente.KeyDown += new KeyEventHandler(txtCliente_KeyDown);
            }
        }

        private void txtVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                txtVendedor.KeyDown -= new KeyEventHandler(txtVendedor_KeyDown);
                if (e.KeyCode == Keys.Enter && btnPesqVendedor.Enabled == true)
                    btnPesqVendedor_Click(null, null);
                else if (e.KeyCode == Keys.Enter && btnPesqVendedor.Enabled == true)
                {
                    txtVendedor.Clear();
                    txtVendedor.VMPesquisaValor = null;
                    txtVendedor.Focus();
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                txtVendedor.KeyDown += new KeyEventHandler(txtVendedor_KeyDown);
            }
        }

        private void btnPesqVendedor_Click(object sender, EventArgs e)
        {

            try
            {
                btnPesqVendedor.Click -= new EventHandler(btnPesqVendedor_Click);
                using (MOD001.FRM021 frm021 = new MOD001.FRM021(txtVendedor.Text, null))
                {
                    if (frm021.ShowDialog() == DialogResult.OK)
                    {
                        this.txtVendedor.VMPesquisaValor = frm021.vendedor;
                        txtVendedor.Text = frm021.vendedor.Pessoa.Nome;
                    }
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnPesqVendedor.Click += new EventHandler(btnPesqVendedor_Click);
            }
        }

        private void FRM002_Shown(object sender, EventArgs e)
        {
            try
            {
                if (this.acao == Acao.CONSULTAR || this.acao == Acao.ALTERAR)
                {
                    this.txtCodigo.Text = this.contasReceber.GetChavePrimaria();
                    this.txtValor.Text = this.contasReceber.ValorTotal.ToString();
                    this.txtVendedor.Text = this.contasReceber.Vendedor.Pessoa.Nome;
                    this.txtVendedor.VMPesquisaValor = this.contasReceber.Vendedor;
                    this.txtCliente.Text = this.contasReceber.Cliente.Pessoa.Nome;
                    this.txtCliente.VMPesquisaValor = this.contasReceber.Cliente;
                    this.txtPedido.Text = this.contasReceber.Pedido == null ? "0" : this.contasReceber.Pedido.IDPedido.ToString();
                    dtpDataLancamento.Value = this.contasReceber.DataLancamento;
                    dtpDataPagamento.Value = this.contasReceber.DataPagamento;
                    dtpDataVencimento.Value = this.contasReceber.DataVencimento;
                }
            }
            catch (Exception ex)
            {

                Exceptionerro(ex);
            }
        }
    }
}
