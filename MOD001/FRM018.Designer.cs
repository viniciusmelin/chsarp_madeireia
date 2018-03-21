﻿namespace SlnEstagio.MOD001
{
    partial class FRM018
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
            this.gbxInformacao = new SlnEstagio.WINBASE.VMGroupBox();
            this.txtFornecedor = new SlnEstagio.WINBASE.VMTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalvar = new SlnEstagio.WINBASE.VMButton();
            this.btnFechar = new SlnEstagio.WINBASE.VMButton();
            this.vmGroupBox1 = new SlnEstagio.WINBASE.VMGroupBox();
            this.txtCidade = new SlnEstagio.WINBASE.VMTextBox();
            this.txtCep = new SlnEstagio.WINBASE.VMTextBox();
            this.txtComplemento = new SlnEstagio.WINBASE.VMTextBox();
            this.txtnumero = new SlnEstagio.WINBASE.VMTextBox();
            this.txtBairro = new SlnEstagio.WINBASE.VMTextBox();
            this.txtLogradouro = new SlnEstagio.WINBASE.VMTextBox();
            this.lblBairro = new SlnEstagio.WINBASE.VMLabel();
            this.lblCep = new SlnEstagio.WINBASE.VMLabel();
            this.lblCidade = new SlnEstagio.WINBASE.VMLabel();
            this.lblComplemento = new SlnEstagio.WINBASE.VMLabel();
            this.lblNumero = new SlnEstagio.WINBASE.VMLabel();
            this.lblLogradouro = new SlnEstagio.WINBASE.VMLabel();
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            this.gbxInformacao.SuspendLayout();
            this.vmGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxInformacao
            // 
            this.gbxInformacao.Controls.Add(this.txtFornecedor);
            this.gbxInformacao.Location = new System.Drawing.Point(11, 11);
            this.gbxInformacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxInformacao.Name = "gbxInformacao";
            this.gbxInformacao.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxInformacao.Size = new System.Drawing.Size(401, 47);
            this.gbxInformacao.TabIndex = 0;
            this.gbxInformacao.TabStop = false;
            this.gbxInformacao.Text = "FORNECEDOR";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedor.Location = new System.Drawing.Point(5, 18);
            this.txtFornecedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(387, 20);
            this.txtFornecedor.TabIndex = 0;
            this.txtFornecedor.VMLabelAssociado = null;
            this.txtFornecedor.VMMascara = null;
            this.txtFornecedor.VMPesquisa = false;
            this.txtFornecedor.VMPesquisaValor = null;
            this.txtFornecedor.VMRequerido = false;
            this.txtFornecedor.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtFornecedor.VMValor = null;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(333, 281);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 24);
            this.panel1.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(256, 278);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(73, 28);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "&SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(339, 278);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(73, 28);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "&CANCELAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // vmGroupBox1
            // 
            this.vmGroupBox1.Controls.Add(this.txtCidade);
            this.vmGroupBox1.Controls.Add(this.txtCep);
            this.vmGroupBox1.Controls.Add(this.txtComplemento);
            this.vmGroupBox1.Controls.Add(this.txtnumero);
            this.vmGroupBox1.Controls.Add(this.txtBairro);
            this.vmGroupBox1.Controls.Add(this.txtLogradouro);
            this.vmGroupBox1.Controls.Add(this.lblBairro);
            this.vmGroupBox1.Controls.Add(this.lblCep);
            this.vmGroupBox1.Controls.Add(this.lblCidade);
            this.vmGroupBox1.Controls.Add(this.lblComplemento);
            this.vmGroupBox1.Controls.Add(this.lblNumero);
            this.vmGroupBox1.Controls.Add(this.lblLogradouro);
            this.vmGroupBox1.Location = new System.Drawing.Point(11, 63);
            this.vmGroupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vmGroupBox1.Name = "vmGroupBox1";
            this.vmGroupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vmGroupBox1.Size = new System.Drawing.Size(401, 211);
            this.vmGroupBox1.TabIndex = 1;
            this.vmGroupBox1.TabStop = false;
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Location = new System.Drawing.Point(7, 172);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(148, 20);
            this.txtCidade.TabIndex = 36;
            this.txtCidade.VMLabelAssociado = null;
            this.txtCidade.VMMascara = null;
            this.txtCidade.VMPesquisa = false;
            this.txtCidade.VMPesquisaValor = null;
            this.txtCidade.VMRequerido = false;
            this.txtCidade.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtCidade.VMValor = null;
            // 
            // txtCep
            // 
            this.txtCep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCep.Location = new System.Drawing.Point(182, 121);
            this.txtCep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(109, 20);
            this.txtCep.TabIndex = 35;
            this.txtCep.VMLabelAssociado = null;
            this.txtCep.VMMascara = null;
            this.txtCep.VMPesquisa = false;
            this.txtCep.VMPesquisaValor = null;
            this.txtCep.VMRequerido = false;
            this.txtCep.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtCep.VMValor = null;
            // 
            // txtComplemento
            // 
            this.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplemento.Location = new System.Drawing.Point(7, 121);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(169, 20);
            this.txtComplemento.TabIndex = 34;
            this.txtComplemento.VMLabelAssociado = null;
            this.txtComplemento.VMMascara = null;
            this.txtComplemento.VMPesquisa = false;
            this.txtComplemento.VMPesquisaValor = null;
            this.txtComplemento.VMRequerido = false;
            this.txtComplemento.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtComplemento.VMValor = null;
            // 
            // txtnumero
            // 
            this.txtnumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnumero.Location = new System.Drawing.Point(262, 75);
            this.txtnumero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(71, 20);
            this.txtnumero.TabIndex = 33;
            this.txtnumero.VMLabelAssociado = null;
            this.txtnumero.VMMascara = null;
            this.txtnumero.VMPesquisa = false;
            this.txtnumero.VMPesquisaValor = null;
            this.txtnumero.VMRequerido = false;
            this.txtnumero.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtnumero.VMValor = null;
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(7, 75);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(252, 20);
            this.txtBairro.TabIndex = 32;
            this.txtBairro.VMLabelAssociado = null;
            this.txtBairro.VMMascara = null;
            this.txtBairro.VMPesquisa = false;
            this.txtBairro.VMPesquisaValor = null;
            this.txtBairro.VMRequerido = false;
            this.txtBairro.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtBairro.VMValor = null;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogradouro.Location = new System.Drawing.Point(7, 31);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(386, 20);
            this.txtLogradouro.TabIndex = 31;
            this.txtLogradouro.VMLabelAssociado = null;
            this.txtLogradouro.VMMascara = null;
            this.txtLogradouro.VMPesquisa = false;
            this.txtLogradouro.VMPesquisaValor = null;
            this.txtLogradouro.VMRequerido = false;
            this.txtLogradouro.VMTipoDado = SlnEstagio.WINBASE.TipoDado.Texto;
            this.txtLogradouro.VMValor = null;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(4, 58);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(48, 13);
            this.lblBairro.TabIndex = 30;
            this.lblBairro.Text = "BAIRRO";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(179, 105);
            this.lblCep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(28, 13);
            this.lblCep.TabIndex = 29;
            this.lblCep.Text = "CEP";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(4, 156);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(47, 13);
            this.lblCidade.TabIndex = 28;
            this.lblCidade.Text = "CIDADE";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(4, 105);
            this.lblComplemento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(90, 13);
            this.lblComplemento.TabIndex = 26;
            this.lblComplemento.Text = "COMPLEMENTO";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(262, 58);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(19, 13);
            this.lblNumero.TabIndex = 25;
            this.lblNumero.Text = "Nº";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(4, 15);
            this.lblLogradouro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(84, 13);
            this.lblLogradouro.TabIndex = 0;
            this.lblLogradouro.Text = "LOGRADOURO";
            // 
            // FRM018
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 311);
            this.Controls.Add(this.gbxInformacao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.vmGroupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Name = "FRM018";
            this.Text = "CADASTRAR ENDEREÇO FORNECEDOR";
            this.Shown += new System.EventHandler(this.FRM018_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            this.gbxInformacao.ResumeLayout(false);
            this.gbxInformacao.PerformLayout();
            this.vmGroupBox1.ResumeLayout(false);
            this.vmGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WINBASE.VMGroupBox gbxInformacao;
        private WINBASE.VMTextBox txtFornecedor;
        private System.Windows.Forms.Panel panel1;
        private WINBASE.VMButton btnSalvar;
        private WINBASE.VMButton btnFechar;
        private WINBASE.VMGroupBox vmGroupBox1;
        private WINBASE.VMTextBox txtCidade;
        private WINBASE.VMTextBox txtCep;
        private WINBASE.VMTextBox txtComplemento;
        private WINBASE.VMTextBox txtnumero;
        private WINBASE.VMTextBox txtBairro;
        private WINBASE.VMTextBox txtLogradouro;
        private WINBASE.VMLabel lblBairro;
        private WINBASE.VMLabel lblCep;
        private WINBASE.VMLabel lblCidade;
        private WINBASE.VMLabel lblComplemento;
        private WINBASE.VMLabel lblNumero;
        private WINBASE.VMLabel lblLogradouro;
    }
}