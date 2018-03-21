namespace SlnEstagio.Carregar
{
    partial class Form1
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
            this.txtUsuario = new SlnEstagio.WINBASE.VMTextBox();
            this.txtSenha = new SlnEstagio.WINBASE.VMTextBox();
            this.btnCancelar = new SlnEstagio.WINBASE.VMButton();
            this.btnEntrar = new SlnEstagio.WINBASE.VMButton();
            this.lblSenha = new SlnEstagio.WINBASE.VMLabel();
            this.vmLabel2 = new SlnEstagio.WINBASE.VMLabel();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(12, 38);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(299, 22);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.VMPesquisa = false;
            this.txtUsuario.VMPesquisaValor = null;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(12, 83);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(299, 22);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.VMPesquisa = false;
            this.txtSenha.VMPesquisaValor = null;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(236, 111);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 34);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(155, 111);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 34);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(9, 63);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 17);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha";
            // 
            // vmLabel2
            // 
            this.vmLabel2.AutoSize = true;
            this.vmLabel2.Location = new System.Drawing.Point(9, 18);
            this.vmLabel2.Name = "vmLabel2";
            this.vmLabel2.Size = new System.Drawing.Size(57, 17);
            this.vmLabel2.TabIndex = 0;
            this.vmLabel2.Text = "Usuário";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 159);
            this.Controls.Add(this.vmLabel2);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SlnEstagio.WINBASE.VMTextBox txtUsuario;
        private SlnEstagio.WINBASE.VMTextBox txtSenha;
        private SlnEstagio.WINBASE.VMButton btnCancelar;
        private SlnEstagio.WINBASE.VMButton btnEntrar;
        private SlnEstagio.WINBASE.VMLabel lblSenha;
        private SlnEstagio.WINBASE.VMLabel vmLabel2;
    }
}

