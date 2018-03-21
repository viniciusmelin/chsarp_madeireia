using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlnEstagio.WINBASE
{
    public class VMDataGridView : DataGridView
    {
        public VMDataGridView()
        {
            this.AutoGenerateColumns = false;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.RowHeadersWidth = 22;

        }

        public tipo GetlinhaSelecionado<tipo>()
        {
            try
            {
                if (SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Nenhum registro selecioando!","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return (tipo)Convert.ChangeType(null, typeof(tipo));
                }

                return (tipo)Convert.ChangeType(SelectedRows[0].DataBoundItem, typeof(tipo));
 

            }
            catch (Exception ex)
            {

                throw new  Exception(ex.Message);
            }
        }

        private object BindProperty(object objProperty, string strPropertyName)
        {
            try
            {
                object objRetorno = "";

                if (strPropertyName.Contains("."))
                {
                    PropertyInfo[] objPropertyInfo;
                    string strLeftPropertyName;

                    strLeftPropertyName = strPropertyName.Substring(0, strPropertyName.IndexOf("."));
                    if (objProperty != null) //Inserido 18/09/2010 para deixar passar propriedades nulas
                    {
                        objPropertyInfo = objProperty.GetType().GetProperties();

                        foreach (PropertyInfo propertyInfo in objPropertyInfo)
                        {
                            if (propertyInfo.Name == strLeftPropertyName)
                            {
                                objRetorno = BindProperty(propertyInfo.GetValue(objProperty, null), strPropertyName.Substring(strPropertyName.IndexOf(".") + 1));
                                break;
                            }
                        }
                    }
                }
                else
                {
                    Type tpyPropertyType;
                    PropertyInfo pfoPropertyInfo;

                    if (objProperty != null) //Inserido 21/10/2010 para deixar passar propriedades nulas
                    {
                        tpyPropertyType = objProperty.GetType();
                        pfoPropertyInfo = tpyPropertyType.GetProperty(strPropertyName);
                        objRetorno = pfoPropertyInfo.GetValue(objProperty, null);
                    }
                }

                return objRetorno;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        protected override void OnCellFormatting(DataGridViewCellFormattingEventArgs e)
        {

            base.OnCellFormatting(e);

            try
            {

                if ((this.Rows[e.RowIndex].DataBoundItem != null) && (this.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = BindProperty(this.Rows[e.RowIndex].DataBoundItem, this.Columns[e.ColumnIndex].DataPropertyName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // VMDataGridView
            // 
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.RowHeadersWidth = 22;
            this.RowTemplate.Height = 24;
            this.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
