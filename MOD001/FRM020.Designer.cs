namespace SlnEstagio.MOD001
{
    partial class FRM020
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
            this.dgwColecao = new SlnEstagio.WINBASE.VMDataGridView();
            this.gbxInformacao = new SlnEstagio.WINBASE.VMGroupBox();
            this.cbxAtivos = new SlnEstagio.WINBASE.VMComboBox();
            this.txtPesquisar = new SlnEstagio.WINBASE.VMTextBox();
            this.btnVMPesquisar = new SlnEstagio.WINBASE.VMButton();
            this.lblAtivo = new SlnEstagio.WINBASE.VMLabel();
            this.lblVMPesquisar = new SlnEstagio.WINBASE.VMLabel();
            this.btnFechar = new SlnEstagio.WINBASE.VMButton();
            this.btnSelecionar = new SlnEstagio.WINBASE.VMButton();
            this.txtRegistros = new SlnEstagio.WINBASE.VMTextBox();
            this.lblRegistro = new SlnEstagio.WINBASE.VMLabel();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColecao)).BeginInit();
            this.gbxInformacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // dgwColecao
            // 
            this.dgwColecao.AllowUserToAddRows = false;
            this.dgwColecao.AllowUserToDeleteRows = false;
            this.dgwColecao.AllowUserToOrderColumns = true;
            this.dgwColecao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwColecao.Location = new System.Drawing.Point(9, 58);
            this.dgwColecao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgwColecao.Name = "dgwColecao";
            this.dgwColecao.RowHeadersWidth = 22;
            this.dgwColecao.RowTemplate.Height = 24;
            this.dgwColecao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwColecao.Size = new System.Drawing.Size(485, 327);
            this.dgwColecao.TabIndex = 1;
            // 
            // gbxInformacao
            // 
            this.gbxInformacao.Controls.Add(this.cbxAtivos);
            this.gbxInformacao.Controls.Add(this.txtPesquisar);
            this.gbxInformacao.Controls.Add(this.btnVMPesquisar);
            this.gbxInformacao.Controls.Add(this.lblAtivo);
            this.gbxInformacao.Controls.Add(this.lblVMPesquisar);
            this.gbxInformacao.Location = new System.Drawing.Point(9, 4);
            this.gbxInformacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxInformacao.Name = "gbxInformacao";
            this.gbxInformacao.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxInformacao.Size = new System.Drawing.Size(485, 49);
            this.gbxInformacao.TabIndex = 0;
            this.gbxInformacao.TabStop = false;
            // 
            // cbxAtivos
            // 
            this.cbxAtivos.FormattingEnabled = true;
            this.cbxAtivos.GSLabelAssociado = null;
            this.cbxAtivos.Location = new System.Drawing.Point(314, 18);
            this.cbxAtivos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxAtivos.Name = "cbxAtivos";
            this.cbxAtivos.Size = new System.Drawing.Size(83, 21);
            this.cbxAtivos.TabIndex = 3;
            this.cbxAtivos.VMRequerido = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisar.Location = new System.Drawing.Point(80, 18);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(168, 20);
            this.txtPesquisar.TabIndex = 1;
            this.txtPesquisar.VMLabelAssociado = null;
            this.txtPesquisar.VMMascara = null;
            this.txtPesquisar.VMPesquisa = false;
            this.txtPesquisar.VMPesquisaValor = null;
            this.txtPesquisar.VMRequerido = false;
            this.txtPesquisar.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtPesquisar.VMValor = null;
            // 
            // btnVMPesquisar
            // 
            this.btnVMPesquisar.Location = new System.Drawing.Point(401, 13);
            this.btnVMPesquisar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVMPesquisar.Name = "btnVMPesquisar";
            this.btnVMPesquisar.Size = new System.Drawing.Size(79, 28);
            this.btnVMPesquisar.TabIndex = 4;
            this.btnVMPesquisar.Text = "PESQUISAR";
            this.btnVMPesquisar.UseVisualStyleBackColor = true;
            this.btnVMPesquisar.Click += new System.EventHandler(this.btnVMPesquisar_Click);
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.Location = new System.Drawing.Point(261, 21);
            this.lblAtivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(49, 13);
            this.lblAtivo.TabIndex = 2;
            this.lblAtivo.Text = "ATIVOS:";
            // 
            // lblVMPesquisar
            // 
            this.lblVMPesquisar.AutoSize = true;
            this.lblVMPesquisar.Location = new System.Drawing.Point(4, 21);
            this.lblVMPesquisar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVMPesquisar.Name = "lblVMPesquisar";
            this.lblVMPesquisar.Size = new System.Drawing.Size(72, 13);
            this.lblVMPesquisar.TabIndex = 0;
            this.lblVMPesquisar.Text = "PESQUISAR:";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(430, 390);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(64, 28);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(339, 390);
            this.btnSelecionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(87, 28);
            this.btnSelecionar.TabIndex = 4;
            this.btnSelecionar.Text = "SELECIONAR";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // txtRegistros
            // 
            this.txtRegistros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRegistros.Location = new System.Drawing.Point(86, 394);
            this.txtRegistros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRegistros.Name = "txtRegistros";
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
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(9, 397);
            this.lblRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(73, 13);
            this.lblRegistro.TabIndex = 2;
            this.lblRegistro.Text = "REGISTROS:";
            // 
            // FRM020
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 422);
            this.Controls.Add(this.txtRegistros);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.gbxInformacao);
            this.Controls.Add(this.dgwColecao);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Name = "FRM020";
            this.Text = "PESQUISAR CLIENTE";
            this.Shown += new System.EventHandler(this.FRM020_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColecao)).EndInit();
            this.gbxInformacao.ResumeLayout(false);
            this.gbxInformacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WINBASE.VMDataGridView dgwColecao;
        private WINBASE.VMGroupBox gbxInformacao;
        private WINBASE.VMLabel lblAtivo;
        private WINBASE.VMLabel lblVMPesquisar;
        private WINBASE.VMButton btnFechar;
        private WINBASE.VMButton btnSelecionar;
        private WINBASE.VMButton btnVMPesquisar;
        private WINBASE.VMTextBox txtRegistros;
        private WINBASE.VMLabel lblRegistro;
        private WINBASE.VMTextBox txtPesquisar;
        private WINBASE.VMComboBox cbxAtivos;
    }
}