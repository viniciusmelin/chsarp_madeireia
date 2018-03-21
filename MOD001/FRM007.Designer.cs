namespace SlnEstagio.MOD001
{
    partial class FRM007
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
            this.gbxInformacao = new SlnEstagio.WINBASE.VMGroupBox();
            this.cbxPrincipal = new SlnEstagio.WINBASE.VMCheckBox();
            this.txtEmail = new SlnEstagio.WINBASE.VMTextBox();
            this.lblEmail = new SlnEstagio.WINBASE.VMLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInserir = new SlnEstagio.WINBASE.VMButton();
            this.btnFechar = new SlnEstagio.WINBASE.VMButton();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            this.gbxInformacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // gbxInformacao
            // 
            this.gbxInformacao.Controls.Add(this.cbxPrincipal);
            this.gbxInformacao.Controls.Add(this.txtEmail);
            this.gbxInformacao.Controls.Add(this.lblEmail);
            this.gbxInformacao.Location = new System.Drawing.Point(9, 10);
            this.gbxInformacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxInformacao.Name = "gbxInformacao";
            this.gbxInformacao.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxInformacao.Size = new System.Drawing.Size(371, 102);
            this.gbxInformacao.TabIndex = 0;
            this.gbxInformacao.TabStop = false;
            this.gbxInformacao.Text = "INFORMAÇÕES DE E-MAIL";
            // 
            // cbxPrincipal
            // 
            this.cbxPrincipal.AutoSize = true;
            this.cbxPrincipal.Location = new System.Drawing.Point(7, 72);
            this.cbxPrincipal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxPrincipal.Name = "cbxPrincipal";
            this.cbxPrincipal.Size = new System.Drawing.Size(82, 17);
            this.cbxPrincipal.TabIndex = 2;
            this.cbxPrincipal.Text = "PRINCIPAL";
            this.cbxPrincipal.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Location = new System.Drawing.Point(7, 41);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(328, 20);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.VMLabelAssociado = null;
            this.txtEmail.VMMascara = null;
            this.txtEmail.VMPesquisa = false;
            this.txtEmail.VMPesquisaValor = null;
            this.txtEmail.VMRequerido = false;
            this.txtEmail.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtEmail.VMValor = null;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(4, 25);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-MAIL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(297, 120);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 24);
            this.panel1.TabIndex = 2;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(214, 115);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(79, 28);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "INSERIR";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(302, 115);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(79, 28);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "&CANCELAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FRM007
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 148);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.gbxInformacao);
            this.Name = "FRM007";
            this.Text = "CADASTRAR EMAIL CLIENTE";
            this.Shown += new System.EventHandler(this.FRM007_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            this.gbxInformacao.ResumeLayout(false);
            this.gbxInformacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SlnEstagio.WINBASE.VMGroupBox gbxInformacao;
        private SlnEstagio.WINBASE.VMTextBox txtEmail;
        private WINBASE.VMLabel lblEmail;
        private System.Windows.Forms.Panel panel1;
        private WINBASE.VMButton btnInserir;
        private WINBASE.VMButton btnFechar;
        private WINBASE.VMCheckBox cbxPrincipal;
    }
}