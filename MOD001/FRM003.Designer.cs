namespace SlnEstagio.MOD001
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
            this.gbxVMPesquisarCliente = new SlnEstagio.WINBASE.VMGroupBox();
            this.lblAtivos = new SlnEstagio.WINBASE.VMLabel();
            this.cbxAtivos = new SlnEstagio.WINBASE.VMComboBox();
            this.lblPesquisar = new SlnEstagio.WINBASE.VMLabel();
            this.txtVMPesquisar = new SlnEstagio.WINBASE.VMTextBox();
            this.btnPesquisar = new SlnEstagio.WINBASE.VMButton();
            this.dgwColecao = new SlnEstagio.WINBASE.VMDataGridView();
            this.btnFechar = new SlnEstagio.WINBASE.VMButton();
            this.btnInserir = new SlnEstagio.WINBASE.VMButton();
            this.btnAlterar = new SlnEstagio.WINBASE.VMButton();
            this.btnExcluir = new SlnEstagio.WINBASE.VMButton();
            this.vmLabel3 = new SlnEstagio.WINBASE.VMLabel();
            this.txtRegistro = new SlnEstagio.WINBASE.VMTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEndereco = new SlnEstagio.WINBASE.VMButton();
            this.btnEmail = new SlnEstagio.WINBASE.VMButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            this.gbxVMPesquisarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColecao)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // gbxVMPesquisarCliente
            // 
            this.gbxVMPesquisarCliente.BackColor = System.Drawing.Color.Transparent;
            this.gbxVMPesquisarCliente.Controls.Add(this.lblAtivos);
            this.gbxVMPesquisarCliente.Controls.Add(this.cbxAtivos);
            this.gbxVMPesquisarCliente.Controls.Add(this.lblPesquisar);
            this.gbxVMPesquisarCliente.Controls.Add(this.txtVMPesquisar);
            this.gbxVMPesquisarCliente.Controls.Add(this.btnPesquisar);
            this.gbxVMPesquisarCliente.Location = new System.Drawing.Point(9, 10);
            this.gbxVMPesquisarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxVMPesquisarCliente.Name = "gbxVMPesquisarCliente";
            this.gbxVMPesquisarCliente.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxVMPesquisarCliente.Size = new System.Drawing.Size(759, 50);
            this.gbxVMPesquisarCliente.TabIndex = 0;
            this.gbxVMPesquisarCliente.TabStop = false;
            // 
            // lblAtivos
            // 
            this.lblAtivos.AutoSize = true;
            this.lblAtivos.Location = new System.Drawing.Point(506, 18);
            this.lblAtivos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAtivos.Name = "lblAtivos";
            this.lblAtivos.Size = new System.Drawing.Size(49, 13);
            this.lblAtivos.TabIndex = 2;
            this.lblAtivos.Text = "ATIVOS:";
            // 
            // cbxAtivos
            // 
            this.cbxAtivos.FormattingEnabled = true;
            this.cbxAtivos.GSLabelAssociado = null;
            this.cbxAtivos.Location = new System.Drawing.Point(556, 15);
            this.cbxAtivos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxAtivos.Name = "cbxAtivos";
            this.cbxAtivos.Size = new System.Drawing.Size(62, 21);
            this.cbxAtivos.TabIndex = 3;
            this.cbxAtivos.VMRequerido = false;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(4, 18);
            this.lblPesquisar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(72, 13);
            this.lblPesquisar.TabIndex = 0;
            this.lblPesquisar.Text = "PESQUISAR:";
            // 
            // txtVMPesquisar
            // 
            this.txtVMPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVMPesquisar.Location = new System.Drawing.Point(77, 15);
            this.txtVMPesquisar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVMPesquisar.Name = "txtVMPesquisar";
            this.txtVMPesquisar.Size = new System.Drawing.Size(425, 20);
            this.txtVMPesquisar.TabIndex = 1;
            this.txtVMPesquisar.VMLabelAssociado = null;
            this.txtVMPesquisar.VMMascara = null;
            this.txtVMPesquisar.VMPesquisa = false;
            this.txtVMPesquisar.VMPesquisaValor = null;
            this.txtVMPesquisar.VMRequerido = false;
            this.txtVMPesquisar.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtVMPesquisar.VMValor = null;
            this.txtVMPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVMPesquisar_KeyDown);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(632, 10);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(77, 29);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnVMPesquisar_Click);
            // 
            // dgwColecao
            // 
            this.dgwColecao.AllowUserToAddRows = false;
            this.dgwColecao.AllowUserToDeleteRows = false;
            this.dgwColecao.AllowUserToOrderColumns = true;
            this.dgwColecao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwColecao.Location = new System.Drawing.Point(9, 65);
            this.dgwColecao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgwColecao.Name = "dgwColecao";
            this.dgwColecao.RowHeadersWidth = 22;
            this.dgwColecao.RowTemplate.Height = 24;
            this.dgwColecao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwColecao.Size = new System.Drawing.Size(759, 291);
            this.dgwColecao.TabIndex = 1;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(704, 360);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(64, 28);
            this.btnFechar.TabIndex = 11;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(488, 361);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(64, 28);
            this.btnInserir.TabIndex = 7;
            this.btnInserir.Text = "INSERIR";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(556, 360);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(68, 28);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(629, 360);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(64, 28);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // vmLabel3
            // 
            this.vmLabel3.AutoSize = true;
            this.vmLabel3.Location = new System.Drawing.Point(7, 370);
            this.vmLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel3.Name = "vmLabel3";
            this.vmLabel3.Size = new System.Drawing.Size(73, 13);
            this.vmLabel3.TabIndex = 2;
            this.vmLabel3.Text = "REGISTROS:";
            // 
            // txtRegistro
            // 
            this.txtRegistro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRegistro.Location = new System.Drawing.Point(81, 366);
            this.txtRegistro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.ReadOnly = true;
            this.txtRegistro.Size = new System.Drawing.Size(92, 20);
            this.txtRegistro.TabIndex = 3;
            this.txtRegistro.Text = "0";
            this.txtRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRegistro.VMLabelAssociado = null;
            this.txtRegistro.VMMascara = null;
            this.txtRegistro.VMPesquisa = false;
            this.txtRegistro.VMPesquisaValor = null;
            this.txtRegistro.VMRequerido = false;
            this.txtRegistro.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtRegistro.VMValor = null;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(698, 363);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 24);
            this.panel1.TabIndex = 10;
            // 
            // btnEndereco
            // 
            this.btnEndereco.Location = new System.Drawing.Point(395, 361);
            this.btnEndereco.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEndereco.Name = "btnEndereco";
            this.btnEndereco.Size = new System.Drawing.Size(82, 28);
            this.btnEndereco.TabIndex = 5;
            this.btnEndereco.Text = "ENDEREÇO";
            this.btnEndereco.UseVisualStyleBackColor = true;
            this.btnEndereco.Click += new System.EventHandler(this.btnEndereco_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(308, 361);
            this.btnEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(82, 28);
            this.btnEmail.TabIndex = 4;
            this.btnEmail.Text = "E-MAIL";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(482, 364);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 24);
            this.panel2.TabIndex = 6;
            // 
            // FRM003
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 392);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnEndereco);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.vmLabel3);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.gbxVMPesquisarCliente);
            this.Controls.Add(this.dgwColecao);
            this.Name = "FRM003";
            this.Text = "SELECIONAR CLIENTE";
            this.Shown += new System.EventHandler(this.FRM003_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            this.gbxVMPesquisarCliente.ResumeLayout(false);
            this.gbxVMPesquisarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColecao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SlnEstagio.WINBASE.VMButton btnPesquisar;
        private SlnEstagio.WINBASE.VMTextBox txtVMPesquisar;
        private SlnEstagio.WINBASE.VMGroupBox gbxVMPesquisarCliente;
        private SlnEstagio.WINBASE.VMLabel lblPesquisar;
        private SlnEstagio.WINBASE.VMLabel lblAtivos;
        private SlnEstagio.WINBASE.VMComboBox cbxAtivos;
        private SlnEstagio.WINBASE.VMButton btnFechar;
        private SlnEstagio.WINBASE.VMButton btnInserir;
        private SlnEstagio.WINBASE.VMButton btnAlterar;
        private SlnEstagio.WINBASE.VMButton btnExcluir;
        private SlnEstagio.WINBASE.VMLabel vmLabel3;
        private SlnEstagio.WINBASE.VMTextBox txtRegistro;
        private System.Windows.Forms.Panel panel1;
        private SlnEstagio.WINBASE.VMButton btnEndereco;
        private SlnEstagio.WINBASE.VMButton btnEmail;
        private System.Windows.Forms.Panel panel2;
        public WINBASE.VMDataGridView dgwColecao;
    }
}