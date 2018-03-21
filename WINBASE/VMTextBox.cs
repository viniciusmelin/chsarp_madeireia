using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlnEstagio.WINBASE
{
    public class VMTextBox : TextBox
    {

        public bool VMPesquisa { get; set; } //É um campo do tipo PESQ, ou seja campo de VMPesquisa
        public object VMPesquisaValor { get; set; }

        public bool VMRequerido { get; set; }
        public VMLabel VMLabelAssociado { get; set; }
        public object VMValor { get; set; }

        private TipoDado _VMTipoDado;
        private string _VMascara;

        public VMTextBox()
        {
            this.CharacterCasing = CharacterCasing.Upper;
        }

        public TipoDado VMTipoDado
        {
            get
            {
                try
                {
                    return _VMTipoDado;
                }
                catch
                {
                    return TipoDado.Texto;
                }
            }
            set
            {
                try
                {
                    _VMTipoDado = value;
                    switch (_VMTipoDado)
                    {
                        case TipoDado.Inteiro:
                            this.Text = this.FormatarTexto("0");
                            this.MaxLength = 8;
                            break;
                        case TipoDado.Valor:
                            this.Text = this.FormatarTexto("0");
                            break;
                        case TipoDado.ValorNegativo:
                            this.Text = this.FormatarTexto("0");
                            break;
                        default:
                            this.Text = string.Empty;
                            break;
                    }
                }
                catch
                {
                }
            }
        }

        public string VMMascara
        {
            get
            {
                try
                {
                    return _VMascara;
                }
                catch
                {
                    return string.Empty;
                }
            }
            set
            {
                try
                {
                    _VMascara = value;
                    this.Text = FormatarTexto(this.Text);
                }
                catch
                {
                }
            }
        }




        //public bool PermitirNulo { get; set; }

        private string FormatarTexto(string strTexto)
        {
            try
            {
                string strRetorno = strTexto;

                if (!string.IsNullOrEmpty(this.VMMascara))
                {
                    switch (this.VMTipoDado)
                    {
                        case TipoDado.Inteiro:
                            strRetorno = Convert.ToInt32(strTexto).ToString(this.VMMascara);
                            break;
                        case TipoDado.Valor:
                            strRetorno = Convert.ToDecimal(strTexto).ToString(this.VMMascara, CultureInfo.CurrentCulture);
                            break;
                        case TipoDado.ValorNegativo:
                            strRetorno = Convert.ToDecimal(strTexto).ToString(this.VMMascara, CultureInfo.CurrentCulture);
                            break;
                    }
                }

                return strRetorno;
            }
            catch
            {
                return string.Empty;
            }
        }

        //Texto, Inteiro, Valor, Email, CPF, CNPJ, CPFCNPJ, IE
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            try
            {
                switch (this.VMTipoDado)
                {
                    case TipoDado.Inteiro:
                        if (!char.IsNumber(e.KeyChar) && !(char.IsControl(e.KeyChar)))
                            e.Handled = true;
                        break;
                    case TipoDado.Valor:
                        if (!char.IsNumber(e.KeyChar) && !(char.IsControl(e.KeyChar)) && !e.KeyChar.Equals(',')) //!e.KeyChar.Equals('.') &&
                            e.Handled = true;
                        break;
                    case TipoDado.ValorNegativo:
                        if (!e.KeyChar.Equals('-') && !char.IsNumber(e.KeyChar) && !(char.IsControl(e.KeyChar)) && !e.KeyChar.Equals(',')) //!e.KeyChar.Equals('.') &&
                            e.Handled = true;
                        break;
                    case TipoDado.CNPJ:
                        if (!char.IsNumber(e.KeyChar) && !(char.IsControl(e.KeyChar)))
                            e.Handled = true;
                        break;
                    case TipoDado.CPF:
                        if (!char.IsNumber(e.KeyChar) && !(char.IsControl(e.KeyChar)))
                            e.Handled = true;
                        break;
                    case TipoDado.CPFCNPJ:
                        if (!char.IsNumber(e.KeyChar) && !(char.IsControl(e.KeyChar)))
                            e.Handled = true;
                        break;
                }
                base.OnKeyPress(e);
            }
            catch
            {
            }
        }

        protected override void OnEnter(EventArgs e)
        {
            try
            {
                //Se estiver habilitado e não estiver somente leitura, então remove a formatação.
                if (this.Enabled.Equals(true) && this.ReadOnly.Equals(false))
                {
                    switch (this.VMTipoDado)
                    {
                        case TipoDado.Inteiro:
                            if (string.IsNullOrEmpty(this.Text))
                                this.Text = this.FormatarTexto("0");
                            break;
                        case TipoDado.Valor:
                            if (string.IsNullOrEmpty(this.Text))
                                this.Text = this.FormatarTexto("0");
                            else
                                this.Text = this.Text.Replace(".", string.Empty);
                            break;
                        case TipoDado.ValorNegativo:
                            if (string.IsNullOrEmpty(this.Text))
                                this.Text = this.FormatarTexto("0");
                            else
                                this.Text = this.Text.Replace(".", string.Empty);
                            break;

                    }

                    this.SelectAll();
                }

                base.OnEnter(e);
            }
            catch
            {
            }
        }

        protected override void OnValidated(EventArgs e)
        {
            try
            {
                this.VMValor = null;

                switch (this.VMTipoDado)
                {
                    case TipoDado.Inteiro:
                        try
                        {
                            if (string.IsNullOrEmpty(this.Text))
                                this.Text = this.FormatarTexto("0");

                            //this.VMValor = Convert.ToInt32(this.Text);
                            this.VMValor = Convert.ToInt32(this.Text.Replace(".", ""));
                        }
                        catch
                        {
                            MessageBox.Show("'" + this.Text + "' não é um inteiro válido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            this.Text = this.FormatarTexto("0");
                            this.VMValor = Convert.ToInt32(this.Text);
                        }

                        break;
                    case TipoDado.Valor:
                        try
                        {
                            if (string.IsNullOrEmpty(this.Text))
                                this.Text = this.FormatarTexto("0");

                            this.VMValor = Convert.ToDecimal(this.Text);
                        }
                        catch
                        {
                            MessageBox.Show("'" + this.Text + "' não é um valor válido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            this.Text = this.FormatarTexto("0");
                            this.VMValor = Convert.ToDecimal(this.Text);
                        }

                        break;
                    case TipoDado.ValorNegativo:
                        try
                        {
                            if (string.IsNullOrEmpty(this.Text))
                                this.Text = this.FormatarTexto("0");

                            this.VMValor = Convert.ToDecimal(this.Text);
                        }
                        catch
                        {
                            MessageBox.Show("'" + this.Text + "' não é um valor válido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            this.Text = this.FormatarTexto("0");
                            this.VMValor = Convert.ToDecimal(this.Text);
                        }
                        break;
                    case TipoDado.CPF:
                        try
                        {
                            if (this.ReadOnly.Equals(false) && this.Enabled.Equals(true))
                            {
                                if (Funcoes.CPFValido(this.Text))
                                    this.VMValor = this.Text;
                                else
                                    throw new Exception("CPF Inválido!");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("'" + this.Text + "' não é um CPF válido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            this.Text = this.FormatarTexto(string.Empty);
                            this.VMValor = null;
                        }

                        break;
                    case TipoDado.CNPJ:
                        try
                        {
                            if (this.ReadOnly.Equals(false) && this.Enabled.Equals(true))
                            {
                                if (Funcoes.CnpjValido(this.Text))
                                    this.VMValor = this.Text;
                                else
                                    throw new Exception("CNPJ Inválido!");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("'" + this.Text + "' não é um CNPJ válido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            this.Text = this.FormatarTexto(string.Empty);
                            this.VMValor = null;
                        }

                        break;



                }

                this.Text = this.FormatarTexto(this.Text);
                base.OnValidated(e);
            }
            catch
            {
            }
        }

    }
}
