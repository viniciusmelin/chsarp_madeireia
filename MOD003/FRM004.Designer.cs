namespace SlnEstagio.MOD003
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
            this.btnEfetuarPagamento = new SlnEstagio.WINBASE.VMButton();
            this.txtValorTotal = new SlnEstagio.WINBASE.VMTextBox();
            this.vmLabel1 = new SlnEstagio.WINBASE.VMLabel();
            this.txtRegistro = new SlnEstagio.WINBASE.VMTextBox();
            this.lblRegistro = new SlnEstagio.WINBASE.VMLabel();
            this.btnInserir = new SlnEstagio.WINBASE.VMButton();
            this.btnAlterar = new SlnEstagio.WINBASE.VMButton();
            this.btnExcluir = new SlnEstagio.WINBASE.VMButton();
            this.btnfechar = new SlnEstagio.WINBASE.VMButton();
            this.dgwColecao = new SlnEstagio.WINBASE.VMDataGridView();
            this.btnVMPesquisar = new SlnEstagio.WINBASE.VMButton();
            this.gbxCodigo = new SlnEstagio.WINBASE.VMGroupBox();
            this.txtcodigo = new SlnEstagio.WINBASE.VMTextBox();
            this.gbxOutros = new SlnEstagio.WINBASE.VMGroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.vmLabel2 = new SlnEstagio.WINBASE.VMLabel();
            this.dtpDataFinal = new SlnEstagio.WINBASE.VMDataTimePicker();
            this.lblDataFinal = new SlnEstagio.WINBASE.VMLabel();
            this.dtpDataInicial = new SlnEstagio.WINBASE.VMDataTimePicker();
            this.lblDataInicial = new SlnEstagio.WINBASE.VMLabel();
            this.btnPesqFornecedor = new SlnEstagio.WINBASE.VMButton();
            this.txtFornecedor = new SlnEstagio.WINBASE.VMTextBox();
            this.lblFornecedor = new SlnEstagio.WINBASE.VMLabel();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColecao)).BeginInit();
            this.gbxCodigo.SuspendLayout();
            this.gbxOutros.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btnEfetuarPagamento
            // 
            this.btnEfetuarPagamento.Location = new System.Drawing.Point(423, 471);
            this.btnEfetuarPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.btnEfetuarPagamento.Name = "btnEfetuarPagamento";
            this.btnEfetuarPagamento.Size = new System.Drawing.Size(105, 28);
            this.btnEfetuarPagamento.TabIndex = 8;
            this.btnEfetuarPagamento.Text = "&EFETUAR PG.";
            this.btnEfetuarPagamento.UseVisualStyleBackColor = true;
            this.btnEfetuarPagamento.Click += new System.EventHandler(this.btnEfetuarPagamento_Click);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorTotal.Location = new System.Drawing.Point(250, 436);
            this.txtValorTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(92, 20);
            this.txtValorTotal.TabIndex = 7;
            this.txtValorTotal.Text = "0";
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorTotal.VMLabelAssociado = null;
            this.txtValorTotal.VMMascara = null;
            this.txtValorTotal.VMPesquisa = false;
            this.txtValorTotal.VMPesquisaValor = null;
            this.txtValorTotal.VMRequerido = false;
            this.txtValorTotal.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtValorTotal.VMValor = null;
            // 
            // vmLabel1
            // 
            this.vmLabel1.AutoSize = true;
            this.vmLabel1.Location = new System.Drawing.Point(185, 440);
            this.vmLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel1.Name = "vmLabel1";
            this.vmLabel1.Size = new System.Drawing.Size(61, 13);
            this.vmLabel1.TabIndex = 6;
            this.vmLabel1.Text = "V. TOTAL.:";
            // 
            // txtRegistro
            // 
            this.txtRegistro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRegistro.Location = new System.Drawing.Point(89, 437);
            this.txtRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.ReadOnly = true;
            this.txtRegistro.Size = new System.Drawing.Size(92, 20);
            this.txtRegistro.TabIndex = 5;
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
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(9, 440);
            this.lblRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(76, 13);
            this.lblRegistro.TabIndex = 4;
            this.lblRegistro.Text = "REGISTROS.:";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(532, 438);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(68, 28);
            this.btnInserir.TabIndex = 10;
            this.btnInserir.Text = "&INSERIR";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(532, 471);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(68, 28);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "&ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(604, 438);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(68, 28);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "&EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnfechar
            // 
            this.btnfechar.Location = new System.Drawing.Point(604, 471);
            this.btnfechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(68, 28);
            this.btnfechar.TabIndex = 12;
            this.btnfechar.Text = "&FECHAR";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // dgwColecao
            // 
            this.dgwColecao.AllowDrop = true;
            this.dgwColecao.AllowUserToAddRows = false;
            this.dgwColecao.AllowUserToDeleteRows = false;
            this.dgwColecao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwColecao.Location = new System.Drawing.Point(9, 121);
            this.dgwColecao.Margin = new System.Windows.Forms.Padding(2);
            this.dgwColecao.Name = "dgwColecao";
            this.dgwColecao.RowHeadersWidth = 22;
            this.dgwColecao.RowTemplate.Height = 24;
            this.dgwColecao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwColecao.Size = new System.Drawing.Size(664, 312);
            this.dgwColecao.TabIndex = 3;
            // 
            // btnVMPesquisar
            // 
            this.btnVMPesquisar.Location = new System.Drawing.Point(590, 87);
            this.btnVMPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVMPesquisar.Name = "btnVMPesquisar";
            this.btnVMPesquisar.Size = new System.Drawing.Size(83, 28);
            this.btnVMPesquisar.TabIndex = 2;
            this.btnVMPesquisar.Text = "&PESQUISAR";
            this.btnVMPesquisar.UseVisualStyleBackColor = true;
            this.btnVMPesquisar.Click += new System.EventHandler(this.btnVMPesquisar_Click);
            // 
            // gbxCodigo
            // 
            this.gbxCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxCodigo.Controls.Add(this.txtcodigo);
            this.gbxCodigo.Location = new System.Drawing.Point(566, 6);
            this.gbxCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.gbxCodigo.Name = "gbxCodigo";
            this.gbxCodigo.Padding = new System.Windows.Forms.Padding(2);
            this.gbxCodigo.Size = new System.Drawing.Size(106, 50);
            this.gbxCodigo.TabIndex = 1;
            this.gbxCodigo.TabStop = false;
            this.gbxCodigo.Text = "CÓDIGO";
            // 
            // txtcodigo
            // 
            this.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcodigo.Location = new System.Drawing.Point(8, 17);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtcodigo.MaxLength = 8;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(92, 20);
            this.txtcodigo.TabIndex = 0;
            this.txtcodigo.Text = "0";
            this.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcodigo.VMLabelAssociado = null;
            this.txtcodigo.VMMascara = null;
            this.txtcodigo.VMPesquisa = false;
            this.txtcodigo.VMPesquisaValor = null;
            this.txtcodigo.VMRequerido = false;
            this.txtcodigo.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Inteiro;
            this.txtcodigo.VMValor = null;
            // 
            // gbxOutros
            // 
            this.gbxOutros.Controls.Add(this.checkedListBox1);
            this.gbxOutros.Controls.Add(this.vmLabel2);
            this.gbxOutros.Controls.Add(this.dtpDataFinal);
            this.gbxOutros.Controls.Add(this.lblDataFinal);
            this.gbxOutros.Controls.Add(this.dtpDataInicial);
            this.gbxOutros.Controls.Add(this.lblDataInicial);
            this.gbxOutros.Controls.Add(this.btnPesqFornecedor);
            this.gbxOutros.Controls.Add(this.txtFornecedor);
            this.gbxOutros.Controls.Add(this.lblFornecedor);
            this.gbxOutros.Location = new System.Drawing.Point(9, 6);
            this.gbxOutros.Margin = new System.Windows.Forms.Padding(2);
            this.gbxOutros.Name = "gbxOutros";
            this.gbxOutros.Padding = new System.Windows.Forms.Padding(2);
            this.gbxOutros.Size = new System.Drawing.Size(556, 108);
            this.gbxOutros.TabIndex = 0;
            this.gbxOutros.TabStop = false;
            this.gbxOutros.Text = "FILTROS";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(425, 30);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 64);
            this.checkedListBox1.TabIndex = 8;
            // 
            // vmLabel2
            // 
            this.vmLabel2.AutoSize = true;
            this.vmLabel2.Location = new System.Drawing.Point(422, 15);
            this.vmLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel2.Name = "vmLabel2";
            this.vmLabel2.Size = new System.Drawing.Size(61, 13);
            this.vmLabel2.TabIndex = 7;
            this.vmLabel2.Text = "SITUAÇÃO";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(7, 71);
            this.dtpDataFinal.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(86, 20);
            this.dtpDataFinal.TabIndex = 3;
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Location = new System.Drawing.Point(4, 56);
            this.lblDataFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(58, 13);
            this.lblDataFinal.TabIndex = 2;
            this.lblDataFinal.Text = "DT. FINAL";
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(7, 31);
            this.dtpDataInicial.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(86, 20);
            this.dtpDataInicial.TabIndex = 1;
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.Location = new System.Drawing.Point(4, 17);
            this.lblDataInicial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(65, 13);
            this.lblDataInicial.TabIndex = 0;
            this.lblDataInicial.Text = "DT. INICIAL";
            // 
            // btnPesqFornecedor
            // 
            this.btnPesqFornecedor.Location = new System.Drawing.Point(376, 31);
            this.btnPesqFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesqFornecedor.Name = "btnPesqFornecedor";
            this.btnPesqFornecedor.Size = new System.Drawing.Size(27, 20);
            this.btnPesqFornecedor.TabIndex = 6;
            this.btnPesqFornecedor.UseVisualStyleBackColor = true;
            this.btnPesqFornecedor.Click += new System.EventHandler(this.btnPesqFornecedor_Click);
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedor.Location = new System.Drawing.Point(97, 31);
            this.txtFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(275, 20);
            this.txtFornecedor.TabIndex = 5;
            this.txtFornecedor.VMLabelAssociado = null;
            this.txtFornecedor.VMMascara = null;
            this.txtFornecedor.VMPesquisa = false;
            this.txtFornecedor.VMPesquisaValor = null;
            this.txtFornecedor.VMRequerido = false;
            this.txtFornecedor.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtFornecedor.VMValor = null;
            this.txtFornecedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFornecedor_KeyDown);
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(94, 16);
            this.lblFornecedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(82, 13);
            this.lblFornecedor.TabIndex = 4;
            this.lblFornecedor.Text = "FORNECEDOR";
            // 
            // FRM004
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 504);
            this.Controls.Add(this.btnVMPesquisar);
            this.Controls.Add(this.gbxCodigo);
            this.Controls.Add(this.gbxOutros);
            this.Controls.Add(this.btnEfetuarPagamento);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.vmLabel1);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.dgwColecao);
            this.Name = "FRM004";
            this.Text = "PESQUISAR CONTAS A PAGAR";
            this.Shown += new System.EventHandler(this.FRM004_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColecao)).EndInit();
            this.gbxCodigo.ResumeLayout(false);
            this.gbxCodigo.PerformLayout();
            this.gbxOutros.ResumeLayout(false);
            this.gbxOutros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WINBASE.VMButton btnEfetuarPagamento;
        private WINBASE.VMTextBox txtValorTotal;
        private WINBASE.VMLabel vmLabel1;
        private WINBASE.VMTextBox txtRegistro;
        private WINBASE.VMLabel lblRegistro;
        private WINBASE.VMButton btnInserir;
        private WINBASE.VMButton btnAlterar;
        private WINBASE.VMButton btnExcluir;
        private WINBASE.VMButton btnfechar;
        private WINBASE.VMDataGridView dgwColecao;
        private WINBASE.VMButton btnVMPesquisar;
        private WINBASE.VMGroupBox gbxCodigo;
        private WINBASE.VMTextBox txtcodigo;
        private WINBASE.VMGroupBox gbxOutros;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private WINBASE.VMLabel vmLabel2;
        private WINBASE.VMDataTimePicker dtpDataFinal;
        private WINBASE.VMLabel lblDataFinal;
        private WINBASE.VMDataTimePicker dtpDataInicial;
        private WINBASE.VMLabel lblDataInicial;
        private WINBASE.VMButton btnPesqFornecedor;
        private WINBASE.VMTextBox txtFornecedor;
        private WINBASE.VMLabel lblFornecedor;
    }
}