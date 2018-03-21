namespace SlnEstagio.MOD002
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
            this.dgwColecao = new SlnEstagio.WINBASE.VMDataGridView();
            this.btnFechar = new SlnEstagio.WINBASE.VMButton();
            this.txtPedido = new SlnEstagio.WINBASE.VMTextBox();
            this.vmLabel1 = new SlnEstagio.WINBASE.VMLabel();
            this.lblNomeCliente = new SlnEstagio.WINBASE.VMLabel();
            this.txtNomeCliente = new SlnEstagio.WINBASE.VMTextBox();
            this.vmLabel2 = new SlnEstagio.WINBASE.VMLabel();
            this.txtRegistros = new SlnEstagio.WINBASE.VMTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColecao)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // dgwColecao
            // 
            this.dgwColecao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwColecao.Location = new System.Drawing.Point(9, 47);
            this.dgwColecao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgwColecao.Name = "dgwColecao";
            this.dgwColecao.RowHeadersWidth = 22;
            this.dgwColecao.RowTemplate.Height = 24;
            this.dgwColecao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwColecao.Size = new System.Drawing.Size(552, 217);
            this.dgwColecao.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(484, 269);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(77, 28);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtPedido
            // 
            this.txtPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPedido.Location = new System.Drawing.Point(11, 24);
            this.txtPedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.ReadOnly = true;
            this.txtPedido.Size = new System.Drawing.Size(76, 20);
            this.txtPedido.TabIndex = 3;
            this.txtPedido.TabStop = false;
            this.txtPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPedido.VMLabelAssociado = null;
            this.txtPedido.VMMascara = null;
            this.txtPedido.VMPesquisa = false;
            this.txtPedido.VMPesquisaValor = null;
            this.txtPedido.VMRequerido = false;
            this.txtPedido.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtPedido.VMValor = null;
            // 
            // vmLabel1
            // 
            this.vmLabel1.AutoSize = true;
            this.vmLabel1.Location = new System.Drawing.Point(9, 8);
            this.vmLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel1.Name = "vmLabel1";
            this.vmLabel1.Size = new System.Drawing.Size(77, 13);
            this.vmLabel1.TabIndex = 4;
            this.vmLabel1.Text = "CÓD. PEDIDO";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(88, 8);
            this.lblNomeCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(106, 13);
            this.lblNomeCliente.TabIndex = 6;
            this.lblNomeCliente.Text = "NOME DO CLIENTE";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCliente.Location = new System.Drawing.Point(91, 24);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(470, 20);
            this.txtNomeCliente.TabIndex = 5;
            this.txtNomeCliente.TabStop = false;
            this.txtNomeCliente.VMLabelAssociado = null;
            this.txtNomeCliente.VMMascara = null;
            this.txtNomeCliente.VMPesquisa = false;
            this.txtNomeCliente.VMPesquisaValor = null;
            this.txtNomeCliente.VMRequerido = false;
            this.txtNomeCliente.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtNomeCliente.VMValor = null;
            // 
            // vmLabel2
            // 
            this.vmLabel2.AutoSize = true;
            this.vmLabel2.Location = new System.Drawing.Point(11, 272);
            this.vmLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vmLabel2.Name = "vmLabel2";
            this.vmLabel2.Size = new System.Drawing.Size(76, 13);
            this.vmLabel2.TabIndex = 7;
            this.vmLabel2.Text = "REGISTROS.:";
            // 
            // txtRegistros
            // 
            this.txtRegistros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRegistros.Location = new System.Drawing.Point(91, 269);
            this.txtRegistros.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegistros.Name = "txtRegistros";
            this.txtRegistros.ReadOnly = true;
            this.txtRegistros.Size = new System.Drawing.Size(92, 20);
            this.txtRegistros.TabIndex = 8;
            this.txtRegistros.Text = "0";
            this.txtRegistros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRegistros.VMLabelAssociado = null;
            this.txtRegistros.VMMascara = null;
            this.txtRegistros.VMPesquisa = false;
            this.txtRegistros.VMPesquisaValor = null;
            this.txtRegistros.VMRequerido = false;
            this.txtRegistros.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtRegistros.VMValor = null;
            // 
            // FRM003
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 300);
            this.Controls.Add(this.vmLabel2);
            this.Controls.Add(this.txtRegistros);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.vmLabel1);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dgwColecao);
            this.Name = "FRM003";
            this.Text = "CONSULTAR ITENS PEDIDO";
            this.Shown += new System.EventHandler(this.FRM003_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColecao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WINBASE.VMDataGridView dgwColecao;
        private WINBASE.VMButton btnFechar;
        private WINBASE.VMTextBox txtPedido;
        private WINBASE.VMLabel vmLabel1;
        private WINBASE.VMLabel lblNomeCliente;
        private WINBASE.VMTextBox txtNomeCliente;
        private WINBASE.VMLabel vmLabel2;
        private WINBASE.VMTextBox txtRegistros;
    }
}