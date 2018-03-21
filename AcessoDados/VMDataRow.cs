using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.AcessoDados
{
    public class VMDataRow
    {
        DataRow dataRow;

        public DataRow GetDataRow { get { return this.dataRow; } }

        public VMDataRow(DataRow dataRow)
        {
            this.dataRow = dataRow;
        }

        public Guid GetUsu(string nomeDaColuna)
        {
            if (!this.dataRow.Table.Columns.Contains(nomeDaColuna))
                throw new Exception("O resultado do banco de dados não possui a coluna " + nomeDaColuna);

            if (this.dataRow[nomeDaColuna] == DBNull.Value)
                throw new Exception("A coluna " + nomeDaColuna + " veio vazia do banco de dados");

            return new Guid(dataRow[nomeDaColuna].ToString());
        }

        public object GetObjNull(string nomeDaColuna)
        {
            if (!this.dataRow.Table.Columns.Contains(nomeDaColuna))
                return null;

            if (this.dataRow[nomeDaColuna] == DBNull.Value)
                return null;

            return this.dataRow[nomeDaColuna];
        }


        public int? GetIntNull(string nomeDaColuna)
        {
            if (!this.dataRow.Table.Columns.Contains(nomeDaColuna))
                return null;

            if (this.dataRow[nomeDaColuna] == DBNull.Value)
                return null;

            int intRetorno = 0;
            if (!Int32.TryParse(this.dataRow[nomeDaColuna].ToString(), out intRetorno))
                return null;

            return intRetorno;
        }

        public int GetInt(string nomeDaColuna)
        {
            int intRetorno = 0;

            if (!this.dataRow.Table.Columns.Contains(nomeDaColuna))
                return intRetorno;

            if (this.dataRow[nomeDaColuna] == DBNull.Value)
                return intRetorno;

            if (!Int32.TryParse(this.dataRow[nomeDaColuna].ToString(), out intRetorno))
                intRetorno = 0;

            return intRetorno;
        }

        public DateTime GetDat(string nomeDaColuna)
        {
            DateTime datRetorno = new DateTime();

            if (!this.dataRow.Table.Columns.Contains(nomeDaColuna))
                return datRetorno;

            if (this.dataRow[nomeDaColuna] == DBNull.Value)
                return datRetorno;

            if (!DateTime.TryParse(this.dataRow[nomeDaColuna].ToString(), out datRetorno))
                datRetorno = new DateTime();

            return datRetorno;
        }

        public DateTime? GetDatNull(string nomeDaColuna)
        {
            if (!this.dataRow.Table.Columns.Contains(nomeDaColuna))
                return null;

            if (this.dataRow[nomeDaColuna] == DBNull.Value)
                return null;

            DateTime datRetorno;
            if (!DateTime.TryParse(this.dataRow[nomeDaColuna].ToString(), out datRetorno))
                return null;

            return datRetorno;
        }


        public DateTimeOffset GetDatTimOffSet(string nomeDaColuna)
        {
            DateTimeOffset datRetorno = new DateTimeOffset();

            if (!this.dataRow.Table.Columns.Contains(nomeDaColuna))
                return datRetorno;

            if (this.dataRow[nomeDaColuna] == DBNull.Value)
                return datRetorno;

            if (!DateTimeOffset.TryParse(this.dataRow[nomeDaColuna].ToString(), out datRetorno))
                datRetorno = new DateTimeOffset();

            return datRetorno;
        }

        public DateTimeOffset? GetDatTimOffSetNull(string nomeDaColuna)
        {
            if (!this.dataRow.Table.Columns.Contains(nomeDaColuna))
                return null;

            if (this.dataRow[nomeDaColuna] == DBNull.Value)
                return null;

            DateTimeOffset datRetorno;
            if (!DateTimeOffset.TryParse(this.dataRow[nomeDaColuna].ToString(), out datRetorno))
                return null;

            return datRetorno;
        }

        public Boolean GetBoo(string nomeDaColuna)
        {
            Boolean booRetorno = false;

            if (!this.dataRow.Table.Columns.Contains(nomeDaColuna))
                return booRetorno;

            if (this.dataRow[nomeDaColuna] == DBNull.Value)
                return booRetorno;

            //Se no banco de dados passar 0 ou 1 digitado e não der o CAST to BIT, ele não entende como boolean.
            //if (!Boolean.TryParse(this.dataRow[nomeDaColuna].ToString(), out booRetorno))
            //    booRetorno = false;

            try
            {
                booRetorno = Convert.ToBoolean(this.dataRow[nomeDaColuna]);
            }
            catch
            {
                booRetorno = false;
            }


            return booRetorno;
        }

        public Boolean? GetBooNull(string nomeDaColuna)
        {
            if (!this.dataRow.Table.Columns.Contains(nomeDaColuna))
                return null;

            if (this.dataRow[nomeDaColuna] == DBNull.Value)
                return null;

            //Se no banco de dados passar 0 ou 1 digitado e não der o CAST to BIT, ele não entende como boolean.
            //if (!Boolean.TryParse(this.dataRow[nomeDaColuna].ToString(), out booRetorno))
            //booRetorno = false;

            bool booRetorno;
            try
            {
                booRetorno = Convert.ToBoolean(this.dataRow[nomeDaColuna]);
            }
            catch
            {
                booRetorno = false;
            }

            return booRetorno;
        }

        public String GetStr(string nomeDaColuna)
        {
            string strRetorno = string.Empty;

            if (!this.dataRow.Table.Columns.Contains(nomeDaColuna))
                return strRetorno;

            if (this.dataRow[nomeDaColuna] == DBNull.Value)
                return strRetorno;

            strRetorno = this.dataRow[nomeDaColuna].ToString();

            return strRetorno;
        }

        public Decimal GetDec(string nomeDaColuna)
        {
            Decimal decRetorno = 0;

            if (!this.dataRow.Table.Columns.Contains(nomeDaColuna))
                return decRetorno;

            if (this.dataRow[nomeDaColuna] == DBNull.Value)
                return decRetorno;

            if (!Decimal.TryParse(this.dataRow[nomeDaColuna].ToString(), out decRetorno))
                decRetorno = 0;

            return decRetorno;
        }

        public Decimal? GetDecNull(string nomeDaColuna)
        {
            if (!this.dataRow.Table.Columns.Contains(nomeDaColuna))
                return null;

            if (this.dataRow[nomeDaColuna] == DBNull.Value)
                return null;

            Decimal decRetorno;
            if (!Decimal.TryParse(this.dataRow[nomeDaColuna].ToString(), out decRetorno))
                return null;

            return decRetorno;
        }
    }
}
