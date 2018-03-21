namespace SlnEstagio.MOD003
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
            this.vmGroupBox4 = new SlnEstagio.WINBASE.VMGroupBox();
            this.lblPedido = new SlnEstagio.WINBASE.VMLabel();
            this.txtPedido = new SlnEstagio.WINBASE.VMTextBox();
            this.dtpDataPagamento = new SlnEstagio.WINBASE.VMDataTimePicker();
            this.lblCodigo = new SlnEstagio.WINBASE.VMLabel();
            this.txtCodigo = new SlnEstagio.WINBASE.VMTextBox();
            this.dtpDataVencimento = new SlnEstagio.WINBASE.VMDataTimePicker();
            this.dtpDataLancamento = new SlnEstagio.WINBASE.VMDataTimePicker();
            this.btnPesqVendedor = new SlnEstagio.WINBASE.VMButton();
            this.lblVendedor = new SlnEstagio.WINBASE.VMLabel();
            this.txtValor = new SlnEstagio.WINBASE.VMTextBox();
            this.txtVendedor = new SlnEstagio.WINBASE.VMTextBox();
            this.btnPesqCliente = new SlnEstagio.WINBASE.VMButton();
            this.lblCliente = new SlnEstagio.WINBASE.VMLabel();
            this.lblDataPagamento = new SlnEstagio.WINBASE.VMLabel();
            this.lblDataLancamento = new SlnEstagio.WINBASE.VMLabel();
            this.lblValor = new SlnEstagio.WINBASE.VMLabel();
            this.txtCliente = new SlnEstagio.WINBASE.VMTextBox();
            this.lblDataVencimento = new SlnEstagio.WINBASE.VMLabel();
            this.btnFechar = new SlnEstagio.WINBASE.VMButton();
            this.btnSalvar = new SlnEstagio.WINBASE.VMButton();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            this.vmGroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // vmGroupBox4
            // 
            this.vmGroupBox4.Controls.Add(this.lblPedido);
            this.vmGroupBox4.Controls.Add(this.txtPedido);
            this.vmGroupBox4.Controls.Add(this.dtpDataPagamento);
            this.vmGroupBox4.Controls.Add(this.lblCodigo);
            this.vmGroupBox4.Controls.Add(this.txtCodigo);
            this.vmGroupBox4.Controls.Add(this.dtpDataVencimento);
            this.vmGroupBox4.Controls.Add(this.dtpDataLancamento);
            this.vmGroupBox4.Controls.Add(this.btnPesqVendedor);
            this.vmGroupBox4.Controls.Add(this.lblVendedor);
            this.vmGroupBox4.Controls.Add(this.txtValor);
            this.vmGroupBox4.Controls.Add(this.txtVendedor);
            this.vmGroupBox4.Controls.Add(this.btnPesqCliente);
            this.vmGroupBox4.Controls.Add(this.lblCliente);
            this.vmGroupBox4.Controls.Add(this.lblDataPagamento);
            this.vmGroupBox4.Controls.Add(this.lblDataLancamento);
            this.vmGroupBox4.Controls.Add(this.lblValor);
            this.vmGroupBox4.Controls.Add(this.txtCliente);
            this.vmGroupBox4.Controls.Add(this.lblDataVencimento);
            this.vmGroupBox4.Location = new System.Drawing.Point(2, 10);
            this.vmGroupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.vmGroupBox4.Name = "vmGroupBox4";
            this.vmGroupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.vmGroupBox4.Size = new System.Drawing.Size(331, 253);
            this.vmGroupBox4.TabIndex = 0;
            this.vmGroupBox4.TabStop = false;
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(95, 16);
            this.lblPedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(48, 13);
            this.lblPedido.TabIndex = 2;
            this.lblPedido.Text = "PEDIDO";
            // 
            // txtPedido
            // 
            this.txtPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPedido.Location = new System.Drawing.Point(95, 31);
            this.txtPedido.Margin = new System.Windows.Forms.Padding(2);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.ReadOnly = true;
            this.txtPedido.Size = new System.Drawing.Size(76, 20);
            this.txtPedido.TabIndex = 3;
            this.txtPedido.TabStop = false;
            this.txtPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPedido.VMLabelAssociado = null;
            this.txtPedido.VMMascara = null;
            this.txtPedido.VMPesquisa = false;
            this.txtPedido.VMPesquisaValor = null;
            this.txtPedido.VMRequerido = false;
            this.txtPedido.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtPedido.VMValor = null;
            // 
            // dtpDataPagamento
            // 
            this.dtpDataPagamento.CustomFormat = "";
            this.dtpDataPagamento.Enabled = false;
            this.dtpDataPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataPagamento.GSLabelAssociado = null;
            this.dtpDataPagamento.Location = new System.Drawing.Point(225, 79);
            this.dtpDataPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataPagamento.Name = "dtpDataPagamento";
            this.dtpDataPagamento.Size = new System.Drawing.Size(92, 20);
            this.dtpDataPagamento.TabIndex = 9;
            this.dtpDataPagamento.Value = null;
            this.dtpDataPagamento.VMAceitaNulo = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(4, 16);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "CÓDIGO";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Location = new System.Drawing.Point(4, 31);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(76, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodigo.VMLabelAssociado = null;
            this.txtCodigo.VMMascara = null;
            this.txtCodigo.VMPesquisa = false;
            this.txtCodigo.VMPesquisaValor = null;
            this.txtCodigo.VMRequerido = false;
            this.txtCodigo.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtCodigo.VMValor = null;
            // 
            // dtpDataVencimento
            // 
            this.dtpDataVencimento.CustomFormat = "";
            this.dtpDataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVencimento.GSLabelAssociado = null;
            this.dtpDataVencimento.Location = new System.Drawing.Point(119, 79);
            this.dtpDataVencimento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataVencimento.Name = "dtpDataVencimento";
            this.dtpDataVencimento.Size = new System.Drawing.Size(92, 20);
            this.dtpDataVencimento.TabIndex = 7;
            this.dtpDataVencimento.Value = new System.DateTime(2016, 11, 17, 23, 32, 39, 945);
            this.dtpDataVencimento.VMAceitaNulo = true;
            // 
            // dtpDataLancamento
            // 
            this.dtpDataLancamento.CustomFormat = "";
            this.dtpDataLancamento.Enabled = false;
            this.dtpDataLancamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataLancamento.GSLabelAssociado = null;
            this.dtpDataLancamento.Location = new System.Drawing.Point(7, 79);
            this.dtpDataLancamento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataLancamento.Name = "dtpDataLancamento";
            this.dtpDataLancamento.Size = new System.Drawing.Size(92, 20);
            this.dtpDataLancamento.TabIndex = 5;
            this.dtpDataLancamento.Value = new System.DateTime(2016, 11, 17, 23, 32, 39, 948);
            // 
            // btnPesqVendedor
            // 
            this.btnPesqVendedor.Location = new System.Drawing.Point(284, 171);
            this.btnPesqVendedor.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesqVendedor.Name = "btnPesqVendedor";
            this.btnPesqVendedor.Size = new System.Drawing.Size(32, 20);
            this.btnPesqVendedor.TabIndex = 15;
            this.btnPesqVendedor.UseVisualStyleBackColor = true;
            this.btnPesqVendedor.Click += new System.EventHandler(this.btnPesqVendedor_Click);
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(4, 155);
            this.lblVendedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(68, 13);
            this.lblVendedor.TabIndex = 13;
            this.lblVendedor.Text = "VENDEDOR";
            // 
            // txtValor
            // 
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor.Location = new System.Drawing.Point(7, 222);
            this.txtValor.Margin = new System.Windows.Forms.Padding(2);
            this.txtValor.MaxLength = 8;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(92, 20);
            this.txtValor.TabIndex = 17;
            this.txtValor.Text = "0,00";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor.VMLabelAssociado = null;
            this.txtValor.VMMascara = "##0.00";
            this.txtValor.VMPesquisa = false;
            this.txtValor.VMPesquisaValor = null;
            this.txtValor.VMRequerido = false;
            this.txtValor.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Valor;
            this.txtValor.VMValor = null;
            // 
            // txtVendedor
            // 
            this.txtVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVendedor.Location = new System.Drawing.Point(7, 171);
            this.txtVendedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(274, 20);
            this.txtVendedor.TabIndex = 14;
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
            this.btnPesqCliente.Location = new System.Drawing.Point(284, 126);
            this.btnPesqCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesqCliente.Name = "btnPesqCliente";
            this.btnPesqCliente.Size = new System.Drawing.Size(32, 20);
            this.btnPesqCliente.TabIndex = 12;
            this.btnPesqCliente.UseVisualStyleBackColor = true;
            this.btnPesqCliente.Click += new System.EventHandler(this.btnPesqCliente_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(4, 110);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(52, 13);
            this.lblCliente.TabIndex = 10;
            this.lblCliente.Text = "CLIENTE";
            // 
            // lblDataPagamento
            // 
            this.lblDataPagamento.AutoSize = true;
            this.lblDataPagamento.Location = new System.Drawing.Point(223, 63);
            this.lblDataPagamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataPagamento.Name = "lblDataPagamento";
            this.lblDataPagamento.Size = new System.Drawing.Size(96, 13);
            this.lblDataPagamento.TabIndex = 8;
            this.lblDataPagamento.Text = "DT. PAGAMENTO";
            // 
            // lblDataLancamento
            // 
            this.lblDataLancamento.AutoSize = true;
            this.lblDataLancamento.Location = new System.Drawing.Point(4, 63);
            this.lblDataLancamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataLancamento.Name = "lblDataLancamento";
            this.lblDataLancamento.Size = new System.Drawing.Size(102, 13);
            this.lblDataLancamento.TabIndex = 4;
            this.lblDataLancamento.Text = "DT. LANÇAMENTO";
            this.toolTip1.SetToolTip(this.lblDataLancamento, "DATA DE LANÇAMENTO");
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(4, 206);
            this.lblValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(43, 13);
            this.lblValor.TabIndex = 16;
            this.lblValor.Text = "VALOR";
            // 
            // txtCliente
            // 
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliente.Location = new System.Drawing.Point(7, 126);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(274, 20);
            this.txtCliente.TabIndex = 11;
            this.txtCliente.VMLabelAssociado = null;
            this.txtCliente.VMMascara = null;
            this.txtCliente.VMPesquisa = false;
            this.txtCliente.VMPesquisaValor = null;
            this.txtCliente.VMRequerido = false;
            this.txtCliente.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtCliente.VMValor = null;
            this.txtCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyDown);
            // 
            // lblDataVencimento
            // 
            this.lblDataVencimento.AutoSize = true;
            this.lblDataVencimento.Location = new System.Drawing.Point(117, 63);
            this.lblDataVencimento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataVencimento.Name = "lblDataVencimento";
            this.lblDataVencimento.Size = new System.Drawing.Size(99, 13);
            this.lblDataVencimento.TabIndex = 6;
            this.lblDataVencimento.Text = "DT. VENCIMENTO";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(270, 267);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(63, 28);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "&FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(202, 267);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(63, 28);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "&SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FRM002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 301);
            this.Controls.Add(this.vmGroupBox4);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFechar);
            this.Name = "FRM002";
            this.Text = "CADASTRAR CONTAS A RECEBER";
            this.Shown += new System.EventHandler(this.FRM002_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            this.vmGroupBox4.ResumeLayout(false);
            this.vmGroupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private WINBASE.VMGroupBox vmGroupBox4;
        private WINBASE.VMLabel lblDataPagamento;
        private WINBASE.VMLabel lblValor;
        private WINBASE.VMLabel lblDataVencimento;
        private WINBASE.VMTextBox txtValor;
        private WINBASE.VMButton btnFechar;
        private WINBASE.VMButton btnSalvar;
        private WINBASE.VMDataTimePicker dtpDataPagamento;
        private WINBASE.VMLabel lblCodigo;
        private WINBASE.VMTextBox txtCodigo;
        private WINBASE.VMDataTimePicker dtpDataVencimento;
        private WINBASE.VMDataTimePicker dtpDataLancamento;
        private WINBASE.VMButton btnPesqVendedor;
        private WINBASE.VMLabel lblVendedor;
        private WINBASE.VMTextBox txtVendedor;
        private WINBASE.VMButton btnPesqCliente;
        private WINBASE.VMLabel lblCliente;
        private WINBASE.VMLabel lblDataLancamento;
        private WINBASE.VMTextBox txtCliente;
        private WINBASE.VMLabel lblPedido;
        private WINBASE.VMTextBox txtPedido;
    }
}