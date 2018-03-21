namespace SlnEstagio.MOD001
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
            this.gbInformacoesCliente = new SlnEstagio.WINBASE.VMGroupBox();
            this.lblLimiteMaxCliente = new SlnEstagio.WINBASE.VMLabel();
            this.lblLimiteMininoCliente = new SlnEstagio.WINBASE.VMLabel();
            this.txtLimiteMaxCliente = new SlnEstagio.WINBASE.VMTextBox();
            this.txtLimiteMinCliente = new SlnEstagio.WINBASE.VMTextBox();
            this.dtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.lblDataCadastro = new SlnEstagio.WINBASE.VMLabel();
            this.lblcodigoCliente = new SlnEstagio.WINBASE.VMLabel();
            this.txtcodigocliente = new SlnEstagio.WINBASE.VMTextBox();
            this.gbxAtivo = new SlnEstagio.WINBASE.VMGroupBox();
            this.rbtNao = new System.Windows.Forms.RadioButton();
            this.rbtSim = new System.Windows.Forms.RadioButton();
            this.lblCpf = new SlnEstagio.WINBASE.VMLabel();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblDataNascimento = new SlnEstagio.WINBASE.VMLabel();
            this.lblNome = new SlnEstagio.WINBASE.VMLabel();
            this.txtCpf = new SlnEstagio.WINBASE.VMTextBox();
            this.txtNome = new SlnEstagio.WINBASE.VMTextBox();
            this.btnSalvarCliente = new SlnEstagio.WINBASE.VMButton();
            this.btnFecharCliente = new SlnEstagio.WINBASE.VMButton();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            this.gbInformacoesCliente.SuspendLayout();
            this.gbxAtivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // gbInformacoesCliente
            // 
            this.gbInformacoesCliente.Controls.Add(this.lblLimiteMaxCliente);
            this.gbInformacoesCliente.Controls.Add(this.lblLimiteMininoCliente);
            this.gbInformacoesCliente.Controls.Add(this.txtLimiteMaxCliente);
            this.gbInformacoesCliente.Controls.Add(this.txtLimiteMinCliente);
            this.gbInformacoesCliente.Controls.Add(this.dtpDataCadastro);
            this.gbInformacoesCliente.Controls.Add(this.lblDataCadastro);
            this.gbInformacoesCliente.Controls.Add(this.lblcodigoCliente);
            this.gbInformacoesCliente.Controls.Add(this.txtcodigocliente);
            this.gbInformacoesCliente.Controls.Add(this.gbxAtivo);
            this.gbInformacoesCliente.Controls.Add(this.lblCpf);
            this.gbInformacoesCliente.Controls.Add(this.dtpDataNascimento);
            this.gbInformacoesCliente.Controls.Add(this.lblDataNascimento);
            this.gbInformacoesCliente.Controls.Add(this.lblNome);
            this.gbInformacoesCliente.Controls.Add(this.txtCpf);
            this.gbInformacoesCliente.Controls.Add(this.txtNome);
            this.gbInformacoesCliente.Location = new System.Drawing.Point(9, 10);
            this.gbInformacoesCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbInformacoesCliente.Name = "gbInformacoesCliente";
            this.gbInformacoesCliente.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbInformacoesCliente.Size = new System.Drawing.Size(376, 270);
            this.gbInformacoesCliente.TabIndex = 0;
            this.gbInformacoesCliente.TabStop = false;
            this.gbInformacoesCliente.Text = "INFORMAÇÕES CLIENTE";
            // 
            // lblLimiteMaxCliente
            // 
            this.lblLimiteMaxCliente.AutoSize = true;
            this.lblLimiteMaxCliente.Location = new System.Drawing.Point(2, 216);
            this.lblLimiteMaxCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLimiteMaxCliente.Name = "lblLimiteMaxCliente";
            this.lblLimiteMaxCliente.Size = new System.Drawing.Size(71, 13);
            this.lblLimiteMaxCliente.TabIndex = 13;
            this.lblLimiteMaxCliente.Text = "LIMITE MAX.";
            // 
            // lblLimiteMininoCliente
            // 
            this.lblLimiteMininoCliente.AutoSize = true;
            this.lblLimiteMininoCliente.Location = new System.Drawing.Point(4, 168);
            this.lblLimiteMininoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLimiteMininoCliente.Name = "lblLimiteMininoCliente";
            this.lblLimiteMininoCliente.Size = new System.Drawing.Size(68, 13);
            this.lblLimiteMininoCliente.TabIndex = 11;
            this.lblLimiteMininoCliente.Text = "LIMITE MIN.";
            // 
            // txtLimiteMaxCliente
            // 
            this.txtLimiteMaxCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLimiteMaxCliente.Location = new System.Drawing.Point(4, 232);
            this.txtLimiteMaxCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLimiteMaxCliente.Name = "txtLimiteMaxCliente";
            this.txtLimiteMaxCliente.Size = new System.Drawing.Size(72, 20);
            this.txtLimiteMaxCliente.TabIndex = 14;
            this.txtLimiteMaxCliente.Text = "0,00";
            this.txtLimiteMaxCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLimiteMaxCliente.VMLabelAssociado = null;
            this.txtLimiteMaxCliente.VMMascara = "##0.00";
            this.txtLimiteMaxCliente.VMPesquisa = false;
            this.txtLimiteMaxCliente.VMPesquisaValor = null;
            this.txtLimiteMaxCliente.VMRequerido = false;
            this.txtLimiteMaxCliente.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Valor;
            this.txtLimiteMaxCliente.VMValor = null;
            // 
            // txtLimiteMinCliente
            // 
            this.txtLimiteMinCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLimiteMinCliente.Location = new System.Drawing.Point(4, 184);
            this.txtLimiteMinCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLimiteMinCliente.Name = "txtLimiteMinCliente";
            this.txtLimiteMinCliente.Size = new System.Drawing.Size(72, 20);
            this.txtLimiteMinCliente.TabIndex = 12;
            this.txtLimiteMinCliente.Text = "0,00";
            this.txtLimiteMinCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLimiteMinCliente.VMLabelAssociado = null;
            this.txtLimiteMinCliente.VMMascara = "##0.00";
            this.txtLimiteMinCliente.VMPesquisa = false;
            this.txtLimiteMinCliente.VMPesquisaValor = null;
            this.txtLimiteMinCliente.VMRequerido = false;
            this.txtLimiteMinCliente.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Valor;
            this.txtLimiteMinCliente.VMValor = null;
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.Enabled = false;
            this.dtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCadastro.Location = new System.Drawing.Point(171, 37);
            this.dtpDataCadastro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDataCadastro.Name = "dtpDataCadastro";
            this.dtpDataCadastro.Size = new System.Drawing.Size(86, 20);
            this.dtpDataCadastro.TabIndex = 3;
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Location = new System.Drawing.Point(169, 20);
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
            this.txtcodigocliente.Size = new System.Drawing.Size(72, 20);
            this.txtcodigocliente.TabIndex = 1;
            this.txtcodigocliente.TabStop = false;
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
            this.gbxAtivo.TabIndex = 10;
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
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Enabled = false;
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(269, 37);
            this.dtpDataNascimento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(86, 20);
            this.dtpDataNascimento.TabIndex = 9;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(267, 20);
            this.lblDataNascimento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(71, 13);
            this.lblDataNascimento.TabIndex = 8;
            this.lblDataNascimento.Text = "DATA NASC.";
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
            this.txtCpf.MaxLength = 11;
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
            // btnSalvarCliente
            // 
            this.btnSalvarCliente.Location = new System.Drawing.Point(226, 284);
            this.btnSalvarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalvarCliente.Name = "btnSalvarCliente";
            this.btnSalvarCliente.Size = new System.Drawing.Size(76, 28);
            this.btnSalvarCliente.TabIndex = 1;
            this.btnSalvarCliente.Text = "SALVAR";
            this.btnSalvarCliente.UseVisualStyleBackColor = true;
            this.btnSalvarCliente.Click += new System.EventHandler(this.btnSalvarCliente_Click);
            // 
            // btnFecharCliente
            // 
            this.btnFecharCliente.Location = new System.Drawing.Point(310, 284);
            this.btnFecharCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFecharCliente.Name = "btnFecharCliente";
            this.btnFecharCliente.Size = new System.Drawing.Size(76, 28);
            this.btnFecharCliente.TabIndex = 2;
            this.btnFecharCliente.Text = "CANCELAR";
            this.btnFecharCliente.UseVisualStyleBackColor = true;
            this.btnFecharCliente.Click += new System.EventHandler(this.btnFecharCliente_Click);
            // 
            // FRM002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 316);
            this.Controls.Add(this.btnFecharCliente);
            this.Controls.Add(this.btnSalvarCliente);
            this.Controls.Add(this.gbInformacoesCliente);
            this.Name = "FRM002";
            this.Text = "CADASTRAR CLIENTE";
            this.Shown += new System.EventHandler(this.FRM002_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            this.gbInformacoesCliente.ResumeLayout(false);
            this.gbInformacoesCliente.PerformLayout();
            this.gbxAtivo.ResumeLayout(false);
            this.gbxAtivo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SlnEstagio.WINBASE.VMGroupBox gbInformacoesCliente;
        private SlnEstagio.WINBASE.VMLabel lblLimiteMaxCliente;
        private SlnEstagio.WINBASE.VMLabel lblLimiteMininoCliente;
        private SlnEstagio.WINBASE.VMTextBox txtLimiteMaxCliente;
        private SlnEstagio.WINBASE.VMTextBox txtLimiteMinCliente;
        private System.Windows.Forms.DateTimePicker dtpDataCadastro;
        private SlnEstagio.WINBASE.VMLabel lblDataCadastro;
        private SlnEstagio.WINBASE.VMLabel lblcodigoCliente;
        private SlnEstagio.WINBASE.VMTextBox txtcodigocliente;
        private SlnEstagio.WINBASE.VMGroupBox gbxAtivo;
        private System.Windows.Forms.RadioButton rbtNao;
        private System.Windows.Forms.RadioButton rbtSim;
        private SlnEstagio.WINBASE.VMLabel lblCpf;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private SlnEstagio.WINBASE.VMLabel lblDataNascimento;
        private SlnEstagio.WINBASE.VMLabel lblNome;
        private SlnEstagio.WINBASE.VMTextBox txtCpf;
        private SlnEstagio.WINBASE.VMTextBox txtNome;
        private SlnEstagio.WINBASE.VMButton btnSalvarCliente;
        private SlnEstagio.WINBASE.VMButton btnFecharCliente;
    }
}