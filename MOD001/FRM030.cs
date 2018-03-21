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
    public partial class FRM030 : FRMBASE
    {

        #region Forms
        ContasPagarTipoCollection contasPagarCollection = new ContasPagarTipoCollection();
        NegContasPagarTipo negContasPagarTipo = new NegContasPagarTipo();
        public FRM030()
        {
            InitializeComponent();
            carregar(cbxAtivo);
            CarregarColuna();
        }

        void CarregarColuna()
        {
            AdicionarColunaTextBoxGrid(dgwColecao, "IDContasPagarTipo", "Código", "Código do Contas a Pagar", null, 60, DataGridViewContentAlignment.MiddleRight, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaTextBoxGrid(dgwColecao, "Descricao", "Descrição", "Descrição do Contas a Pagar", null, 300, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft);
            AdicionarColunaCheckBoxGrid(dgwColecao, "Ativo", "Ativo", "Ativo", null, 60, DataGridViewContentAlignment.MiddleCenter, DataGridViewContentAlignment.MiddleCenter);
        }
        private void AtualizarGrid(ContasPagarTipo ContasPagarTipo, bool booExcluir)
        {
            try
            {
                object FiltroExcluir = null;

                if (booExcluir)
                {
                    FiltroExcluir = (LocalizarFiltroExcluir(dgwColecao) as ContasPagarTipo).GetChavePrimaria();
                    dgwColecao.DataSource = null;
                    contasPagarCollection.Remove(ContasPagarTipo);
                }
                else
                {
                    if (ContasPagarTipo != null)
                    {
                        var Item = from p in contasPagarCollection
                                   where p.GetChavePrimaria() == ContasPagarTipo.GetChavePrimaria()
                                   select p;

                        if (Item.Count() == 1)
                        {
                            ContasPagarTipo ContasPagarTipoSelecionado = Item.First();
                            ContasPagarTipoSelecionado = ContasPagarTipo;
                        }
                        else
                            contasPagarCollection.Add(ContasPagarTipo);
                    }
                    else
                    {
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                        object[] args = new object[3];
                        args[0] = "ConsultarContasPagarTipo";
                        args[1] = txtVMPesquisar.Text;
                        args[2] = cbxAtivo.SelectedValue;
                        backgroundWorker1.RunWorkerAsync(args);
                        while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                    }
                }

                dgwColecao.DataSource = null;
                if (contasPagarCollection.Count() > 0)
                    dgwColecao.DataSource = contasPagarCollection.ToList<ContasPagarTipo>();

                txtRegistro.Text = dgwColecao.Rows.Count.ToString();

                //if (objContasPagarTipo != null)
                //    LocalizarIndexLinha(dgwColecao, FiltroExcluir == null ? objContasPagarTipo.GetChavePrimaria() : FiltroExcluir);

                dgwColecao.Update();
                dgwColecao.Refresh();

                if (dgwColecao.RowCount > 0)
                    dgwColecao.Focus();

            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
        }
        #endregion
        #region Controles
        private void btnVMPesquisar_Click(object sender, EventArgs e)
        {

            try
            {
                btnVMPesquisar.Click -= new EventHandler(btnVMPesquisar_Click);
                AtualizarGrid(null, false);
            }
            catch (Exception ex)
            {
                Exceptionerro(ex);
            }
            finally
            {
                btnVMPesquisar.Click += new EventHandler(btnVMPesquisar_Click);
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                btnExcluir.Click -= new EventHandler(btnExcluir_Click);

                ContasPagarTipo contasPagarTipoSelecionado = dgwColecao.GetlinhaSelecionado<ContasPagarTipo>();

                if (contasPagarTipoSelecionado == null)
                    return;
                if (ExibirMensagemPergunta("Deseja excluir o registro selecionado?","EXCLUIR REGISTRO") != DialogResult.Yes)
                    return;

                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                object[] args = new object[2];
                args[0] = "ContasPagarTipoExcluir";
                args[1] = contasPagarTipoSelecionado;
                backgroundWorker1.RunWorkerAsync(args);
                while (backgroundWorker1.IsBusy) { Application.DoEvents(); }
                int retorno;

                if (int.TryParse(mensagembackgroundWor, out retorno))
                {
                    ExibirMensagem("Contas a Pagar Tipo foi excluído com sucesso!");
                    AtualizarGrid(contasPagarTipoSelecionado, true);
                }
                else
                {
                    ExibirMensagemErro("Não foi possível excluir o Contas a Pagar. \n Motivo: " + mensagembackgroundWor);
                }
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

                ContasPagarTipo contasPagarTipoSel = dgwColecao.GetlinhaSelecionado<ContasPagarTipo>();
                if (contasPagarTipoSel == null)
                    return;

                using (MOD001.FRM031 frm031 = new FRM031(contasPagarTipoSel, Acao.ALTERAR))
                {
                    if (frm031.ShowDialog() == DialogResult.OK)
                    {
                        AtualizarGrid(frm031.contasPagarTipo, false);
                    }
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

        private void btnInserir_Click(object sender, EventArgs e)
        {

            try
            {
                btnInserir.Click -= new EventHandler(btnInserir_Click);

                using (MOD001.FRM031 frm031 = new FRM031(new ContasPagarTipo(), Acao.INSERIR))
                {
                    if (frm031.ShowDialog() == DialogResult.OK)
                        AtualizarGrid(frm031.contasPagarTipo, false);
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
        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtVMPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                txtVMPesquisar.KeyDown -= new KeyEventHandler(txtVMPesquisar_KeyDown);

                if (e.KeyCode == Keys.Enter && btnVMPesquisar.Enabled == true)
                    btnVMPesquisar_Click(null, null);
            }
            catch (Exception ex)
            {

                Exceptionerro(ex);
            }
            finally
            {
                txtVMPesquisar.KeyDown += new KeyEventHandler(txtVMPesquisar_KeyDown);
            }
        }
        #endregion
        #region BackGroundWork
        string mensagembackgroundWor;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;

            if (args[0].Equals("ConsultarContasPagarTipo"))
            {
                this.contasPagarCollection = negContasPagarTipo.Pesquisar(args[1].ToString(), (bool?)args[2]);
            }
            else if (args[0].Equals("ContasPagarTipoExcluir"))
            {
                this.mensagembackgroundWor = negContasPagarTipo.Excluir(args[1] as ContasPagarTipo);
            }
        }
        #endregion

    }
}
