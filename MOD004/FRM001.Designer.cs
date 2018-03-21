namespace SlnEstagio.MOD004
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
            this.txtRegistro = new SlnEstagio.WINBASE.VMTextBox();
            this.lblRegistro = new SlnEstagio.WINBASE.VMLabel();
            this.dgwColecao = new SlnEstagio.WINBASE.VMDataGridView();
            this.vmGroupBox1 = new SlnEstagio.WINBASE.VMGroupBox();
            this.vmLabel6 = new SlnEstagio.WINBASE.VMLabel();
            this.btnPesquisar = new SlnEstagio.WINBASE.VMButton();
            this.btnPesqProdutoPesquisar = new SlnEstagio.WINBASE.VMButton();
            this.txtProdutoPesquisar = new SlnEstagio.WINBASE.VMTextBox();
            this.vmLabel3 = new SlnEstagio.WINBASE.VMLabel();
            this.vmLabel2 = new SlnEstagio.WINBASE.VMLabel();
            this.dtpFinal = new SlnEstagio.WINBASE.VMDataTimePicker();
            this.dtpInicial = new SlnEstagio.WINBASE.VMDataTimePicker();
            this.vmGroupBox2 = new SlnEstagio.WINBASE.VMGroupBox();
            this.vmLabel9 = new SlnEstagio.WINBASE.VMLabel();
            this.vmLabel8 = new SlnEstagio.WINBASE.VMLabel();
            this.cbxOperacao = new SlnEstagio.WINBASE.VMComboBox();
            this.btnPesqProdutoMovimentacao = new SlnEstagio.WINBASE.VMButton();
            this.vmLabel7 = new SlnEstagio.WINBASE.VMLabel();
            this.txtQuantidadeMovimentacao = new SlnEstagio.WINBASE.VMTextBox();
            this.txtProdutoMovimentacao = new SlnEstagio.WINBASE.VMTextBox();
            this.btnMovimentar = new SlnEstagio.WINBASE.VMButton();
            this.txtCredito = new SlnEstagio.WINBASE.VMTextBox();
            this.vmLabel4 = new SlnEstagio.WINBASE.VMLabel();
            this.txtDebito = new SlnEstagio.WINBASE.VMTextBox();
            this.vmLabel5 = new SlnEstagio.WINBASE.VMLabel();
            this.vmGroupBox3 = new SlnEstagio.WINBASE.VMGroupBox();
            this.vmLabel15 = new SlnEstagio.WINBASE.VMLabel();
            this.txtQuantidadeDestino = new SlnEstagio.WINBASE.VMTextBox();
            this.vmLabel14 = new SlnEstagio.WINBASE.VMLabel();
            this.vmLabel13 = new SlnEstagio.WINBASE.VMLabel();
            this.txtCubagemDestino = new SlnEstagio.WINBASE.VMTextBox();
            this.txtCubagemOrigem = new SlnEstagio.WINBASE.VMTextBox();
            this.vmLabel10 = new SlnEstagio.WINBASE.VMLabel();
            this.btnPesqProdutoDestino = new SlnEstagio.WINBASE.VMButton();
            this.vmLabel11 = new SlnEstagio.WINBASE.VMLabel();
            this.txtProdutoDestino = new SlnEstagio.WINBASE.VMTextBox();
            this.btnPesqProdutoOriginal = new SlnEstagio.WINBASE.VMButton();
            this.txtQuantidadeOriginal = new SlnEstagio.WINBASE.VMTextBox();
            this.vmLabel12 = new SlnEstagio.WINBASE.VMLabel();
            this.txtProdutoOrigem = new SlnEstagio.WINBASE.VMTextBox();
            this.btnTransformar = new SlnEstagio.WINBASE.VMButton();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColecao)).BeginInit();
            this.vmGroupBox1.SuspendLayout();
            this.vmGroupBox2.SuspendLayout();
            this.vmGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // txtRegistro
            // 
            this.txtRegistro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRegistro.Location = new System.Drawing.Point(452, 471);
            this.txtRegistro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.ReadOnly = true;
            this.txtRegistro.Size = new System.Drawing.Size(92, 20);
            this.txtRegistro.TabIndex = 5;
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
            this.lblRegistro.Location = new System.Drawing.Point(382, 475);
            this.lblRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(69, 13);
            this.lblRegistro.TabIndex = 4;
            this.lblRegistro.Text = "REGISTRO.:";
            // 
            // dgwColecao
            // 
            this.dgwColecao.AllowDrop = true;
            this.dgwColecao.AllowUserToAddRows = false;
            this.dgwColecao.AllowUserToDeleteRows = false;
            this.dgwColecao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwColecao.Location = new System.Drawing.Point(381, 7);
            this.dgwColecao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgwColecao.Name = "dgwColecao";
            this.dgwColecao.RowHeadersWidth = 22;
            this.dgwColecao.RowTemplate.Height = 24;
            this.dgwColecao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwColecao.Size = new System.Drawing.Size(599, 457);
            this.dgwColecao.TabIndex = 3;
            // 
            // vmGroupBox1
            // 
            this.vmGroupBox1.Controls.Add(this.vmLabel6);
            this.vmGroupBox1.Controls.Add(this.btnPesquisar);
            this.vmGroupBox1.Controls.Add(this.btnPesqProdutoPesquisar);
            this.vmGroupBox1.Controls.Add(this.txtProdutoPesquisar);
            this.vmGroupBox1.Controls.Add(this.vmLabel3);
            this.vmGroupBox1.Controls.Add(this.vmLabel2);
            this.vmGroupBox1.Controls.Add(this.dtpFinal);
            this.vmGroupBox1.Controls.Add(this.dtpInicial);
            this.vmGroupBox1.Location = new System.Drawing.Point(10, 2);
            this.vmGroupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vmGroupBox1.Name = "vmGroupBox1";
            this.vmGroupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vmGroupBox1.Size = new System.Drawing.Size(368, 101);
            this.vmGroupBox1.TabIndex = 0;
            this.vmGroupBox1.TabStop = false;
            // 
            // vmLabel6
            // 
            this.vmLabel6.AutoSize = true;
            this.vmLabel6.Location = new System.Drawing.Point(4, 60);
            this.vmLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel6.Name = "vmLabel6";
            this.vmLabel6.Size = new System.Drawing.Size(61, 13);
            this.vmLabel6.TabIndex = 4;
            this.vmLabel6.Text = "PRODUTO";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(284, 73);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(77, 23);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "&PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnPesqProdutoPesquisar
            // 
            this.btnPesqProdutoPesquisar.Location = new System.Drawing.Point(251, 74);
            this.btnPesqProdutoPesquisar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPesqProdutoPesquisar.Name = "btnPesqProdutoPesquisar";
            this.btnPesqProdutoPesquisar.Size = new System.Drawing.Size(27, 20);
            this.btnPesqProdutoPesquisar.TabIndex = 6;
            this.btnPesqProdutoPesquisar.UseVisualStyleBackColor = true;
            this.btnPesqProdutoPesquisar.Click += new System.EventHandler(this.btnPesqProdutoPesquisar_Click);
            // 
            // txtProdutoPesquisar
            // 
            this.txtProdutoPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProdutoPesquisar.Location = new System.Drawing.Point(6, 74);
            this.txtProdutoPesquisar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProdutoPesquisar.Name = "txtProdutoPesquisar";
            this.txtProdutoPesquisar.Size = new System.Drawing.Size(242, 20);
            this.txtProdutoPesquisar.TabIndex = 5;
            this.txtProdutoPesquisar.VMLabelAssociado = null;
            this.txtProdutoPesquisar.VMMascara = null;
            this.txtProdutoPesquisar.VMPesquisa = false;
            this.txtProdutoPesquisar.VMPesquisaValor = null;
            this.txtProdutoPesquisar.VMRequerido = false;
            this.txtProdutoPesquisar.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtProdutoPesquisar.VMValor = null;
            this.txtProdutoPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProdutoPesquisar_KeyDown);
            // 
            // vmLabel3
            // 
            this.vmLabel3.AutoSize = true;
            this.vmLabel3.Location = new System.Drawing.Point(94, 16);
            this.vmLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel3.Name = "vmLabel3";
            this.vmLabel3.Size = new System.Drawing.Size(69, 13);
            this.vmLabel3.TabIndex = 2;
            this.vmLabel3.Text = "DATA FINAL";
            // 
            // vmLabel2
            // 
            this.vmLabel2.AutoSize = true;
            this.vmLabel2.Location = new System.Drawing.Point(4, 15);
            this.vmLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel2.Name = "vmLabel2";
            this.vmLabel2.Size = new System.Drawing.Size(76, 13);
            this.vmLabel2.TabIndex = 0;
            this.vmLabel2.Text = "DATA INICIAL";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(97, 32);
            this.dtpFinal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(90, 20);
            this.dtpFinal.TabIndex = 3;
            // 
            // dtpInicial
            // 
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicial.Location = new System.Drawing.Point(3, 32);
            this.dtpInicial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(90, 20);
            this.dtpInicial.TabIndex = 1;
            // 
            // vmGroupBox2
            // 
            this.vmGroupBox2.Controls.Add(this.vmLabel9);
            this.vmGroupBox2.Controls.Add(this.vmLabel8);
            this.vmGroupBox2.Controls.Add(this.cbxOperacao);
            this.vmGroupBox2.Controls.Add(this.btnPesqProdutoMovimentacao);
            this.vmGroupBox2.Controls.Add(this.vmLabel7);
            this.vmGroupBox2.Controls.Add(this.txtQuantidadeMovimentacao);
            this.vmGroupBox2.Controls.Add(this.txtProdutoMovimentacao);
            this.vmGroupBox2.Controls.Add(this.btnMovimentar);
            this.vmGroupBox2.Location = new System.Drawing.Point(9, 107);
            this.vmGroupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vmGroupBox2.Name = "vmGroupBox2";
            this.vmGroupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vmGroupBox2.Size = new System.Drawing.Size(369, 164);
            this.vmGroupBox2.TabIndex = 1;
            this.vmGroupBox2.TabStop = false;
            this.vmGroupBox2.Text = "REGISTRAR MOVIMENTAÇÕES";
            // 
            // vmLabel9
            // 
            this.vmLabel9.AutoSize = true;
            this.vmLabel9.Location = new System.Drawing.Point(162, 72);
            this.vmLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel9.Name = "vmLabel9";
            this.vmLabel9.Size = new System.Drawing.Size(78, 13);
            this.vmLabel9.TabIndex = 5;
            this.vmLabel9.Text = "QUANTIDADE";
            // 
            // vmLabel8
            // 
            this.vmLabel8.AutoSize = true;
            this.vmLabel8.Location = new System.Drawing.Point(4, 70);
            this.vmLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel8.Name = "vmLabel8";
            this.vmLabel8.Size = new System.Drawing.Size(32, 13);
            this.vmLabel8.TabIndex = 3;
            this.vmLabel8.Text = "TIPO";
            // 
            // cbxOperacao
            // 
            this.cbxOperacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOperacao.FormattingEnabled = true;
            this.cbxOperacao.GSLabelAssociado = null;
            this.cbxOperacao.Items.AddRange(new object[] {
            "ENTRADA",
            "SAÍDA"});
            this.cbxOperacao.Location = new System.Drawing.Point(7, 86);
            this.cbxOperacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxOperacao.Name = "cbxOperacao";
            this.cbxOperacao.Size = new System.Drawing.Size(154, 21);
            this.cbxOperacao.TabIndex = 4;
            this.cbxOperacao.VMRequerido = false;
            // 
            // btnPesqProdutoMovimentacao
            // 
            this.btnPesqProdutoMovimentacao.Location = new System.Drawing.Point(335, 42);
            this.btnPesqProdutoMovimentacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPesqProdutoMovimentacao.Name = "btnPesqProdutoMovimentacao";
            this.btnPesqProdutoMovimentacao.Size = new System.Drawing.Size(27, 19);
            this.btnPesqProdutoMovimentacao.TabIndex = 2;
            this.btnPesqProdutoMovimentacao.UseVisualStyleBackColor = true;
            this.btnPesqProdutoMovimentacao.Click += new System.EventHandler(this.btnPesqProdutoMovimentacao_Click);
            // 
            // vmLabel7
            // 
            this.vmLabel7.AutoSize = true;
            this.vmLabel7.Location = new System.Drawing.Point(4, 25);
            this.vmLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel7.Name = "vmLabel7";
            this.vmLabel7.Size = new System.Drawing.Size(61, 13);
            this.vmLabel7.TabIndex = 0;
            this.vmLabel7.Text = "PRODUTO";
            // 
            // txtQuantidadeMovimentacao
            // 
            this.txtQuantidadeMovimentacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQuantidadeMovimentacao.Location = new System.Drawing.Point(164, 86);
            this.txtQuantidadeMovimentacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQuantidadeMovimentacao.MaxLength = 8;
            this.txtQuantidadeMovimentacao.Name = "txtQuantidadeMovimentacao";
            this.txtQuantidadeMovimentacao.Size = new System.Drawing.Size(129, 20);
            this.txtQuantidadeMovimentacao.TabIndex = 6;
            this.txtQuantidadeMovimentacao.Text = "0";
            this.txtQuantidadeMovimentacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantidadeMovimentacao.VMLabelAssociado = null;
            this.txtQuantidadeMovimentacao.VMMascara = null;
            this.txtQuantidadeMovimentacao.VMPesquisa = false;
            this.txtQuantidadeMovimentacao.VMPesquisaValor = null;
            this.txtQuantidadeMovimentacao.VMRequerido = false;
            this.txtQuantidadeMovimentacao.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Inteiro;
            this.txtQuantidadeMovimentacao.VMValor = null;
            // 
            // txtProdutoMovimentacao
            // 
            this.txtProdutoMovimentacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProdutoMovimentacao.Location = new System.Drawing.Point(7, 41);
            this.txtProdutoMovimentacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProdutoMovimentacao.Name = "txtProdutoMovimentacao";
            this.txtProdutoMovimentacao.Size = new System.Drawing.Size(319, 20);
            this.txtProdutoMovimentacao.TabIndex = 1;
            this.txtProdutoMovimentacao.VMLabelAssociado = null;
            this.txtProdutoMovimentacao.VMMascara = null;
            this.txtProdutoMovimentacao.VMPesquisa = false;
            this.txtProdutoMovimentacao.VMPesquisaValor = null;
            this.txtProdutoMovimentacao.VMRequerido = false;
            this.txtProdutoMovimentacao.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtProdutoMovimentacao.VMValor = null;
            this.txtProdutoMovimentacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProdutoMovimentacao_KeyDown);
            // 
            // btnMovimentar
            // 
            this.btnMovimentar.Location = new System.Drawing.Point(4, 120);
            this.btnMovimentar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMovimentar.Name = "btnMovimentar";
            this.btnMovimentar.Size = new System.Drawing.Size(358, 37);
            this.btnMovimentar.TabIndex = 7;
            this.btnMovimentar.Text = "&MOVIMENTAR";
            this.btnMovimentar.UseVisualStyleBackColor = true;
            this.btnMovimentar.Click += new System.EventHandler(this.btnMovimentar_Click);
            // 
            // txtCredito
            // 
            this.txtCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCredito.Location = new System.Drawing.Point(754, 471);
            this.txtCredito.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.ReadOnly = true;
            this.txtCredito.Size = new System.Drawing.Size(92, 20);
            this.txtCredito.TabIndex = 11;
            this.txtCredito.VMLabelAssociado = null;
            this.txtCredito.VMMascara = null;
            this.txtCredito.VMPesquisa = false;
            this.txtCredito.VMPesquisaValor = null;
            this.txtCredito.VMRequerido = false;
            this.txtCredito.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtCredito.VMValor = null;
            // 
            // vmLabel4
            // 
            this.vmLabel4.AutoSize = true;
            this.vmLabel4.Location = new System.Drawing.Point(545, 475);
            this.vmLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel4.Name = "vmLabel4";
            this.vmLabel4.Size = new System.Drawing.Size(53, 13);
            this.vmLabel4.TabIndex = 8;
            this.vmLabel4.Text = "DÉBITO.:";
            // 
            // txtDebito
            // 
            this.txtDebito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDebito.Location = new System.Drawing.Point(599, 471);
            this.txtDebito.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDebito.Name = "txtDebito";
            this.txtDebito.ReadOnly = true;
            this.txtDebito.Size = new System.Drawing.Size(92, 20);
            this.txtDebito.TabIndex = 9;
            this.txtDebito.VMLabelAssociado = null;
            this.txtDebito.VMMascara = null;
            this.txtDebito.VMPesquisa = false;
            this.txtDebito.VMPesquisaValor = null;
            this.txtDebito.VMRequerido = false;
            this.txtDebito.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtDebito.VMValor = null;
            // 
            // vmLabel5
            // 
            this.vmLabel5.AutoSize = true;
            this.vmLabel5.Location = new System.Drawing.Point(692, 475);
            this.vmLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel5.Name = "vmLabel5";
            this.vmLabel5.Size = new System.Drawing.Size(61, 13);
            this.vmLabel5.TabIndex = 10;
            this.vmLabel5.Text = "CRÉDITO.:";
            // 
            // vmGroupBox3
            // 
            this.vmGroupBox3.Controls.Add(this.vmLabel15);
            this.vmGroupBox3.Controls.Add(this.txtQuantidadeDestino);
            this.vmGroupBox3.Controls.Add(this.vmLabel14);
            this.vmGroupBox3.Controls.Add(this.vmLabel13);
            this.vmGroupBox3.Controls.Add(this.txtCubagemDestino);
            this.vmGroupBox3.Controls.Add(this.txtCubagemOrigem);
            this.vmGroupBox3.Controls.Add(this.vmLabel10);
            this.vmGroupBox3.Controls.Add(this.btnPesqProdutoDestino);
            this.vmGroupBox3.Controls.Add(this.vmLabel11);
            this.vmGroupBox3.Controls.Add(this.txtProdutoDestino);
            this.vmGroupBox3.Controls.Add(this.btnPesqProdutoOriginal);
            this.vmGroupBox3.Controls.Add(this.txtQuantidadeOriginal);
            this.vmGroupBox3.Controls.Add(this.vmLabel12);
            this.vmGroupBox3.Controls.Add(this.txtProdutoOrigem);
            this.vmGroupBox3.Controls.Add(this.btnTransformar);
            this.vmGroupBox3.Location = new System.Drawing.Point(8, 276);
            this.vmGroupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vmGroupBox3.Name = "vmGroupBox3";
            this.vmGroupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vmGroupBox3.Size = new System.Drawing.Size(370, 216);
            this.vmGroupBox3.TabIndex = 2;
            this.vmGroupBox3.TabStop = false;
            this.vmGroupBox3.Text = "TRANSFORMAR PRODUTO";
            // 
            // vmLabel15
            // 
            this.vmLabel15.AutoSize = true;
            this.vmLabel15.Location = new System.Drawing.Point(131, 127);
            this.vmLabel15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel15.Name = "vmLabel15";
            this.vmLabel15.Size = new System.Drawing.Size(84, 13);
            this.vmLabel15.TabIndex = 13;
            this.vmLabel15.Text = "QTD. DESTINO";
            // 
            // txtQuantidadeDestino
            // 
            this.txtQuantidadeDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQuantidadeDestino.Location = new System.Drawing.Point(134, 143);
            this.txtQuantidadeDestino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQuantidadeDestino.MaxLength = 8;
            this.txtQuantidadeDestino.Name = "txtQuantidadeDestino";
            this.txtQuantidadeDestino.Size = new System.Drawing.Size(116, 20);
            this.txtQuantidadeDestino.TabIndex = 14;
            this.txtQuantidadeDestino.Text = "0";
            this.txtQuantidadeDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantidadeDestino.VMLabelAssociado = null;
            this.txtQuantidadeDestino.VMMascara = null;
            this.txtQuantidadeDestino.VMPesquisa = false;
            this.txtQuantidadeDestino.VMPesquisaValor = null;
            this.txtQuantidadeDestino.VMRequerido = false;
            this.txtQuantidadeDestino.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Inteiro;
            this.txtQuantidadeDestino.VMValor = null;
            // 
            // vmLabel14
            // 
            this.vmLabel14.AutoSize = true;
            this.vmLabel14.Location = new System.Drawing.Point(267, 81);
            this.vmLabel14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel14.Name = "vmLabel14";
            this.vmLabel14.Size = new System.Drawing.Size(60, 13);
            this.vmLabel14.TabIndex = 9;
            this.vmLabel14.Text = "CUBAGEM";
            // 
            // vmLabel13
            // 
            this.vmLabel13.AutoSize = true;
            this.vmLabel13.Location = new System.Drawing.Point(267, 37);
            this.vmLabel13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel13.Name = "vmLabel13";
            this.vmLabel13.Size = new System.Drawing.Size(60, 13);
            this.vmLabel13.TabIndex = 4;
            this.vmLabel13.Text = "CUBAGEM";
            // 
            // txtCubagemDestino
            // 
            this.txtCubagemDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCubagemDestino.Location = new System.Drawing.Point(267, 97);
            this.txtCubagemDestino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCubagemDestino.Name = "txtCubagemDestino";
            this.txtCubagemDestino.ReadOnly = true;
            this.txtCubagemDestino.Size = new System.Drawing.Size(96, 20);
            this.txtCubagemDestino.TabIndex = 10;
            this.txtCubagemDestino.VMLabelAssociado = null;
            this.txtCubagemDestino.VMMascara = null;
            this.txtCubagemDestino.VMPesquisa = false;
            this.txtCubagemDestino.VMPesquisaValor = null;
            this.txtCubagemDestino.VMRequerido = false;
            this.txtCubagemDestino.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtCubagemDestino.VMValor = null;
            // 
            // txtCubagemOrigem
            // 
            this.txtCubagemOrigem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCubagemOrigem.Location = new System.Drawing.Point(267, 54);
            this.txtCubagemOrigem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCubagemOrigem.Name = "txtCubagemOrigem";
            this.txtCubagemOrigem.ReadOnly = true;
            this.txtCubagemOrigem.Size = new System.Drawing.Size(96, 20);
            this.txtCubagemOrigem.TabIndex = 5;
            this.txtCubagemOrigem.VMLabelAssociado = null;
            this.txtCubagemOrigem.VMMascara = null;
            this.txtCubagemOrigem.VMPesquisa = false;
            this.txtCubagemOrigem.VMPesquisaValor = null;
            this.txtCubagemOrigem.VMRequerido = false;
            this.txtCubagemOrigem.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtCubagemOrigem.VMValor = null;
            // 
            // vmLabel10
            // 
            this.vmLabel10.AutoSize = true;
            this.vmLabel10.Location = new System.Drawing.Point(6, 127);
            this.vmLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel10.Name = "vmLabel10";
            this.vmLabel10.Size = new System.Drawing.Size(87, 13);
            this.vmLabel10.TabIndex = 11;
            this.vmLabel10.Text = "QTD. ORIGINAL";
            // 
            // btnPesqProdutoDestino
            // 
            this.btnPesqProdutoDestino.Location = new System.Drawing.Point(233, 97);
            this.btnPesqProdutoDestino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPesqProdutoDestino.Name = "btnPesqProdutoDestino";
            this.btnPesqProdutoDestino.Size = new System.Drawing.Size(27, 20);
            this.btnPesqProdutoDestino.TabIndex = 8;
            this.btnPesqProdutoDestino.UseVisualStyleBackColor = true;
            this.btnPesqProdutoDestino.Click += new System.EventHandler(this.btnPesqProdutoDestino_Click);
            // 
            // vmLabel11
            // 
            this.vmLabel11.AutoSize = true;
            this.vmLabel11.Location = new System.Drawing.Point(6, 81);
            this.vmLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel11.Name = "vmLabel11";
            this.vmLabel11.Size = new System.Drawing.Size(112, 13);
            this.vmLabel11.TabIndex = 6;
            this.vmLabel11.Text = "PRODUTO DESTINO";
            // 
            // txtProdutoDestino
            // 
            this.txtProdutoDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProdutoDestino.Location = new System.Drawing.Point(8, 98);
            this.txtProdutoDestino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProdutoDestino.Name = "txtProdutoDestino";
            this.txtProdutoDestino.Size = new System.Drawing.Size(220, 20);
            this.txtProdutoDestino.TabIndex = 7;
            this.txtProdutoDestino.VMLabelAssociado = null;
            this.txtProdutoDestino.VMMascara = null;
            this.txtProdutoDestino.VMPesquisa = false;
            this.txtProdutoDestino.VMPesquisaValor = null;
            this.txtProdutoDestino.VMRequerido = false;
            this.txtProdutoDestino.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtProdutoDestino.VMValor = null;
            this.txtProdutoDestino.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProdutoDestino_KeyDown);
            // 
            // btnPesqProdutoOriginal
            // 
            this.btnPesqProdutoOriginal.Location = new System.Drawing.Point(233, 53);
            this.btnPesqProdutoOriginal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPesqProdutoOriginal.Name = "btnPesqProdutoOriginal";
            this.btnPesqProdutoOriginal.Size = new System.Drawing.Size(27, 20);
            this.btnPesqProdutoOriginal.TabIndex = 2;
            this.btnPesqProdutoOriginal.UseVisualStyleBackColor = true;
            this.btnPesqProdutoOriginal.Click += new System.EventHandler(this.btnPesqProdutoOriginal_Click);
            // 
            // txtQuantidadeOriginal
            // 
            this.txtQuantidadeOriginal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQuantidadeOriginal.Location = new System.Drawing.Point(8, 143);
            this.txtQuantidadeOriginal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQuantidadeOriginal.MaxLength = 8;
            this.txtQuantidadeOriginal.Name = "txtQuantidadeOriginal";
            this.txtQuantidadeOriginal.Size = new System.Drawing.Size(116, 20);
            this.txtQuantidadeOriginal.TabIndex = 12;
            this.txtQuantidadeOriginal.Text = "0";
            this.txtQuantidadeOriginal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantidadeOriginal.VMLabelAssociado = null;
            this.txtQuantidadeOriginal.VMMascara = null;
            this.txtQuantidadeOriginal.VMPesquisa = false;
            this.txtQuantidadeOriginal.VMPesquisaValor = null;
            this.txtQuantidadeOriginal.VMRequerido = false;
            this.txtQuantidadeOriginal.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Inteiro;
            this.txtQuantidadeOriginal.VMValor = null;
            // 
            // vmLabel12
            // 
            this.vmLabel12.AutoSize = true;
            this.vmLabel12.Location = new System.Drawing.Point(4, 37);
            this.vmLabel12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel12.Name = "vmLabel12";
            this.vmLabel12.Size = new System.Drawing.Size(107, 13);
            this.vmLabel12.TabIndex = 0;
            this.vmLabel12.Text = "PRODUTO ORIGEM";
            // 
            // txtProdutoOrigem
            // 
            this.txtProdutoOrigem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProdutoOrigem.Location = new System.Drawing.Point(7, 54);
            this.txtProdutoOrigem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProdutoOrigem.Name = "txtProdutoOrigem";
            this.txtProdutoOrigem.Size = new System.Drawing.Size(222, 20);
            this.txtProdutoOrigem.TabIndex = 1;
            this.txtProdutoOrigem.VMLabelAssociado = null;
            this.txtProdutoOrigem.VMMascara = null;
            this.txtProdutoOrigem.VMPesquisa = false;
            this.txtProdutoOrigem.VMPesquisaValor = null;
            this.txtProdutoOrigem.VMRequerido = false;
            this.txtProdutoOrigem.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtProdutoOrigem.VMValor = null;
            this.txtProdutoOrigem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProdutoOrigem_KeyDown);
            // 
            // btnTransformar
            // 
            this.btnTransformar.Location = new System.Drawing.Point(4, 178);
            this.btnTransformar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTransformar.Name = "btnTransformar";
            this.btnTransformar.Size = new System.Drawing.Size(359, 33);
            this.btnTransformar.TabIndex = 0;
            this.btnTransformar.Text = "&TRANSFORMAR";
            this.btnTransformar.UseVisualStyleBackColor = true;
            this.btnTransformar.Click += new System.EventHandler(this.btnTransformar_Click);
            // 
            // FRM001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 500);
            this.Controls.Add(this.vmGroupBox3);
            this.Controls.Add(this.txtCredito);
            this.Controls.Add(this.vmLabel4);
            this.Controls.Add(this.txtDebito);
            this.Controls.Add(this.vmLabel5);
            this.Controls.Add(this.vmGroupBox2);
            this.Controls.Add(this.vmGroupBox1);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.dgwColecao);
            this.Name = "FRM001";
            this.Text = "CONTROLE DE ESTOQUE";
            this.Shown += new System.EventHandler(this.FRM001_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColecao)).EndInit();
            this.vmGroupBox1.ResumeLayout(false);
            this.vmGroupBox1.PerformLayout();
            this.vmGroupBox2.ResumeLayout(false);
            this.vmGroupBox2.PerformLayout();
            this.vmGroupBox3.ResumeLayout(false);
            this.vmGroupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WINBASE.VMTextBox txtRegistro;
        private WINBASE.VMLabel lblRegistro;
        private WINBASE.VMDataGridView dgwColecao;
        private WINBASE.VMGroupBox vmGroupBox1;
        private WINBASE.VMTextBox txtProdutoPesquisar;
        private WINBASE.VMLabel vmLabel3;
        private WINBASE.VMLabel vmLabel2;
        private WINBASE.VMDataTimePicker dtpFinal;
        private WINBASE.VMDataTimePicker dtpInicial;
        private WINBASE.VMLabel vmLabel6;
        private WINBASE.VMButton btnPesquisar;
        private WINBASE.VMButton btnPesqProdutoPesquisar;
        private WINBASE.VMGroupBox vmGroupBox2;
        private WINBASE.VMButton btnMovimentar;
        private WINBASE.VMTextBox txtCredito;
        private WINBASE.VMLabel vmLabel4;
        private WINBASE.VMTextBox txtDebito;
        private WINBASE.VMLabel vmLabel5;
        private WINBASE.VMLabel vmLabel8;
        private WINBASE.VMComboBox cbxOperacao;
        private WINBASE.VMButton btnPesqProdutoMovimentacao;
        private WINBASE.VMLabel vmLabel7;
        private WINBASE.VMTextBox txtProdutoMovimentacao;
        private WINBASE.VMLabel vmLabel9;
        private WINBASE.VMTextBox txtQuantidadeMovimentacao;
        private WINBASE.VMGroupBox vmGroupBox3;
        private WINBASE.VMLabel vmLabel10;
        private WINBASE.VMButton btnPesqProdutoOriginal;
        private WINBASE.VMLabel vmLabel12;
        private WINBASE.VMTextBox txtQuantidadeOriginal;
        private WINBASE.VMTextBox txtProdutoOrigem;
        private WINBASE.VMButton btnTransformar;
        private WINBASE.VMButton btnPesqProdutoDestino;
        private WINBASE.VMLabel vmLabel11;
        private WINBASE.VMTextBox txtProdutoDestino;
        private WINBASE.VMLabel vmLabel14;
        private WINBASE.VMLabel vmLabel13;
        private WINBASE.VMTextBox txtCubagemDestino;
        private WINBASE.VMTextBox txtCubagemOrigem;
        private WINBASE.VMLabel vmLabel15;
        private WINBASE.VMTextBox txtQuantidadeDestino;
    }
}