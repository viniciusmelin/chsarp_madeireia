namespace SlnEstagio.MOD001
{
    partial class FRM014
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
            this.vmGroupBox1 = new SlnEstagio.WINBASE.VMGroupBox();
            this.gbxCubagem = new SlnEstagio.WINBASE.VMGroupBox();
            this.txtPreco = new SlnEstagio.WINBASE.VMTextBox();
            this.lblQuaMin = new SlnEstagio.WINBASE.VMLabel();
            this.vmLabel1 = new SlnEstagio.WINBASE.VMLabel();
            this.txtQuanMin = new SlnEstagio.WINBASE.VMTextBox();
            this.lblCubagem = new SlnEstagio.WINBASE.VMLabel();
            this.txtProfundidade = new SlnEstagio.WINBASE.VMTextBox();
            this.lblProfundidade = new SlnEstagio.WINBASE.VMLabel();
            this.txtAltura = new SlnEstagio.WINBASE.VMTextBox();
            this.lblAltura = new SlnEstagio.WINBASE.VMLabel();
            this.txtLargura = new SlnEstagio.WINBASE.VMTextBox();
            this.lblLargura = new SlnEstagio.WINBASE.VMLabel();
            this.gbxInformacaoProduto = new SlnEstagio.WINBASE.VMGroupBox();
            this.gbxAtivo = new SlnEstagio.WINBASE.VMGroupBox();
            this.rbtNao = new SlnEstagio.WINBASE.VMRadioButton();
            this.rbtSim = new SlnEstagio.WINBASE.VMRadioButton();
            this.lblDescricao = new SlnEstagio.WINBASE.VMLabel();
            this.txtDescricao = new SlnEstagio.WINBASE.VMTextBox();
            this.lblCodigo = new SlnEstagio.WINBASE.VMLabel();
            this.txtCodigo = new SlnEstagio.WINBASE.VMTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalvar = new SlnEstagio.WINBASE.VMButton();
            this.btnCancelar = new SlnEstagio.WINBASE.VMButton();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            this.vmGroupBox1.SuspendLayout();
            this.gbxCubagem.SuspendLayout();
            this.gbxInformacaoProduto.SuspendLayout();
            this.gbxAtivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // vmGroupBox1
            // 
            this.vmGroupBox1.Controls.Add(this.gbxCubagem);
            this.vmGroupBox1.Controls.Add(this.gbxInformacaoProduto);
            this.vmGroupBox1.Location = new System.Drawing.Point(9, 10);
            this.vmGroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.vmGroupBox1.Name = "vmGroupBox1";
            this.vmGroupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.vmGroupBox1.Size = new System.Drawing.Size(440, 310);
            this.vmGroupBox1.TabIndex = 0;
            this.vmGroupBox1.TabStop = false;
            this.vmGroupBox1.Text = "INFORMAÇÕES PRODUTO";
            // 
            // gbxCubagem
            // 
            this.gbxCubagem.Controls.Add(this.txtPreco);
            this.gbxCubagem.Controls.Add(this.lblQuaMin);
            this.gbxCubagem.Controls.Add(this.vmLabel1);
            this.gbxCubagem.Controls.Add(this.txtQuanMin);
            this.gbxCubagem.Controls.Add(this.lblCubagem);
            this.gbxCubagem.Controls.Add(this.txtProfundidade);
            this.gbxCubagem.Controls.Add(this.lblProfundidade);
            this.gbxCubagem.Controls.Add(this.txtAltura);
            this.gbxCubagem.Controls.Add(this.lblAltura);
            this.gbxCubagem.Controls.Add(this.txtLargura);
            this.gbxCubagem.Controls.Add(this.lblLargura);
            this.gbxCubagem.Location = new System.Drawing.Point(9, 119);
            this.gbxCubagem.Margin = new System.Windows.Forms.Padding(2);
            this.gbxCubagem.Name = "gbxCubagem";
            this.gbxCubagem.Padding = new System.Windows.Forms.Padding(2);
            this.gbxCubagem.Size = new System.Drawing.Size(423, 184);
            this.gbxCubagem.TabIndex = 1;
            this.gbxCubagem.TabStop = false;
            this.gbxCubagem.Text = "CUBAGEM";
            // 
            // txtPreco
            // 
            this.txtPreco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPreco.Location = new System.Drawing.Point(4, 39);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(2);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(112, 20);
            this.txtPreco.TabIndex = 1;
            this.txtPreco.Text = "0,00";
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPreco.VMLabelAssociado = null;
            this.txtPreco.VMMascara = "##0.00";
            this.txtPreco.VMPesquisa = false;
            this.txtPreco.VMPesquisaValor = null;
            this.txtPreco.VMRequerido = false;
            this.txtPreco.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Valor;
            this.txtPreco.VMValor = null;
            // 
            // lblQuaMin
            // 
            this.lblQuaMin.AutoSize = true;
            this.lblQuaMin.Location = new System.Drawing.Point(118, 23);
            this.lblQuaMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuaMin.Name = "lblQuaMin";
            this.lblQuaMin.Size = new System.Drawing.Size(59, 13);
            this.lblQuaMin.TabIndex = 2;
            this.lblQuaMin.Text = "QTD. MIN.";
            // 
            // vmLabel1
            // 
            this.vmLabel1.AutoSize = true;
            this.vmLabel1.Location = new System.Drawing.Point(2, 23);
            this.vmLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel1.Name = "vmLabel1";
            this.vmLabel1.Size = new System.Drawing.Size(69, 13);
            this.vmLabel1.TabIndex = 0;
            this.vmLabel1.Text = "PREÇO (CM)";
            // 
            // txtQuanMin
            // 
            this.txtQuanMin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQuanMin.Location = new System.Drawing.Point(120, 39);
            this.txtQuanMin.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuanMin.Name = "txtQuanMin";
            this.txtQuanMin.Size = new System.Drawing.Size(112, 20);
            this.txtQuanMin.TabIndex = 3;
            this.txtQuanMin.Text = "0";
            this.txtQuanMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuanMin.VMLabelAssociado = null;
            this.txtQuanMin.VMMascara = null;
            this.txtQuanMin.VMPesquisa = false;
            this.txtQuanMin.VMPesquisaValor = null;
            this.txtQuanMin.VMRequerido = false;
            this.txtQuanMin.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Valor;
            this.txtQuanMin.VMValor = null;
            // 
            // lblCubagem
            // 
            this.lblCubagem.AutoSize = true;
            this.lblCubagem.Location = new System.Drawing.Point(156, 145);
            this.lblCubagem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCubagem.Name = "lblCubagem";
            this.lblCubagem.Size = new System.Drawing.Size(60, 13);
            this.lblCubagem.TabIndex = 10;
            this.lblCubagem.Text = "CUBAGEM";
            // 
            // txtProfundidade
            // 
            this.txtProfundidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProfundidade.Location = new System.Drawing.Point(120, 88);
            this.txtProfundidade.Margin = new System.Windows.Forms.Padding(2);
            this.txtProfundidade.Name = "txtProfundidade";
            this.txtProfundidade.Size = new System.Drawing.Size(112, 20);
            this.txtProfundidade.TabIndex = 9;
            this.txtProfundidade.Text = "0";
            this.txtProfundidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtProfundidade.VMLabelAssociado = null;
            this.txtProfundidade.VMMascara = null;
            this.txtProfundidade.VMPesquisa = false;
            this.txtProfundidade.VMPesquisaValor = null;
            this.txtProfundidade.VMRequerido = false;
            this.txtProfundidade.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Valor;
            this.txtProfundidade.VMValor = null;
            this.txtProfundidade.Leave += new System.EventHandler(this.txtCubagemTotal_Leave);
            // 
            // lblProfundidade
            // 
            this.lblProfundidade.AutoSize = true;
            this.lblProfundidade.Location = new System.Drawing.Point(118, 72);
            this.lblProfundidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfundidade.Name = "lblProfundidade";
            this.lblProfundidade.Size = new System.Drawing.Size(118, 13);
            this.lblProfundidade.TabIndex = 8;
            this.lblProfundidade.Text = "PROFUNDIDADE (CM)";
            // 
            // txtAltura
            // 
            this.txtAltura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAltura.Location = new System.Drawing.Point(236, 39);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(2);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(112, 20);
            this.txtAltura.TabIndex = 5;
            this.txtAltura.Text = "0";
            this.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAltura.VMLabelAssociado = null;
            this.txtAltura.VMMascara = null;
            this.txtAltura.VMPesquisa = false;
            this.txtAltura.VMPesquisaValor = null;
            this.txtAltura.VMRequerido = false;
            this.txtAltura.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Valor;
            this.txtAltura.VMValor = null;
            this.txtAltura.Leave += new System.EventHandler(this.txtCubagemTotal_Leave);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(233, 23);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(75, 13);
            this.lblAltura.TabIndex = 4;
            this.lblAltura.Text = "ALTURA (CM)";
            // 
            // txtLargura
            // 
            this.txtLargura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLargura.Location = new System.Drawing.Point(4, 88);
            this.txtLargura.Margin = new System.Windows.Forms.Padding(2);
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Size = new System.Drawing.Size(112, 20);
            this.txtLargura.TabIndex = 7;
            this.txtLargura.Text = "0";
            this.txtLargura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLargura.VMLabelAssociado = null;
            this.txtLargura.VMMascara = null;
            this.txtLargura.VMPesquisa = false;
            this.txtLargura.VMPesquisaValor = null;
            this.txtLargura.VMRequerido = false;
            this.txtLargura.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Valor;
            this.txtLargura.VMValor = null;
            this.txtLargura.Leave += new System.EventHandler(this.txtCubagemTotal_Leave);
            // 
            // lblLargura
            // 
            this.lblLargura.AutoSize = true;
            this.lblLargura.Location = new System.Drawing.Point(2, 72);
            this.lblLargura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLargura.Name = "lblLargura";
            this.lblLargura.Size = new System.Drawing.Size(84, 13);
            this.lblLargura.TabIndex = 6;
            this.lblLargura.Text = "LARGURA (CM)";
            // 
            // gbxInformacaoProduto
            // 
            this.gbxInformacaoProduto.Controls.Add(this.gbxAtivo);
            this.gbxInformacaoProduto.Controls.Add(this.lblDescricao);
            this.gbxInformacaoProduto.Controls.Add(this.txtDescricao);
            this.gbxInformacaoProduto.Controls.Add(this.lblCodigo);
            this.gbxInformacaoProduto.Controls.Add(this.txtCodigo);
            this.gbxInformacaoProduto.Location = new System.Drawing.Point(9, 12);
            this.gbxInformacaoProduto.Margin = new System.Windows.Forms.Padding(2);
            this.gbxInformacaoProduto.Name = "gbxInformacaoProduto";
            this.gbxInformacaoProduto.Padding = new System.Windows.Forms.Padding(2);
            this.gbxInformacaoProduto.Size = new System.Drawing.Size(423, 102);
            this.gbxInformacaoProduto.TabIndex = 0;
            this.gbxInformacaoProduto.TabStop = false;
            // 
            // gbxAtivo
            // 
            this.gbxAtivo.Controls.Add(this.rbtNao);
            this.gbxAtivo.Controls.Add(this.rbtSim);
            this.gbxAtivo.Location = new System.Drawing.Point(288, 25);
            this.gbxAtivo.Margin = new System.Windows.Forms.Padding(2);
            this.gbxAtivo.Name = "gbxAtivo";
            this.gbxAtivo.Padding = new System.Windows.Forms.Padding(2);
            this.gbxAtivo.Size = new System.Drawing.Size(104, 41);
            this.gbxAtivo.TabIndex = 2;
            this.gbxAtivo.TabStop = false;
            this.gbxAtivo.Text = "ATIVO";
            // 
            // rbtNao
            // 
            this.rbtNao.AutoSize = true;
            this.rbtNao.Location = new System.Drawing.Point(48, 17);
            this.rbtNao.Margin = new System.Windows.Forms.Padding(2);
            this.rbtNao.Name = "rbtNao";
            this.rbtNao.Size = new System.Drawing.Size(48, 17);
            this.rbtNao.TabIndex = 1;
            this.rbtNao.Text = "NÃO";
            this.rbtNao.UseVisualStyleBackColor = true;
            // 
            // rbtSim
            // 
            this.rbtSim.AutoSize = true;
            this.rbtSim.Checked = true;
            this.rbtSim.Location = new System.Drawing.Point(4, 17);
            this.rbtSim.Margin = new System.Windows.Forms.Padding(2);
            this.rbtSim.Name = "rbtSim";
            this.rbtSim.Size = new System.Drawing.Size(44, 17);
            this.rbtSim.TabIndex = 0;
            this.rbtSim.TabStop = true;
            this.rbtSim.Text = "SIM";
            this.rbtSim.UseVisualStyleBackColor = true;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(5, 57);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(69, 13);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "DESCRIÇÃO";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(8, 72);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(386, 20);
            this.txtDescricao.TabIndex = 4;
            this.txtDescricao.VMLabelAssociado = null;
            this.txtDescricao.VMMascara = null;
            this.txtDescricao.VMPesquisa = false;
            this.txtDescricao.VMPesquisaValor = null;
            this.txtDescricao.VMRequerido = true;
            this.txtDescricao.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtDescricao.VMValor = null;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(5, 19);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "CÓDIGO";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Location = new System.Drawing.Point(8, 35);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(92, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.VMLabelAssociado = null;
            this.txtCodigo.VMMascara = null;
            this.txtCodigo.VMPesquisa = false;
            this.txtCodigo.VMPesquisaValor = null;
            this.txtCodigo.VMRequerido = false;
            this.txtCodigo.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtCodigo.VMValor = null;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(366, 326);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 24);
            this.panel1.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(284, 324);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(78, 28);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "&SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(371, 324);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 28);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "&CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FRM014
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 358);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.vmGroupBox1);
            this.Name = "FRM014";
            this.Text = "CADASTRAR PRODUTO";
            this.Shown += new System.EventHandler(this.FRM014_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            this.vmGroupBox1.ResumeLayout(false);
            this.gbxCubagem.ResumeLayout(false);
            this.gbxCubagem.PerformLayout();
            this.gbxInformacaoProduto.ResumeLayout(false);
            this.gbxInformacaoProduto.PerformLayout();
            this.gbxAtivo.ResumeLayout(false);
            this.gbxAtivo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SlnEstagio.WINBASE.VMGroupBox vmGroupBox1;
        private SlnEstagio.WINBASE.VMGroupBox gbxCubagem;
        private SlnEstagio.WINBASE.VMTextBox txtLargura;
        private WINBASE.VMLabel lblLargura;
        private SlnEstagio.WINBASE.VMGroupBox gbxInformacaoProduto;
        private WINBASE.VMLabel lblDescricao;
        private SlnEstagio.WINBASE.VMTextBox txtDescricao;
        private WINBASE.VMLabel lblCodigo;
        private SlnEstagio.WINBASE.VMTextBox txtCodigo;
        private WINBASE.VMLabel lblCubagem;
        private SlnEstagio.WINBASE.VMTextBox txtProfundidade;
        private WINBASE.VMLabel lblProfundidade;
        private WINBASE.VMLabel lblAltura;
        private WINBASE.VMLabel lblQuaMin;
        private SlnEstagio.WINBASE.VMTextBox txtQuanMin;
        private WINBASE.VMRadioButton rbtSim;
        private WINBASE.VMRadioButton rbtNao;
        private SlnEstagio.WINBASE.VMGroupBox gbxAtivo;
        private SlnEstagio.WINBASE.VMTextBox txtAltura;
        private System.Windows.Forms.Panel panel1;
        private WINBASE.VMButton btnSalvar;
        private WINBASE.VMButton btnCancelar;
        private WINBASE.VMTextBox txtPreco;
        private WINBASE.VMLabel vmLabel1;
    }
}