namespace SlnEstagio.MOD005
{
    partial class FRM002
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
            this.txtCliente = new SlnEstagio.WINBASE.VMTextBox();
            this.btnPesqCliente = new SlnEstagio.WINBASE.VMButton();
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
            this.vmGroupBox2.Controls.Add(this.txtCliente);
            this.vmGroupBox2.Controls.Add(this.btnPesqCliente);
            this.vmGroupBox2.Location = new System.Drawing.Point(6, 0);
            this.vmGroupBox2.Name = "vmGroupBox2";
            this.vmGroupBox2.Size = new System.Drawing.Size(547, 48);
            this.vmGroupBox2.TabIndex = 0;
            this.vmGroupBox2.TabStop = false;
            // 
            // cbxAtivo
            // 
            this.cbxAtivo.FormattingEnabled = true;
            this.cbxAtivo.GSLabelAssociado = null;
            this.cbxAtivo.Location = new System.Drawing.Point(461, 17);
            this.cbxAtivo.Margin = new System.Windows.Forms.Padding(2);
            this.cbxAtivo.Name = "cbxAtivo";
            this.cbxAtivo.Size = new System.Drawing.Size(77, 21);
            this.cbxAtivo.TabIndex = 4;
            this.cbxAtivo.VMRequerido = false;
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.Location = new System.Drawing.Point(408, 20);
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
            this.vmLabel1.Size = new System.Drawing.Size(55, 13);
            this.vmLabel1.TabIndex = 0;
            this.vmLabel1.Text = "CLIENTE:";
            // 
            // txtCliente
            // 
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliente.Location = new System.Drawing.Point(68, 17);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(295, 20);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.VMLabelAssociado = null;
            this.txtCliente.VMMascara = null;
            this.txtCliente.VMPesquisa = false;
            this.txtCliente.VMPesquisaValor = null;
            this.txtCliente.VMRequerido = false;
            this.txtCliente.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtCliente.VMValor = null;
            this.txtCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyDown);
            // 
            // btnPesqCliente
            // 
            this.btnPesqCliente.Location = new System.Drawing.Point(369, 17);
            this.btnPesqCliente.Name = "btnPesqCliente";
            this.btnPesqCliente.Size = new System.Drawing.Size(34, 20);
            this.btnPesqCliente.TabIndex = 2;
            this.btnPesqCliente.UseVisualStyleBackColor = true;
            this.btnPesqCliente.Click += new System.EventHandler(this.btnPesqCliente_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(473, 54);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(80, 31);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "&FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(387, 54);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(80, 31);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "&IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // FRM002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 88);
            this.Controls.Add(this.vmGroupBox2);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnImprimir);
            this.Name = "FRM002";
            this.Text = "RELATÓRIO DE CLIENTES";
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            this.vmGroupBox2.ResumeLayout(false);
            this.vmGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WINBASE.VMGroupBox vmGroupBox2;
        private WINBASE.VMLabel vmLabel1;
        private WINBASE.VMTextBox txtCliente;
        private WINBASE.VMButton btnPesqCliente;
        private WINBASE.VMButton btnFechar;
        private WINBASE.VMButton btnImprimir;
        private WINBASE.VMComboBox cbxAtivo;
        private WINBASE.VMLabel lblAtivo;
    }
}