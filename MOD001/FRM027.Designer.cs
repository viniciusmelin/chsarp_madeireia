namespace SlnEstagio.MOD001
{
    partial class FRM027
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
            this.btnFecharCliente = new SlnEstagio.WINBASE.VMButton();
            this.btnSalvar = new SlnEstagio.WINBASE.VMButton();
            this.gbInformacoesCliente = new SlnEstagio.WINBASE.VMGroupBox();
            this.dtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.lblDataCadastro = new SlnEstagio.WINBASE.VMLabel();
            this.lblcodigoCliente = new SlnEstagio.WINBASE.VMLabel();
            this.txtcodigocliente = new SlnEstagio.WINBASE.VMTextBox();
            this.gbxAtivo = new SlnEstagio.WINBASE.VMGroupBox();
            this.rbtNao = new System.Windows.Forms.RadioButton();
            this.rbtSim = new System.Windows.Forms.RadioButton();
            this.lblCpf = new SlnEstagio.WINBASE.VMLabel();
            this.lblNome = new SlnEstagio.WINBASE.VMLabel();
            this.txtCpf = new SlnEstagio.WINBASE.VMTextBox();
            this.txtNome = new SlnEstagio.WINBASE.VMTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            this.gbInformacoesCliente.SuspendLayout();
            this.gbxAtivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btnFecharCliente
            // 
            this.btnFecharCliente.Location = new System.Drawing.Point(297, 193);
            this.btnFecharCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFecharCliente.Name = "btnFecharCliente";
            this.btnFecharCliente.Size = new System.Drawing.Size(76, 28);
            this.btnFecharCliente.TabIndex = 2;
            this.btnFecharCliente.Text = "CANCELAR";
            this.btnFecharCliente.UseVisualStyleBackColor = true;
            this.btnFecharCliente.Click += new System.EventHandler(this.btnFecharCliente_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(214, 193);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(76, 28);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gbInformacoesCliente
            // 
            this.gbInformacoesCliente.Controls.Add(this.dtpDataCadastro);
            this.gbInformacoesCliente.Controls.Add(this.lblDataCadastro);
            this.gbInformacoesCliente.Controls.Add(this.lblcodigoCliente);
            this.gbInformacoesCliente.Controls.Add(this.txtcodigocliente);
            this.gbInformacoesCliente.Controls.Add(this.gbxAtivo);
            this.gbInformacoesCliente.Controls.Add(this.lblCpf);
            this.gbInformacoesCliente.Controls.Add(this.lblNome);
            this.gbInformacoesCliente.Controls.Add(this.txtCpf);
            this.gbInformacoesCliente.Controls.Add(this.txtNome);
            this.gbInformacoesCliente.Location = new System.Drawing.Point(9, 10);
            this.gbInformacoesCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbInformacoesCliente.Name = "gbInformacoesCliente";
            this.gbInformacoesCliente.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbInformacoesCliente.Size = new System.Drawing.Size(364, 178);
            this.gbInformacoesCliente.TabIndex = 0;
            this.gbInformacoesCliente.TabStop = false;
            this.gbInformacoesCliente.Text = "INFORMAÇÕES CLIENTE";
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.Enabled = false;
            this.dtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCadastro.Location = new System.Drawing.Point(269, 37);
            this.dtpDataCadastro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // txtcodigocliente
            // 
            this.txtcodigocliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcodigocliente.Enabled = false;
            this.txtcodigocliente.Location = new System.Drawing.Point(4, 37);
            this.txtcodigocliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcodigocliente.Name = "txtcodigocliente";
            this.txtcodigocliente.ReadOnly = true;
            this.txtcodigocliente.Size = new System.Drawing.Size(72, 20);
            this.txtcodigocliente.TabIndex = 1;
            this.txtcodigocliente.TabStop = false;
            this.txtcodigocliente.Text = "0";
            this.txtcodigocliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcodigocliente.VMLabelAssociado = null;
            this.txtcodigocliente.VMMascara = null;
            this.txtcodigocliente.VMPesquisa = false;
            this.txtcodigocliente.VMPesquisaValor = null;
            this.txtcodigocliente.VMRequerido = false;
            this.txtcodigocliente.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtcodigocliente.VMValor = null;
            // 
            // gbxAtivo
            // 
            this.gbxAtivo.Controls.Add(this.rbtNao);
            this.gbxAtivo.Controls.Add(this.rbtSim);
            this.gbxAtivo.Location = new System.Drawing.Point(251, 119);
            this.gbxAtivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxAtivo.Name = "gbxAtivo";
            this.gbxAtivo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxAtivo.Size = new System.Drawing.Size(103, 46);
            this.gbxAtivo.TabIndex = 8;
            this.gbxAtivo.TabStop = false;
            this.gbxAtivo.Text = "Ativo";
            // 
            // rbtNao
            // 
            this.rbtNao.AutoSize = true;
            this.rbtNao.Location = new System.Drawing.Point(48, 17);
            this.rbtNao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtNao.Name = "rbtNao";
            this.rbtNao.Size = new System.Drawing.Size(48, 17);
            this.rbtNao.TabIndex = 1;
            this.rbtNao.TabStop = true;
            this.rbtNao.Text = "NÃO";
            this.rbtNao.UseVisualStyleBackColor = true;
            // 
            // rbtSim
            // 
            this.rbtSim.AutoSize = true;
            this.rbtSim.Checked = true;
            this.rbtSim.Location = new System.Drawing.Point(4, 17);
            this.rbtSim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 6;
            this.lblCpf.Text = "CPF";
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
            this.txtCpf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCpf.MaxLength = 25;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(152, 20);
            this.txtCpf.TabIndex = 7;
            this.txtCpf.VMLabelAssociado = this.lblCpf;
            this.txtCpf.VMMascara = null;
            this.txtCpf.VMPesquisa = false;
            this.txtCpf.VMPesquisaValor = null;
            this.txtCpf.VMRequerido = true;
            this.txtCpf.VMTipoDado = SlnEstagio.WINBASE.TipoDado.CPF;
            this.txtCpf.VMValor = null;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(4, 85);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(350, 20);
            this.txtNome.TabIndex = 5;
            this.txtNome.VMLabelAssociado = this.lblNome;
            this.txtNome.VMMascara = null;
            this.txtNome.VMPesquisa = false;
            this.txtNome.VMPesquisaValor = null;
            this.txtNome.VMRequerido = true;
            this.txtNome.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtNome.VMValor = null;
            // 
            // FRM027
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 225);
            this.Controls.Add(this.btnFecharCliente);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbInformacoesCliente);
            this.Name = "FRM027";
            this.Text = "CADASTRAR VENDEDOR";
            this.Shown += new System.EventHandler(this.FRM027_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            this.gbInformacoesCliente.ResumeLayout(false);
            this.gbInformacoesCliente.PerformLayout();
            this.gbxAtivo.ResumeLayout(false);
            this.gbxAtivo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WINBASE.VMButton btnFecharCliente;
        private WINBASE.VMButton btnSalvar;
        private WINBASE.VMGroupBox gbInformacoesCliente;
        private System.Windows.Forms.DateTimePicker dtpDataCadastro;
        private WINBASE.VMLabel lblDataCadastro;
        private WINBASE.VMLabel lblcodigoCliente;
        private WINBASE.VMTextBox txtcodigocliente;
        private WINBASE.VMGroupBox gbxAtivo;
        private System.Windows.Forms.RadioButton rbtNao;
        private System.Windows.Forms.RadioButton rbtSim;
        private WINBASE.VMLabel lblCpf;
        private WINBASE.VMLabel lblNome;
        private WINBASE.VMTextBox txtCpf;
        private WINBASE.VMTextBox txtNome;
    }
}