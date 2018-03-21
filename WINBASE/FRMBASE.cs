using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SlnEstagio.WINBASE
{
    public partial class FRMBASE : Form
    {
        //List<string> OpenFormulario = new List<string>();

        public FRMBASE()
        {
            InitializeComponent();
        }
        //void verificar
        public void carregar(ComboBox cbx)
        {
            Dictionary<string, bool?> lista = new Dictionary<string, bool?>();
            lista.Add("TODOS", null);
            lista.Add("SIM", true);
            lista.Add("NÃO", false);
            cbx.ValueMember = "Value";
            cbx.DisplayMember = "Key";
            cbx.DataSource = new BindingSource(lista, null);
            cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx.SelectedIndex = 0;



        }
        public string Form { get; set; }
        public string Modulo { get; set; }
        public void carregar(ComboBox cbx, EnumTipoComboBox tipo, RichTextBox text)
        {
            if (EnumTipoComboBox.ATIVO == tipo)
            {
                Dictionary<string, bool?> lista = new Dictionary<string, bool?>();
                lista.Add("TODOS", null);
                lista.Add("SIM", true);
                lista.Add("NÃO", false);
                cbx.ValueMember = "Value";
                cbx.DisplayMember = "Key";
                cbx.DataSource = new BindingSource(lista, null);
                cbx.DropDownStyle = ComboBoxStyle.DropDownList;
                cbx.SelectedIndex = 0;
            }
            else
            {

            }




        }


        #region Colunas do Grid

        public void LimparColunasGrid(VMDataGridView dgwSelecao)
        {
            dgwSelecao.Columns.Clear();
        }

        private void AddColunaTextBox(
            DataGridView dgwSelecao,
            string strNomePropriedade,
            string strCabecalho,
            string strToolTipText,
            int intLargura,
            DataGridViewContentAlignment? objAlinhamentoGrid,
            DataGridViewContentAlignment? objAlinhamentoCabecalhoGrid,
            string strFormatoDados,
            bool booSomenteLeitura,
            Color? corFundo,
            object objTagPodeSerUtilizadaParaGuardarInformacoesExtras
        )
        {
            try
            {
                var colGrid = new DataGridViewTextBoxColumn();

                colGrid.DataPropertyName = strNomePropriedade;

                colGrid.HeaderText = strCabecalho;
                colGrid.Width = intLargura;

                if (objAlinhamentoGrid.HasValue)
                    colGrid.DefaultCellStyle.Alignment = objAlinhamentoGrid.Value;

                if (!string.IsNullOrWhiteSpace(strFormatoDados))
                    colGrid.DefaultCellStyle.Format = strFormatoDados;

                if (!string.IsNullOrWhiteSpace(strToolTipText))
                    colGrid.ToolTipText = strToolTipText;

                colGrid.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                if (objAlinhamentoCabecalhoGrid.HasValue)
                    colGrid.HeaderCell.Style.Alignment = objAlinhamentoCabecalhoGrid.Value;

                colGrid.ReadOnly = booSomenteLeitura;

                if (corFundo.HasValue)
                    colGrid.DefaultCellStyle.ForeColor = corFundo.Value;

                if (objTagPodeSerUtilizadaParaGuardarInformacoesExtras != null)
                    colGrid.Tag = objTagPodeSerUtilizadaParaGuardarInformacoesExtras;

                dgwSelecao.Columns.Add(colGrid);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método AdicionarColunaTextBoxGrid. Mensagem: " + ex.Message);
            }
        }

        private void AddColunaCheckBoxGrid(
             DataGridView dgwSelecao,
             string strNomePropriedade,
             string strCabecalho,
             string strToolTipText,
             string strNomeColuna,
             int intLargura,
             DataGridViewContentAlignment? objAlinhamentoGrid,
             DataGridViewContentAlignment? objAlinhamentoCabecalhoGrid,
             string strValorNulo,
             bool booSomenteLeitura
         )
        {
            try
            {
                var colGrid = new DataGridViewCheckBoxColumn();
                colGrid.SortMode = DataGridViewColumnSortMode.Automatic;
                colGrid.DataPropertyName = strNomePropriedade;
                colGrid.HeaderText = strCabecalho;
                colGrid.Name = strNomeColuna;
                colGrid.Width = intLargura;
                colGrid.ReadOnly = booSomenteLeitura;

                if (objAlinhamentoGrid.HasValue)
                    colGrid.DefaultCellStyle.Alignment = objAlinhamentoGrid.Value;

                if (!string.IsNullOrWhiteSpace(strValorNulo))
                    colGrid.DefaultCellStyle.NullValue = strValorNulo;

                if (!string.IsNullOrWhiteSpace(strToolTipText))
                    colGrid.ToolTipText = strToolTipText;

                if (objAlinhamentoCabecalhoGrid.HasValue)
                    colGrid.HeaderCell.Style.Alignment = objAlinhamentoCabecalhoGrid.Value;

                dgwSelecao.Columns.Add(colGrid);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método AdicionarColunaCheckBoxGrid. Mensagem: " + ex.Message);
            }
        }

        public void AdicionarColunaTextBoxGrid(
           DataGridView dgwSelecao,
           string strNomePropriedade,
           string strCabecalho,
           string strToolTipText,
           string strFormatoDados,
            int intLargura,
           DataGridViewContentAlignment? objAlinhamentoGrid,
           DataGridViewContentAlignment? objAlinhamentoCabecalhoGrid
           )
        {
            AddColunaTextBox(
                   dgwSelecao,
                   strNomePropriedade,
                   strCabecalho,
                   strToolTipText,
                   intLargura,
                   objAlinhamentoGrid,
                   objAlinhamentoCabecalhoGrid,
                   strFormatoDados,
                   true,
                   null,
                   null
                );
        }

        public void AdicionarColunaTextBoxGridAntigo(
            VMDataGridView dgwSelecao,
            string strNomePropriedade,
            string strCabecalho,
            int intLargura,
            DataGridViewContentAlignment? objAlinhamentoGrid,
            string strFormatoDados,
            string strToolTipText,
            DataGridViewContentAlignment? objAlinhamentoCabecalhoGrid
            )
        {
            AddColunaTextBox(
                   dgwSelecao,
                   strNomePropriedade,
                   strCabecalho,
                   strToolTipText,
                   intLargura,
                   objAlinhamentoGrid,
                   objAlinhamentoCabecalhoGrid,
                   strFormatoDados,
                   true,
                   null,
                   null
                );
        }

        public void AdicionarColunaTextBoxGridEditavel(
           DataGridView dgwSelecao,
           string strNomePropriedade,
           string strCabecalho,
           string strToolTipText,
           string strFormatoDados,
           int intLargura,
           DataGridViewContentAlignment? objAlinhamentoGrid,
           DataGridViewContentAlignment? objAlinhamentoCabecalhoGrid,
           Color? corFonte,
           object objTagPodeSerUtilizadaParaGuardarInformacoesExtras
           )
        {
            AddColunaTextBox(
                   dgwSelecao,
                   strNomePropriedade,
                   strCabecalho,
                   strToolTipText,
                   intLargura,
                   objAlinhamentoGrid,
                   objAlinhamentoCabecalhoGrid,
                   strFormatoDados,
                   false,
                   corFonte,
                   objTagPodeSerUtilizadaParaGuardarInformacoesExtras
                );
        }





        public void AdicionarColunaCheckBoxGridAntigo(
            VMDataGridView dgwSelecao,
            string strNomePropriedade,
            string strCabecalho,
            int intLargura,
            DataGridViewContentAlignment? objAlinhamentoGrid,
            string strValorNulo,
            string strToolTipText,
            DataGridViewContentAlignment? objAlinhamentoCabecalhoGrid)
        {

            AddColunaCheckBoxGrid(
                dgwSelecao,
                strNomePropriedade,
                strCabecalho,
                strToolTipText,
                "",
                intLargura,
                objAlinhamentoGrid,
                objAlinhamentoCabecalhoGrid,
                strValorNulo,
                true
             );
        }

        public void AdicionarColunaCheckBoxGrid(
            VMDataGridView dgwSelecao,
            string strNomePropriedade,
            string strCabecalho,
            string strToolTipText,
            string strValorNulo,
            int intLargura,
            DataGridViewContentAlignment? objAlinhamentoGrid,
            DataGridViewContentAlignment? objAlinhamentoCabecalhoGrid)
        {

            AddColunaCheckBoxGrid(
                dgwSelecao,
                strNomePropriedade,
                strCabecalho,
                strToolTipText,
                "",
                intLargura,
                objAlinhamentoGrid,
                objAlinhamentoCabecalhoGrid,
                strValorNulo,
                true
             );
        }

        public void AdicionarColunaCheckBoxGridSelecionavel(VMDataGridView dgwSelecao, string strNomePropriedade, string strNomeColuna, string strCabecalho, int intLargura, DataGridViewContentAlignment objAlinhamentoGrid, string strToolTipText, DataGridViewContentAlignment? objAlinhamentoCabecalhoGrid)
        {
            AddColunaCheckBoxGrid(
                dgwSelecao,
                strNomePropriedade,
                strCabecalho,
                strToolTipText,
                strNomeColuna,
                intLargura,
                objAlinhamentoGrid,
                objAlinhamentoCabecalhoGrid,
                null,
                false
             );
        }


        #endregion
        protected virtual object LocalizarFiltroExcluir(VMDataGridView dgwSelecao)
        {
            try
            {
                return
                    dgwSelecao.Rows[
                    (dgwSelecao.Rows.Count - 1) > dgwSelecao.SelectedRows[0].Index ?
                        (dgwSelecao.SelectedRows[0].Index + 1) :
                        (dgwSelecao.SelectedRows[0].Index <= 0) ? 0 : dgwSelecao.SelectedRows[0].Index - 1
                    ].DataBoundItem;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método LocalizarFiltroExcluir. Mensagem: " + ex.Message);
            }
        }

        public void Exceptionerro(Exception exception)
        {
            try
            {
                MessageBox.Show("Mensagem: " + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao exibir Exceção. Mensagem" + ex.Message);
            }
        }

        public DialogResult ExibirMensagem(string texto)
        {
            return MessageBox.Show(texto);
        }

        public DialogResult ExibirMensagemPergunta(string texto, string cabecalho)
        {
            return MessageBox.Show(texto, cabecalho, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        public DialogResult ExibirMensagemErro(string texto)
        {
            return MessageBox.Show("Erro motivo:\n" + texto, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DialogResult ExibirMensagemAlerta(string texto)
        {
            return MessageBox.Show(null, texto, "ALERTA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected int ValidarCampos(object containerPrincipal, bool validarContainerFilhos) //, bool validarContainerFilhos
        {
            try
            {
                int intRetorno = 0;

                foreach (Control objControl in (containerPrincipal as Control).Controls)
                {
                    if (objControl is VMTextBox)
                    {
                        if ((objControl as VMTextBox).VMRequerido)
                        {
                            //Se for um TextBox de VMPesquisa
                            if ((objControl as VMTextBox).VMPesquisa)
                            {
                                if ((objControl as VMTextBox).VMPesquisaValor == null)
                                {
                                    objErrorProvider.SetError(objControl, string.Format("O preenchimento do campo '{0}' é obrigatório.", (objControl as VMTextBox).VMLabelAssociado != null ? (objControl as VMTextBox).VMLabelAssociado.Text.Replace(":", string.Empty).Trim() : string.Empty));
                                    intRetorno++;
                                }
                                else
                                    objErrorProvider.SetError(objControl, string.Empty);
                            }
                            else
                            {
                                if ((objControl as VMTextBox).Text.Equals(string.Empty))
                                {
                                    objErrorProvider.SetError(objControl, string.Format("O preenchimento do campo '{0}' é obrigatório.", (objControl as VMTextBox).VMLabelAssociado != null ? (objControl as VMTextBox).VMLabelAssociado.Text.Replace(":", string.Empty).Trim() : string.Empty));
                                    intRetorno++;
                                }
                                else
                                    objErrorProvider.SetError(objControl, string.Empty);
                            }
                        }
                        else
                            objErrorProvider.SetError(objControl, string.Empty);
                    }
                    else if (objControl is VMComboBox)
                    {
                        if ((objControl as VMComboBox).VMRequerido)
                        {
                            if (
                                (objControl as VMComboBox).SelectedValue == null ||
                                (objControl as VMComboBox).Text.Equals("NENHUM") ||
                                (objControl as VMComboBox).Text.Equals("NENHUMA") ||
                                (objControl as VMComboBox).Text.Equals(string.Empty))
                            {
                                objErrorProvider.SetError(
                                    objControl,
                                    string.Format("O preenchimento do campo '{0}' é obrigatório.",
                                       (objControl as VMComboBox).GSLabelAssociado != null ?
                                       (objControl as VMComboBox).GSLabelAssociado.Text.Replace(":", string.Empty).Trim() :
                                       string.Empty));
                                intRetorno++;
                            }
                            else
                                objErrorProvider.SetError(objControl, string.Empty);
                        }
                    }
                    if (validarContainerFilhos && EhContainer(objControl))
                    {
                        intRetorno += ValidarCampos(objControl, true);
                    }

                }

                return intRetorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método ValidadarCampos. Mensagem: " + ex.Message);
            }
        }

        private bool EhContainer(Control ctrControle)
        {
            try
            {
                string[] strContainers = { "VMGroupBox", "VMTabControl", "TabControl", "TabPage", "VMGroupBox" };

                foreach (string strContainer in strContainers)
                {
                    if (ctrControle.GetType().Name.Equals(strContainer))
                        return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método EhContainer. Mensagem: " + ex.Message);
            }
        }

        //public void VerificarFormulario(Type formulario, Form frmbase, bool fechar)
        //{
        //    //((FRMBASE)Convert.ChangeType(formulario, typeof(Entidade))).ShowDialog();
        //    if ()
        //    {
        //        foreach (Form item in Application.OpenForms)
        //        {
        //            if (item.GetType().FullName == ((Form)Convert.ChangeType(formulario, typeof(formulario))).GetType().FullName)
        //            {
        //                ((Form)Convert.ChangeType(formulario, typeof(formu))).ShowDialog();
        //            }

        //        }

        //    }
        //    else
        //    {
        //        ((Form)Convert.ChangeType(formulario, typeof(Entidade))).Activate();
        //        ((Form)Convert.ChangeType(formulario, typeof(Entidade))).MdiParent = frmbase;
        //        ((Form)Convert.ChangeType(formulario, typeof(Entidade))).Show();

        //    }
        //}

        //public void VerificarFormulario(Type formulario, Form frmbase, bool fechar)
        //{
        //    //Form teste = (Form)Activator.CreateInstance(formulario);
        //    Form teste = (Form)Activator.CreateInstance(formulario);

        //    //object teste = (Form)Convert.ChangeType(formulario, TypeCode.Object);
        //    //Form teste = ((Form)Convert.ChangeType(formulario));
        //    if (f.e == teste.GetType().FullName )
        //    {

        //    }

        //    if (false)
        //    {
        //        //teste.Show();
        //    }
        //    else
        //    {
        //        //teste = new Form();
        //        teste.BringToFront();
        //        teste.Activate();
        //        teste.MdiParent = frmbase;
        //        teste.Show();
        //    }

        //}

        //public void OpenForm<T>(string caminho) where T : Form, new()
        //{
        //    string[] str = typeof(T).FullName.Split('.');
        //    Type t = Type.GetType(caminho + "," + str[0] + "." + str[1]);
        //    Form testeq = (FRMBASE)Activator.CreateInstance(t);
        //    if(true)
        //    {
        //        //testeq = new Form();

        //        Form tt = new T();
        //        testeq.Activate();
        //        testeq.Show();
        //    }
        //    else
        //    {
        //    }
        //}

        public void OpenForm<T>(string caminho) where T : Form, new()
        {
            string[] str = typeof(T).FullName.Split('.');
            Type t = Type.GetType(caminho + "," + str[0] + "." + str[1]);
            Form testeq = (Form)Activator.CreateInstance(t);
            if (true)
            {
                testeq.Activate();
                testeq.Show();
            }
            else
            {

            }
        }
    }
}
