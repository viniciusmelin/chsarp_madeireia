namespace SlnEstagio.MOD001
{
    partial class FRM011
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluir = new SlnEstagio.WINBASE.VMButton();
            this.btnAlterar = new SlnEstagio.WINBASE.VMButton();
            this.btnInserir = new SlnEstagio.WINBASE.VMButton();
            this.btnFechar = new SlnEstagio.WINBASE.VMButton();
            this.dgwColecao = new SlnEstagio.WINBASE.VMDataGridView();
            this.gbxInformacoes = new SlnEstagio.WINBASE.VMGroupBox();
            this.txtRazaoSocial = new SlnEstagio.WINBASE.VMTextBox();
            this.lblRazaoSocial = new SlnEstagio.WINBASE.VMLabel();
            this.txtRegistro = new SlnEstagio.WINBASE.VMTextBox();
            this.lblRegistro = new SlnEstagio.WINBASE.VMLabel();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColecao)).BeginInit();
            this.gbxInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(577, 296);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 24);
            this.panel1.TabIndex = 7;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(508, 292);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(64, 28);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(438, 292);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(66, 28);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(370, 292);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(64, 28);
            this.btnInserir.TabIndex = 4;
            this.btnInserir.Text = "INSERIR";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(582, 292);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(64, 28);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // dgwColecao
            // 
            this.dgwColecao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwColecao.Location = new System.Drawing.Point(9, 57);
            this.dgwColecao.Margin = new System.Windows.Forms.Padding(2);
            this.dgwColecao.Name = "dgwColecao";
            this.dgwColecao.RowHeadersWidth = 22;
            this.dgwColecao.RowTemplate.Height = 24;
            this.dgwColecao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwColecao.Size = new System.Drawing.Size(638, 230);
            this.dgwColecao.TabIndex = 1;
            // 
            // gbxInformacoes
            // 
            this.gbxInformacoes.Controls.Add(this.txtRazaoSocial);
            this.gbxInformacoes.Controls.Add(this.lblRazaoSocial);
            this.gbxInformacoes.Location = new System.Drawing.Point(9, -1);
            this.gbxInformacoes.Margin = new System.Windows.Forms.Padding(2);
            this.gbxInformacoes.Name = "gbxInformacoes";
            this.gbxInformacoes.Padding = new System.Windows.Forms.Padding(2);
            this.gbxInformacoes.Size = new System.Drawing.Size(638, 54);
            this.gbxInformacoes.TabIndex = 0;
            this.gbxInformacoes.TabStop = false;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazaoSocial.Location = new System.Drawing.Point(128, 21);
            this.txtRazaoSocial.Margin = new System.Windows.Forms.Padding(2);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(492, 20);
            this.txtRazaoSocial.TabIndex = 1;
            this.txtRazaoSocial.VMLabelAssociado = null;
            this.txtRazaoSocial.VMMascara = null;
            this.txtRazaoSocial.VMPesquisa = false;
            this.txtRazaoSocial.VMPesquisaValor = null;
            this.txtRazaoSocial.VMRequerido = false;
            this.txtRazaoSocial.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtRazaoSocial.VMValor = null;
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Location = new System.Drawing.Point(4, 24);
            this.lblRazaoSocial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(125, 13);
            this.lblRazaoSocial.TabIndex = 0;
            this.lblRazaoSocial.Text = "NOME/RAZÃO SOCIAL:";
            // 
            // txtRegistro
            // 
            this.txtRegistro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRegistro.Location = new System.Drawing.Point(87, 296);
            this.txtRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.ReadOnly = true;
            this.txtRegistro.Size = new System.Drawing.Size(92, 20);
            this.txtRegistro.TabIndex = 3;
            this.txtRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRegistro.VMLabelAssociado = null;
            this.txtRegistro.VMMascara = null;
            this.txtRegistro.VMPesquisa = false;
            this.txtRegistro.VMPesquisaValor = null;
            this.txtRegistro.VMRequerido = false;
            this.txtRegistro.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtRegistro.VMValor = null;
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(10, 300);
            this.lblRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(73, 13);
            this.lblRegistro.TabIndex = 2;
            this.lblRegistro.Text = "REGISTROS:";
            // 
            // FRM011
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 325);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dgwColecao);
            this.Controls.Add(this.gbxInformacoes);
            this.Name = "FRM011";
            this.Text = "SELECIONAR TELEFONE  CLIENTE";
            this.Shown += new System.EventHandler(this.FRM011_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColecao)).EndInit();
            this.gbxInformacoes.ResumeLayout(false);
            this.gbxInformacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private WINBASE.VMButton btnExcluir;
        private WINBASE.VMButton btnAlterar;
        private WINBASE.VMButton btnInserir;
        private WINBASE.VMButton btnFechar;
        private SlnEstagio.WINBASE.VMDataGridView dgwColecao;
        private SlnEstagio.WINBASE.VMGroupBox gbxInformacoes;
        private SlnEstagio.WINBASE.VMTextBox txtRazaoSocial;
        private WINBASE.VMLabel lblRazaoSocial;
        private WINBASE.VMTextBox txtRegistro;
        private WINBASE.VMLabel lblRegistro;
    }
}