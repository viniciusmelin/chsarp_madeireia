namespace SlnEstagio.MOD003
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
            this.btnPesqVendedor = new SlnEstagio.WINBASE.VMButton();
            this.btnPesqCliente = new SlnEstagio.WINBASE.VMButton();
            this.txtCliente = new SlnEstagio.WINBASE.VMTextBox();
            this.lblCliente = new SlnEstagio.WINBASE.VMLabel();
            this.txtVendedor = new SlnEstagio.WINBASE.VMTextBox();
            this.lblVendedor = new SlnEstagio.WINBASE.VMLabel();
            this.btnfechar = new SlnEstagio.WINBASE.VMButton();
            this.btnExcluir = new SlnEstagio.WINBASE.VMButton();
            this.btnAlterar = new SlnEstagio.WINBASE.VMButton();
            this.btnInserir = new SlnEstagio.WINBASE.VMButton();
            this.txtValorTotal = new SlnEstagio.WINBASE.VMTextBox();
            this.vmLabel1 = new SlnEstagio.WINBASE.VMLabel();
            this.txtRegistro = new SlnEstagio.WINBASE.VMTextBox();
            this.lblRegistro = new SlnEstagio.WINBASE.VMLabel();
            this.btnSituacao = new SlnEstagio.WINBASE.VMButton();
            this.btnEfetuarBaixa = new SlnEstagio.WINBASE.VMButton();
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
            // dgwColecao
            // 
            this.dgwColecao.AllowDrop = true;
            this.dgwColecao.AllowUserToAddRows = false;
            this.dgwColecao.AllowUserToDeleteRows = false;
            this.dgwColecao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwColecao.Location = new System.Drawing.Point(9, 123);
            this.dgwColecao.Margin = new System.Windows.Forms.Padding(2);
            this.dgwColecao.Name = "dgwColecao";
            this.dgwColecao.RowHeadersWidth = 22;
            this.dgwColecao.RowTemplate.Height = 24;
            this.dgwColecao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwColecao.Size = new System.Drawing.Size(718, 292);
            this.dgwColecao.TabIndex = 3;
            // 
            // btnVMPesquisar
            // 
            this.btnVMPesquisar.Location = new System.Drawing.Point(644, 85);
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
            this.gbxCodigo.Location = new System.Drawing.Point(622, 9);
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
            this.txtcodigo.Location = new System.Drawing.Point(5, 17);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtcodigo.MaxLength = 8;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(96, 20);
            this.txtcodigo.TabIndex = 0;
            this.txtcodigo.Text = "0";
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
            this.gbxOutros.Controls.Add(this.btnPesqVendedor);
            this.gbxOutros.Controls.Add(this.btnPesqCliente);
            this.gbxOutros.Controls.Add(this.txtCliente);
            this.gbxOutros.Controls.Add(this.lblCliente);
            this.gbxOutros.Controls.Add(this.txtVendedor);
            this.gbxOutros.Controls.Add(this.lblVendedor);
            this.gbxOutros.Location = new System.Drawing.Point(14, 7);
            this.gbxOutros.Margin = new System.Windows.Forms.Padding(2);
            this.gbxOutros.Name = "gbxOutros";
            this.gbxOutros.Padding = new System.Windows.Forms.Padding(2);
            this.gbxOutros.Size = new System.Drawing.Size(604, 108);
            this.gbxOutros.TabIndex = 0;
            this.gbxOutros.TabStop = false;
            this.gbxOutros.Text = "FILTROS";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(449, 26);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 64);
            this.checkedListBox1.TabIndex = 11;
            // 
            // vmLabel2
            // 
            this.vmLabel2.AutoSize = true;
            this.vmLabel2.Location = new System.Drawing.Point(447, 9);
            this.vmLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel2.Name = "vmLabel2";
            this.vmLabel2.Size = new System.Drawing.Size(61, 13);
            this.vmLabel2.TabIndex = 10;
            this.vmLabel2.Text = "SITUAÇÃO";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(7, 76);
            this.dtpDataFinal.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(86, 20);
            this.dtpDataFinal.TabIndex = 3;
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Location = new System.Drawing.Point(4, 60);
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
            this.lblDataInicial.Location = new System.Drawing.Point(4, 15);
            this.lblDataInicial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(65, 13);
            this.lblDataInicial.TabIndex = 0;
            this.lblDataInicial.Text = "DT. INICIAL";
            // 
            // btnPesqVendedor
            // 
            this.btnPesqVendedor.Location = new System.Drawing.Point(392, 76);
            this.btnPesqVendedor.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesqVendedor.Name = "btnPesqVendedor";
            this.btnPesqVendedor.Size = new System.Drawing.Size(27, 20);
            this.btnPesqVendedor.TabIndex = 9;
            this.btnPesqVendedor.UseVisualStyleBackColor = true;
            this.btnPesqVendedor.Click += new System.EventHandler(this.btnPesqVendedor_Click);
            // 
            // btnPesqCliente
            // 
            this.btnPesqCliente.Location = new System.Drawing.Point(392, 31);
            this.btnPesqCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesqCliente.Name = "btnPesqCliente";
            this.btnPesqCliente.Size = new System.Drawing.Size(27, 20);
            this.btnPesqCliente.TabIndex = 6;
            this.btnPesqCliente.UseVisualStyleBackColor = true;
            this.btnPesqCliente.Click += new System.EventHandler(this.btnPesqCliente_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliente.Location = new System.Drawing.Point(97, 31);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(291, 20);
            this.txtCliente.TabIndex = 5;
            this.txtCliente.VMLabelAssociado = null;
            this.txtCliente.VMMascara = null;
            this.txtCliente.VMPesquisa = false;
            this.txtCliente.VMPesquisaValor = null;
            this.txtCliente.VMRequerido = false;
            this.txtCliente.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtCliente.VMValor = null;
            this.txtCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyDown);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(97, 14);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(52, 13);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "CLIENTE";
            // 
            // txtVendedor
            // 
            this.txtVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVendedor.Location = new System.Drawing.Point(97, 76);
            this.txtVendedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(291, 20);
            this.txtVendedor.TabIndex = 8;
            this.txtVendedor.VMLabelAssociado = null;
            this.txtVendedor.VMMascara = null;
            this.txtVendedor.VMPesquisa = false;
            this.txtVendedor.VMPesquisaValor = null;
            this.txtVendedor.VMRequerido = false;
            this.txtVendedor.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtVendedor.VMValor = null;
            this.txtVendedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVendedor_KeyDown);
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(97, 62);
            this.lblVendedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(68, 13);
            this.lblVendedor.TabIndex = 7;
            this.lblVendedor.Text = "VENDEDOR";
            // 
            // btnfechar
            // 
            this.btnfechar.Location = new System.Drawing.Point(659, 457);
            this.btnfechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(68, 28);
            this.btnfechar.TabIndex = 15;
            this.btnfechar.Text = "&FECHAR";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(659, 424);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(68, 28);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "&EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(586, 457);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(68, 28);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "&ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(586, 424);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(68, 28);
            this.btnInserir.TabIndex = 12;
            this.btnInserir.Text = "&INSERIR";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorTotal.Location = new System.Drawing.Point(258, 424);
            this.txtValorTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(92, 20);
            this.txtValorTotal.TabIndex = 7;
            this.txtValorTotal.TabStop = false;
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
            this.vmLabel1.Location = new System.Drawing.Point(194, 426);
            this.vmLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel1.Name = "vmLabel1";
            this.vmLabel1.Size = new System.Drawing.Size(61, 13);
            this.vmLabel1.TabIndex = 6;
            this.vmLabel1.Text = "V. TOTAL.:";
            // 
            // txtRegistro
            // 
            this.txtRegistro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRegistro.Location = new System.Drawing.Point(82, 424);
            this.txtRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.ReadOnly = true;
            this.txtRegistro.Size = new System.Drawing.Size(92, 20);
            this.txtRegistro.TabIndex = 5;
            this.txtRegistro.TabStop = false;
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
            this.lblRegistro.Location = new System.Drawing.Point(11, 426);
            this.lblRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(69, 13);
            this.lblRegistro.TabIndex = 4;
            this.lblRegistro.Text = "REGISTRO.:";
            // 
            // btnSituacao
            // 
            this.btnSituacao.Location = new System.Drawing.Point(512, 424);
            this.btnSituacao.Margin = new System.Windows.Forms.Padding(2);
            this.btnSituacao.Name = "btnSituacao";
            this.btnSituacao.Size = new System.Drawing.Size(70, 28);
            this.btnSituacao.TabIndex = 10;
            this.btnSituacao.Text = "&SITUAÇÃO";
            this.btnSituacao.UseVisualStyleBackColor = true;
            this.btnSituacao.Click += new System.EventHandler(this.btnSituacao_Click);
            // 
            // btnEfetuarBaixa
            // 
            this.btnEfetuarBaixa.Location = new System.Drawing.Point(477, 457);
            this.btnEfetuarBaixa.Margin = new System.Windows.Forms.Padding(2);
            this.btnEfetuarBaixa.Name = "btnEfetuarBaixa";
            this.btnEfetuarBaixa.Size = new System.Drawing.Size(105, 28);
            this.btnEfetuarBaixa.TabIndex = 11;
            this.btnEfetuarBaixa.Text = "&EFETUAR BAIXA";
            this.btnEfetuarBaixa.UseVisualStyleBackColor = true;
            this.btnEfetuarBaixa.Click += new System.EventHandler(this.btnEfetuarBaixa_Click);
            // 
            // FRM001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 490);
            this.Controls.Add(this.btnEfetuarBaixa);
            this.Controls.Add(this.btnSituacao);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.vmLabel1);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.btnVMPesquisar);
            this.Controls.Add(this.gbxCodigo);
            this.Controls.Add(this.gbxOutros);
            this.Controls.Add(this.dgwColecao);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "FRM001";
            this.Text = "PESQUISAR CONTAS A RECEBER";
            this.Shown += new System.EventHandler(this.FRM001_Shown);
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
        private WINBASE.VMButton btnPesqVendedor;
        private WINBASE.VMButton btnPesqCliente;
        private WINBASE.VMTextBox txtCliente;
        private WINBASE.VMLabel lblCliente;
        private WINBASE.VMTextBox txtVendedor;
        private WINBASE.VMLabel lblVendedor;
        private WINBASE.VMButton btnfechar;
        private WINBASE.VMButton btnExcluir;
        private WINBASE.VMButton btnAlterar;
        private WINBASE.VMButton btnInserir;
        private WINBASE.VMTextBox txtValorTotal;
        private WINBASE.VMLabel vmLabel1;
        private WINBASE.VMTextBox txtRegistro;
        private WINBASE.VMLabel lblRegistro;
        private WINBASE.VMButton btnSituacao;
        private WINBASE.VMButton btnEfetuarBaixa;
    }
}