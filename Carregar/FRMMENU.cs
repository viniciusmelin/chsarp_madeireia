using SlnEstagio.MOD001;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SlnEstagio.WINBASE;

namespace SlnEstagio.Carregar
{
    public partial class FRMMENU : Form
    {
       
        private Dictionary<Type, Form> openForms = new Dictionary<Type, Form>();
        public FRMMENU()
        {
            InitializeComponent();
            tsslblHora.Text = DateTime.Now.ToString();
            timer1.Start();
        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                cLIENTEToolStripMenuItem.Click -= new EventHandler(cLIENTEToolStripMenuItem_Click);
                OpenForm<FRM003>(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cLIENTEToolStripMenuItem.Click += new EventHandler(cLIENTEToolStripMenuItem_Click);
            }
            
        }

        public void OpenForm<T>(Form pai) where T : FRMBASE, new()
        {
            Form C = new Form();
            string[] str = typeof(T).FullName.Split('.');
            Type type = Type.GetType(typeof(T).FullName + "," + str[0] + "." + str[1],true);

            if (!openForms.TryGetValue(type, out C) || C.IsDisposed)
            {
                openForms[type] = C = (FRMBASE)Activator.CreateInstance(type);
            }
            //tsslblForm.Text = str[1].Replace("MOD", str[1]);
            C.MdiParent = pai;
            C.Show();
            C.Focus();
        }

        private void vENDEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                vENDEDORToolStripMenuItem.Click -= new EventHandler(vENDEDORToolStripMenuItem_Click);
                OpenForm<FRM024>(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                vENDEDORToolStripMenuItem.Click += new EventHandler(vENDEDORToolStripMenuItem_Click);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsslblHora.Text = DateTime.Now.ToString();
            if (this.ActiveMdiChild != null)
            {
                Type tipo = this.ActiveMdiChild.GetType();
                //toolStripStatusLabel1.Text = string.Format("MODULO: {0} | FORM: {1}", ((WINBASE.FRMBASE)this.ActiveMdiChild).Modulo.Replace("MOD",""),this.ActiveMdiChild.GetType().Name.Replace("FRM",""));
                toolStripStatusLabel1.Text = string.Format("MODULO: {0} | FORM: {1}", tipo.Namespace.Replace("SlnEstagio.MOD", ""), tipo.Name.Replace("FRM", ""));
            }
        }

        private void fORNECEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                fORNECEDORToolStripMenuItem.Click -= new EventHandler(fORNECEDORToolStripMenuItem_Click);
                OpenForm<FRM008>(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fORNECEDORToolStripMenuItem.Click += new EventHandler(fORNECEDORToolStripMenuItem_Click);
            }
        }

        private void pRODUTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                pRODUTOToolStripMenuItem.Click -= new EventHandler(pRODUTOToolStripMenuItem_Click);
                OpenForm<FRM013>(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                pRODUTOToolStripMenuItem.Click += new EventHandler(pRODUTOToolStripMenuItem_Click);
            }
        }

        private void pEDIDOCOMPRAToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                pEDIDOCOMPRAToolStripMenuItem.Click -= new EventHandler(pEDIDOCOMPRAToolStripMenuItem_Click);
                OpenForm<SlnEstagio.MOD002.FRM001>(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                pEDIDOCOMPRAToolStripMenuItem.Click += new EventHandler(pEDIDOCOMPRAToolStripMenuItem_Click);
            }
        }

        private void cONTASARECEBERToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                cONTASARECEBERToolStripMenuItem.Click -= new EventHandler(cONTASARECEBERToolStripMenuItem_Click);
                OpenForm<SlnEstagio.MOD003.FRM001>(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cONTASARECEBERToolStripMenuItem.Click += new EventHandler(cONTASARECEBERToolStripMenuItem_Click);
            }
        }

        private void tIPOPAGAMENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                tIPOPAGAMENTOToolStripMenuItem.Click -= new EventHandler(tIPOPAGAMENTOToolStripMenuItem_Click);
                OpenForm< MOD001.FRM028>(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tIPOPAGAMENTOToolStripMenuItem.Click += new EventHandler(tIPOPAGAMENTOToolStripMenuItem_Click);
            }
        }

        private void eSTOQUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                eSTOQUEToolStripMenuItem.Click -= new EventHandler(eSTOQUEToolStripMenuItem_Click);
                OpenForm<MOD004.FRM001>(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                eSTOQUEToolStripMenuItem.Click += new EventHandler(eSTOQUEToolStripMenuItem_Click);
            }
        }

        private void cONTASAPAGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cONTASAPAGARToolStripMenuItem.Click -= new EventHandler(cONTASAPAGARToolStripMenuItem_Click);
                OpenForm<MOD003.FRM004>(this);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cONTASAPAGARToolStripMenuItem.Click += new EventHandler(cONTASAPAGARToolStripMenuItem_Click);
            }
        }

        private void pRODUTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                pRODUTOSToolStripMenuItem.Click -= new EventHandler(pRODUTOSToolStripMenuItem_Click);
                OpenForm<MOD005.FRM004>(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                pRODUTOSToolStripMenuItem.Click += new EventHandler(pRODUTOSToolStripMenuItem_Click);
            }
        }

        private void tIPOCONTASAPAGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                tIPOCONTASAPAGARToolStripMenuItem.Click -= new EventHandler(tIPOCONTASAPAGARToolStripMenuItem_Click);
                OpenForm<MOD001.FRM030>(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tIPOCONTASAPAGARToolStripMenuItem.Click += new EventHandler(tIPOCONTASAPAGARToolStripMenuItem_Click);
            }
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cLIENTESToolStripMenuItem.Click -= new EventHandler(cLIENTESToolStripMenuItem_Click);
                OpenForm<MOD005.FRM002>(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cLIENTESToolStripMenuItem.Click += new EventHandler(cLIENTESToolStripMenuItem_Click);
            }
        }

        private void cONTASAPAGARToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            try
            {
                cONTASAPAGARToolStripMenuItem1.Click -= new EventHandler(cONTASAPAGARToolStripMenuItem1_Click);
                OpenForm<MOD005.FRM003>(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cONTASAPAGARToolStripMenuItem1.Click += new EventHandler(cONTASAPAGARToolStripMenuItem1_Click);
            }
        }

        private void fORNECEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                fORNECEDORESToolStripMenuItem.Click -= new EventHandler(fORNECEDORESToolStripMenuItem_Click);
                OpenForm<MOD005.FRM001>(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fORNECEDORESToolStripMenuItem.Click += new EventHandler(fORNECEDORESToolStripMenuItem_Click);
            }
        }

        private void cONTASARECEBERToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            try
            {
                cONTASARECEBERToolStripMenuItem1.Click -= new EventHandler(cONTASARECEBERToolStripMenuItem1_Click);
                OpenForm<MOD005.FRM005>(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cONTASARECEBERToolStripMenuItem1.Click += new EventHandler(cONTASARECEBERToolStripMenuItem1_Click);
            }
        }
    }
}
