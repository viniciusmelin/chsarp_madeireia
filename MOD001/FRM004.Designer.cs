namespace SlnEstagio.MOD001
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
            this.lblRazaoSocial = new SlnEstagio.WINBASE.VMLabel();
            this.gbxEnderecoInformacao = new SlnEstagio.WINBASE.VMGroupBox();
            this.txtRazaoSocial = new SlnEstagio.WINBASE.VMTextBox();
            this.dgwColecao = new SlnEstagio.WINBASE.VMDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluir = new SlnEstagio.WINBASE.VMButton();
            this.btnAlterar = new SlnEstagio.WINBASE.VMButton();
            this.btnInserir = new SlnEstagio.WINBASE.VMButton();
            this.btnFechar = new SlnEstagio.WINBASE.VMButton();
            this.txtRegistro = new SlnEstagio.WINBASE.VMTextBox();
            this.vmLabel3 = new SlnEstagio.WINBASE.VMLabel();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            this.gbxEnderecoInformacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColecao)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
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
            // gbxEnderecoInformacao
            // 
            this.gbxEnderecoInformacao.Controls.Add(this.txtRazaoSocial);
            this.gbxEnderecoInformacao.Controls.Add(this.lblRazaoSocial);
            this.gbxEnderecoInformacao.Location = new System.Drawing.Point(9, 10);
            this.gbxEnderecoInformacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxEnderecoInformacao.Name = "gbxEnderecoInformacao";
            this.gbxEnderecoInformacao.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxEnderecoInformacao.Size = new System.Drawing.Size(638, 54);
            this.gbxEnderecoInformacao.TabIndex = 0;
            this.gbxEnderecoInformacao.TabStop = false;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazaoSocial.Location = new System.Drawing.Point(128, 22);
            this.txtRazaoSocial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.ReadOnly = true;
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
            // dgwColecao
            // 
            this.dgwColecao.AllowUserToAddRows = false;
            this.dgwColecao.AllowUserToDeleteRows = false;
            this.dgwColecao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwColecao.Location = new System.Drawing.Point(9, 68);
            this.dgwColecao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgwColecao.Name = "dgwColecao";
            this.dgwColecao.RowHeadersWidth = 22;
            this.dgwColecao.RowTemplate.Height = 24;
            this.dgwColecao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwColecao.Size = new System.Drawing.Size(638, 219);
            this.dgwColecao.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(577, 296);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 24);
            this.panel1.TabIndex = 5;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(508, 292);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(64, 28);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(428, 292);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(76, 28);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(359, 292);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(64, 28);
            this.btnInserir.TabIndex = 2;
            this.btnInserir.Text = "INSERIR";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(582, 292);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(64, 28);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtRegistro
            // 
            this.txtRegistro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRegistro.Location = new System.Drawing.Point(81, 297);
            this.txtRegistro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.ReadOnly = true;
            this.txtRegistro.Size = new System.Drawing.Size(92, 20);
            this.txtRegistro.TabIndex = 14;
            this.txtRegistro.Text = "0";
            this.txtRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRegistro.VMLabelAssociado = null;
            this.txtRegistro.VMMascara = null;
            this.txtRegistro.VMPesquisa = false;
            this.txtRegistro.VMPesquisaValor = null;
            this.txtRegistro.VMRequerido = false;
            this.txtRegistro.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtRegistro.VMValor = null;
            // 
            // vmLabel3
            // 
            this.vmLabel3.AutoSize = true;
            this.vmLabel3.Location = new System.Drawing.Point(7, 299);
            this.vmLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel3.Name = "vmLabel3";
            this.vmLabel3.Size = new System.Drawing.Size(73, 13);
            this.vmLabel3.TabIndex = 13;
            this.vmLabel3.Text = "REGISTROS:";
            // 
            // FRM004
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 327);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.vmLabel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dgwColecao);
            this.Controls.Add(this.gbxEnderecoInformacao);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Name = "FRM004";
            this.Text = "SELECIONAR ENDEREÇO CLIENTE";
            this.Shown += new System.EventHandler(this.FRM004_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            this.gbxEnderecoInformacao.ResumeLayout(false);
            this.gbxEnderecoInformacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColecao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SlnEstagio.WINBASE.VMLabel lblRazaoSocial;
        private SlnEstagio.WINBASE.VMGroupBox gbxEnderecoInformacao;
        private SlnEstagio.WINBASE.VMTextBox txtRazaoSocial;
        private SlnEstagio.WINBASE.VMDataGridView dgwColecao;
        private System.Windows.Forms.Panel panel1;
        private SlnEstagio.WINBASE.VMButton btnExcluir;
        private SlnEstagio.WINBASE.VMButton btnAlterar;
        private SlnEstagio.WINBASE.VMButton btnInserir;
        private SlnEstagio.WINBASE.VMButton btnFechar;
        private WINBASE.VMTextBox txtRegistro;
        private WINBASE.VMLabel vmLabel3;
    }
}