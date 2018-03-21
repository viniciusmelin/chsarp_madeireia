namespace SlnEstagio.MOD001
{
    partial class FRM010
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
            this.btnSalvar = new SlnEstagio.WINBASE.VMButton();
            this.btnFechar = new SlnEstagio.WINBASE.VMButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbxInformacao = new SlnEstagio.WINBASE.VMGroupBox();
            this.txtSenhaRepitida = new SlnEstagio.WINBASE.VMTextBox();
            this.vmLabel1 = new SlnEstagio.WINBASE.VMLabel();
            this.btnPesqPessoa = new SlnEstagio.WINBASE.VMButton();
            this.txtUsuario = new SlnEstagio.WINBASE.VMTextBox();
            this.lblUsuario = new SlnEstagio.WINBASE.VMLabel();
            this.txtSenha = new SlnEstagio.WINBASE.VMTextBox();
            this.lblSenha = new SlnEstagio.WINBASE.VMLabel();
            this.txtPessoa = new SlnEstagio.WINBASE.VMTextBox();
            this.lblPessoa = new SlnEstagio.WINBASE.VMLabel();
            this.txtCodigo = new SlnEstagio.WINBASE.VMTextBox();
            this.lblCodigo = new SlnEstagio.WINBASE.VMLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.vmCheckBox5 = new SlnEstagio.WINBASE.VMCheckBox();
            this.vmCheckBox4 = new SlnEstagio.WINBASE.VMCheckBox();
            this.vmCheckBox3 = new SlnEstagio.WINBASE.VMCheckBox();
            this.vmCheckBox2 = new SlnEstagio.WINBASE.VMCheckBox();
            this.vmCheckBox1 = new SlnEstagio.WINBASE.VMCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbxInformacao.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(297, 286);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 24);
            this.panel1.TabIndex = 21;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(229, 285);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(64, 28);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(302, 285);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(64, 28);
            this.btnFechar.TabIndex = 19;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(356, 270);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbxInformacao);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(348, 244);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "USUÁRIO";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbxInformacao
            // 
            this.gbxInformacao.Controls.Add(this.txtSenhaRepitida);
            this.gbxInformacao.Controls.Add(this.vmLabel1);
            this.gbxInformacao.Controls.Add(this.btnPesqPessoa);
            this.gbxInformacao.Controls.Add(this.txtUsuario);
            this.gbxInformacao.Controls.Add(this.lblUsuario);
            this.gbxInformacao.Controls.Add(this.txtSenha);
            this.gbxInformacao.Controls.Add(this.lblSenha);
            this.gbxInformacao.Controls.Add(this.txtPessoa);
            this.gbxInformacao.Controls.Add(this.lblPessoa);
            this.gbxInformacao.Controls.Add(this.txtCodigo);
            this.gbxInformacao.Controls.Add(this.lblCodigo);
            this.gbxInformacao.Location = new System.Drawing.Point(4, 9);
            this.gbxInformacao.Margin = new System.Windows.Forms.Padding(2);
            this.gbxInformacao.Name = "gbxInformacao";
            this.gbxInformacao.Padding = new System.Windows.Forms.Padding(2);
            this.gbxInformacao.Size = new System.Drawing.Size(335, 228);
            this.gbxInformacao.TabIndex = 1;
            this.gbxInformacao.TabStop = false;
            this.gbxInformacao.Text = "INFORMAÇÕES DE USUÁRIO";
            // 
            // txtSenhaRepitida
            // 
            this.txtSenhaRepitida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSenhaRepitida.Location = new System.Drawing.Point(7, 153);
            this.txtSenhaRepitida.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenhaRepitida.Name = "txtSenhaRepitida";
            this.txtSenhaRepitida.PasswordChar = '*';
            this.txtSenhaRepitida.Size = new System.Drawing.Size(212, 20);
            this.txtSenhaRepitida.TabIndex = 24;
            this.txtSenhaRepitida.VMLabelAssociado = null;
            this.txtSenhaRepitida.VMMascara = null;
            this.txtSenhaRepitida.VMPesquisa = false;
            this.txtSenhaRepitida.VMPesquisaValor = null;
            this.txtSenhaRepitida.VMRequerido = true;
            this.txtSenhaRepitida.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtSenhaRepitida.VMValor = null;
            // 
            // vmLabel1
            // 
            this.vmLabel1.AutoSize = true;
            this.vmLabel1.Location = new System.Drawing.Point(4, 138);
            this.vmLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel1.Name = "vmLabel1";
            this.vmLabel1.Size = new System.Drawing.Size(90, 13);
            this.vmLabel1.TabIndex = 23;
            this.vmLabel1.Text = "REPITIR SENHA";
            // 
            // btnPesqPessoa
            // 
            this.btnPesqPessoa.Location = new System.Drawing.Point(222, 187);
            this.btnPesqPessoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesqPessoa.Name = "btnPesqPessoa";
            this.btnPesqPessoa.Size = new System.Drawing.Size(28, 23);
            this.btnPesqPessoa.TabIndex = 22;
            this.btnPesqPessoa.Text = "EXCLUIR";
            this.btnPesqPessoa.UseVisualStyleBackColor = true;
            this.btnPesqPessoa.Click += new System.EventHandler(this.btnPesqPessoa_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Location = new System.Drawing.Point(7, 80);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(210, 20);
            this.txtUsuario.TabIndex = 8;
            this.txtUsuario.VMLabelAssociado = null;
            this.txtUsuario.VMMascara = null;
            this.txtUsuario.VMPesquisa = false;
            this.txtUsuario.VMPesquisaValor = null;
            this.txtUsuario.VMRequerido = true;
            this.txtUsuario.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtUsuario.VMValor = null;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(4, 63);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(56, 13);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "USUÁRIO";
            // 
            // txtSenha
            // 
            this.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSenha.Location = new System.Drawing.Point(7, 116);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(212, 20);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.VMLabelAssociado = null;
            this.txtSenha.VMMascara = null;
            this.txtSenha.VMPesquisa = false;
            this.txtSenha.VMPesquisaValor = null;
            this.txtSenha.VMRequerido = true;
            this.txtSenha.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtSenha.VMValor = null;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(4, 100);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(44, 13);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "SENHA";
            // 
            // txtPessoa
            // 
            this.txtPessoa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPessoa.Location = new System.Drawing.Point(7, 189);
            this.txtPessoa.Margin = new System.Windows.Forms.Padding(2);
            this.txtPessoa.Name = "txtPessoa";
            this.txtPessoa.Size = new System.Drawing.Size(212, 20);
            this.txtPessoa.TabIndex = 4;
            this.txtPessoa.VMLabelAssociado = null;
            this.txtPessoa.VMMascara = null;
            this.txtPessoa.VMPesquisa = false;
            this.txtPessoa.VMPesquisaValor = null;
            this.txtPessoa.VMRequerido = false;
            this.txtPessoa.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtPessoa.VMValor = null;
            // 
            // lblPessoa
            // 
            this.lblPessoa.AutoSize = true;
            this.lblPessoa.Location = new System.Drawing.Point(4, 173);
            this.lblPessoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(50, 13);
            this.lblPessoa.TabIndex = 3;
            this.lblPessoa.Text = "PESSOA";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Location = new System.Drawing.Point(7, 38);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(65, 20);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.VMLabelAssociado = null;
            this.txtCodigo.VMMascara = null;
            this.txtCodigo.VMPesquisa = false;
            this.txtCodigo.VMPesquisaValor = null;
            this.txtCodigo.VMRequerido = false;
            this.txtCodigo.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtCodigo.VMValor = null;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(4, 22);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(33, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "CÓD.";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.vmCheckBox5);
            this.tabPage2.Controls.Add(this.vmCheckBox4);
            this.tabPage2.Controls.Add(this.vmCheckBox3);
            this.tabPage2.Controls.Add(this.vmCheckBox2);
            this.tabPage2.Controls.Add(this.vmCheckBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(348, 244);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ACESSOS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // vmCheckBox5
            // 
            this.vmCheckBox5.AutoSize = true;
            this.vmCheckBox5.Location = new System.Drawing.Point(4, 100);
            this.vmCheckBox5.Margin = new System.Windows.Forms.Padding(2);
            this.vmCheckBox5.Name = "vmCheckBox5";
            this.vmCheckBox5.Size = new System.Drawing.Size(63, 17);
            this.vmCheckBox5.TabIndex = 4;
            this.vmCheckBox5.Text = "SENHA";
            this.vmCheckBox5.UseVisualStyleBackColor = true;
            // 
            // vmCheckBox4
            // 
            this.vmCheckBox4.AutoSize = true;
            this.vmCheckBox4.Location = new System.Drawing.Point(4, 29);
            this.vmCheckBox4.Margin = new System.Windows.Forms.Padding(2);
            this.vmCheckBox4.Name = "vmCheckBox4";
            this.vmCheckBox4.Size = new System.Drawing.Size(76, 17);
            this.vmCheckBox4.TabIndex = 3;
            this.vmCheckBox4.Text = "ALTERAR";
            this.vmCheckBox4.UseVisualStyleBackColor = true;
            // 
            // vmCheckBox3
            // 
            this.vmCheckBox3.AutoSize = true;
            this.vmCheckBox3.Location = new System.Drawing.Point(4, 54);
            this.vmCheckBox3.Margin = new System.Windows.Forms.Padding(2);
            this.vmCheckBox3.Name = "vmCheckBox3";
            this.vmCheckBox3.Size = new System.Drawing.Size(72, 17);
            this.vmCheckBox3.TabIndex = 2;
            this.vmCheckBox3.Text = "EXCLUIR";
            this.vmCheckBox3.UseVisualStyleBackColor = true;
            // 
            // vmCheckBox2
            // 
            this.vmCheckBox2.AutoSize = true;
            this.vmCheckBox2.Location = new System.Drawing.Point(4, 78);
            this.vmCheckBox2.Margin = new System.Windows.Forms.Padding(2);
            this.vmCheckBox2.Name = "vmCheckBox2";
            this.vmCheckBox2.Size = new System.Drawing.Size(88, 17);
            this.vmCheckBox2.TabIndex = 1;
            this.vmCheckBox2.Text = "PESQUISAR";
            this.vmCheckBox2.UseVisualStyleBackColor = true;
            // 
            // vmCheckBox1
            // 
            this.vmCheckBox1.AutoSize = true;
            this.vmCheckBox1.Location = new System.Drawing.Point(4, 5);
            this.vmCheckBox1.Margin = new System.Windows.Forms.Padding(2);
            this.vmCheckBox1.Name = "vmCheckBox1";
            this.vmCheckBox1.Size = new System.Drawing.Size(70, 17);
            this.vmCheckBox1.TabIndex = 0;
            this.vmCheckBox1.Text = "INSERIR";
            this.vmCheckBox1.UseVisualStyleBackColor = true;
            // 
            // FRM010
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 317);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFechar);
            this.Name = "FRM010";
            this.Text = "CADASTRAR USUÁRIO";
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbxInformacao.ResumeLayout(false);
            this.gbxInformacao.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private WINBASE.VMButton btnSalvar;
        private WINBASE.VMButton btnFechar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private WINBASE.VMGroupBox gbxInformacao;
        private WINBASE.VMButton btnPesqPessoa;
        private WINBASE.VMTextBox txtUsuario;
        private WINBASE.VMLabel lblUsuario;
        private WINBASE.VMTextBox txtSenha;
        private WINBASE.VMLabel lblSenha;
        private WINBASE.VMTextBox txtPessoa;
        private WINBASE.VMLabel lblPessoa;
        private WINBASE.VMTextBox txtCodigo;
        private WINBASE.VMLabel lblCodigo;
        private System.Windows.Forms.TabPage tabPage2;
        private WINBASE.VMCheckBox vmCheckBox4;
        private WINBASE.VMCheckBox vmCheckBox3;
        private WINBASE.VMCheckBox vmCheckBox2;
        private WINBASE.VMCheckBox vmCheckBox1;
        private WINBASE.VMCheckBox vmCheckBox5;
        private WINBASE.VMTextBox txtSenhaRepitida;
        private WINBASE.VMLabel vmLabel1;
    }
}