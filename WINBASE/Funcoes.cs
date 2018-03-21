using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.WINBASE
{
    public class Funcoes
    {
        #region CPF e CNPJ

        public static bool CPFValido(string strCpf)
        {
            int[] intMultiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] intMultiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string strTempCpf;
            string strDigito;
            int intSoma;
            int intResto;

            strCpf = strCpf.Trim();
            strCpf = strCpf.Replace(".", "").Replace("-", "");

            if (strCpf.Length != 11)
                return false;

            strTempCpf = strCpf.Substring(0, 9);
            intSoma = 0;
            for (int i = 0; i < 9; i++)
                intSoma += int.Parse(strTempCpf[i].ToString()) * intMultiplicador1[i];

            intResto = intSoma % 11;
            if (intResto < 2)
                intResto = 0;
            else
                intResto = 11 - intResto;

            strDigito = intResto.ToString();

            strTempCpf = strTempCpf + strDigito;

            intSoma = 0;
            for (int i = 0; i < 10; i++)
                intSoma += int.Parse(strTempCpf[i].ToString()) * intMultiplicador2[i];

            intResto = intSoma % 11;
            if (intResto < 2)
                intResto = 0;
            else
                intResto = 11 - intResto;

            strDigito = strDigito + intResto.ToString();

            return strCpf.EndsWith(strDigito);
        }

        public static bool CnpjValido(string strCnpj)
        {
            int[] strMultiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] strMultiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int intSoma;
            int intResto;
            string strDigito;
            string strTempCnpj;

            strCnpj = strCnpj.Trim();
            strCnpj = strCnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (strCnpj.Length != 14)
                return false;

            strTempCnpj = strCnpj.Substring(0, 12);

            intSoma = 0;
            for (int i = 0; i < 12; i++)
                intSoma += int.Parse(strTempCnpj[i].ToString()) * strMultiplicador1[i];

            intResto = (intSoma % 11);
            if (intResto < 2)
                intResto = 0;
            else
                intResto = 11 - intResto;

            strDigito = intResto.ToString();

            strTempCnpj = strTempCnpj + strDigito;
            intSoma = 0;
            for (int i = 0; i < 13; i++)
                intSoma += int.Parse(strTempCnpj[i].ToString()) * strMultiplicador2[i];

            intResto = (intSoma % 11);
            if (intResto < 2)
                intResto = 0;
            else
                intResto = 11 - intResto;

            strDigito = strDigito + intResto.ToString();

            return strCnpj.EndsWith(strDigito);
        }

        public static string FormatarCpfCnpj(string strCpfCnpj)
        {
            if (string.IsNullOrEmpty(strCpfCnpj))
                return strCpfCnpj;

            strCpfCnpj = GetNumber(strCpfCnpj);

            if (strCpfCnpj.Length <= 11)
            {
                MaskedTextProvider mtpCpf = new MaskedTextProvider(@"000\.000\.000-00");
                mtpCpf.Set(ZerosEsquerda(strCpfCnpj, 11));
                return mtpCpf.ToString();
            }
            else
            {
                MaskedTextProvider mtpCnpj = new MaskedTextProvider(@"00\.000\.000/0000-00");
                mtpCnpj.Set(ZerosEsquerda(strCpfCnpj, 14));
                return mtpCnpj.ToString();
            }
        }

        #endregion
        public static string GetNumber(string strTexto)
        {
            string strRetorno = "";
            foreach (char chrTexto in strTexto)
            {
                if ((chrTexto == '0') ||
                    (chrTexto == '1') ||
                    (chrTexto == '2') ||
                    (chrTexto == '3') ||
                    (chrTexto == '4') ||
                    (chrTexto == '5') ||
                    (chrTexto == '6') ||
                    (chrTexto == '7') ||
                    (chrTexto == '8') ||
                    (chrTexto == '9'))
                    strRetorno += chrTexto;
            }
            return strRetorno;
        }
        public static string ZerosEsquerda(string strString, int intTamanho)
        {
            string strResult = "";
            for (int intCont = 1; intCont <= (intTamanho - strString.Length); intCont++)
            {
                strResult += "0";
            }
            return strResult + strString;
        }
    }
}
