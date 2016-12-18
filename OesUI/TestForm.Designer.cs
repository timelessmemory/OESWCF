using OesUI.Custom;
using System;
namespace OesUI
{
    partial class TestForm
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
            this.customTipDialog = new OesUI.Custom.CustomTipDialog();
            this.SuspendLayout();
            // 
            // customTipDialog
            // 
            this.customTipDialog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.customTipDialog.BackColor = System.Drawing.Color.White;
            this.customTipDialog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customTipDialog.Location = new System.Drawing.Point(184, 29);
            this.customTipDialog.Name = "customTipDialog";
            this.customTipDialog.Size = new System.Drawing.Size(400, 200);
            this.customTipDialog.TabIndex = 0;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.customTipDialog);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomTipDialog customTipDialog;

    }
}