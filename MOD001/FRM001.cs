using System;
using System.Windows.Forms;

namespace SlnEstagio.MOD001
{
    public partial class FRM001 : Form
    {
        public FRM001()
        {
            InitializeComponent();
        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            



            //VerificarFormulario( typeof(FRM002), this,false);
            OpenForm<FRM002>(typeof(FRM002).FullName);
            if(Application.OpenForms.Count > 0 )
                MessageBox.Show("Test");


        }

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

        private void vENDEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        protected override void OnCreateControl()
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void fINACEIROToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
