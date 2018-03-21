namespace SlnEstagio.MOD005
{
    partial class FRM001
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
            this.cbxAtivo = new SlnEstagio.WINBASE.VMComboBox();
            this.lblAtivo = new SlnEstagio.WINBASE.VMLabel();
            this.vmLabel1 = new SlnEstagio.WINBASE.VMLabel();
            this.txtFornecedor = new SlnEstagio.WINBASE.VMTextBox();
            this.btnPesqFornecedor = new SlnEstagio.WINBASE.VMButton();
            this.btnImprimir = new SlnEstagio.WINBASE.VMButton();
            this.btnFechar = new SlnEstagio.WINBASE.VMButton();
            this.vmButton2 = new SlnEstagio.WINBASE.VMButton();
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
            this.vmGroupBox1.Controls.Add(this.cbxAtivo);
            this.vmGroupBox1.Controls.Add(this.lblAtivo);
            this.vmGroupBox1.Controls.Add(this.vmLabel1);
            this.vmGroupBox1.Controls.Add(this.txtFornecedor);
            this.vmGroupBox1.Controls.Add(this.btnPesqFornecedor);
            this.vmGroupBox1.Location = new System.Drawing.Point(7, 4);
            this.vmGroupBox1.Name = "vmGroupBox1";
            this.vmGroupBox1.Size = new System.Drawing.Size(625, 45);
            this.vmGroupBox1.TabIndex = 0;
            this.vmGroupBox1.TabStop = false;
            // 
            // cbxAtivo
            // 
            this.cbxAtivo.FormattingEnabled = true;
            this.cbxAtivo.GSLabelAssociado = null;
            this.cbxAtivo.Location = new System.Drawing.Point(537, 12);
            this.cbxAtivo.Margin = new System.Windows.Forms.Padding(2);
            this.cbxAtivo.Name = "cbxAtivo";
            this.cbxAtivo.Size = new System.Drawing.Size(77, 21);
            this.cbxAtivo.TabIndex = 6;
            this.cbxAtivo.VMRequerido = false;
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.Location = new System.Drawing.Point(484, 16);
            this.lblAtivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(49, 13);
            this.lblAtivo.TabIndex = 5;
            this.lblAtivo.Text = "ATIVOS:";
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
            this.txtFornecedor.Location = new System.Drawing.Point(97, 13);
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
            this.txtFornecedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFornecedor_KeyDown);
            // 
            // btnPesqFornecedor
            // 
            this.btnPesqFornecedor.Location = new System.Drawing.Point(445, 13);
            this.btnPesqFornecedor.Name = "btnPesqFornecedor";
            this.btnPesqFornecedor.Size = new System.Drawing.Size(34, 20);
            this.btnPesqFornecedor.TabIndex = 2;
            this.btnPesqFornecedor.UseVisualStyleBackColor = true;
            this.btnPesqFornecedor.Click += new System.EventHandler(this.btnPesqFornecedor_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(466, 55);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(80, 31);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "&IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(552, 55);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(80, 31);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "&FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // vmButton2
            // 
            this.vmButton2.Location = new System.Drawing.Point(552, 55);
            this.vmButton2.Name = "vmButton2";
            this.vmButton2.Size = new System.Drawing.Size(75, 23);
            this.vmButton2.TabIndex = 7;
            this.vmButton2.Text = "vmButton2";
            this.vmButton2.UseVisualStyleBackColor = true;
            // 
            // FRM001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 90);
            this.Controls.Add(this.vmGroupBox1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.vmButton2);
            this.Controls.Add(this.btnImprimir);
            this.Name = "FRM001";
            this.Text = "RELATÓRIO FORNECEDORES";
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
        private WINBASE.VMButton btnImprimir;
        private WINBASE.VMButton btnFechar;
        private WINBASE.VMButton vmButton2;
        private WINBASE.VMComboBox cbxAtivo;
        private WINBASE.VMLabel lblAtivo;
    }
}