using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODRELATORIO
{
    public class Relatorio
    {
        public string NomeArquivoRelatorio = string.Empty;
        public String CaminhoRelatorio; //Exemplo: "GS300.Erp.NFe.Relatorios.relDanfeRetrato.rdlc";
        //const int intValorMaximoExcel = 65536;

        protected ReportViewer objReportViewer = null;
        byte[] bytBuffer = null;

        public DataTable DataTable1 = null; //DataTable Principal
        public DataTable DataTable2 = null;
        public DataTable DataTable3 = null;
        public DataTable DataTable4 = null;
        public DataTable DataTable5 = null;
        public DataTable DataTable6 = null;
        public DataTable DataTable7 = null;
        public DataTable DataTable8 = null;
        public DataTable DataTable9 = null;
        public DataTable DataTable10 = null;
        public DataTable DataTable11 = null;
        public DataTable DataTable12 = null;
        public DataTable DataTable13 = null;
        public DataTable DataTable14 = null;
        public DataTable DataTable15 = null;

        #region Tipo Relatorio

        public enum TipoRelatorioEnum
        {
            PDF = 1,
            EXCEL = 2,
            DATASET = 3
        }

        #endregion

        #region Parametros

        private List<ReportParameter> Parametros = new List<ReportParameter>();

        public bool LimparParametros()
        {
            try
            {
                this.Parametros.Clear();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AdicionarParametro(string strNome, string strValor)
        {
            try
            {
                this.Parametros.Add(new ReportParameter(strNome, strValor));
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        protected byte[] ConverterReportViewerParaVisualizar(ReportViewer rpvRelatorio, TipoRelatorioEnum objTipoRelatorio)
        {
            try
            {
                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string extension;

                if (objTipoRelatorio.Equals(TipoRelatorioEnum.PDF))
                    return rpvRelatorio.LocalReport.Render("Pdf", null, out mimeType, out encoding, out extension, out streamids, out warnings);
                else
                    return null;

            }
            catch (Exception ex)
            {
                //ExcecaoGS300(ex);
                throw new Exception(ex.Message);
            }
        }

        protected void ExibirRelatorio(byte[] bytBuffer, TipoRelatorioEnum objTipoRelatorio)
        {
            FileStream objFileStream = null;
            try
            {
                string strTempPath = Path.GetTempPath();
                string strExtensao = ".pdf";
                string strTempFile = strTempPath + this.NomeArquivoRelatorio + DateTime.Now.ToString("dd_MM_yyyy-HH_mm_ss") + strExtensao;

                objFileStream = new FileStream(strTempFile, FileMode.Create);
                objFileStream.Write(bytBuffer, 0, bytBuffer.Length);
                objFileStream.Close();

                Process.Start(strTempFile);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                objFileStream = null;
            }
        }

        public virtual void Imprimir()
        {
            DataSet dtsTabelas = null;
            DataTable dtbDataTableUm = null;
            DataTable dtbDataTableDois = null;
            DataTable dtbDataTableTres = null;
            DataTable dtbDataTableQuatro = null;
            DataTable dtbDataTableCinco = null;
            DataTable dtbDataTableSeis = null;
            DataTable dtbDataTableSete = null;
            DataTable dtbDataTableOito = null;
            DataTable dtbDataTableNove = null;
            DataTable dtbDataTableDez = null;
            DataTable dtbDataTableOnze = null;
            DataTable dtbDataTableDoze = null;
            DataTable dtbDataTableTreze = null;
            DataTable dtbDataTableCatorze = null;
            DataTable dtbDataTableQuinze = null;

            try
            {

                //Cria o report viewer
                objReportViewer = new ReportViewer();
                objReportViewer.ProcessingMode = ProcessingMode.Local;

                //Setar o local onde está o relatório
                if (string.IsNullOrEmpty(this.CaminhoRelatorio))
                {
                    throw new Exception("O caminho para o relatório não foi informado!");
                    //return;
                }

                objReportViewer.LocalReport.ReportEmbeddedResource = CaminhoRelatorio;

                //Adicionar parâmetros
                if (this.Parametros.Count > 0)
                    objReportViewer.LocalReport.SetParameters(this.Parametros);

                //Adicionar os DataTables
                if (this.DataTable1 != null)
                    objReportViewer.LocalReport.DataSources.Add(new ReportDataSource("dtsDataSet1", this.DataTable1));
                if (this.DataTable2 != null)
                    objReportViewer.LocalReport.DataSources.Add(new ReportDataSource("dtsDataSet2", this.DataTable2));
                if (this.DataTable3 != null)
                    objReportViewer.LocalReport.DataSources.Add(new ReportDataSource("dtsDataSet3", this.DataTable3));
                if (this.DataTable4 != null)
                    objReportViewer.LocalReport.DataSources.Add(new ReportDataSource("dtsDataSet4", this.DataTable4));
                if (this.DataTable5 != null)
                    objReportViewer.LocalReport.DataSources.Add(new ReportDataSource("dtsDataSet5", this.DataTable5));
                if (this.DataTable6 != null)
                    objReportViewer.LocalReport.DataSources.Add(new ReportDataSource("dtsDataSet6", this.DataTable6));
                if (this.DataTable7 != null)
                    objReportViewer.LocalReport.DataSources.Add(new ReportDataSource("dtsDataSet7", this.DataTable7));
                if (this.DataTable8 != null)
                    objReportViewer.LocalReport.DataSources.Add(new ReportDataSource("dtsDataSet8", this.DataTable8));
                if (this.DataTable9 != null)
                    objReportViewer.LocalReport.DataSources.Add(new ReportDataSource("dtsDataSet9", this.DataTable9));
                if (this.DataTable10 != null)
                    objReportViewer.LocalReport.DataSources.Add(new ReportDataSource("dtsDataSet10", this.DataTable10));
                if (this.DataTable11 != null)
                    objReportViewer.LocalReport.DataSources.Add(new ReportDataSource("dtsDataSet11", this.DataTable11));
                if (this.DataTable12 != null)
                    objReportViewer.LocalReport.DataSources.Add(new ReportDataSource("dtsDataSet12", this.DataTable12));
                if (this.DataTable13 != null)
                    objReportViewer.LocalReport.DataSources.Add(new ReportDataSource("dtsDataSet13", this.DataTable13));
                if (this.DataTable14 != null)
                    objReportViewer.LocalReport.DataSources.Add(new ReportDataSource("dtsDataSet14", this.DataTable14));
                if (this.DataTable15 != null)
                    objReportViewer.LocalReport.DataSources.Add(new ReportDataSource("dtsDataSet15", this.DataTable15));


                bytBuffer = ConverterReportViewerParaVisualizar(objReportViewer, TipoRelatorioEnum.PDF);

                if (bytBuffer == null)
                    return;

                ExibirRelatorio(bytBuffer, TipoRelatorioEnum.PDF);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {

                if (dtbDataTableUm != null)
                {
                    dtbDataTableUm.Clear();
                    dtbDataTableUm = null;
                }

                if (dtbDataTableDois != null)
                {
                    dtbDataTableDois.Clear();
                    dtbDataTableDois = null;
                }
                if (dtbDataTableTres != null)
                {
                    dtbDataTableTres.Clear();
                    dtbDataTableTres = null;
                }
                if (dtbDataTableQuatro != null)
                {
                    dtbDataTableQuatro.Clear();
                    dtbDataTableQuatro = null;
                }
                if (dtbDataTableCinco != null)
                {
                    dtbDataTableCinco.Clear();
                    dtbDataTableCinco = null;
                }
                if (dtbDataTableSeis != null)
                {
                    dtbDataTableSeis.Clear();
                    dtbDataTableSeis = null;
                }
                if (dtbDataTableSete != null)
                {
                    dtbDataTableSete.Clear();
                    dtbDataTableSete = null;
                }
                if (dtbDataTableOito != null)
                {
                    dtbDataTableOito.Clear();
                    dtbDataTableOito = null;
                }
                if (dtbDataTableNove != null)
                {
                    dtbDataTableNove.Clear();
                    dtbDataTableNove = null;
                }
                if (dtbDataTableDez != null)
                {
                    dtbDataTableDez.Clear();
                    dtbDataTableDez = null;
                }
                if (dtbDataTableOnze != null)
                {
                    dtbDataTableOnze.Clear();
                    dtbDataTableOnze = null;
                }
                if (dtbDataTableDoze != null)
                {
                    dtbDataTableDoze.Clear();
                    dtbDataTableDoze = null;
                }
                if (dtbDataTableTreze != null)
                {
                    dtbDataTableTreze.Clear();
                    dtbDataTableTreze = null;
                }
                if (dtbDataTableCatorze != null)
                {
                    dtbDataTableCatorze.Clear();
                    dtbDataTableCatorze = null;
                }
                if (dtbDataTableQuinze != null)
                {
                    dtbDataTableQuinze.Clear();
                    dtbDataTableQuinze = null;
                }

                if (dtsTabelas != null)
                {
                    dtsTabelas.Clear();
                    dtsTabelas = null;
                }


                this.DataTable1 = null;
                this.DataTable2 = null;
                this.DataTable3 = null;
                this.DataTable4 = null;
                this.DataTable5 = null;
                this.DataTable6 = null;
                this.DataTable7 = null;
                this.DataTable8 = null;
                this.DataTable9 = null;
                this.DataTable10 = null;
                this.DataTable11 = null;
                this.DataTable12 = null;
                this.DataTable13 = null;
                this.DataTable14 = null;
                this.DataTable15 = null;
            }
        }
    }
}
