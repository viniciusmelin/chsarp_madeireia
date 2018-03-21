namespace SlnEstagio.MOD001
{
    partial class FRM013
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
            this.lblRegistros = new SlnEstagio.WINBASE.VMLabel();
            this.btnExcluir = new SlnEstagio.WINBASE.VMButton();
            this.btnAlterar = new SlnEstagio.WINBASE.VMButton();
            this.btnInseir = new SlnEstagio.WINBASE.VMButton();
            this.dgwColecao = new SlnEstagio.WINBASE.VMDataGridView();
            this.lblAtivo = new SlnEstagio.WINBASE.VMLabel();
            this.cbxAtivos = new SlnEstagio.WINBASE.VMComboBox();
            this.lblVMPesquisar = new SlnEstagio.WINBASE.VMLabel();
            this.txtVMPesquisar = new SlnEstagio.WINBASE.VMTextBox();
            this.btnVMPesquisar = new SlnEstagio.WINBASE.VMButton();
            this.btnFechar = new SlnEstagio.WINBASE.VMButton();
            this.gbxInformacao = new SlnEstagio.WINBASE.VMGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColecao)).BeginInit();
            this.gbxInformacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(667, 362);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 24);
            this.panel1.TabIndex = 9;
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
            this.txtRegistros.VMLabelAssociado = null;
            this.txtRegistros.VMMascara = null;
            this.txtRegistros.VMPesquisa = false;
            this.txtRegistros.VMPesquisaValor = null;
            this.txtRegistros.VMRequerido = false;
            this.txtRegistros.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtRegistros.VMValor = null;
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Location = new System.Drawing.Point(7, 370);
            this.lblRegistros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(73, 13);
            this.lblRegistros.TabIndex = 2;
            this.lblRegistros.Text = "REGISTROS:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(588, 362);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(74, 28);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(502, 362);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(81, 28);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInseir
            // 
            this.btnInseir.Location = new System.Drawing.Point(424, 362);
            this.btnInseir.Margin = new System.Windows.Forms.Padding(2);
            this.btnInseir.Name = "btnInseir";
            this.btnInseir.Size = new System.Drawing.Size(74, 28);
            this.btnInseir.TabIndex = 6;
            this.btnInseir.Text = "INSERIR";
            this.btnInseir.UseVisualStyleBackColor = true;
            this.btnInseir.Click += new System.EventHandler(this.btnInseir_Click);
            // 
            // dgwColecao
            // 
            this.dgwColecao.AllowUserToAddRows = false;
            this.dgwColecao.AllowUserToDeleteRows = false;
            this.dgwColecao.AllowUserToOrderColumns = true;
            this.dgwColecao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwColecao.Location = new System.Drawing.Point(9, 65);
            this.dgwColecao.Margin = new System.Windows.Forms.Padding(2);
            this.dgwColecao.Name = "dgwColecao";
            this.dgwColecao.RowHeadersWidth = 22;
            this.dgwColecao.RowTemplate.Height = 24;
            this.dgwColecao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwColecao.Size = new System.Drawing.Size(737, 291);
            this.dgwColecao.TabIndex = 1;
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.Location = new System.Drawing.Point(520, 19);
            this.lblAtivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(49, 13);
            this.lblAtivo.TabIndex = 2;
            this.lblAtivo.Text = "ATIVOS:";
            // 
            // cbxAtivos
            // 
            this.cbxAtivos.FormattingEnabled = true;
            this.cbxAtivos.GSLabelAssociado = null;
            this.cbxAtivos.Location = new System.Drawing.Point(573, 15);
            this.cbxAtivos.Margin = new System.Windows.Forms.Padding(2);
            this.cbxAtivos.Name = "cbxAtivos";
            this.cbxAtivos.Size = new System.Drawing.Size(62, 21);
            this.cbxAtivos.TabIndex = 3;
            this.cbxAtivos.VMRequerido = false;
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
            this.txtVMPesquisar.Location = new System.Drawing.Point(77, 15);
            this.txtVMPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.txtVMPesquisar.Name = "txtVMPesquisar";
            this.txtVMPesquisar.Size = new System.Drawing.Size(439, 20);
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
            // btnVMPesquisar
            // 
            this.btnVMPesquisar.Location = new System.Drawing.Point(639, 13);
            this.btnVMPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVMPesquisar.Name = "btnVMPesquisar";
            this.btnVMPesquisar.Size = new System.Drawing.Size(77, 24);
            this.btnVMPesquisar.TabIndex = 4;
            this.btnVMPesquisar.Text = "PESQUISAR";
            this.btnVMPesquisar.UseVisualStyleBackColor = true;
            this.btnVMPesquisar.Click += new System.EventHandler(this.btnVMPesquisar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(672, 362);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(74, 28);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // gbxInformacao
            // 
            this.gbxInformacao.Controls.Add(this.lblAtivo);
            this.gbxInformacao.Controls.Add(this.cbxAtivos);
            this.gbxInformacao.Controls.Add(this.lblVMPesquisar);
            this.gbxInformacao.Controls.Add(this.txtVMPesquisar);
            this.gbxInformacao.Controls.Add(this.btnVMPesquisar);
            this.gbxInformacao.Location = new System.Drawing.Point(9, 10);
            this.gbxInformacao.Margin = new System.Windows.Forms.Padding(2);
            this.gbxInformacao.Name = "gbxInformacao";
            this.gbxInformacao.Padding = new System.Windows.Forms.Padding(2);
            this.gbxInformacao.Size = new System.Drawing.Size(737, 50);
            this.gbxInformacao.TabIndex = 0;
            this.gbxInformacao.TabStop = false;
            // 
            // FRM013
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 396);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRegistros);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInseir);
            this.Controls.Add(this.dgwColecao);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.gbxInformacao);
            this.Name = "FRM013";
            this.Text = "PESQUISAR PRODUTO";
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColecao)).EndInit();
            this.gbxInformacao.ResumeLayout(false);
            this.gbxInformacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private SlnEstagio.WINBASE.VMTextBox txtRegistros;
        private WINBASE.VMLabel lblRegistros;
        private WINBASE.VMButton btnExcluir;
        private WINBASE.VMButton btnAlterar;
        private WINBASE.VMButton btnInseir;
        private SlnEstagio.WINBASE.VMDataGridView dgwColecao;
        private WINBASE.VMLabel lblAtivo;
        private WINBASE.VMComboBox cbxAtivos;
        private WINBASE.VMLabel lblVMPesquisar;
        private SlnEstagio.WINBASE.VMTextBox txtVMPesquisar;
        private WINBASE.VMButton btnVMPesquisar;
        private WINBASE.VMButton btnFechar;
        private SlnEstagio.WINBASE.VMGroupBox gbxInformacao;
    }
}