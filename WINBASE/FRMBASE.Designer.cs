using System;
using System.Reflection;
using System.Windows.Forms;

namespace SlnEstagio.WINBASE
{
    partial class FRMBASE
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.objErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // objErrorProvider
            // 
            this.objErrorProvider.ContainerControl = this;
            // 
            // FRMBASE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(711, 442);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMBASE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMBASE";
            ((System.ComponentModel.ISupportInitialize)(this.objErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.ErrorProvider objErrorProvider;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}