namespace SlnEstagio.MOD001
{
    partial class FRM016
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
            this.btnFechar = new SlnEstagio.WINBASE.VMButton();
            this.btnSalvar = new SlnEstagio.WINBASE.VMButton();
            this.gbInformacoesFornecedor = new SlnEstagio.WINBASE.VMGroupBox();
            this.vmLabel1 = new SlnEstagio.WINBASE.VMLabel();
            this.txtInscEstadual = new SlnEstagio.WINBASE.VMTextBox();
            this.dtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.lblDataCadastro = new SlnEstagio.WINBASE.VMLabel();
            this.lblcodigoCliente = new SlnEstagio.WINBASE.VMLabel();
            this.txtcodigo = new SlnEstagio.WINBASE.VMTextBox();
            this.gbxAtivo = new SlnEstagio.WINBASE.VMGroupBox();
            this.rbtNao = new System.Windows.Forms.RadioButton();
            this.rbtSim = new System.Windows.Forms.RadioButton();
            this.lblCpf = new SlnEstagio.WINBASE.VMLabel();
            this.lblNome = new SlnEstagio.WINBASE.VMLabel();
            this.txtCpf = new SlnEstagio.WINBASE.VMTextBox();
            this.txtNome = new SlnEstagio.WINBASE.VMTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            this.gbInformacoesFornecedor.SuspendLayout();
            this.gbxAtivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(301, 252);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(77, 29);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "CANCELAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFecharCliente_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(219, 252);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(77, 29);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gbInformacoesFornecedor
            // 
            this.gbInformacoesFornecedor.Controls.Add(this.vmLabel1);
            this.gbInformacoesFornecedor.Controls.Add(this.txtInscEstadual);
            this.gbInformacoesFornecedor.Controls.Add(this.dtpDataCadastro);
            this.gbInformacoesFornecedor.Controls.Add(this.lblDataCadastro);
            this.gbInformacoesFornecedor.Controls.Add(this.lblcodigoCliente);
            this.gbInformacoesFornecedor.Controls.Add(this.txtcodigo);
            this.gbInformacoesFornecedor.Controls.Add(this.gbxAtivo);
            this.gbInformacoesFornecedor.Controls.Add(this.lblCpf);
            this.gbInformacoesFornecedor.Controls.Add(this.lblNome);
            this.gbInformacoesFornecedor.Controls.Add(this.txtCpf);
            this.gbInformacoesFornecedor.Controls.Add(this.txtNome);
            this.gbInformacoesFornecedor.Location = new System.Drawing.Point(9, 10);
            this.gbInformacoesFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.gbInformacoesFornecedor.Name = "gbInformacoesFornecedor";
            this.gbInformacoesFornecedor.Padding = new System.Windows.Forms.Padding(2);
            this.gbInformacoesFornecedor.Size = new System.Drawing.Size(376, 238);
            this.gbInformacoesFornecedor.TabIndex = 0;
            this.gbInformacoesFornecedor.TabStop = false;
            this.gbInformacoesFornecedor.Text = "INFORMAÇÕES FORNECEDOR";
            // 
            // vmLabel1
            // 
            this.vmLabel1.AutoSize = true;
            this.vmLabel1.Location = new System.Drawing.Point(2, 177);
            this.vmLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel1.Name = "vmLabel1";
            this.vmLabel1.Size = new System.Drawing.Size(125, 13);
            this.vmLabel1.TabIndex = 9;
            this.vmLabel1.Text = "INSCRIÇÃO ESTADUAL";
            // 
            // txtInscEstadual
            // 
            this.txtInscEstadual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInscEstadual.Location = new System.Drawing.Point(4, 193);
            this.txtInscEstadual.Margin = new System.Windows.Forms.Padding(2);
            this.txtInscEstadual.Name = "txtInscEstadual";
            this.txtInscEstadual.Size = new System.Drawing.Size(152, 20);
            this.txtInscEstadual.TabIndex = 10;
            this.txtInscEstadual.VMLabelAssociado = null;
            this.txtInscEstadual.VMMascara = null;
            this.txtInscEstadual.VMPesquisa = false;
            this.txtInscEstadual.VMPesquisaValor = null;
            this.txtInscEstadual.VMRequerido = true;
            this.txtInscEstadual.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtInscEstadual.VMValor = null;
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.Enabled = false;
            this.dtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCadastro.Location = new System.Drawing.Point(269, 37);
            this.dtpDataCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataCadastro.Name = "dtpDataCadastro";
            this.dtpDataCadastro.Size = new System.Drawing.Size(86, 20);
            this.dtpDataCadastro.TabIndex = 3;
            this.dtpDataCadastro.TabStop = false;
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Location = new System.Drawing.Point(267, 20);
            this.lblDataCadastro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(64, 13);
            this.lblDataCadastro.TabIndex = 2;
            this.lblDataCadastro.Text = "DATA CAD.";
            // 
            // lblcodigoCliente
            // 
            this.lblcodigoCliente.AutoSize = true;
            this.lblcodigoCliente.Location = new System.Drawing.Point(2, 20);
            this.lblcodigoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcodigoCliente.Name = "lblcodigoCliente";
            this.lblcodigoCliente.Size = new System.Drawing.Size(33, 13);
            this.lblcodigoCliente.TabIndex = 0;
            this.lblcodigoCliente.Text = "CÓD.";
            // 
            // txtcodigo
            // 
            this.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcodigo.Location = new System.Drawing.Point(4, 37);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.ReadOnly = true;
            this.txtcodigo.Size = new System.Drawing.Size(72, 20);
            this.txtcodigo.TabIndex = 1;
            this.txtcodigo.TabStop = false;
            this.txtcodigo.VMLabelAssociado = null;
            this.txtcodigo.VMMascara = null;
            this.txtcodigo.VMPesquisa = false;
            this.txtcodigo.VMPesquisaValor = null;
            this.txtcodigo.VMRequerido = false;
            this.txtcodigo.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtcodigo.VMValor = null;
            // 
            // gbxAtivo
            // 
            this.gbxAtivo.Controls.Add(this.rbtNao);
            this.gbxAtivo.Controls.Add(this.rbtSim);
            this.gbxAtivo.Location = new System.Drawing.Point(251, 119);
            this.gbxAtivo.Margin = new System.Windows.Forms.Padding(2);
            this.gbxAtivo.Name = "gbxAtivo";
            this.gbxAtivo.Padding = new System.Windows.Forms.Padding(2);
            this.gbxAtivo.Size = new System.Drawing.Size(103, 46);
            this.gbxAtivo.TabIndex = 8;
            this.gbxAtivo.TabStop = false;
            this.gbxAtivo.Text = "Ativo";
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
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(2, 119);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(34, 13);
            this.lblCpf.TabIndex = 6;
            this.lblCpf.Text = "CNPJ";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(2, 69);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "NOME";
            // 
            // txtCpf
            // 
            this.txtCpf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCpf.Location = new System.Drawing.Point(4, 135);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(2);
            this.txtCpf.MaxLength = 14;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(152, 20);
            this.txtCpf.TabIndex = 7;
            this.txtCpf.VMLabelAssociado = this.lblCpf;
            this.txtCpf.VMMascara = null;
            this.txtCpf.VMPesquisa = false;
            this.txtCpf.VMPesquisaValor = null;
            this.txtCpf.VMRequerido = true;
            this.txtCpf.VMTipoDado = SlnEstagio.WINBASE.TipoDado.CNPJ;
            this.txtCpf.VMValor = null;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(4, 85);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(350, 20);
            this.txtNome.TabIndex = 5;
            this.txtNome.VMLabelAssociado = null;
            this.txtNome.VMMascara = null;
            this.txtNome.VMPesquisa = false;
            this.txtNome.VMPesquisaValor = null;
            this.txtNome.VMRequerido = true;
            this.txtNome.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtNome.VMValor = null;
            // 
            // FRM016
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 285);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbInformacoesFornecedor);
            this.Name = "FRM016";
            this.Text = "CADASTRAR FORNECEDOR";
            this.Shown += new System.EventHandler(this.FRM016_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            this.gbInformacoesFornecedor.ResumeLayout(false);
            this.gbInformacoesFornecedor.PerformLayout();
            this.gbxAtivo.ResumeLayout(false);
            this.gbxAtivo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WINBASE.VMButton btnFechar;
        private WINBASE.VMButton btnSalvar;
        private WINBASE.VMGroupBox gbInformacoesFornecedor;
        private WINBASE.VMLabel vmLabel1;
        private WINBASE.VMTextBox txtInscEstadual;
        private System.Windows.Forms.DateTimePicker dtpDataCadastro;
        private WINBASE.VMLabel lblDataCadastro;
        private WINBASE.VMLabel lblcodigoCliente;
        private WINBASE.VMTextBox txtcodigo;
        private WINBASE.VMGroupBox gbxAtivo;
        private System.Windows.Forms.RadioButton rbtNao;
        private System.Windows.Forms.RadioButton rbtSim;
        private WINBASE.VMLabel lblCpf;
        private WINBASE.VMLabel lblNome;
        private WINBASE.VMTextBox txtCpf;
        private WINBASE.VMTextBox txtNome;
    }
}