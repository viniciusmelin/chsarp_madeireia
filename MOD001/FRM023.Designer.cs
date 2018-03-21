namespace SlnEstagio.MOD001
{
    partial class FRM023
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
            this.txtRegistro = new SlnEstagio.WINBASE.VMTextBox();
            this.lblRegistro = new SlnEstagio.WINBASE.VMLabel();
            this.btnFechar = new SlnEstagio.WINBASE.VMButton();
            this.btnSelecionar = new SlnEstagio.WINBASE.VMButton();
            this.gbxInformacao = new SlnEstagio.WINBASE.VMGroupBox();
            this.btnVMPesquisar = new SlnEstagio.WINBASE.VMButton();
            this.cbxAtivo = new SlnEstagio.WINBASE.VMComboBox();
            this.lblAtivo = new SlnEstagio.WINBASE.VMLabel();
            this.txtVMPesquisar = new SlnEstagio.WINBASE.VMTextBox();
            this.lblVMPesquisar = new SlnEstagio.WINBASE.VMLabel();
            this.dgwColecao = new SlnEstagio.WINBASE.VMDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            this.gbxInformacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColecao)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // txtRegistro
            // 
            this.txtRegistro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRegistro.Location = new System.Drawing.Point(86, 401);
            this.txtRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.ReadOnly = true;
            this.txtRegistro.Size = new System.Drawing.Size(92, 20);
            this.txtRegistro.TabIndex = 9;
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
            this.lblRegistro.Location = new System.Drawing.Point(9, 405);
            this.lblRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(76, 13);
            this.lblRegistro.TabIndex = 8;
            this.lblRegistro.Text = "REGISTROS.:";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(430, 396);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(64, 28);
            this.btnFechar.TabIndex = 11;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(341, 396);
            this.btnSelecionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(85, 28);
            this.btnSelecionar.TabIndex = 10;
            this.btnSelecionar.Text = "SELECIONAR";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // gbxInformacao
            // 
            this.gbxInformacao.Controls.Add(this.btnVMPesquisar);
            this.gbxInformacao.Controls.Add(this.cbxAtivo);
            this.gbxInformacao.Controls.Add(this.lblAtivo);
            this.gbxInformacao.Controls.Add(this.txtVMPesquisar);
            this.gbxInformacao.Controls.Add(this.lblVMPesquisar);
            this.gbxInformacao.Location = new System.Drawing.Point(9, 10);
            this.gbxInformacao.Margin = new System.Windows.Forms.Padding(2);
            this.gbxInformacao.Name = "gbxInformacao";
            this.gbxInformacao.Padding = new System.Windows.Forms.Padding(2);
            this.gbxInformacao.Size = new System.Drawing.Size(485, 49);
            this.gbxInformacao.TabIndex = 6;
            this.gbxInformacao.TabStop = false;
            // 
            // btnVMPesquisar
            // 
            this.btnVMPesquisar.Location = new System.Drawing.Point(400, 12);
            this.btnVMPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVMPesquisar.Name = "btnVMPesquisar";
            this.btnVMPesquisar.Size = new System.Drawing.Size(81, 28);
            this.btnVMPesquisar.TabIndex = 4;
            this.btnVMPesquisar.Text = "PESQUISAR";
            this.btnVMPesquisar.UseVisualStyleBackColor = true;
            this.btnVMPesquisar.Click += new System.EventHandler(this.btnVMPesquisar_Click);
            // 
            // cbxAtivo
            // 
            this.cbxAtivo.FormattingEnabled = true;
            this.cbxAtivo.GSLabelAssociado = null;
            this.cbxAtivo.Location = new System.Drawing.Point(319, 16);
            this.cbxAtivo.Margin = new System.Windows.Forms.Padding(2);
            this.cbxAtivo.Name = "cbxAtivo";
            this.cbxAtivo.Size = new System.Drawing.Size(77, 21);
            this.cbxAtivo.TabIndex = 3;
            this.cbxAtivo.VMRequerido = false;
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.Location = new System.Drawing.Point(266, 19);
            this.lblAtivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(49, 13);
            this.lblAtivo.TabIndex = 2;
            this.lblAtivo.Text = "ATIVOS:";
            // 
            // txtVMPesquisar
            // 
            this.txtVMPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVMPesquisar.Location = new System.Drawing.Point(82, 16);
            this.txtVMPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.txtVMPesquisar.Name = "txtVMPesquisar";
            this.txtVMPesquisar.Size = new System.Drawing.Size(180, 20);
            this.txtVMPesquisar.TabIndex = 1;
            this.txtVMPesquisar.VMLabelAssociado = null;
            this.txtVMPesquisar.VMMascara = null;
            this.txtVMPesquisar.VMPesquisa = false;
            this.txtVMPesquisar.VMPesquisaValor = null;
            this.txtVMPesquisar.VMRequerido = false;
            this.txtVMPesquisar.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtVMPesquisar.VMValor = null;
            this.txtVMPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVMPesquisar_KeyDown);
            // 
            // lblVMPesquisar
            // 
            this.lblVMPesquisar.AutoSize = true;
            this.lblVMPesquisar.Location = new System.Drawing.Point(6, 20);
            this.lblVMPesquisar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVMPesquisar.Name = "lblVMPesquisar";
            this.lblVMPesquisar.Size = new System.Drawing.Size(72, 13);
            this.lblVMPesquisar.TabIndex = 0;
            this.lblVMPesquisar.Text = "PESQUISAR:";
            // 
            // dgwColecao
            // 
            this.dgwColecao.AllowUserToAddRows = false;
            this.dgwColecao.AllowUserToDeleteRows = false;
            this.dgwColecao.AllowUserToOrderColumns = true;
            this.dgwColecao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwColecao.Location = new System.Drawing.Point(9, 63);
            this.dgwColecao.Margin = new System.Windows.Forms.Padding(2);
            this.dgwColecao.Name = "dgwColecao";
            this.dgwColecao.RowHeadersWidth = 22;
            this.dgwColecao.RowTemplate.Height = 24;
            this.dgwColecao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwColecao.Size = new System.Drawing.Size(485, 327);
            this.dgwColecao.TabIndex = 7;
            // 
            // FRM023
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 427);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.gbxInformacao);
            this.Controls.Add(this.dgwColecao);
            this.Name = "FRM023";
            this.Text = "PESQUISAR PRODUTO";
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            this.gbxInformacao.ResumeLayout(false);
            this.gbxInformacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColecao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WINBASE.VMTextBox txtRegistro;
        private WINBASE.VMLabel lblRegistro;
        private WINBASE.VMButton btnFechar;
        private WINBASE.VMButton btnSelecionar;
        private WINBASE.VMGroupBox gbxInformacao;
        private WINBASE.VMButton btnVMPesquisar;
        private WINBASE.VMComboBox cbxAtivo;
        private WINBASE.VMLabel lblAtivo;
        private WINBASE.VMTextBox txtVMPesquisar;
        private WINBASE.VMLabel lblVMPesquisar;
        private WINBASE.VMDataGridView dgwColecao;
    }
}