namespace SlnEstagio.MOD003
{
    partial class FRM008
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
            this.btnBaixar = new SlnEstagio.WINBASE.VMButton();
            this.btnFechar = new SlnEstagio.WINBASE.VMButton();
            this.txtCodigo = new SlnEstagio.WINBASE.VMTextBox();
            this.vmLabel1 = new SlnEstagio.WINBASE.VMLabel();
            this.vmLabel2 = new SlnEstagio.WINBASE.VMLabel();
            this.txtDataLancamento = new SlnEstagio.WINBASE.VMTextBox();
            this.vmLabel4 = new SlnEstagio.WINBASE.VMLabel();
            this.txtValor = new SlnEstagio.WINBASE.VMTextBox();
            this.vmLabel5 = new SlnEstagio.WINBASE.VMLabel();
            this.txtFornecedor = new SlnEstagio.WINBASE.VMTextBox();
            this.vmLabel6 = new SlnEstagio.WINBASE.VMLabel();
            this.txtContasPagarTipo = new SlnEstagio.WINBASE.VMTextBox();
            this.txtDataVencimento = new SlnEstagio.WINBASE.VMTextBox();
            this.vmLabel7 = new SlnEstagio.WINBASE.VMLabel();
            this.txtDataPagamento = new SlnEstagio.WINBASE.VMTextBox();
            this.vmLabel3 = new SlnEstagio.WINBASE.VMLabel();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btnBaixar
            // 
            this.btnBaixar.Location = new System.Drawing.Point(168, 241);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(75, 29);
            this.btnBaixar.TabIndex = 14;
            this.btnBaixar.Text = "EF. BAIXAR";
            this.btnBaixar.UseVisualStyleBackColor = true;
            this.btnBaixar.Click += new System.EventHandler(this.btnBaixar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(249, 241);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 29);
            this.btnFechar.TabIndex = 15;
            this.btnFechar.Text = "&FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Location = new System.Drawing.Point(12, 30);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.VMLabelAssociado = null;
            this.txtCodigo.VMMascara = null;
            this.txtCodigo.VMPesquisa = false;
            this.txtCodigo.VMPesquisaValor = null;
            this.txtCodigo.VMRequerido = false;
            this.txtCodigo.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtCodigo.VMValor = null;
            // 
            // vmLabel1
            // 
            this.vmLabel1.AutoSize = true;
            this.vmLabel1.Location = new System.Drawing.Point(12, 14);
            this.vmLabel1.Name = "vmLabel1";
            this.vmLabel1.Size = new System.Drawing.Size(49, 13);
            this.vmLabel1.TabIndex = 0;
            this.vmLabel1.Text = "CÓDIGO";
            // 
            // vmLabel2
            // 
            this.vmLabel2.AutoSize = true;
            this.vmLabel2.Location = new System.Drawing.Point(12, 193);
            this.vmLabel2.Name = "vmLabel2";
            this.vmLabel2.Size = new System.Drawing.Size(43, 13);
            this.vmLabel2.TabIndex = 12;
            this.vmLabel2.Text = "VALOR";
            // 
            // txtDataLancamento
            // 
            this.txtDataLancamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDataLancamento.Location = new System.Drawing.Point(12, 159);
            this.txtDataLancamento.Name = "txtDataLancamento";
            this.txtDataLancamento.ReadOnly = true;
            this.txtDataLancamento.Size = new System.Drawing.Size(100, 20);
            this.txtDataLancamento.TabIndex = 7;
            this.txtDataLancamento.TabStop = false;
            this.txtDataLancamento.VMLabelAssociado = null;
            this.txtDataLancamento.VMMascara = null;
            this.txtDataLancamento.VMPesquisa = false;
            this.txtDataLancamento.VMPesquisaValor = null;
            this.txtDataLancamento.VMRequerido = false;
            this.txtDataLancamento.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtDataLancamento.VMValor = null;
            // 
            // vmLabel4
            // 
            this.vmLabel4.AutoSize = true;
            this.vmLabel4.Location = new System.Drawing.Point(12, 143);
            this.vmLabel4.Name = "vmLabel4";
            this.vmLabel4.Size = new System.Drawing.Size(52, 13);
            this.vmLabel4.TabIndex = 6;
            this.vmLabel4.Text = "DT. LAN.";
            // 
            // txtValor
            // 
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor.Location = new System.Drawing.Point(12, 209);
            this.txtValor.MaxLength = 8;
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 13;
            this.txtValor.TabStop = false;
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
            // vmLabel5
            // 
            this.vmLabel5.AutoSize = true;
            this.vmLabel5.Location = new System.Drawing.Point(12, 56);
            this.vmLabel5.Name = "vmLabel5";
            this.vmLabel5.Size = new System.Drawing.Size(82, 13);
            this.vmLabel5.TabIndex = 2;
            this.vmLabel5.Text = "FORNECEDOR";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedor.Location = new System.Drawing.Point(12, 72);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.ReadOnly = true;
            this.txtFornecedor.Size = new System.Drawing.Size(312, 20);
            this.txtFornecedor.TabIndex = 3;
            this.txtFornecedor.TabStop = false;
            this.txtFornecedor.VMLabelAssociado = null;
            this.txtFornecedor.VMMascara = null;
            this.txtFornecedor.VMPesquisa = false;
            this.txtFornecedor.VMPesquisaValor = null;
            this.txtFornecedor.VMRequerido = false;
            this.txtFornecedor.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtFornecedor.VMValor = null;
            // 
            // vmLabel6
            // 
            this.vmLabel6.AutoSize = true;
            this.vmLabel6.Location = new System.Drawing.Point(12, 95);
            this.vmLabel6.Name = "vmLabel6";
            this.vmLabel6.Size = new System.Drawing.Size(129, 13);
            this.vmLabel6.TabIndex = 4;
            this.vmLabel6.Text = "CONTAS A PAGAR TIPO";
            // 
            // txtContasPagarTipo
            // 
            this.txtContasPagarTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContasPagarTipo.Location = new System.Drawing.Point(12, 111);
            this.txtContasPagarTipo.Name = "txtContasPagarTipo";
            this.txtContasPagarTipo.ReadOnly = true;
            this.txtContasPagarTipo.Size = new System.Drawing.Size(312, 20);
            this.txtContasPagarTipo.TabIndex = 5;
            this.txtContasPagarTipo.TabStop = false;
            this.txtContasPagarTipo.VMLabelAssociado = null;
            this.txtContasPagarTipo.VMMascara = null;
            this.txtContasPagarTipo.VMPesquisa = false;
            this.txtContasPagarTipo.VMPesquisaValor = null;
            this.txtContasPagarTipo.VMRequerido = false;
            this.txtContasPagarTipo.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtContasPagarTipo.VMValor = null;
            // 
            // txtDataVencimento
            // 
            this.txtDataVencimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDataVencimento.Location = new System.Drawing.Point(117, 159);
            this.txtDataVencimento.Name = "txtDataVencimento";
            this.txtDataVencimento.ReadOnly = true;
            this.txtDataVencimento.Size = new System.Drawing.Size(100, 20);
            this.txtDataVencimento.TabIndex = 9;
            this.txtDataVencimento.TabStop = false;
            this.txtDataVencimento.VMLabelAssociado = null;
            this.txtDataVencimento.VMMascara = null;
            this.txtDataVencimento.VMPesquisa = false;
            this.txtDataVencimento.VMPesquisaValor = null;
            this.txtDataVencimento.VMRequerido = false;
            this.txtDataVencimento.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtDataVencimento.VMValor = null;
            // 
            // vmLabel7
            // 
            this.vmLabel7.AutoSize = true;
            this.vmLabel7.Location = new System.Drawing.Point(114, 143);
            this.vmLabel7.Name = "vmLabel7";
            this.vmLabel7.Size = new System.Drawing.Size(53, 13);
            this.vmLabel7.TabIndex = 8;
            this.vmLabel7.Text = "DT. VEN.";
            // 
            // txtDataPagamento
            // 
            this.txtDataPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDataPagamento.Location = new System.Drawing.Point(223, 159);
            this.txtDataPagamento.Name = "txtDataPagamento";
            this.txtDataPagamento.ReadOnly = true;
            this.txtDataPagamento.Size = new System.Drawing.Size(100, 20);
            this.txtDataPagamento.TabIndex = 11;
            this.txtDataPagamento.TabStop = false;
            this.txtDataPagamento.VMLabelAssociado = null;
            this.txtDataPagamento.VMMascara = null;
            this.txtDataPagamento.VMPesquisa = false;
            this.txtDataPagamento.VMPesquisaValor = null;
            this.txtDataPagamento.VMRequerido = false;
            this.txtDataPagamento.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtDataPagamento.VMValor = null;
            // 
            // vmLabel3
            // 
            this.vmLabel3.AutoSize = true;
            this.vmLabel3.Location = new System.Drawing.Point(220, 143);
            this.vmLabel3.Name = "vmLabel3";
            this.vmLabel3.Size = new System.Drawing.Size(50, 13);
            this.vmLabel3.TabIndex = 10;
            this.vmLabel3.Text = "DT. PAG";
            // 
            // FRM008
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 273);
            this.Controls.Add(this.vmLabel6);
            this.Controls.Add(this.txtContasPagarTipo);
            this.Controls.Add(this.vmLabel5);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.vmLabel3);
            this.Controls.Add(this.vmLabel7);
            this.Controls.Add(this.vmLabel4);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDataPagamento);
            this.Controls.Add(this.txtDataVencimento);
            this.Controls.Add(this.txtDataLancamento);
            this.Controls.Add(this.vmLabel2);
            this.Controls.Add(this.vmLabel1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnBaixar);
            this.Name = "FRM008";
            this.Text = "BAIXAR CONTAS A RECEBER";
            this.Shown += new System.EventHandler(this.FRM008_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WINBASE.VMButton btnBaixar;
        private WINBASE.VMButton btnFechar;
        private WINBASE.VMTextBox txtCodigo;
        private WINBASE.VMLabel vmLabel1;
        private WINBASE.VMLabel vmLabel2;
        private WINBASE.VMTextBox txtDataLancamento;
        private WINBASE.VMLabel vmLabel4;
        private WINBASE.VMTextBox txtValor;
        private WINBASE.VMLabel vmLabel5;
        private WINBASE.VMTextBox txtFornecedor;
        private WINBASE.VMLabel vmLabel6;
        private WINBASE.VMTextBox txtContasPagarTipo;
        private WINBASE.VMTextBox txtDataVencimento;
        private WINBASE.VMLabel vmLabel7;
        private WINBASE.VMTextBox txtDataPagamento;
        private WINBASE.VMLabel vmLabel3;
    }
}