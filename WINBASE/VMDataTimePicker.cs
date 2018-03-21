using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlnEstagio.WINBASE
{
    public class VMDataTimePicker : DateTimePicker
    {
        #region Variáveis

        private bool booIsNull;
        private string strValorNulo = string.Empty;
        private DateTimePickerFormat dtpFormat = DateTimePickerFormat.Long;
        private string strFormatoCustomizado = string.Empty;
        private string strFormatoComoString = string.Empty;
        private bool booAceitaNulo;

        #endregion

        #region Construtor

        public VMDataTimePicker()
            : base()
        {
            base.Format = DateTimePickerFormat.Custom;
            this.Format = DateTimePickerFormat.Long;
        }

        #endregion

        #region Propriedades públicas

        public VMLabel GSLabelAssociado { get; set; }

        [DefaultValue(false)]
        public bool VMAceitaNulo
        {
            get
            {
                return booAceitaNulo;
            }
            set
            {
                this.booAceitaNulo = value;
            }
        }

        public new DateTime? Value
        {
            get
            {
                if (booIsNull)
                    return null;
                else
                    return base.Value;
            }
            set
            {
                if (value.Equals(null))
                    SetarParaValorNulo();
                else
                {
                    TranformarValorParaDateTime();
                    base.Value = (DateTime)value;
                }
            }
        }

        [Browsable(true)]
        [DefaultValue(DateTimePickerFormat.Long), TypeConverter(typeof(Enum))]
        public new DateTimePickerFormat Format
        {
            get
            {
                return dtpFormat;
            }
            set
            {
                dtpFormat = value;
                SetarFormato();
                OnFormatChanged(EventArgs.Empty);
            }
        }

        public new string CustomFormat
        {
            get
            {
                return strFormatoCustomizado;
            }
            set
            {
                strFormatoCustomizado = value;
            }
        }

        #endregion

        #region Propriedades e métodos privados

        private string FormatarParaString
        {
            get
            {
                return strFormatoComoString;
            }
            set
            {
                strFormatoComoString = value;
                base.CustomFormat = value;
            }
        }

        private void SetarFormato()
        {
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            DateTimeFormatInfo objDateTimeFormatInfo = objCultureInfo.DateTimeFormat;

            switch (dtpFormat)
            {
                case DateTimePickerFormat.Long:
                    FormatarParaString = objDateTimeFormatInfo.LongDatePattern;
                    break;
                case DateTimePickerFormat.Short:
                    FormatarParaString = objDateTimeFormatInfo.ShortDatePattern;
                    break;
                case DateTimePickerFormat.Time:
                    FormatarParaString = objDateTimeFormatInfo.ShortTimePattern;
                    break;
                case DateTimePickerFormat.Custom:
                    FormatarParaString = this.CustomFormat;
                    break;
            }
        }

        private void SetarParaValorNulo()
        {
            booIsNull = true;
            base.CustomFormat = (strValorNulo == null || strValorNulo == string.Empty) ? " " : "'" + strValorNulo + "'";
        }

        private void TranformarValorParaDateTime()
        {
            if (booIsNull)
            {
                SetarFormato();
                booIsNull = false;
                base.OnValueChanged(new EventArgs());
            }
        }
        #endregion

        #region Métodos sobreescritos

        protected override void OnCloseUp(EventArgs e)
        {
            if (Control.MouseButtons == MouseButtons.None)
            {
                if (booIsNull)
                {
                    TranformarValorParaDateTime();
                    booIsNull = false;
                }
            }
            base.OnCloseUp(e);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            if ((e.KeyCode.Equals(Keys.Delete)) && VMAceitaNulo.Equals(true))
            {
                this.Value = null;
                OnValueChanged(EventArgs.Empty);
            }
            base.OnKeyUp(e);
        }

        #endregion
    }
}
