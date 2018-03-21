namespace SlnEstagio.MOD005
{
    partial class FRM004
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
            this.vmGroupBox2 = new SlnEstagio.WINBASE.VMGroupBox();
            this.cbxAtivo = new SlnEstagio.WINBASE.VMComboBox();
            this.lblAtivo = new SlnEstagio.WINBASE.VMLabel();
            this.vmLabel1 = new SlnEstagio.WINBASE.VMLabel();
            this.txtProduto = new SlnEstagio.WINBASE.VMTextBox();
            this.btnPesqProduto = new SlnEstagio.WINBASE.VMButton();
            this.btnFechar = new SlnEstagio.WINBASE.VMButton();
            this.btnImprimir = new SlnEstagio.WINBASE.VMButton();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            this.vmGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // vmGroupBox2
            // 
            this.vmGroupBox2.Controls.Add(this.cbxAtivo);
            this.vmGroupBox2.Controls.Add(this.lblAtivo);
            this.vmGroupBox2.Controls.Add(this.vmLabel1);
            this.vmGroupBox2.Controls.Add(this.txtProduto);
            this.vmGroupBox2.Controls.Add(this.btnPesqProduto);
            this.vmGroupBox2.Location = new System.Drawing.Point(6, 2);
            this.vmGroupBox2.Name = "vmGroupBox2";
            this.vmGroupBox2.Size = new System.Drawing.Size(580, 48);
            this.vmGroupBox2.TabIndex = 0;
            this.vmGroupBox2.TabStop = false;
            // 
            // cbxAtivo
            // 
            this.cbxAtivo.FormattingEnabled = true;
            this.cbxAtivo.GSLabelAssociado = null;
            this.cbxAtivo.Location = new System.Drawing.Point(498, 16);
            this.cbxAtivo.Margin = new System.Windows.Forms.Padding(2);
            this.cbxAtivo.Name = "cbxAtivo";
            this.cbxAtivo.Size = new System.Drawing.Size(77, 21);
            this.cbxAtivo.TabIndex = 4;
            this.cbxAtivo.VMRequerido = false;
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.Location = new System.Drawing.Point(445, 19);
            this.lblAtivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(49, 13);
            this.lblAtivo.TabIndex = 3;
            this.lblAtivo.Text = "ATIVOS:";
            // 
            // vmLabel1
            // 
            this.vmLabel1.AutoSize = true;
            this.vmLabel1.Location = new System.Drawing.Point(7, 20);
            this.vmLabel1.Name = "vmLabel1";
            this.vmLabel1.Size = new System.Drawing.Size(67, 13);
            this.vmLabel1.TabIndex = 0;
            this.vmLabel1.Text = "PRODUTO: ";
            // 
            // txtProduto
            // 
            this.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto.Location = new System.Drawing.Point(80, 16);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(320, 20);
            this.txtProduto.TabIndex = 1;
            this.txtProduto.VMLabelAssociado = null;
            this.txtProduto.VMMascara = null;
            this.txtProduto.VMPesquisa = false;
            this.txtProduto.VMPesquisaValor = null;
            this.txtProduto.VMRequerido = false;
            this.txtProduto.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtProduto.VMValor = null;
            this.txtProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProduto_KeyDown);
            // 
            // btnPesqProduto
            // 
            this.btnPesqProduto.Location = new System.Drawing.Point(406, 16);
            this.btnPesqProduto.Name = "btnPesqProduto";
            this.btnPesqProduto.Size = new System.Drawing.Size(34, 20);
            this.btnPesqProduto.TabIndex = 2;
            this.btnPesqProduto.UseVisualStyleBackColor = true;
            this.btnPesqProduto.Click += new System.EventHandler(this.btnPesqProduto_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(506, 56);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(80, 31);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "&FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(420, 56);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(80, 31);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "&IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // FRM004
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 90);
            this.Controls.Add(this.vmGroupBox2);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnImprimir);
            this.Name = "FRM004";
            this.Text = "RELATÓRIO DE PRODUTOS";
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            this.vmGroupBox2.ResumeLayout(false);
            this.vmGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WINBASE.VMGroupBox vmGroupBox2;
        private WINBASE.VMComboBox cbxAtivo;
        private WINBASE.VMLabel lblAtivo;
        private WINBASE.VMLabel vmLabel1;
        private WINBASE.VMTextBox txtProduto;
        private WINBASE.VMButton btnPesqProduto;
        private WINBASE.VMButton btnFechar;
        private WINBASE.VMButton btnImprimir;
    }
}