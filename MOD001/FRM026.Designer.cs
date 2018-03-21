namespace SlnEstagio.MOD001
{
    partial class FRM026
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
            this.btnExcluir = new SlnEstagio.WINBASE.VMButton();
            this.btnAlterar = new SlnEstagio.WINBASE.VMButton();
            this.btnInserir = new SlnEstagio.WINBASE.VMButton();
            this.btnFechar = new SlnEstagio.WINBASE.VMButton();
            this.dgwColecao = new SlnEstagio.WINBASE.VMDataGridView();
            this.vmGroupBox1 = new SlnEstagio.WINBASE.VMGroupBox();
            this.txtNomeCliente = new SlnEstagio.WINBASE.VMTextBox();
            this.lblClienteNome = new SlnEstagio.WINBASE.VMLabel();
            this.txtRegistro = new SlnEstagio.WINBASE.VMTextBox();
            this.vmLabel3 = new SlnEstagio.WINBASE.VMLabel();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColecao)).BeginInit();
            this.vmGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(577, 296);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 24);
            this.panel1.TabIndex = 12;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(508, 292);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(64, 28);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(433, 292);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(70, 28);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(364, 292);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(64, 28);
            this.btnInserir.TabIndex = 9;
            this.btnInserir.Text = "INSERIR";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(582, 292);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(64, 28);
            this.btnFechar.TabIndex = 13;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // dgwColecao
            // 
            this.dgwColecao.AllowUserToAddRows = false;
            this.dgwColecao.AllowUserToDeleteRows = false;
            this.dgwColecao.AllowUserToOrderColumns = true;
            this.dgwColecao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwColecao.Location = new System.Drawing.Point(9, 60);
            this.dgwColecao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgwColecao.Name = "dgwColecao";
            this.dgwColecao.RowHeadersWidth = 22;
            this.dgwColecao.RowTemplate.Height = 24;
            this.dgwColecao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwColecao.Size = new System.Drawing.Size(638, 227);
            this.dgwColecao.TabIndex = 8;
            // 
            // vmGroupBox1
            // 
            this.vmGroupBox1.Controls.Add(this.txtNomeCliente);
            this.vmGroupBox1.Controls.Add(this.lblClienteNome);
            this.vmGroupBox1.Location = new System.Drawing.Point(9, 2);
            this.vmGroupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vmGroupBox1.Name = "vmGroupBox1";
            this.vmGroupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vmGroupBox1.Size = new System.Drawing.Size(638, 54);
            this.vmGroupBox1.TabIndex = 7;
            this.vmGroupBox1.TabStop = false;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCliente.Location = new System.Drawing.Point(128, 20);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(492, 20);
            this.txtNomeCliente.TabIndex = 1;
            this.txtNomeCliente.VMLabelAssociado = null;
            this.txtNomeCliente.VMMascara = null;
            this.txtNomeCliente.VMPesquisa = false;
            this.txtNomeCliente.VMPesquisaValor = null;
            this.txtNomeCliente.VMRequerido = false;
            this.txtNomeCliente.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtNomeCliente.VMValor = null;
            // 
            // lblClienteNome
            // 
            this.lblClienteNome.AutoSize = true;
            this.lblClienteNome.Location = new System.Drawing.Point(4, 24);
            this.lblClienteNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClienteNome.Name = "lblClienteNome";
            this.lblClienteNome.Size = new System.Drawing.Size(125, 13);
            this.lblClienteNome.TabIndex = 0;
            this.lblClienteNome.Text = "NOME/RAZÃO SOCIAL:";
            // 
            // txtRegistro
            // 
            this.txtRegistro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRegistro.Location = new System.Drawing.Point(83, 292);
            this.txtRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.ReadOnly = true;
            this.txtRegistro.Size = new System.Drawing.Size(92, 20);
            this.txtRegistro.TabIndex = 18;
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
            // vmLabel3
            // 
            this.vmLabel3.AutoSize = true;
            this.vmLabel3.Location = new System.Drawing.Point(6, 296);
            this.vmLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel3.Name = "vmLabel3";
            this.vmLabel3.Size = new System.Drawing.Size(73, 13);
            this.vmLabel3.TabIndex = 17;
            this.vmLabel3.Text = "REGISTROS:";
            // 
            // FRM026
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 323);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.vmLabel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dgwColecao);
            this.Controls.Add(this.vmGroupBox1);
            this.Name = "FRM026";
            this.Text = "PESQUISAR E-MAIL VENDEDOR";
            this.Shown += new System.EventHandler(this.FRM026_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColecao)).EndInit();
            this.vmGroupBox1.ResumeLayout(false);
            this.vmGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private WINBASE.VMButton btnExcluir;
        private WINBASE.VMButton btnAlterar;
        private WINBASE.VMButton btnInserir;
        private WINBASE.VMButton btnFechar;
        private WINBASE.VMDataGridView dgwColecao;
        private WINBASE.VMGroupBox vmGroupBox1;
        private WINBASE.VMTextBox txtNomeCliente;
        private WINBASE.VMLabel lblClienteNome;
        private WINBASE.VMTextBox txtRegistro;
        private WINBASE.VMLabel vmLabel3;
    }
}