namespace SlnEstagio.MOD001
{
    partial class FRM031
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
            this.vmGroupBox1 = new SlnEstagio.WINBASE.VMGroupBox();
            this.vmGroupBox2 = new SlnEstagio.WINBASE.VMGroupBox();
            this.rbtNao = new SlnEstagio.WINBASE.VMRadioButton();
            this.rbtSim = new SlnEstagio.WINBASE.VMRadioButton();
            this.txtDescricao = new SlnEstagio.WINBASE.VMTextBox();
            this.lblDescricao = new SlnEstagio.WINBASE.VMLabel();
            this.txtCodigo = new SlnEstagio.WINBASE.VMTextBox();
            this.lblCodigo = new SlnEstagio.WINBASE.VMLabel();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            this.vmGroupBox1.SuspendLayout();
            this.vmGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(302, 159);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "&FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(221, 159);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "&SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // vmGroupBox1
            // 
            this.vmGroupBox1.Controls.Add(this.vmGroupBox2);
            this.vmGroupBox1.Controls.Add(this.txtDescricao);
            this.vmGroupBox1.Controls.Add(this.lblDescricao);
            this.vmGroupBox1.Controls.Add(this.txtCodigo);
            this.vmGroupBox1.Controls.Add(this.lblCodigo);
            this.vmGroupBox1.Location = new System.Drawing.Point(4, 3);
            this.vmGroupBox1.Name = "vmGroupBox1";
            this.vmGroupBox1.Size = new System.Drawing.Size(373, 150);
            this.vmGroupBox1.TabIndex = 0;
            this.vmGroupBox1.TabStop = false;
            // 
            // vmGroupBox2
            // 
            this.vmGroupBox2.Controls.Add(this.rbtNao);
            this.vmGroupBox2.Controls.Add(this.rbtSim);
            this.vmGroupBox2.Location = new System.Drawing.Point(5, 94);
            this.vmGroupBox2.Name = "vmGroupBox2";
            this.vmGroupBox2.Size = new System.Drawing.Size(109, 44);
            this.vmGroupBox2.TabIndex = 4;
            this.vmGroupBox2.TabStop = false;
            this.vmGroupBox2.Text = "ATIVO";
            // 
            // rbtNao
            // 
            this.rbtNao.AutoSize = true;
            this.rbtNao.Location = new System.Drawing.Point(55, 19);
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
            this.rbtSim.Location = new System.Drawing.Point(7, 20);
            this.rbtSim.Name = "rbtSim";
            this.rbtSim.Size = new System.Drawing.Size(44, 17);
            this.rbtSim.TabIndex = 0;
            this.rbtSim.TabStop = true;
            this.rbtSim.Text = "SIM";
            this.rbtSim.UseVisualStyleBackColor = true;
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(5, 68);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(363, 20);
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.VMLabelAssociado = null;
            this.txtDescricao.VMMascara = null;
            this.txtDescricao.VMPesquisa = false;
            this.txtDescricao.VMPesquisaValor = null;
            this.txtDescricao.VMRequerido = false;
            this.txtDescricao.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtDescricao.VMValor = null;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(5, 52);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(69, 13);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "DESCRIÇÃO";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Location = new System.Drawing.Point(5, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(66, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.Text = "0";
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.lblCodigo.Location = new System.Drawing.Point(5, 13);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "CÓDIGO";
            // 
            // FRM031
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 188);
            this.Controls.Add(this.vmGroupBox1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFechar);
            this.Name = "FRM031";
            this.Text = "CADASTRAR CONTAS A PAGAR TIPO";
            this.Shown += new System.EventHandler(this.FRM031_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            this.vmGroupBox1.ResumeLayout(false);
            this.vmGroupBox1.PerformLayout();
            this.vmGroupBox2.ResumeLayout(false);
            this.vmGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private WINBASE.VMButton btnFechar;
        private WINBASE.VMButton btnSalvar;
        private WINBASE.VMGroupBox vmGroupBox1;
        private WINBASE.VMGroupBox vmGroupBox2;
        private WINBASE.VMRadioButton rbtNao;
        private WINBASE.VMRadioButton rbtSim;
        private WINBASE.VMTextBox txtDescricao;
        private WINBASE.VMLabel lblDescricao;
        private WINBASE.VMTextBox txtCodigo;
        private WINBASE.VMLabel lblCodigo;
    }
}