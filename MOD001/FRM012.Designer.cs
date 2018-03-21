namespace SlnEstagio.MOD001
{
    partial class FRM012
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
            this.gbxInformacoes = new SlnEstagio.WINBASE.VMGroupBox();
            this.lblTipo = new SlnEstagio.WINBASE.VMLabel();
            this.cbxTipoTelefone = new SlnEstagio.WINBASE.VMComboBox();
            this.ckbxPrincipal = new SlnEstagio.WINBASE.VMCheckBox();
            this.lblNumero = new SlnEstagio.WINBASE.VMLabel();
            this.txtNumero = new SlnEstagio.WINBASE.VMTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalvar = new SlnEstagio.WINBASE.VMButton();
            this.btnFechar = new SlnEstagio.WINBASE.VMButton();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            this.gbxInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxInformacoes
            // 
            this.gbxInformacoes.Controls.Add(this.lblTipo);
            this.gbxInformacoes.Controls.Add(this.cbxTipoTelefone);
            this.gbxInformacoes.Controls.Add(this.ckbxPrincipal);
            this.gbxInformacoes.Controls.Add(this.lblNumero);
            this.gbxInformacoes.Controls.Add(this.txtNumero);
            this.gbxInformacoes.Location = new System.Drawing.Point(9, 0);
            this.gbxInformacoes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxInformacoes.Name = "gbxInformacoes";
            this.gbxInformacoes.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxInformacoes.Size = new System.Drawing.Size(368, 101);
            this.gbxInformacoes.TabIndex = 0;
            this.gbxInformacoes.TabStop = false;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(194, 17);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(32, 13);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "TIPO";
            // 
            // cbxTipoTelefone
            // 
            this.cbxTipoTelefone.FormattingEnabled = true;
            this.cbxTipoTelefone.GSLabelAssociado = null;
            this.cbxTipoTelefone.Location = new System.Drawing.Point(196, 33);
            this.cbxTipoTelefone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxTipoTelefone.Name = "cbxTipoTelefone";
            this.cbxTipoTelefone.Size = new System.Drawing.Size(126, 21);
            this.cbxTipoTelefone.TabIndex = 4;
            this.cbxTipoTelefone.VMRequerido = false;
            // 
            // ckbxPrincipal
            // 
            this.ckbxPrincipal.AutoSize = true;
            this.ckbxPrincipal.Location = new System.Drawing.Point(4, 65);
            this.ckbxPrincipal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckbxPrincipal.Name = "ckbxPrincipal";
            this.ckbxPrincipal.Size = new System.Drawing.Size(82, 17);
            this.ckbxPrincipal.TabIndex = 3;
            this.ckbxPrincipal.Text = "PRINCIPAL";
            this.ckbxPrincipal.UseVisualStyleBackColor = true;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(2, 17);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(55, 13);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "NÚMERO";
            // 
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Location = new System.Drawing.Point(4, 33);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(188, 20);
            this.txtNumero.TabIndex = 0;
            this.txtNumero.VMLabelAssociado = null;
            this.txtNumero.VMMascara = null;
            this.txtNumero.VMPesquisa = false;
            this.txtNumero.VMPesquisaValor = null;
            this.txtNumero.VMRequerido = false;
            this.txtNumero.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtNumero.VMValor = null;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(296, 109);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 24);
            this.panel1.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(216, 105);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(76, 28);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "&SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(301, 105);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(76, 28);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "&CANCELAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FRM012
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 138);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.gbxInformacoes);
            this.Name = "FRM012";
            this.Text = "CADASTRAR TELEFONE CLIENTE";
            this.Shown += new System.EventHandler(this.FRM012_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            this.gbxInformacoes.ResumeLayout(false);
            this.gbxInformacoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SlnEstagio.WINBASE.VMGroupBox gbxInformacoes;
        private WINBASE.VMComboBox cbxTipoTelefone;
        private WINBASE.VMCheckBox ckbxPrincipal;
        private WINBASE.VMLabel lblNumero;
        private SlnEstagio.WINBASE.VMTextBox txtNumero;
        private WINBASE.VMLabel lblTipo;
        private System.Windows.Forms.Panel panel1;
        private WINBASE.VMButton btnSalvar;
        private WINBASE.VMButton btnFechar;
    }
}