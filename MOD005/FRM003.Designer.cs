namespace SlnEstagio.MOD005
{
    partial class FRM003
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
            this.vmGroupBox1 = new SlnEstagio.WINBASE.VMGroupBox();
            this.vmLabel1 = new SlnEstagio.WINBASE.VMLabel();
            this.txtFornecedor = new SlnEstagio.WINBASE.VMTextBox();
            this.btnPesqFornecedor = new SlnEstagio.WINBASE.VMButton();
            this.btnFechar = new SlnEstagio.WINBASE.VMButton();
            this.btnImprimir = new SlnEstagio.WINBASE.VMButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.vmLabel2 = new SlnEstagio.WINBASE.VMLabel();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            this.vmGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // vmGroupBox1
            // 
            this.vmGroupBox1.Controls.Add(this.checkedListBox1);
            this.vmGroupBox1.Controls.Add(this.vmLabel2);
            this.vmGroupBox1.Controls.Add(this.vmLabel1);
            this.vmGroupBox1.Controls.Add(this.txtFornecedor);
            this.vmGroupBox1.Controls.Add(this.btnPesqFornecedor);
            this.vmGroupBox1.Location = new System.Drawing.Point(12, 2);
            this.vmGroupBox1.Name = "vmGroupBox1";
            this.vmGroupBox1.Size = new System.Drawing.Size(539, 118);
            this.vmGroupBox1.TabIndex = 0;
            this.vmGroupBox1.TabStop = false;
            // 
            // vmLabel1
            // 
            this.vmLabel1.AutoSize = true;
            this.vmLabel1.Location = new System.Drawing.Point(6, 16);
            this.vmLabel1.Name = "vmLabel1";
            this.vmLabel1.Size = new System.Drawing.Size(85, 13);
            this.vmLabel1.TabIndex = 0;
            this.vmLabel1.Text = "FORNECEDOR:";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedor.Location = new System.Drawing.Point(9, 32);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(342, 20);
            this.txtFornecedor.TabIndex = 1;
            this.txtFornecedor.VMLabelAssociado = null;
            this.txtFornecedor.VMMascara = null;
            this.txtFornecedor.VMPesquisa = false;
            this.txtFornecedor.VMPesquisaValor = null;
            this.txtFornecedor.VMRequerido = false;
            this.txtFornecedor.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtFornecedor.VMValor = null;
            // 
            // btnPesqFornecedor
            // 
            this.btnPesqFornecedor.Location = new System.Drawing.Point(357, 31);
            this.btnPesqFornecedor.Name = "btnPesqFornecedor";
            this.btnPesqFornecedor.Size = new System.Drawing.Size(34, 20);
            this.btnPesqFornecedor.TabIndex = 2;
            this.btnPesqFornecedor.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(471, 126);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(80, 31);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "&FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(385, 126);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(80, 31);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "&IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(407, 31);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 64);
            this.checkedListBox1.TabIndex = 4;
            // 
            // vmLabel2
            // 
            this.vmLabel2.AutoSize = true;
            this.vmLabel2.Location = new System.Drawing.Point(404, 16);
            this.vmLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel2.Name = "vmLabel2";
            this.vmLabel2.Size = new System.Drawing.Size(61, 13);
            this.vmLabel2.TabIndex = 3;
            this.vmLabel2.Text = "SITUAÇÃO";
            // 
            // FRM003
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 164);
            this.Controls.Add(this.vmGroupBox1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnImprimir);
            this.Name = "FRM003";
            this.Text = "RELATÓRIO DE CONTAS A PAGAR";
            this.Shown += new System.EventHandler(this.FRM003_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            this.vmGroupBox1.ResumeLayout(false);
            this.vmGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WINBASE.VMGroupBox vmGroupBox1;
        private WINBASE.VMLabel vmLabel1;
        private WINBASE.VMTextBox txtFornecedor;
        private WINBASE.VMButton btnPesqFornecedor;
        private WINBASE.VMButton btnFechar;
        private WINBASE.VMButton btnImprimir;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private WINBASE.VMLabel vmLabel2;
    }
}