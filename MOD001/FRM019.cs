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
    public partial class FRM019 : FRMBASE
    {
        #region Forms
        Endereco endereco = new Endereco();
        Fornecedor fornecedor = new Fornecedor();
        NegEndereco negEndereco = new NegEndereco();
        EnderecoCollection enderecoCollection = new EnderecoCollection();
        public FRM019()
        {
            InitializeComponent();
        }

        public FRM019(Fornecedor fornecedor)
        {
            InitializeComponent();
            this.fornecedor = fornecedor;
        }
        private void FRM019_Shown(object sender, EventArgs e)
        {
            try
            {
                txtRazaoSocial.Text = this.fornecedor.Pessoa.Nome;
                object[] args = new object[2];
                args[0] = "VMPesquisarEnderecoFornecedor";
                args[1] = this.fornecedor;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }

            }
            catch (Exception ex)
            {

                ExibirMensagem(ex.Message);
            }
        }
        #endregion
        #region Controles
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            try
            {
                btnInserir.Click -= new EventHandler(btnInserir_Click);
                using (SlnEstagio.MOD001.FRM018 frm018 = new FRM018(null, Acao.INSERIR))
                {
                    if (frm018.ShowDialog() == DialogResult.OK)
                        this.endereco = frm018.endereco;
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnInserir.Click += new EventHandler(btnInserir_Click);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                btnExcluir.Click -= new EventHandler(btnExcluir_Click);
                Endereco enderecoSelecioando = dgwColecao.GetlinhaSelecionado<Endereco>();
                if (enderecoSelecioando == null)
                    return;

                if (ExibirMensagemPergunta("Deseja excluir endereço deste fornecedor", "EXCLUIR ENDEREÇO") == DialogResult.No)
                    return;

                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[2];
                args[0] = "ExcluirEnderecoFornecedor";
                args[1] = enderecoSelecioando;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int retorno;
                if (int.TryParse(mensagembackgroundWor, out retorno))
                {
                    ExibirMensagem("O endereço deste fornecedor foi excluído com sucesso!");
                }
                else
                    ExibirMensagemErro("Não foi possivel excluir endereço deste fornecedor!");
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnExcluir.Click += new EventHandler(btnExcluir_Click);
            }
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                btnAlterar.Click -= new EventHandler(btnAlterar_Click);
                Endereco enderecoSelecionado = dgwColecao.GetlinhaSelecionado<Endereco>();
                if (enderecoSelecionado == null)
                    return;

                using (SlnEstagio.MOD001.FRM018 frm018 = new FRM018(enderecoSelecionado, Acao.ALTERAR))
                {
                    if (frm018.ShowDialog() == DialogResult.OK)
                        this.endereco = frm018.endereco;
                }
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnAlterar.Click += new EventHandler(btnAlterar_Click);
            }
        }
        #endregion
        #region BackGroundWork
        string mensagembackgroundWor;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("ExcluirEnderecoFornecedor"))
            {
                this.mensagembackgroundWor = negEndereco.Excluir(args[1] as Endereco);
            }
            else if (args[0].Equals("VMPesquisarEnderecoFornecedor"))
            {
                this.enderecoCollection = negEndereco.VMPesquisarEnderecoFornecedor(args[1] as Fornecedor);
            }
        }
        #endregion
    }
}
