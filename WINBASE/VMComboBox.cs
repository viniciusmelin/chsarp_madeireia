using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlnEstagio.WINBASE
{
    public class VMComboBox: ComboBox
    {
        //public VMComboBox()
        //{
        //    this.DropDownStyle = ComboBoxStyle.DropDownList;
        //    carregar();
        //}

        //void carregar()
        //{
        //    Dictionary<string, bool?> lista = new Dictionary<string, bool?>();
        //    lista.Add("TODOS",null);
        //    lista.Add( "SIM",true);
        //    lista.Add( "NÃO",false);
        //    this.ValueMember = "Value";
        //    this.DisplayMember = "Key";
        //    this.DataSource = new BindingSource(lista, null);
        //    this.SelectedIndex = -1;
        //}


        public bool VMRequerido { get; set; }
        public VMLabel GSLabelAssociado { get; set; }

    }
}
