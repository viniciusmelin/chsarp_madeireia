namespace SlnEstagio.MOD001
{
    partial class FRM028
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
            this.txtRegistros = new SlnEstagio.WINBASE.VMTextBox();
            this.vmLabel3 = new SlnEstagio.WINBASE.VMLabel();
            this.btnExcluir = new SlnEstagio.WINBASE.VMButton();
            this.btnAlterar = new SlnEstagio.WINBASE.VMButton();
            this.btnInserir = new SlnEstagio.WINBASE.VMButton();
            this.btnFechar = new SlnEstagio.WINBASE.VMButton();
            this.gbxVMPesquisarCliente = new SlnEstagio.WINBASE.VMGroupBox();
            this.lblAtivos = new SlnEstagio.WINBASE.VMLabel();
            this.cbxAtivos = new SlnEstagio.WINBASE.VMComboBox();
            this.lblPesquisar = new SlnEstagio.WINBASE.VMLabel();
            this.txtVMPesquisar = new SlnEstagio.WINBASE.VMTextBox();
            this.btnPesquisar = new SlnEstagio.WINBASE.VMButton();
            this.dgwColecao = new SlnEstagio.WINBASE.VMDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            this.gbxVMPesquisarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColecao)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(495, 360);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 24);
            this.panel1.TabIndex = 7;
            // 
            // txtRegistros
            // 
            this.txtRegistros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRegistros.Location = new System.Drawing.Point(81, 366);
            this.txtRegistros.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegistros.Name = "txtRegistros";
            this.txtRegistros.ReadOnly = true;
            this.txtRegistros.Size = new System.Drawing.Size(92, 20);
            this.txtRegistros.TabIndex = 3;
            this.txtRegistros.TabStop = false;
            this.txtRegistros.Text = "0";
            this.txtRegistros.VMLabelAssociado = null;
            this.txtRegistros.VMMascara = null;
            this.txtRegistros.VMPesquisa = false;
            this.txtRegistros.VMPesquisaValor = null;
            this.txtRegistros.VMRequerido = false;
            this.txtRegistros.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtRegistros.VMValor = null;
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
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(413, 360);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(77, 26);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(332, 360);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(77, 26);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(250, 360);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(77, 26);
            this.btnInserir.TabIndex = 4;
            this.btnInserir.Text = "INSERIR";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(500, 360);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(77, 26);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // gbxVMPesquisarCliente
            // 
            this.gbxVMPesquisarCliente.Controls.Add(this.lblAtivos);
            this.gbxVMPesquisarCliente.Controls.Add(this.cbxAtivos);
            this.gbxVMPesquisarCliente.Controls.Add(this.lblPesquisar);
            this.gbxVMPesquisarCliente.Controls.Add(this.txtVMPesquisar);
            this.gbxVMPesquisarCliente.Controls.Add(this.btnPesquisar);
            this.gbxVMPesquisarCliente.Location = new System.Drawing.Point(9, 2);
            this.gbxVMPesquisarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.gbxVMPesquisarCliente.Name = "gbxVMPesquisarCliente";
            this.gbxVMPesquisarCliente.Padding = new System.Windows.Forms.Padding(2);
            this.gbxVMPesquisarCliente.Size = new System.Drawing.Size(568, 47);
            this.gbxVMPesquisarCliente.TabIndex = 0;
            this.gbxVMPesquisarCliente.TabStop = false;
            // 
            // lblAtivos
            // 
            this.lblAtivos.AutoSize = true;
            this.lblAtivos.Location = new System.Drawing.Point(365, 22);
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
            this.cbxAtivos.Location = new System.Drawing.Point(418, 17);
            this.cbxAtivos.Margin = new System.Windows.Forms.Padding(2);
            this.cbxAtivos.Name = "cbxAtivos";
            this.cbxAtivos.Size = new System.Drawing.Size(62, 21);
            this.cbxAtivos.TabIndex = 3;
            this.cbxAtivos.VMRequerido = false;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(4, 21);
            this.lblPesquisar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(72, 13);
            this.lblPesquisar.TabIndex = 0;
            this.lblPesquisar.Text = "PESQUISAR:";
            // 
            // txtVMPesquisar
            // 
            this.txtVMPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVMPesquisar.Location = new System.Drawing.Point(80, 18);
            this.txtVMPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.txtVMPesquisar.Name = "txtVMPesquisar";
            this.txtVMPesquisar.Size = new System.Drawing.Size(281, 20);
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
            this.btnPesquisar.Location = new System.Drawing.Point(484, 13);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(80, 27);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgwColecao
            // 
            this.dgwColecao.AllowUserToAddRows = false;
            this.dgwColecao.AllowUserToDeleteRows = false;
            this.dgwColecao.AllowUserToOrderColumns = true;
            this.dgwColecao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwColecao.Location = new System.Drawing.Point(9, 54);
            this.dgwColecao.Margin = new System.Windows.Forms.Padding(2);
            this.dgwColecao.Name = "dgwColecao";
            this.dgwColecao.RowHeadersWidth = 22;
            this.dgwColecao.RowTemplate.Height = 24;
            this.dgwColecao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwColecao.Size = new System.Drawing.Size(568, 302);
            this.dgwColecao.TabIndex = 1;
            // 
            // FRM028
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 391);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRegistros);
            this.Controls.Add(this.vmLabel3);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.gbxVMPesquisarCliente);
            this.Controls.Add(this.dgwColecao);
            this.Name = "FRM028";
            this.Text = "PESQUISAR TIPO PAGAMENTO";
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            this.gbxVMPesquisarCliente.ResumeLayout(false);
            this.gbxVMPesquisarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColecao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private WINBASE.VMTextBox txtRegistros;
        private WINBASE.VMLabel vmLabel3;
        private WINBASE.VMButton btnExcluir;
        private WINBASE.VMButton btnAlterar;
        private WINBASE.VMButton btnInserir;
        private WINBASE.VMButton btnFechar;
        private WINBASE.VMGroupBox gbxVMPesquisarCliente;
        private WINBASE.VMLabel lblAtivos;
        private WINBASE.VMComboBox cbxAtivos;
        private WINBASE.VMLabel lblPesquisar;
        private WINBASE.VMTextBox txtVMPesquisar;
        private WINBASE.VMButton btnPesquisar;
        public WINBASE.VMDataGridView dgwColecao;
    }
}