namespace SlnEstagio.MOD001
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEmail = new SlnEstagio.WINBASE.VMButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRegistro = new SlnEstagio.WINBASE.VMTextBox();
            this.lblRegistro = new SlnEstagio.WINBASE.VMLabel();
            this.btnExcluir = new SlnEstagio.WINBASE.VMButton();
            this.btnAlterar = new SlnEstagio.WINBASE.VMButton();
            this.btnInserir = new SlnEstagio.WINBASE.VMButton();
            this.dgwColecao = new SlnEstagio.WINBASE.VMDataGridView();
            this.lblAtivo = new SlnEstagio.WINBASE.VMLabel();
            this.cbxAtivo = new SlnEstagio.WINBASE.VMComboBox();
            this.lblVMPesquisar = new SlnEstagio.WINBASE.VMLabel();
            this.txtVMPesquisar = new SlnEstagio.WINBASE.VMTextBox();
            this.btnPesquisar = new SlnEstagio.WINBASE.VMButton();
            this.btnFechar = new SlnEstagio.WINBASE.VMButton();
            this.gbxVMPesquisarFornecedor = new SlnEstagio.WINBASE.VMGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColecao)).BeginInit();
            this.gbxVMPesquisarFornecedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(454, 364);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 24);
            this.panel2.TabIndex = 6;
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(368, 361);
            this.btnEmail.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(82, 28);
            this.btnEmail.TabIndex = 4;
            this.btnEmail.Text = "E-MAIL";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(676, 364);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 24);
            this.panel1.TabIndex = 10;
            // 
            // txtRegistro
            // 
            this.txtRegistro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRegistro.Location = new System.Drawing.Point(85, 364);
            this.txtRegistro.Margin = new System.Windows.Forms.Padding(2);
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
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(7, 368);
            this.lblRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(73, 13);
            this.lblRegistro.TabIndex = 2;
            this.lblRegistro.Text = "REGISTROS:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(608, 360);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(64, 28);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(528, 360);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(74, 28);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(460, 360);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(64, 28);
            this.btnInserir.TabIndex = 7;
            this.btnInserir.Text = "INSERIR";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // dgwColecao
            // 
            this.dgwColecao.AllowUserToAddRows = false;
            this.dgwColecao.AllowUserToDeleteRows = false;
            this.dgwColecao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwColecao.Location = new System.Drawing.Point(9, 46);
            this.dgwColecao.Margin = new System.Windows.Forms.Padding(2);
            this.dgwColecao.Name = "dgwColecao";
            this.dgwColecao.RowHeadersWidth = 22;
            this.dgwColecao.RowTemplate.Height = 24;
            this.dgwColecao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwColecao.Size = new System.Drawing.Size(737, 310);
            this.dgwColecao.TabIndex = 1;
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.Location = new System.Drawing.Point(512, 18);
            this.lblAtivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(49, 13);
            this.lblAtivo.TabIndex = 2;
            this.lblAtivo.Text = "ATIVOS:";
            // 
            // cbxAtivo
            // 
            this.cbxAtivo.FormattingEnabled = true;
            this.cbxAtivo.GSLabelAssociado = null;
            this.cbxAtivo.Location = new System.Drawing.Point(563, 14);
            this.cbxAtivo.Margin = new System.Windows.Forms.Padding(2);
            this.cbxAtivo.Name = "cbxAtivo";
            this.cbxAtivo.Size = new System.Drawing.Size(62, 21);
            this.cbxAtivo.TabIndex = 3;
            this.cbxAtivo.VMRequerido = false;
            // 
            // lblVMPesquisar
            // 
            this.lblVMPesquisar.AutoSize = true;
            this.lblVMPesquisar.Location = new System.Drawing.Point(4, 18);
            this.lblVMPesquisar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVMPesquisar.Name = "lblVMPesquisar";
            this.lblVMPesquisar.Size = new System.Drawing.Size(72, 13);
            this.lblVMPesquisar.TabIndex = 0;
            this.lblVMPesquisar.Text = "PESQUISAR:";
            // 
            // txtVMPesquisar
            // 
            this.txtVMPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVMPesquisar.Location = new System.Drawing.Point(76, 15);
            this.txtVMPesquisar.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnPesquisar.Location = new System.Drawing.Point(640, 12);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(77, 24);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnVMPesquisar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(682, 360);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(64, 28);
            this.btnFechar.TabIndex = 11;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // gbxVMPesquisarFornecedor
            // 
            this.gbxVMPesquisarFornecedor.Controls.Add(this.lblAtivo);
            this.gbxVMPesquisarFornecedor.Controls.Add(this.cbxAtivo);
            this.gbxVMPesquisarFornecedor.Controls.Add(this.lblVMPesquisar);
            this.gbxVMPesquisarFornecedor.Controls.Add(this.txtVMPesquisar);
            this.gbxVMPesquisarFornecedor.Controls.Add(this.btnPesquisar);
            this.gbxVMPesquisarFornecedor.Location = new System.Drawing.Point(9, 0);
            this.gbxVMPesquisarFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.gbxVMPesquisarFornecedor.Name = "gbxVMPesquisarFornecedor";
            this.gbxVMPesquisarFornecedor.Padding = new System.Windows.Forms.Padding(2);
            this.gbxVMPesquisarFornecedor.Size = new System.Drawing.Size(737, 42);
            this.gbxVMPesquisarFornecedor.TabIndex = 0;
            this.gbxVMPesquisarFornecedor.TabStop = false;
            // 
            // FRM008
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 395);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.dgwColecao);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.gbxVMPesquisarFornecedor);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "FRM008";
            this.Text = "SELECIONAR FORNECEDOR";
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColecao)).EndInit();
            this.gbxVMPesquisarFornecedor.ResumeLayout(false);
            this.gbxVMPesquisarFornecedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private WINBASE.VMButton btnEmail;
        private System.Windows.Forms.Panel panel1;
        private SlnEstagio.WINBASE.VMTextBox txtRegistro;
        private WINBASE.VMLabel lblRegistro;
        private WINBASE.VMButton btnExcluir;
        private WINBASE.VMButton btnAlterar;
        private WINBASE.VMButton btnInserir;
        private SlnEstagio.WINBASE.VMDataGridView dgwColecao;
        private WINBASE.VMLabel lblAtivo;
        private WINBASE.VMComboBox cbxAtivo;
        private WINBASE.VMLabel lblVMPesquisar;
        private SlnEstagio.WINBASE.VMTextBox txtVMPesquisar;
        private WINBASE.VMButton btnPesquisar;
        private WINBASE.VMButton btnFechar;
        private SlnEstagio.WINBASE.VMGroupBox gbxVMPesquisarFornecedor;
    }
}