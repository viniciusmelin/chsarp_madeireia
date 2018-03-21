namespace SlnEstagio.MOD001
{
    partial class FRM029
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFechar = new SlnEstagio.WINBASE.VMButton();
            this.btnSalvar = new SlnEstagio.WINBASE.VMButton();
            this.vmGroupBox1 = new SlnEstagio.WINBASE.VMGroupBox();
            this.vmGroupBox2 = new SlnEstagio.WINBASE.VMGroupBox();
            this.rbtNao = new SlnEstagio.WINBASE.VMRadioButton();
            this.rbtSim = new SlnEstagio.WINBASE.VMRadioButton();
            this.txtDescricao = new SlnEstagio.WINBASE.VMTextBox();
            this.vmLabel2 = new SlnEstagio.WINBASE.VMLabel();
            this.txtCodigo = new SlnEstagio.WINBASE.VMTextBox();
            this.lblCodigo = new SlnEstagio.WINBASE.VMLabel();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            this.vmGroupBox1.SuspendLayout();
            this.vmGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(267, 174);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(77, 26);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "&FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(186, 174);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(77, 26);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "&SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // vmGroupBox1
            // 
            this.vmGroupBox1.Controls.Add(this.vmGroupBox2);
            this.vmGroupBox1.Controls.Add(this.txtDescricao);
            this.vmGroupBox1.Controls.Add(this.vmLabel2);
            this.vmGroupBox1.Controls.Add(this.txtCodigo);
            this.vmGroupBox1.Controls.Add(this.lblCodigo);
            this.vmGroupBox1.Location = new System.Drawing.Point(4, 2);
            this.vmGroupBox1.Name = "vmGroupBox1";
            this.vmGroupBox1.Size = new System.Drawing.Size(345, 167);
            this.vmGroupBox1.TabIndex = 0;
            this.vmGroupBox1.TabStop = false;
            // 
            // vmGroupBox2
            // 
            this.vmGroupBox2.Controls.Add(this.rbtNao);
            this.vmGroupBox2.Controls.Add(this.rbtSim);
            this.vmGroupBox2.Location = new System.Drawing.Point(8, 112);
            this.vmGroupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.vmGroupBox2.Name = "vmGroupBox2";
            this.vmGroupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.vmGroupBox2.Size = new System.Drawing.Size(114, 48);
            this.vmGroupBox2.TabIndex = 4;
            this.vmGroupBox2.TabStop = false;
            this.vmGroupBox2.Text = "ATIVO";
            // 
            // rbtNao
            // 
            this.rbtNao.AutoSize = true;
            this.rbtNao.Location = new System.Drawing.Point(56, 17);
            this.rbtNao.Margin = new System.Windows.Forms.Padding(2);
            this.rbtNao.Name = "rbtNao";
            this.rbtNao.Size = new System.Drawing.Size(48, 17);
            this.rbtNao.TabIndex = 1;
            this.rbtNao.Text = "NÃO";
            this.rbtNao.UseVisualStyleBackColor = true;
            // 
            // rbtSim
            // 
            this.rbtSim.AutoSize = true;
            this.rbtSim.Checked = true;
            this.rbtSim.Location = new System.Drawing.Point(5, 18);
            this.rbtSim.Margin = new System.Windows.Forms.Padding(2);
            this.rbtSim.Name = "rbtSim";
            this.rbtSim.Size = new System.Drawing.Size(44, 17);
            this.rbtSim.TabIndex = 0;
            this.rbtSim.TabStop = true;
            this.rbtSim.Text = "SIM";
            this.rbtSim.UseVisualStyleBackColor = true;
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(8, 78);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(332, 20);
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.VMLabelAssociado = null;
            this.txtDescricao.VMMascara = null;
            this.txtDescricao.VMPesquisa = false;
            this.txtDescricao.VMPesquisaValor = null;
            this.txtDescricao.VMRequerido = false;
            this.txtDescricao.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtDescricao.VMValor = null;
            // 
            // vmLabel2
            // 
            this.vmLabel2.AutoSize = true;
            this.vmLabel2.Location = new System.Drawing.Point(6, 61);
            this.vmLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel2.Name = "vmLabel2";
            this.vmLabel2.Size = new System.Drawing.Size(69, 13);
            this.vmLabel2.TabIndex = 2;
            this.vmLabel2.Text = "DESCRIÇÃO";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Location = new System.Drawing.Point(7, 30);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(74, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.Text = "0";
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodigo.VMLabelAssociado = null;
            this.txtCodigo.VMMascara = null;
            this.txtCodigo.VMPesquisa = false;
            this.txtCodigo.VMPesquisaValor = null;
            this.txtCodigo.VMRequerido = false;
            this.txtCodigo.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtCodigo.VMValor = null;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 13);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "CÓDIGO";
            // 
            // FRM029
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 205);
            this.Controls.Add(this.vmGroupBox1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSalvar);
            this.Name = "FRM029";
            this.Text = "CADASTRAR TIPO PAGAMENTO";
            this.Shown += new System.EventHandler(this.FRM029_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            this.vmGroupBox1.ResumeLayout(false);
            this.vmGroupBox1.PerformLayout();
            this.vmGroupBox2.ResumeLayout(false);
            this.vmGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WINBASE.VMButton btnFechar;
        private WINBASE.VMButton btnSalvar;
        private WINBASE.VMGroupBox vmGroupBox1;
        private WINBASE.VMGroupBox vmGroupBox2;
        private WINBASE.VMRadioButton rbtNao;
        private WINBASE.VMRadioButton rbtSim;
        private WINBASE.VMTextBox txtDescricao;
        private WINBASE.VMLabel vmLabel2;
        private WINBASE.VMTextBox txtCodigo;
        private WINBASE.VMLabel lblCodigo;
    }
}