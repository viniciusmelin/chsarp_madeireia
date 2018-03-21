namespace SlnEstagio.MOD003
{
    partial class FRM003
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
            this.txtCodigoCliente = new SlnEstagio.WINBASE.VMTextBox();
            this.txtNomeCliente = new SlnEstagio.WINBASE.VMTextBox();
            this.lblCodigo = new SlnEstagio.WINBASE.VMLabel();
            this.vmLabel2 = new SlnEstagio.WINBASE.VMLabel();
            this.cbxTipoPgamento = new SlnEstagio.WINBASE.VMComboBox();
            this.gbxDesconto = new SlnEstagio.WINBASE.VMGroupBox();
            this.rbtValor = new SlnEstagio.WINBASE.VMRadioButton();
            this.rbtPorcentagem = new SlnEstagio.WINBASE.VMRadioButton();
            this.txtDesconto = new SlnEstagio.WINBASE.VMTextBox();
            this.lblValorTotal = new SlnEstagio.WINBASE.VMLabel();
            this.txtValorTotal = new SlnEstagio.WINBASE.VMTextBox();
            this.vmLabel4 = new SlnEstagio.WINBASE.VMLabel();
            this.txtValorPagar = new SlnEstagio.WINBASE.VMTextBox();
            this.lblTipoPagamento = new SlnEstagio.WINBASE.VMLabel();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            this.gbxDesconto.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btnBaixar
            // 
            this.btnBaixar.Location = new System.Drawing.Point(425, 163);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(91, 35);
            this.btnBaixar.TabIndex = 11;
            this.btnBaixar.Text = "&BAIXAR";
            this.btnBaixar.UseVisualStyleBackColor = true;
            this.btnBaixar.Click += new System.EventHandler(this.btnBaixar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(526, 163);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(91, 35);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.Text = "&FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoCliente.Location = new System.Drawing.Point(13, 33);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.ReadOnly = true;
            this.txtCodigoCliente.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoCliente.TabIndex = 1;
            this.txtCodigoCliente.VMLabelAssociado = null;
            this.txtCodigoCliente.VMMascara = null;
            this.txtCodigoCliente.VMPesquisa = false;
            this.txtCodigoCliente.VMPesquisaValor = null;
            this.txtCodigoCliente.VMRequerido = false;
            this.txtCodigoCliente.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtCodigoCliente.VMValor = null;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCliente.Location = new System.Drawing.Point(120, 33);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(497, 22);
            this.txtNomeCliente.TabIndex = 3;
            this.txtNomeCliente.VMLabelAssociado = null;
            this.txtNomeCliente.VMMascara = null;
            this.txtNomeCliente.VMPesquisa = false;
            this.txtNomeCliente.VMPesquisaValor = null;
            this.txtNomeCliente.VMRequerido = false;
            this.txtNomeCliente.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtNomeCliente.VMValor = null;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(9, 13);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 17);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "CÓDIGO";
            // 
            // vmLabel2
            // 
            this.vmLabel2.AutoSize = true;
            this.vmLabel2.Location = new System.Drawing.Point(117, 13);
            this.vmLabel2.Name = "vmLabel2";
            this.vmLabel2.Size = new System.Drawing.Size(110, 17);
            this.vmLabel2.TabIndex = 2;
            this.vmLabel2.Text = "NOME CLIENTE";
            // 
            // cbxTipoPgamento
            // 
            this.cbxTipoPgamento.FormattingEnabled = true;
            this.cbxTipoPgamento.GSLabelAssociado = null;
            this.cbxTipoPgamento.Location = new System.Drawing.Point(12, 90);
            this.cbxTipoPgamento.Name = "cbxTipoPgamento";
            this.cbxTipoPgamento.Size = new System.Drawing.Size(253, 24);
            this.cbxTipoPgamento.TabIndex = 5;
            this.cbxTipoPgamento.VMRequerido = false;
            // 
            // gbxDesconto
            // 
            this.gbxDesconto.Controls.Add(this.rbtValor);
            this.gbxDesconto.Controls.Add(this.rbtPorcentagem);
            this.gbxDesconto.Controls.Add(this.txtDesconto);
            this.gbxDesconto.Location = new System.Drawing.Point(12, 129);
            this.gbxDesconto.Name = "gbxDesconto";
            this.gbxDesconto.Size = new System.Drawing.Size(294, 69);
            this.gbxDesconto.TabIndex = 10;
            this.gbxDesconto.TabStop = false;
            this.gbxDesconto.Text = "INFORMAÇÕES DE DESCONTO";
            // 
            // rbtValor
            // 
            this.rbtValor.AutoSize = true;
            this.rbtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtValor.Location = new System.Drawing.Point(236, 28);
            this.rbtValor.Name = "rbtValor";
            this.rbtValor.Size = new System.Drawing.Size(45, 29);
            this.rbtValor.TabIndex = 2;
            this.rbtValor.TabStop = true;
            this.rbtValor.Text = "$";
            this.toolTip1.SetToolTip(this.rbtValor, "Aplicar Desconto por Valor");
            this.rbtValor.UseVisualStyleBackColor = true;
            this.rbtValor.CheckedChanged += new System.EventHandler(this.rbtPorcentagem_CheckedChanged);
            // 
            // rbtPorcentagem
            // 
            this.rbtPorcentagem.AutoSize = true;
            this.rbtPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPorcentagem.Location = new System.Drawing.Point(178, 28);
            this.rbtPorcentagem.Name = "rbtPorcentagem";
            this.rbtPorcentagem.Size = new System.Drawing.Size(52, 29);
            this.rbtPorcentagem.TabIndex = 1;
            this.rbtPorcentagem.TabStop = true;
            this.rbtPorcentagem.Text = "%";
            this.toolTip1.SetToolTip(this.rbtPorcentagem, "Aplicar Desconto por Porcentagem");
            this.rbtPorcentagem.UseVisualStyleBackColor = true;
            this.rbtPorcentagem.CheckedChanged += new System.EventHandler(this.rbtPorcentagem_CheckedChanged);
            // 
            // txtDesconto
            // 
            this.txtDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesconto.Location = new System.Drawing.Point(6, 31);
            this.txtDesconto.MaxLength = 8;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(166, 22);
            this.txtDesconto.TabIndex = 0;
            this.txtDesconto.Text = "0";
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesconto.VMLabelAssociado = null;
            this.txtDesconto.VMMascara = null;
            this.txtDesconto.VMPesquisa = false;
            this.txtDesconto.VMPesquisaValor = null;
            this.txtDesconto.VMRequerido = false;
            this.txtDesconto.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Valor;
            this.txtDesconto.VMValor = null;
            this.txtDesconto.Leave += new System.EventHandler(this.txtDesconto_Leave);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(286, 70);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(105, 17);
            this.lblValorTotal.TabIndex = 6;
            this.lblValorTotal.Text = "VALOR TOTAL";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorTotal.Location = new System.Drawing.Point(289, 90);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(166, 22);
            this.txtValorTotal.TabIndex = 7;
            this.txtValorTotal.VMLabelAssociado = null;
            this.txtValorTotal.VMMascara = null;
            this.txtValorTotal.VMPesquisa = false;
            this.txtValorTotal.VMPesquisaValor = null;
            this.txtValorTotal.VMRequerido = false;
            this.txtValorTotal.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtValorTotal.VMValor = null;
            // 
            // vmLabel4
            // 
            this.vmLabel4.AutoSize = true;
            this.vmLabel4.Location = new System.Drawing.Point(462, 70);
            this.vmLabel4.Name = "vmLabel4";
            this.vmLabel4.Size = new System.Drawing.Size(107, 17);
            this.vmLabel4.TabIndex = 8;
            this.vmLabel4.Text = "VALOR PAGAR";
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorPagar.Location = new System.Drawing.Point(461, 90);
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.ReadOnly = true;
            this.txtValorPagar.Size = new System.Drawing.Size(156, 22);
            this.txtValorPagar.TabIndex = 9;
            this.txtValorPagar.VMLabelAssociado = null;
            this.txtValorPagar.VMMascara = null;
            this.txtValorPagar.VMPesquisa = false;
            this.txtValorPagar.VMPesquisaValor = null;
            this.txtValorPagar.VMRequerido = false;
            this.txtValorPagar.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtValorPagar.VMValor = null;
            // 
            // lblTipoPagamento
            // 
            this.lblTipoPagamento.AutoSize = true;
            this.lblTipoPagamento.Location = new System.Drawing.Point(9, 70);
            this.lblTipoPagamento.Name = "lblTipoPagamento";
            this.lblTipoPagamento.Size = new System.Drawing.Size(132, 17);
            this.lblTipoPagamento.TabIndex = 4;
            this.lblTipoPagamento.Text = "TIPO PAGAMENTO";
            // 
            // FRM003
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 206);
            this.Controls.Add(this.lblTipoPagamento);
            this.Controls.Add(this.vmLabel4);
            this.Controls.Add(this.txtValorPagar);
            this.Controls.Add(this.gbxDesconto);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.cbxTipoPgamento);
            this.Controls.Add(this.vmLabel2);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.txtCodigoCliente);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnBaixar);
            this.Name = "FRM003";
            this.Text = "EFETUAR BAIXA DE CONTAS A RECEBER";
            this.Shown += new System.EventHandler(this.FRM003_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            this.gbxDesconto.ResumeLayout(false);
            this.gbxDesconto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WINBASE.VMButton btnBaixar;
        private WINBASE.VMButton btnFechar;
        private WINBASE.VMTextBox txtCodigoCliente;
        private WINBASE.VMTextBox txtNomeCliente;
        private WINBASE.VMLabel lblCodigo;
        private WINBASE.VMLabel vmLabel2;
        private WINBASE.VMComboBox cbxTipoPgamento;
        private WINBASE.VMGroupBox gbxDesconto;
        private WINBASE.VMRadioButton rbtValor;
        private WINBASE.VMRadioButton rbtPorcentagem;
        private WINBASE.VMTextBox txtDesconto;
        private WINBASE.VMLabel lblValorTotal;
        private WINBASE.VMTextBox txtValorTotal;
        private WINBASE.VMLabel vmLabel4;
        private WINBASE.VMTextBox txtValorPagar;
        private WINBASE.VMLabel lblTipoPagamento;
    }
}