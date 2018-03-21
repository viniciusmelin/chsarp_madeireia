namespace SlnEstagio.MOD002
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAlterar = new SlnEstagio.WINBASE.VMButton();
            this.btnItens = new SlnEstagio.WINBASE.VMButton();
            this.btnExcluir = new SlnEstagio.WINBASE.VMButton();
            this.btnSitucao = new SlnEstagio.WINBASE.VMButton();
            this.btnInserir = new SlnEstagio.WINBASE.VMButton();
            this.btnFechar = new SlnEstagio.WINBASE.VMButton();
            this.txtRegistros = new SlnEstagio.WINBASE.VMTextBox();
            this.lblValorTotal = new SlnEstagio.WINBASE.VMLabel();
            this.dgwColecao = new SlnEstagio.WINBASE.VMDataGridView();
            this.gbxOutros = new SlnEstagio.WINBASE.VMGroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.vmLabel2 = new SlnEstagio.WINBASE.VMLabel();
            this.cbxOperacao = new SlnEstagio.WINBASE.VMComboBox();
            this.lblOperacao = new SlnEstagio.WINBASE.VMLabel();
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
            this.gbxPedido = new SlnEstagio.WINBASE.VMGroupBox();
            this.txtpedido = new SlnEstagio.WINBASE.VMTextBox();
            this.btnVMPesquisar = new SlnEstagio.WINBASE.VMButton();
            this.txtValorTotal = new SlnEstagio.WINBASE.VMTextBox();
            this.vmLabel1 = new SlnEstagio.WINBASE.VMLabel();
            this.btnImprimir = new SlnEstagio.WINBASE.VMButton();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColecao)).BeginInit();
            this.gbxOutros.SuspendLayout();
            this.gbxPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(638, 435);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 57);
            this.panel1.TabIndex = 14;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(463, 463);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(83, 28);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "&ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnItens
            // 
            this.btnItens.Location = new System.Drawing.Point(644, 430);
            this.btnItens.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnItens.Name = "btnItens";
            this.btnItens.Size = new System.Drawing.Size(83, 28);
            this.btnItens.TabIndex = 15;
            this.btnItens.Text = "&ITENS";
            this.btnItens.UseVisualStyleBackColor = true;
            this.btnItens.Click += new System.EventHandler(this.btnItens_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(550, 463);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(83, 28);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "&EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSitucao
            // 
            this.btnSitucao.Location = new System.Drawing.Point(463, 430);
            this.btnSitucao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSitucao.Name = "btnSitucao";
            this.btnSitucao.Size = new System.Drawing.Size(83, 28);
            this.btnSitucao.TabIndex = 10;
            this.btnSitucao.Text = "&SITUAÇÃO";
            this.btnSitucao.UseVisualStyleBackColor = true;
            this.btnSitucao.Click += new System.EventHandler(this.btnSitucao_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(550, 430);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(83, 28);
            this.btnInserir.TabIndex = 12;
            this.btnInserir.Text = "&INSERIR";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(644, 463);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(83, 28);
            this.btnFechar.TabIndex = 16;
            this.btnFechar.Text = "&FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtRegistros
            // 
            this.txtRegistros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRegistros.Location = new System.Drawing.Point(89, 433);
            this.txtRegistros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRegistros.Name = "txtRegistros";
            this.txtRegistros.ReadOnly = true;
            this.txtRegistros.Size = new System.Drawing.Size(92, 20);
            this.txtRegistros.TabIndex = 6;
            this.txtRegistros.VMLabelAssociado = null;
            this.txtRegistros.VMMascara = null;
            this.txtRegistros.VMPesquisa = false;
            this.txtRegistros.VMPesquisaValor = null;
            this.txtRegistros.VMRequerido = false;
            this.txtRegistros.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtRegistros.VMValor = null;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(37, 463);
            this.lblValorTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(48, 13);
            this.lblValorTotal.TabIndex = 7;
            this.lblValorTotal.Text = "TOTAL.:";
            // 
            // dgwColecao
            // 
            this.dgwColecao.AllowUserToAddRows = false;
            this.dgwColecao.AllowUserToDeleteRows = false;
            this.dgwColecao.AllowUserToResizeRows = false;
            this.dgwColecao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwColecao.Location = new System.Drawing.Point(7, 99);
            this.dgwColecao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgwColecao.Name = "dgwColecao";
            this.dgwColecao.RowHeadersWidth = 22;
            this.dgwColecao.RowTemplate.Height = 24;
            this.dgwColecao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwColecao.Size = new System.Drawing.Size(721, 325);
            this.dgwColecao.TabIndex = 4;
            // 
            // gbxOutros
            // 
            this.gbxOutros.Controls.Add(this.checkedListBox1);
            this.gbxOutros.Controls.Add(this.vmLabel2);
            this.gbxOutros.Controls.Add(this.cbxOperacao);
            this.gbxOutros.Controls.Add(this.lblOperacao);
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
            this.gbxOutros.Location = new System.Drawing.Point(7, 1);
            this.gbxOutros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxOutros.Name = "gbxOutros";
            this.gbxOutros.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxOutros.Size = new System.Drawing.Size(638, 93);
            this.gbxOutros.TabIndex = 1;
            this.gbxOutros.TabStop = false;
            this.gbxOutros.Text = "FILTROS";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(518, 31);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(106, 49);
            this.checkedListBox1.TabIndex = 13;
            // 
            // vmLabel2
            // 
            this.vmLabel2.AutoSize = true;
            this.vmLabel2.Location = new System.Drawing.Point(515, 15);
            this.vmLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel2.Name = "vmLabel2";
            this.vmLabel2.Size = new System.Drawing.Size(61, 13);
            this.vmLabel2.TabIndex = 12;
            this.vmLabel2.Text = "SITUAÇÃO";
            // 
            // cbxOperacao
            // 
            this.cbxOperacao.FormattingEnabled = true;
            this.cbxOperacao.GSLabelAssociado = null;
            this.cbxOperacao.Location = new System.Drawing.Point(401, 29);
            this.cbxOperacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxOperacao.Name = "cbxOperacao";
            this.cbxOperacao.Size = new System.Drawing.Size(104, 21);
            this.cbxOperacao.TabIndex = 11;
            this.cbxOperacao.VMRequerido = false;
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Location = new System.Drawing.Point(399, 15);
            this.lblOperacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(66, 13);
            this.lblOperacao.TabIndex = 10;
            this.lblOperacao.Text = "OPERAÇÃO";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(7, 67);
            this.dtpDataFinal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(86, 20);
            this.dtpDataFinal.TabIndex = 3;
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Location = new System.Drawing.Point(4, 51);
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
            this.dtpDataInicial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnPesqVendedor.Image = global::SlnEstagio.MOD002.Properties.Resources.search_icon;
            this.btnPesqVendedor.Location = new System.Drawing.Point(357, 67);
            this.btnPesqVendedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPesqVendedor.Name = "btnPesqVendedor";
            this.btnPesqVendedor.Size = new System.Drawing.Size(27, 19);
            this.btnPesqVendedor.TabIndex = 9;
            this.btnPesqVendedor.UseVisualStyleBackColor = true;
            this.btnPesqVendedor.Click += new System.EventHandler(this.btnPesqVendedor_Click);
            // 
            // btnPesqCliente
            // 
            this.btnPesqCliente.Image = global::SlnEstagio.MOD002.Properties.Resources.search_icon;
            this.btnPesqCliente.Location = new System.Drawing.Point(357, 31);
            this.btnPesqCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPesqCliente.Name = "btnPesqCliente";
            this.btnPesqCliente.Size = new System.Drawing.Size(27, 19);
            this.btnPesqCliente.TabIndex = 6;
            this.btnPesqCliente.UseVisualStyleBackColor = true;
            this.btnPesqCliente.Click += new System.EventHandler(this.btnPesqCliente_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliente.Location = new System.Drawing.Point(97, 31);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(257, 20);
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
            this.lblCliente.Location = new System.Drawing.Point(94, 15);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(52, 13);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "CLIENTE";
            // 
            // txtVendedor
            // 
            this.txtVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVendedor.Location = new System.Drawing.Point(97, 67);
            this.txtVendedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(257, 20);
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
            this.lblVendedor.Location = new System.Drawing.Point(94, 51);
            this.lblVendedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(68, 13);
            this.lblVendedor.TabIndex = 7;
            this.lblVendedor.Text = "VENDEDOR";
            // 
            // gbxPedido
            // 
            this.gbxPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxPedido.Controls.Add(this.txtpedido);
            this.gbxPedido.Location = new System.Drawing.Point(650, 1);
            this.gbxPedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxPedido.Name = "gbxPedido";
            this.gbxPedido.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxPedido.Size = new System.Drawing.Size(82, 50);
            this.gbxPedido.TabIndex = 2;
            this.gbxPedido.TabStop = false;
            this.gbxPedido.Text = "Nº PEDIDO";
            // 
            // txtpedido
            // 
            this.txtpedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpedido.Location = new System.Drawing.Point(8, 17);
            this.txtpedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtpedido.MaxLength = 8;
            this.txtpedido.Name = "txtpedido";
            this.txtpedido.Size = new System.Drawing.Size(70, 20);
            this.txtpedido.TabIndex = 0;
            this.txtpedido.Text = "0";
            this.txtpedido.VMLabelAssociado = null;
            this.txtpedido.VMMascara = null;
            this.txtpedido.VMPesquisa = false;
            this.txtpedido.VMPesquisaValor = null;
            this.txtpedido.VMRequerido = false;
            this.txtpedido.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Inteiro;
            this.txtpedido.VMValor = null;
            // 
            // btnVMPesquisar
            // 
            this.btnVMPesquisar.Location = new System.Drawing.Point(649, 62);
            this.btnVMPesquisar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVMPesquisar.Name = "btnVMPesquisar";
            this.btnVMPesquisar.Size = new System.Drawing.Size(82, 28);
            this.btnVMPesquisar.TabIndex = 3;
            this.btnVMPesquisar.Text = "PESQUISAR";
            this.btnVMPesquisar.UseVisualStyleBackColor = true;
            this.btnVMPesquisar.Click += new System.EventHandler(this.btnVMPesquisar_Click);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorTotal.Location = new System.Drawing.Point(89, 460);
            this.txtValorTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(92, 20);
            this.txtValorTotal.TabIndex = 8;
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
            this.vmLabel1.Location = new System.Drawing.Point(9, 436);
            this.vmLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel1.Name = "vmLabel1";
            this.vmLabel1.Size = new System.Drawing.Size(76, 13);
            this.vmLabel1.TabIndex = 5;
            this.vmLabel1.Text = "REGISTROS.:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(375, 463);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(83, 28);
            this.btnImprimir.TabIndex = 9;
            this.btnImprimir.Text = "&IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // FRM001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 496);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.vmLabel1);
            this.Controls.Add(this.btnVMPesquisar);
            this.Controls.Add(this.gbxPedido);
            this.Controls.Add(this.gbxOutros);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnItens);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSitucao);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtRegistros);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.dgwColecao);
            this.Name = "FRM001";
            this.Text = "SELECIONAR PEDIDO DE COMPRA";
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColecao)).EndInit();
            this.gbxOutros.ResumeLayout(false);
            this.gbxOutros.PerformLayout();
            this.gbxPedido.ResumeLayout(false);
            this.gbxPedido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SlnEstagio.WINBASE.VMDataGridView dgwColecao;
        private SlnEstagio.WINBASE.VMTextBox txtRegistros;
        private SlnEstagio.WINBASE.VMLabel lblValorTotal;
        private System.Windows.Forms.Panel panel1;
        private SlnEstagio.WINBASE.VMButton btnExcluir;
        private SlnEstagio.WINBASE.VMButton btnSitucao;
        private SlnEstagio.WINBASE.VMButton btnInserir;
        private SlnEstagio.WINBASE.VMButton btnFechar;
        private SlnEstagio.WINBASE.VMButton btnItens;
        private SlnEstagio.WINBASE.VMButton btnAlterar;
        private SlnEstagio.WINBASE.VMGroupBox gbxOutros;
        private SlnEstagio.WINBASE.VMGroupBox gbxPedido;
        private SlnEstagio.WINBASE.VMTextBox txtpedido;
        private SlnEstagio.WINBASE.VMButton btnVMPesquisar;
        private SlnEstagio.WINBASE.VMTextBox txtCliente;
        private SlnEstagio.WINBASE.VMTextBox txtVendedor;
        private SlnEstagio.WINBASE.VMLabel lblVendedor;
        private SlnEstagio.WINBASE.VMLabel lblCliente;
        private SlnEstagio.WINBASE.VMButton btnPesqVendedor;
        private SlnEstagio.WINBASE.VMButton btnPesqCliente;
        private WINBASE.VMDataTimePicker dtpDataFinal;
        private WINBASE.VMLabel lblDataFinal;
        private WINBASE.VMDataTimePicker dtpDataInicial;
        private WINBASE.VMLabel lblDataInicial;
        private WINBASE.VMTextBox txtValorTotal;
        private WINBASE.VMLabel vmLabel1;
        private WINBASE.VMLabel vmLabel2;
        private WINBASE.VMComboBox cbxOperacao;
        private WINBASE.VMLabel lblOperacao;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private WINBASE.VMButton btnImprimir;
    }
}