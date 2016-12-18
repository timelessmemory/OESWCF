namespace OesUI.Custom
{
    partial class MyExam
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUnfinishedExam = new System.Windows.Forms.Label();
            this.lblFinishedExam = new System.Windows.Forms.Label();
            this.lblAll = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.pnlPagination = new System.Windows.Forms.FlowLayoutPanel();
            this.customTipDialog1 = new OesUI.Custom.CustomTipDialog();
            this.AllExam = new OesUI.Custom.ExamList();
            this.SuspendLayout();
            // 
            // lblUnfinishedExam
            // 
            this.lblUnfinishedExam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnfinishedExam.BackColor = System.Drawing.Color.White;
            this.lblUnfinishedExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUnfinishedExam.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblUnfinishedExam.ForeColor = System.Drawing.Color.Black;
            this.lblUnfinishedExam.Location = new System.Drawing.Point(528, 30);
            this.lblUnfinishedExam.Name = "lblUnfinishedExam";
            this.lblUnfinishedExam.Size = new System.Drawing.Size(100, 30);
            this.lblUnfinishedExam.TabIndex = 7;
            this.lblUnfinishedExam.Text = "Unfinished";
            this.lblUnfinishedExam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUnfinishedExam.Click += new System.EventHandler(this.lblUnfinishedExam_Click);
            // 
            // lblFinishedExam
            // 
            this.lblFinishedExam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFinishedExam.BackColor = System.Drawing.Color.White;
            this.lblFinishedExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFinishedExam.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblFinishedExam.ForeColor = System.Drawing.Color.Black;
            this.lblFinishedExam.Location = new System.Drawing.Point(428, 30);
            this.lblFinishedExam.Name = "lblFinishedExam";
            this.lblFinishedExam.Size = new System.Drawing.Size(100, 30);
            this.lblFinishedExam.TabIndex = 6;
            this.lblFinishedExam.Text = "Finished";
            this.lblFinishedExam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFinishedExam.Click += new System.EventHandler(this.lblFinishedExam_Click);
            // 
            // lblAll
            // 
            this.lblAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.lblAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAll.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblAll.ForeColor = System.Drawing.Color.White;
            this.lblAll.Location = new System.Drawing.Point(328, 30);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(100, 30);
            this.lblAll.TabIndex = 5;
            this.lblAll.Text = "All";
            this.lblAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAll.Click += new System.EventHandler(this.lblAll_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.label1.Location = new System.Drawing.Point(0, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(980, 1);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // lblLine
            // 
            this.lblLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.lblLine.Location = new System.Drawing.Point(3, 150);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(975, 1);
            this.lblLine.TabIndex = 16;
            this.lblLine.Text = "label2";
            // 
            // pnlPagination
            // 
            this.pnlPagination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPagination.AutoSize = true;
            this.pnlPagination.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPagination.Location = new System.Drawing.Point(331, 556);
            this.pnlPagination.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPagination.Name = "pnlPagination";
            this.pnlPagination.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnlPagination.Size = new System.Drawing.Size(604, 69);
            this.pnlPagination.TabIndex = 21;
            // 
            // customTipDialog1
            // 
            this.customTipDialog1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.customTipDialog1.BackColor = System.Drawing.Color.White;
            this.customTipDialog1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customTipDialog1.Location = new System.Drawing.Point(249, 236);
            this.customTipDialog1.Name = "customTipDialog1";
            this.customTipDialog1.Size = new System.Drawing.Size(400, 200);
            this.customTipDialog1.TabIndex = 20;
            this.customTipDialog1.TipMessage = "this is first page";
            this.customTipDialog1.Visible = false;
            // 
            // AllExam
            // 
            this.AllExam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AllExam.BackColor = System.Drawing.Color.White;
            this.AllExam.Location = new System.Drawing.Point(0, 109);
            this.AllExam.Name = "AllExam";
            this.AllExam.Size = new System.Drawing.Size(980, 422);
            this.AllExam.TabIndex = 8;
            this.AllExam.Load += new System.EventHandler(this.AllExam_Load);
            // 
            // MyExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlPagination);
            this.Controls.Add(this.customTipDialog1);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllExam);
            this.Controls.Add(this.lblUnfinishedExam);
            this.Controls.Add(this.lblFinishedExam);
            this.Controls.Add(this.lblAll);
            this.Name = "MyExam";
            this.Size = new System.Drawing.Size(980, 640);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyExam_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnfinishedExam;
        private System.Windows.Forms.Label lblFinishedExam;
        private System.Windows.Forms.Label lblAll;
        private ExamList AllExam;

        public ExamList GetAllExam()
        {
            return this.AllExam;
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLine;
        private CustomTipDialog customTipDialog1;
        private System.Windows.Forms.FlowLayoutPanel pnlPagination;
    }
}
