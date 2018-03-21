namespace SlnEstagio.MOD001
{
    partial class FRM009
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
            this.txtRegistro = new SlnEstagio.WINBASE.VMTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRegistro = new SlnEstagio.WINBASE.VMLabel();
            this.btnExcluir = new SlnEstagio.WINBASE.VMButton();
            this.btnAlterar = new SlnEstagio.WINBASE.VMButton();
            this.btnInserir = new SlnEstagio.WINBASE.VMButton();
            this.dgwColecao = new SlnEstagio.WINBASE.VMDataGridView();
            this.btnFechar = new SlnEstagio.WINBASE.VMButton();
            this.gbxVMPesquisarUsuario = new SlnEstagio.WINBASE.VMGroupBox();
            this.lblAtivos = new SlnEstagio.WINBASE.VMLabel();
            this.cbxAtivos = new SlnEstagio.WINBASE.VMComboBox();
            this.vmLabel1 = new SlnEstagio.WINBASE.VMLabel();
            this.txtVMPesquisar = new SlnEstagio.WINBASE.VMTextBox();
            this.btnVMPesquisar = new SlnEstagio.WINBASE.VMButton();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColecao)).BeginInit();
            this.gbxVMPesquisarUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRegistro
            // 
            this.txtRegistro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRegistro.Location = new System.Drawing.Point(84, 364);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(676, 364);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 24);
            this.panel1.TabIndex = 7;
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
            this.btnExcluir.Location = new System.Drawing.Point(608, 361);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(64, 28);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(530, 361);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(74, 28);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(462, 361);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(64, 28);
            this.btnInserir.TabIndex = 4;
            this.btnInserir.Text = "INSERIR";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // dgwColecao
            // 
            this.dgwColecao.AllowUserToAddRows = false;
            this.dgwColecao.AllowUserToDeleteRows = false;
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
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(682, 361);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(64, 28);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // gbxVMPesquisarUsuario
            // 
            this.gbxVMPesquisarUsuario.Controls.Add(this.lblAtivos);
            this.gbxVMPesquisarUsuario.Controls.Add(this.cbxAtivos);
            this.gbxVMPesquisarUsuario.Controls.Add(this.vmLabel1);
            this.gbxVMPesquisarUsuario.Controls.Add(this.txtVMPesquisar);
            this.gbxVMPesquisarUsuario.Controls.Add(this.btnVMPesquisar);
            this.gbxVMPesquisarUsuario.Location = new System.Drawing.Point(9, 10);
            this.gbxVMPesquisarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.gbxVMPesquisarUsuario.Name = "gbxVMPesquisarUsuario";
            this.gbxVMPesquisarUsuario.Padding = new System.Windows.Forms.Padding(2);
            this.gbxVMPesquisarUsuario.Size = new System.Drawing.Size(737, 50);
            this.gbxVMPesquisarUsuario.TabIndex = 0;
            this.gbxVMPesquisarUsuario.TabStop = false;
            // 
            // lblAtivos
            // 
            this.lblAtivos.AutoSize = true;
            this.lblAtivos.Location = new System.Drawing.Point(521, 18);
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
            this.cbxAtivos.Location = new System.Drawing.Point(574, 14);
            this.cbxAtivos.Margin = new System.Windows.Forms.Padding(2);
            this.cbxAtivos.Name = "cbxAtivos";
            this.cbxAtivos.Size = new System.Drawing.Size(62, 21);
            this.cbxAtivos.TabIndex = 3;
            this.cbxAtivos.VMRequerido = false;
            // 
            // vmLabel1
            // 
            this.vmLabel1.AutoSize = true;
            this.vmLabel1.Location = new System.Drawing.Point(4, 18);
            this.vmLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel1.Name = "vmLabel1";
            this.vmLabel1.Size = new System.Drawing.Size(72, 13);
            this.vmLabel1.TabIndex = 0;
            this.vmLabel1.Text = "PESQUISAR:";
            // 
            // txtVMPesquisar
            // 
            this.txtVMPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVMPesquisar.Location = new System.Drawing.Point(77, 15);
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
            // 
            // btnVMPesquisar
            // 
            this.btnVMPesquisar.Location = new System.Drawing.Point(656, 12);
            this.btnVMPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVMPesquisar.Name = "btnVMPesquisar";
            this.btnVMPesquisar.Size = new System.Drawing.Size(77, 24);
            this.btnVMPesquisar.TabIndex = 4;
            this.btnVMPesquisar.Text = "PESQUISAR";
            this.btnVMPesquisar.UseVisualStyleBackColor = true;
            this.btnVMPesquisar.Click += new System.EventHandler(this.btnVMPesquisar_Click);
            // 
            // FRM009
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 393);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.dgwColecao);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.gbxVMPesquisarUsuario);
            this.Name = "FRM009";
            this.Text = "SELECIONAR USUÁRIO";
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColecao)).EndInit();
            this.gbxVMPesquisarUsuario.ResumeLayout(false);
            this.gbxVMPesquisarUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SlnEstagio.WINBASE.VMTextBox txtRegistro;
        private System.Windows.Forms.Panel panel1;
        private WINBASE.VMLabel lblRegistro;
        private WINBASE.VMButton btnExcluir;
        private WINBASE.VMButton btnAlterar;
        private WINBASE.VMButton btnInserir;
        private SlnEstagio.WINBASE.VMDataGridView dgwColecao;
        private WINBASE.VMButton btnFechar;
        private SlnEstagio.WINBASE.VMGroupBox gbxVMPesquisarUsuario;
        private WINBASE.VMLabel lblAtivos;
        private WINBASE.VMComboBox cbxAtivos;
        private WINBASE.VMLabel vmLabel1;
        private SlnEstagio.WINBASE.VMTextBox txtVMPesquisar;
        private WINBASE.VMButton btnVMPesquisar;
    }
}