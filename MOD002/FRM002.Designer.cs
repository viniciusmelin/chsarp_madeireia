namespace SlnEstagio.MOD002
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
            this.gbxInformaoesProduto = new SlnEstagio.WINBASE.VMGroupBox();
            this.txtValorTotal = new SlnEstagio.WINBASE.VMTextBox();
            this.vmLabel1 = new SlnEstagio.WINBASE.VMLabel();
            this.txtCubagemTotal = new SlnEstagio.WINBASE.VMTextBox();
            this.lblCubagemTotal = new SlnEstagio.WINBASE.VMLabel();
            this.txtRegistro = new SlnEstagio.WINBASE.VMTextBox();
            this.lblRegistro = new SlnEstagio.WINBASE.VMLabel();
            this.btnPesqProduto = new SlnEstagio.WINBASE.VMButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluir = new SlnEstagio.WINBASE.VMButton();
            this.btnAlterar = new SlnEstagio.WINBASE.VMButton();
            this.btnInserir = new SlnEstagio.WINBASE.VMButton();
            this.dgwColecao = new SlnEstagio.WINBASE.VMDataGridView();
            this.txtQuantidade = new SlnEstagio.WINBASE.VMTextBox();
            this.lblQuantidade = new SlnEstagio.WINBASE.VMLabel();
            this.lblProduto = new SlnEstagio.WINBASE.VMLabel();
            this.txtProduto = new SlnEstagio.WINBASE.VMTextBox();
            this.gbxInformcoes = new SlnEstagio.WINBASE.VMGroupBox();
            this.lblVendedor = new SlnEstagio.WINBASE.VMLabel();
            this.btnPesqVendedor = new SlnEstagio.WINBASE.VMButton();
            this.txtVendedor = new SlnEstagio.WINBASE.VMTextBox();
            this.btnPesqCliente = new SlnEstagio.WINBASE.VMButton();
            this.lblCliente = new SlnEstagio.WINBASE.VMLabel();
            this.txtCliente = new SlnEstagio.WINBASE.VMTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSalvar = new SlnEstagio.WINBASE.VMButton();
            this.btnCancelar = new SlnEstagio.WINBASE.VMButton();
            this.gbxTipo = new SlnEstagio.WINBASE.VMGroupBox();
            this.rbtOrcamento = new SlnEstagio.WINBASE.VMRadioButton();
            this.rbtPedido = new SlnEstagio.WINBASE.VMRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            this.gbxInformaoesProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColecao)).BeginInit();
            this.gbxInformcoes.SuspendLayout();
            this.gbxTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // gbxInformaoesProduto
            // 
            this.gbxInformaoesProduto.Controls.Add(this.txtValorTotal);
            this.gbxInformaoesProduto.Controls.Add(this.vmLabel1);
            this.gbxInformaoesProduto.Controls.Add(this.txtCubagemTotal);
            this.gbxInformaoesProduto.Controls.Add(this.lblCubagemTotal);
            this.gbxInformaoesProduto.Controls.Add(this.txtRegistro);
            this.gbxInformaoesProduto.Controls.Add(this.lblRegistro);
            this.gbxInformaoesProduto.Controls.Add(this.btnPesqProduto);
            this.gbxInformaoesProduto.Controls.Add(this.panel1);
            this.gbxInformaoesProduto.Controls.Add(this.btnExcluir);
            this.gbxInformaoesProduto.Controls.Add(this.btnAlterar);
            this.gbxInformaoesProduto.Controls.Add(this.btnInserir);
            this.gbxInformaoesProduto.Controls.Add(this.dgwColecao);
            this.gbxInformaoesProduto.Controls.Add(this.txtQuantidade);
            this.gbxInformaoesProduto.Controls.Add(this.lblQuantidade);
            this.gbxInformaoesProduto.Controls.Add(this.lblProduto);
            this.gbxInformaoesProduto.Controls.Add(this.txtProduto);
            this.gbxInformaoesProduto.Location = new System.Drawing.Point(9, 111);
            this.gbxInformaoesProduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxInformaoesProduto.Name = "gbxInformaoesProduto";
            this.gbxInformaoesProduto.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxInformaoesProduto.Size = new System.Drawing.Size(668, 311);
            this.gbxInformaoesProduto.TabIndex = 2;
            this.gbxInformaoesProduto.TabStop = false;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorTotal.Location = new System.Drawing.Point(85, 282);
            this.txtValorTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(92, 20);
            this.txtValorTotal.TabIndex = 9;
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
            this.vmLabel1.Location = new System.Drawing.Point(20, 285);
            this.vmLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel1.Name = "vmLabel1";
            this.vmLabel1.Size = new System.Drawing.Size(61, 13);
            this.vmLabel1.TabIndex = 8;
            this.vmLabel1.Text = "V. TOTAL.:";
            // 
            // txtCubagemTotal
            // 
            this.txtCubagemTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCubagemTotal.Location = new System.Drawing.Point(267, 259);
            this.txtCubagemTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCubagemTotal.Name = "txtCubagemTotal";
            this.txtCubagemTotal.ReadOnly = true;
            this.txtCubagemTotal.Size = new System.Drawing.Size(92, 20);
            this.txtCubagemTotal.TabIndex = 11;
            this.txtCubagemTotal.VMLabelAssociado = null;
            this.txtCubagemTotal.VMMascara = null;
            this.txtCubagemTotal.VMPesquisa = false;
            this.txtCubagemTotal.VMPesquisaValor = null;
            this.txtCubagemTotal.VMRequerido = false;
            this.txtCubagemTotal.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtCubagemTotal.VMValor = null;
            // 
            // lblCubagemTotal
            // 
            this.lblCubagemTotal.AutoSize = true;
            this.lblCubagemTotal.Location = new System.Drawing.Point(189, 261);
            this.lblCubagemTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCubagemTotal.Name = "lblCubagemTotal";
            this.lblCubagemTotal.Size = new System.Drawing.Size(76, 13);
            this.lblCubagemTotal.TabIndex = 10;
            this.lblCubagemTotal.Text = "CUB. TOTAL.:";
            this.toolTip1.SetToolTip(this.lblCubagemTotal, "Cubagem Total (Quantidade x Cubagem do Produto)");
            // 
            // txtRegistro
            // 
            this.txtRegistro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRegistro.Location = new System.Drawing.Point(85, 258);
            this.txtRegistro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.ReadOnly = true;
            this.txtRegistro.Size = new System.Drawing.Size(92, 20);
            this.txtRegistro.TabIndex = 7;
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
            this.lblRegistro.Location = new System.Drawing.Point(5, 262);
            this.lblRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(76, 13);
            this.lblRegistro.TabIndex = 6;
            this.lblRegistro.Text = "REGISTROS.:";
            // 
            // btnPesqProduto
            // 
            this.btnPesqProduto.Location = new System.Drawing.Point(457, 11);
            this.btnPesqProduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPesqProduto.Name = "btnPesqProduto";
            this.btnPesqProduto.Size = new System.Drawing.Size(27, 20);
            this.btnPesqProduto.TabIndex = 2;
            this.btnPesqProduto.UseVisualStyleBackColor = true;
            this.btnPesqProduto.Click += new System.EventHandler(this.btnPesqProduto_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(590, 263);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 24);
            this.panel1.TabIndex = 14;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(596, 260);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(64, 28);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(510, 260);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 28);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(441, 260);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(64, 28);
            this.btnInserir.TabIndex = 12;
            this.btnInserir.Text = "INSERIR";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // dgwColecao
            // 
            this.dgwColecao.AllowUserToAddRows = false;
            this.dgwColecao.AllowUserToDeleteRows = false;
            this.dgwColecao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwColecao.Location = new System.Drawing.Point(8, 35);
            this.dgwColecao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgwColecao.Name = "dgwColecao";
            this.dgwColecao.RowHeadersWidth = 22;
            this.dgwColecao.RowTemplate.Height = 24;
            this.dgwColecao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwColecao.Size = new System.Drawing.Size(652, 220);
            this.dgwColecao.TabIndex = 5;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQuantidade.Location = new System.Drawing.Point(570, 11);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQuantidade.MaxLength = 8;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(69, 20);
            this.txtQuantidade.TabIndex = 4;
            this.txtQuantidade.Text = "0";
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantidade.VMLabelAssociado = null;
            this.txtQuantidade.VMMascara = null;
            this.txtQuantidade.VMPesquisa = false;
            this.txtQuantidade.VMPesquisaValor = null;
            this.txtQuantidade.VMRequerido = false;
            this.txtQuantidade.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Inteiro;
            this.txtQuantidade.VMValor = null;
            this.txtQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantidade_KeyDown);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(489, 15);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(81, 13);
            this.lblQuantidade.TabIndex = 3;
            this.lblQuantidade.Text = "QUANTIDADE:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(6, 15);
            this.lblProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(64, 13);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "PRODUTO:";
            // 
            // txtProduto
            // 
            this.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto.Location = new System.Drawing.Point(76, 11);
            this.txtProduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(377, 20);
            this.txtProduto.TabIndex = 1;
            this.txtProduto.VMLabelAssociado = null;
            this.txtProduto.VMMascara = null;
            this.txtProduto.VMPesquisa = false;
            this.txtProduto.VMPesquisaValor = null;
            this.txtProduto.VMRequerido = false;
            this.txtProduto.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtProduto.VMValor = null;
            this.txtProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProduto_KeyDown);
            // 
            // gbxInformcoes
            // 
            this.gbxInformcoes.Controls.Add(this.lblVendedor);
            this.gbxInformcoes.Controls.Add(this.btnPesqVendedor);
            this.gbxInformcoes.Controls.Add(this.txtVendedor);
            this.gbxInformcoes.Controls.Add(this.btnPesqCliente);
            this.gbxInformcoes.Controls.Add(this.lblCliente);
            this.gbxInformcoes.Controls.Add(this.txtCliente);
            this.gbxInformcoes.Location = new System.Drawing.Point(9, 45);
            this.gbxInformcoes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxInformcoes.Name = "gbxInformcoes";
            this.gbxInformcoes.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxInformcoes.Size = new System.Drawing.Size(668, 62);
            this.gbxInformcoes.TabIndex = 1;
            this.gbxInformcoes.TabStop = false;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(323, 15);
            this.lblVendedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(68, 13);
            this.lblVendedor.TabIndex = 3;
            this.lblVendedor.Text = "VENDEDOR";
            // 
            // btnPesqVendedor
            // 
            this.btnPesqVendedor.Image = global::SlnEstagio.MOD002.Properties.Resources.search_icon;
            this.btnPesqVendedor.Location = new System.Drawing.Point(608, 31);
            this.btnPesqVendedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPesqVendedor.Name = "btnPesqVendedor";
            this.btnPesqVendedor.Size = new System.Drawing.Size(31, 20);
            this.btnPesqVendedor.TabIndex = 5;
            this.btnPesqVendedor.UseVisualStyleBackColor = true;
            this.btnPesqVendedor.Click += new System.EventHandler(this.btnPesqVendedor_Click);
            // 
            // txtVendedor
            // 
            this.txtVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVendedor.Location = new System.Drawing.Point(326, 31);
            this.txtVendedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(278, 20);
            this.txtVendedor.TabIndex = 4;
            this.txtVendedor.VMLabelAssociado = null;
            this.txtVendedor.VMMascara = null;
            this.txtVendedor.VMPesquisa = false;
            this.txtVendedor.VMPesquisaValor = null;
            this.txtVendedor.VMRequerido = false;
            this.txtVendedor.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtVendedor.VMValor = null;
            this.txtVendedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVendedor_KeyDown);
            // 
            // btnPesqCliente
            // 
            this.btnPesqCliente.Image = global::SlnEstagio.MOD002.Properties.Resources.search_icon;
            this.btnPesqCliente.Location = new System.Drawing.Point(290, 31);
            this.btnPesqCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPesqCliente.Name = "btnPesqCliente";
            this.btnPesqCliente.Size = new System.Drawing.Size(31, 20);
            this.btnPesqCliente.TabIndex = 2;
            this.btnPesqCliente.UseVisualStyleBackColor = true;
            this.btnPesqCliente.Click += new System.EventHandler(this.btnPesqCliente_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(6, 15);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(52, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "CLIENTE";
            // 
            // txtCliente
            // 
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliente.Location = new System.Drawing.Point(7, 31);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(278, 20);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(592, 430);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 24);
            this.panel3.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(509, 426);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(79, 28);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(598, 426);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 28);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbxTipo
            // 
            this.gbxTipo.Controls.Add(this.rbtOrcamento);
            this.gbxTipo.Controls.Add(this.rbtPedido);
            this.gbxTipo.Location = new System.Drawing.Point(243, 2);
            this.gbxTipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxTipo.Name = "gbxTipo";
            this.gbxTipo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxTipo.Size = new System.Drawing.Size(177, 38);
            this.gbxTipo.TabIndex = 0;
            this.gbxTipo.TabStop = false;
            // 
            // rbtOrcamento
            // 
            this.rbtOrcamento.AutoSize = true;
            this.rbtOrcamento.Location = new System.Drawing.Point(76, 15);
            this.rbtOrcamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtOrcamento.Name = "rbtOrcamento";
            this.rbtOrcamento.Size = new System.Drawing.Size(94, 17);
            this.rbtOrcamento.TabIndex = 1;
            this.rbtOrcamento.Text = "ORÇAMENTO";
            this.rbtOrcamento.UseVisualStyleBackColor = true;
            this.rbtOrcamento.CheckedChanged += new System.EventHandler(this.rbtTipoPedido_CheckedChanged);
            // 
            // rbtPedido
            // 
            this.rbtPedido.AutoSize = true;
            this.rbtPedido.Checked = true;
            this.rbtPedido.Location = new System.Drawing.Point(8, 15);
            this.rbtPedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtPedido.Name = "rbtPedido";
            this.rbtPedido.Size = new System.Drawing.Size(66, 17);
            this.rbtPedido.TabIndex = 0;
            this.rbtPedido.TabStop = true;
            this.rbtPedido.Text = "PEDIDO";
            this.rbtPedido.UseVisualStyleBackColor = true;
            this.rbtPedido.CheckedChanged += new System.EventHandler(this.rbtTipoPedido_CheckedChanged);
            // 
            // FRM002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 458);
            this.Controls.Add(this.gbxTipo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbxInformcoes);
            this.Controls.Add(this.gbxInformaoesProduto);
            this.Name = "FRM002";
            this.Text = "CADASTRAR PEDIDO DE VENDA";
            this.Shown += new System.EventHandler(this.FRM002_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            this.gbxInformaoesProduto.ResumeLayout(false);
            this.gbxInformaoesProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColecao)).EndInit();
            this.gbxInformcoes.ResumeLayout(false);
            this.gbxInformcoes.PerformLayout();
            this.gbxTipo.ResumeLayout(false);
            this.gbxTipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SlnEstagio.WINBASE.VMGroupBox gbxInformaoesProduto;
        private SlnEstagio.WINBASE.VMDataGridView dgwColecao;
        private SlnEstagio.WINBASE.VMTextBox txtQuantidade;
        private WINBASE.VMLabel lblQuantidade;
        private WINBASE.VMLabel lblProduto;
        private SlnEstagio.WINBASE.VMTextBox txtProduto;
        private WINBASE.VMButton btnPesqVendedor;
        private WINBASE.VMButton btnPesqCliente;
        private WINBASE.VMLabel lblCliente;
        private SlnEstagio.WINBASE.VMTextBox txtCliente;
        private SlnEstagio.WINBASE.VMTextBox txtVendedor;
        private WINBASE.VMLabel lblVendedor;
        private SlnEstagio.WINBASE.VMGroupBox gbxInformcoes;
        private System.Windows.Forms.Panel panel1;
        private WINBASE.VMButton btnExcluir;
        private WINBASE.VMButton btnAlterar;
        private WINBASE.VMButton btnInserir;
        private System.Windows.Forms.Panel panel3;
        private WINBASE.VMButton btnSalvar;
        private WINBASE.VMButton btnCancelar;
        private WINBASE.VMButton btnPesqProduto;
        private SlnEstagio.WINBASE.VMTextBox txtRegistro;
        private WINBASE.VMLabel lblRegistro;
        private WINBASE.VMGroupBox gbxTipo;
        private WINBASE.VMRadioButton rbtOrcamento;
        private WINBASE.VMRadioButton rbtPedido;
        private WINBASE.VMTextBox txtCubagemTotal;
        private WINBASE.VMLabel lblCubagemTotal;
        private WINBASE.VMTextBox txtValorTotal;
        private WINBASE.VMLabel vmLabel1;
    }
}