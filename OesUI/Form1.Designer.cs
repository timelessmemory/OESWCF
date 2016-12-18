using System.Drawing;
namespace OesUI
{
    partial class FormExamList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExamList));
            this.splitExamBlock = new System.Windows.Forms.SplitContainer();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblMyExam = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblChinese = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.lblUserIcon = new System.Windows.Forms.Label();
            this.pnlStudent = new System.Windows.Forms.Panel();
            this.pnlMyExam = new OesUI.Custom.MyExam();
            this.pnlHome = new OesUI.Custom.Home();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(this.splitExamBlock)).BeginInit();
            this.splitExamBlock.Panel1.SuspendLayout();
            this.splitExamBlock.Panel2.SuspendLayout();
            this.splitExamBlock.SuspendLayout();
            this.pnlStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitExamBlock
            // 
            this.splitExamBlock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitExamBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(227)))));
            this.splitExamBlock.IsSplitterFixed = true;
            this.splitExamBlock.Location = new System.Drawing.Point(0, 0);
            this.splitExamBlock.Margin = new System.Windows.Forms.Padding(0);
            this.splitExamBlock.Name = "splitExamBlock";
            this.splitExamBlock.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitExamBlock.Panel1
            // 
            this.splitExamBlock.Panel1.BackColor = System.Drawing.Color.White;
            this.splitExamBlock.Panel1.Controls.Add(this.lblClose);
            this.splitExamBlock.Panel1.Controls.Add(this.lblMyExam);
            this.splitExamBlock.Panel1.Controls.Add(this.lblLogout);
            this.splitExamBlock.Panel1.Controls.Add(this.lblHome);
            this.splitExamBlock.Panel1.Controls.Add(this.lblChinese);
            this.splitExamBlock.Panel1.Controls.Add(this.lbltitle);
            this.splitExamBlock.Panel1.Controls.Add(this.lblCurrentUser);
            this.splitExamBlock.Panel1.Controls.Add(this.lblUserIcon);
            this.splitExamBlock.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitExamBlock.Panel1MinSize = 50;
            // 
            // splitExamBlock.Panel2
            // 
            this.splitExamBlock.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(227)))));
            this.splitExamBlock.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitExamBlock.Panel2.Controls.Add(this.pnlStudent);
            this.splitExamBlock.Panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitExamBlock.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitExamBlock.Size = new System.Drawing.Size(1024, 768);
            this.splitExamBlock.SplitterDistance = 65;
            this.splitExamBlock.SplitterWidth = 1;
            this.splitExamBlock.TabIndex = 0;
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.Image = ((System.Drawing.Image)(resources.GetObject("lblClose.Image")));
            this.lblClose.Location = new System.Drawing.Point(986, 2);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(20, 20);
            this.lblClose.TabIndex = 5;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblMyExam
            // 
            this.lblMyExam.BackColor = System.Drawing.Color.White;
            this.lblMyExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMyExam.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblMyExam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.lblMyExam.Location = new System.Drawing.Point(116, 26);
            this.lblMyExam.Name = "lblMyExam";
            this.lblMyExam.Size = new System.Drawing.Size(100, 40);
            this.lblMyExam.TabIndex = 4;
            this.lblMyExam.Text = "My Exam";
            this.lblMyExam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMyExam.Click += new System.EventHandler(this.lblMyExam_Click);
            // 
            // lblLogout
            // 
            this.lblLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogout.AutoSize = true;
            this.lblLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogout.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.lblLogout.Location = new System.Drawing.Point(948, 43);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(52, 16);
            this.lblLogout.TabIndex = 3;
            this.lblLogout.Text = "Logout";
            // 
            // lblHome
            // 
            this.lblHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(227)))));
            this.lblHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHome.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.lblHome.Location = new System.Drawing.Point(16, 26);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(100, 40);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Home";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // lblChinese
            // 
            this.lblChinese.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChinese.AutoSize = true;
            this.lblChinese.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblChinese.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblChinese.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.lblChinese.Location = new System.Drawing.Point(906, 43);
            this.lblChinese.Name = "lblChinese";
            this.lblChinese.Size = new System.Drawing.Size(36, 16);
            this.lblChinese.TabIndex = 2;
            this.lblChinese.Text = "中文";
            // 
            // lbltitle
            // 
            this.lbltitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltitle.Image = ((System.Drawing.Image)(resources.GetObject("lbltitle.Image")));
            this.lbltitle.Location = new System.Drawing.Point(-2, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(1024, 26);
            this.lbltitle.TabIndex = 3;
            this.lbltitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCurrentUser.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblCurrentUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(103)))), ((int)(((byte)(147)))));
            this.lblCurrentUser.Location = new System.Drawing.Point(836, 42);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(58, 16);
            this.lblCurrentUser.TabIndex = 1;
            this.lblCurrentUser.Text = "Mario.Li";
            // 
            // lblUserIcon
            // 
            this.lblUserIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserIcon.Image = ((System.Drawing.Image)(resources.GetObject("lblUserIcon.Image")));
            this.lblUserIcon.Location = new System.Drawing.Point(797, 39);
            this.lblUserIcon.Name = "lblUserIcon";
            this.lblUserIcon.Size = new System.Drawing.Size(18, 20);
            this.lblUserIcon.TabIndex = 0;
            // 
            // pnlStudent
            // 
            this.pnlStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStudent.BackColor = System.Drawing.Color.White;
            this.pnlStudent.Controls.Add(this.pnlMyExam);
            this.pnlStudent.Controls.Add(this.pnlHome);
            this.pnlStudent.Controls.Add(this.shapeContainer1);
            this.pnlStudent.Location = new System.Drawing.Point(20, 27);
            this.pnlStudent.Name = "pnlStudent";
            this.pnlStudent.Size = new System.Drawing.Size(980, 640);
            this.pnlStudent.TabIndex = 0;
            // 
            // pnlMyExam
            // 
            this.pnlMyExam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMyExam.BackColor = System.Drawing.Color.White;
            this.pnlMyExam.Location = new System.Drawing.Point(0, 0);
            this.pnlMyExam.Name = "pnlMyExam";
            this.pnlMyExam.Size = new System.Drawing.Size(980, 640);
            this.pnlMyExam.TabIndex = 1;
            this.pnlMyExam.Visible = false;
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.White;
            this.pnlHome.Location = new System.Drawing.Point(411, 42);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(980, 640);
            this.pnlHome.TabIndex = 0;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(980, 640);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 484;
            this.lineShape1.X2 = 502;
            this.lineShape1.Y1 = 262;
            this.lineShape1.Y2 = 230;
            // 
            // FormExamList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.splitExamBlock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormExamList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Augmentum Online Exam System Client";
            this.splitExamBlock.Panel1.ResumeLayout(false);
            this.splitExamBlock.Panel1.PerformLayout();
            this.splitExamBlock.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitExamBlock)).EndInit();
            this.splitExamBlock.ResumeLayout(false);
            this.pnlStudent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitExamBlock;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblChinese;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Label lblUserIcon;
        private System.Windows.Forms.Label lblMyExam;
        private System.Windows.Forms.Panel pnlStudent;
        private Custom.MyExam pnlMyExam;
        private Custom.Home pnlHome;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblClose;

        public Custom.MyExam GetPnlMyExam()
        {
            return this.pnlMyExam;
        }
    }
}

