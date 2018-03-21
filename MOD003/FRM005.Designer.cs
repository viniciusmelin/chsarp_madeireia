namespace SlnEstagio.MOD003
{
    partial class FRM005
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
            this.txtCodigo = new SlnEstagio.WINBASE.VMTextBox();
            this.btnFechar = new SlnEstagio.WINBASE.VMButton();
            this.lblCodigo = new SlnEstagio.WINBASE.VMLabel();
            this.txtContasPagarTipo = new SlnEstagio.WINBASE.VMTextBox();
            this.lblContasPagarTipo = new SlnEstagio.WINBASE.VMLabel();
            this.lblDataLancamento = new SlnEstagio.WINBASE.VMLabel();
            this.txtObservacao = new SlnEstagio.WINBASE.VMTextBox();
            this.lblObservacao = new SlnEstagio.WINBASE.VMLabel();
            this.lblFornecedor = new SlnEstagio.WINBASE.VMLabel();
            this.txtFornecedor = new SlnEstagio.WINBASE.VMTextBox();
            this.dtpVencimento = new SlnEstagio.WINBASE.VMDataTimePicker();
            this.lblDataVencimento = new SlnEstagio.WINBASE.VMLabel();
            this.lblDataPagamento = new SlnEstagio.WINBASE.VMLabel();
            this.btnSalvar = new SlnEstagio.WINBASE.VMButton();
            this.lblValor = new SlnEstagio.WINBASE.VMLabel();
            this.txtValor = new SlnEstagio.WINBASE.VMTextBox();
            this.btnPesqContasPagarTipo = new SlnEstagio.WINBASE.VMButton();
            this.btnPesqFornecedor = new SlnEstagio.WINBASE.VMButton();
            this.dtpDataLancamento = new SlnEstagio.WINBASE.VMDataTimePicker();
            this.dtpDataPagamento = new SlnEstagio.WINBASE.VMDataTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Location = new System.Drawing.Point(9, 24);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.MaxLength = 8;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(76, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Text = "0";
            this.txtCodigo.VMLabelAssociado = null;
            this.txtCodigo.VMMascara = null;
            this.txtCodigo.VMPesquisa = false;
            this.txtCodigo.VMPesquisaValor = null;
            this.txtCodigo.VMRequerido = false;
            this.txtCodigo.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Inteiro;
            this.txtCodigo.VMValor = null;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(247, 325);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(64, 26);
            this.btnFechar.TabIndex = 19;
            this.btnFechar.Text = "&FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(7, 8);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "CÓDIGO";
            // 
            // txtContasPagarTipo
            // 
            this.txtContasPagarTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContasPagarTipo.Location = new System.Drawing.Point(8, 155);
            this.txtContasPagarTipo.Margin = new System.Windows.Forms.Padding(2);
            this.txtContasPagarTipo.Name = "txtContasPagarTipo";
            this.txtContasPagarTipo.Size = new System.Drawing.Size(233, 20);
            this.txtContasPagarTipo.TabIndex = 11;
            this.txtContasPagarTipo.VMLabelAssociado = this.lblContasPagarTipo;
            this.txtContasPagarTipo.VMMascara = null;
            this.txtContasPagarTipo.VMPesquisa = false;
            this.txtContasPagarTipo.VMPesquisaValor = null;
            this.txtContasPagarTipo.VMRequerido = true;
            this.txtContasPagarTipo.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtContasPagarTipo.VMValor = null;
            this.txtContasPagarTipo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContasPagarTipo_KeyDown);
            // 
            // lblContasPagarTipo
            // 
            this.lblContasPagarTipo.AutoSize = true;
            this.lblContasPagarTipo.Location = new System.Drawing.Point(5, 140);
            this.lblContasPagarTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContasPagarTipo.Name = "lblContasPagarTipo";
            this.lblContasPagarTipo.Size = new System.Drawing.Size(129, 13);
            this.lblContasPagarTipo.TabIndex = 10;
            this.lblContasPagarTipo.Text = "CONTAS A PAGAR TIPO";
            // 
            // lblDataLancamento
            // 
            this.lblDataLancamento.AutoSize = true;
            this.lblDataLancamento.Location = new System.Drawing.Point(5, 52);
            this.lblDataLancamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataLancamento.Name = "lblDataLancamento";
            this.lblDataLancamento.Size = new System.Drawing.Size(99, 13);
            this.lblDataLancamento.TabIndex = 2;
            this.lblDataLancamento.Text = "DT.LANÇAMENTO";
            // 
            // txtObservacao
            // 
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.Location = new System.Drawing.Point(8, 241);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(2);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(303, 80);
            this.txtObservacao.TabIndex = 17;
            this.txtObservacao.VMLabelAssociado = this.lblObservacao;
            this.txtObservacao.VMMascara = null;
            this.txtObservacao.VMPesquisa = false;
            this.txtObservacao.VMPesquisaValor = null;
            this.txtObservacao.VMRequerido = false;
            this.txtObservacao.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtObservacao.VMValor = null;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(7, 225);
            this.lblObservacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(87, 13);
            this.lblObservacao.TabIndex = 16;
            this.lblObservacao.Text = "OBSERVAÇÕES";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(5, 176);
            this.lblFornecedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(82, 13);
            this.lblFornecedor.TabIndex = 13;
            this.lblFornecedor.Text = "FORNECEDOR";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedor.Location = new System.Drawing.Point(8, 192);
            this.txtFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(233, 20);
            this.txtFornecedor.TabIndex = 14;
            this.txtFornecedor.VMLabelAssociado = this.lblFornecedor;
            this.txtFornecedor.VMMascara = null;
            this.txtFornecedor.VMPesquisa = false;
            this.txtFornecedor.VMPesquisaValor = null;
            this.txtFornecedor.VMRequerido = true;
            this.txtFornecedor.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtFornecedor.VMValor = null;
            this.txtFornecedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFornecedor_KeyDown);
            // 
            // dtpVencimento
            // 
            this.dtpVencimento.CustomFormat = "";
            this.dtpVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimento.GSLabelAssociado = null;
            this.dtpVencimento.Location = new System.Drawing.Point(113, 67);
            this.dtpVencimento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpVencimento.Name = "dtpVencimento";
            this.dtpVencimento.Size = new System.Drawing.Size(93, 20);
            this.dtpVencimento.TabIndex = 5;
            this.dtpVencimento.Value = new System.DateTime(2016, 11, 17, 23, 38, 50, 867);
            // 
            // lblDataVencimento
            // 
            this.lblDataVencimento.AutoSize = true;
            this.lblDataVencimento.Location = new System.Drawing.Point(113, 52);
            this.lblDataVencimento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataVencimento.Name = "lblDataVencimento";
            this.lblDataVencimento.Size = new System.Drawing.Size(96, 13);
            this.lblDataVencimento.TabIndex = 4;
            this.lblDataVencimento.Text = "DT.VENCIMENTO";
            // 
            // lblDataPagamento
            // 
            this.lblDataPagamento.AutoSize = true;
            this.lblDataPagamento.Location = new System.Drawing.Point(218, 52);
            this.lblDataPagamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataPagamento.Name = "lblDataPagamento";
            this.lblDataPagamento.Size = new System.Drawing.Size(93, 13);
            this.lblDataPagamento.TabIndex = 6;
            this.lblDataPagamento.Text = "DT.PAGAMENTO";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(178, 325);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(64, 26);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "&SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(7, 99);
            this.lblValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(43, 13);
            this.lblValor.TabIndex = 8;
            this.lblValor.Text = "VALOR";
            // 
            // txtValor
            // 
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor.Location = new System.Drawing.Point(9, 114);
            this.txtValor.Margin = new System.Windows.Forms.Padding(2);
            this.txtValor.MaxLength = 8;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(81, 20);
            this.txtValor.TabIndex = 9;
            this.txtValor.Text = "0,00";
            this.txtValor.VMLabelAssociado = this.lblValor;
            this.txtValor.VMMascara = "##0.00";
            this.txtValor.VMPesquisa = false;
            this.txtValor.VMPesquisaValor = null;
            this.txtValor.VMRequerido = true;
            this.txtValor.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Valor;
            this.txtValor.VMValor = null;
            // 
            // btnPesqContasPagarTipo
            // 
            this.btnPesqContasPagarTipo.Location = new System.Drawing.Point(263, 155);
            this.btnPesqContasPagarTipo.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesqContasPagarTipo.Name = "btnPesqContasPagarTipo";
            this.btnPesqContasPagarTipo.Size = new System.Drawing.Size(30, 20);
            this.btnPesqContasPagarTipo.TabIndex = 12;
            this.btnPesqContasPagarTipo.Text = "&SALVAR";
            this.btnPesqContasPagarTipo.UseVisualStyleBackColor = true;
            this.btnPesqContasPagarTipo.Click += new System.EventHandler(this.btnPesqContasPagarTipo_Click);
            // 
            // btnPesqFornecedor
            // 
            this.btnPesqFornecedor.Location = new System.Drawing.Point(263, 192);
            this.btnPesqFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesqFornecedor.Name = "btnPesqFornecedor";
            this.btnPesqFornecedor.Size = new System.Drawing.Size(30, 20);
            this.btnPesqFornecedor.TabIndex = 15;
            this.btnPesqFornecedor.Text = "&SALVAR";
            this.btnPesqFornecedor.UseVisualStyleBackColor = true;
            this.btnPesqFornecedor.Click += new System.EventHandler(this.btnPesqFornecedor_Click);
            // 
            // dtpDataLancamento
            // 
            this.dtpDataLancamento.CustomFormat = "";
            this.dtpDataLancamento.Enabled = false;
            this.dtpDataLancamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataLancamento.GSLabelAssociado = null;
            this.dtpDataLancamento.Location = new System.Drawing.Point(5, 67);
            this.dtpDataLancamento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataLancamento.Name = "dtpDataLancamento";
            this.dtpDataLancamento.Size = new System.Drawing.Size(96, 20);
            this.dtpDataLancamento.TabIndex = 3;
            this.dtpDataLancamento.Value = new System.DateTime(2016, 11, 17, 23, 38, 50, 864);
            // 
            // dtpDataPagamento
            // 
            this.dtpDataPagamento.CustomFormat = "";
            this.dtpDataPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataPagamento.GSLabelAssociado = null;
            this.dtpDataPagamento.Location = new System.Drawing.Point(218, 67);
            this.dtpDataPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataPagamento.Name = "dtpDataPagamento";
            this.dtpDataPagamento.Size = new System.Drawing.Size(94, 20);
            this.dtpDataPagamento.TabIndex = 7;
            this.dtpDataPagamento.Value = null;
            this.dtpDataPagamento.VMAceitaNulo = true;
            // 
            // FRM005
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 362);
            this.Controls.Add(this.btnPesqFornecedor);
            this.Controls.Add(this.btnPesqContasPagarTipo);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtpDataPagamento);
            this.Controls.Add(this.dtpDataLancamento);
            this.Controls.Add(this.dtpVencimento);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.lblContasPagarTipo);
            this.Controls.Add(this.lblDataPagamento);
            this.Controls.Add(this.lblDataVencimento);
            this.Controls.Add(this.lblDataLancamento);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtContasPagarTipo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtCodigo);
            this.Name = "FRM005";
            this.Text = "INSERIR CONTAS A PAGAR";
            this.Shown += new System.EventHandler(this.FRM005_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WINBASE.VMTextBox txtCodigo;
        private WINBASE.VMButton btnFechar;
        private WINBASE.VMLabel lblCodigo;
        private WINBASE.VMTextBox txtContasPagarTipo;
        private WINBASE.VMLabel lblDataLancamento;
        private WINBASE.VMTextBox txtObservacao;
        private WINBASE.VMLabel lblContasPagarTipo;
        private WINBASE.VMLabel lblFornecedor;
        private WINBASE.VMTextBox txtFornecedor;
        private WINBASE.VMLabel lblObservacao;
        private WINBASE.VMDataTimePicker dtpVencimento;
        private WINBASE.VMLabel lblDataVencimento;
        private WINBASE.VMLabel lblDataPagamento;
        private WINBASE.VMButton btnSalvar;
        private WINBASE.VMLabel lblValor;
        private WINBASE.VMTextBox txtValor;
        private WINBASE.VMButton btnPesqContasPagarTipo;
        private WINBASE.VMButton btnPesqFornecedor;
        private WINBASE.VMDataTimePicker dtpDataLancamento;
        private WINBASE.VMDataTimePicker dtpDataPagamento;
    }
}