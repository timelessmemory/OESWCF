namespace OesUI
{
    partial class FormResultDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResultDetails));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblExamres = new System.Windows.Forms.Label();
            this.lblExamScore = new System.Windows.Forms.Label();
            this.lblFrags = new System.Windows.Forms.Label();
            this.lblcorrectCount = new System.Windows.Forms.Label();
            this.lblFrag = new System.Windows.Forms.Label();
            this.lblTotalScore = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lblGetScoreValue = new System.Windows.Forms.Label();
            this.lblTotalScoreValue = new System.Windows.Forms.Label();
            this.lblIdValue = new System.Windows.Forms.Label();
            this.lblQuestionCountValue = new System.Windows.Forms.Label();
            this.lblDurationvalue = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.lblEffectiveTimeValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Image = ((System.Drawing.Image)(resources.GetObject("lblTitle.Image")));
            this.lblTitle.Location = new System.Drawing.Point(0, -4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(985, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            // 
            // lblClose
            // 
            this.lblClose.Image = ((System.Drawing.Image)(resources.GetObject("lblClose.Image")));
            this.lblClose.Location = new System.Drawing.Point(964, 1);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(20, 20);
            this.lblClose.TabIndex = 1;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblExamres
            // 
            this.lblExamres.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblExamres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblExamres.Location = new System.Drawing.Point(27, 45);
            this.lblExamres.Name = "lblExamres";
            this.lblExamres.Size = new System.Drawing.Size(100, 30);
            this.lblExamres.TabIndex = 2;
            this.lblExamres.Text = "Exam Result";
            this.lblExamres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExamScore
            // 
            this.lblExamScore.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblExamScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblExamScore.Location = new System.Drawing.Point(567, 38);
            this.lblExamScore.Name = "lblExamScore";
            this.lblExamScore.Size = new System.Drawing.Size(86, 30);
            this.lblExamScore.TabIndex = 3;
            this.lblExamScore.Text = "Exam Score";
            this.lblExamScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFrags
            // 
            this.lblFrags.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblFrags.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblFrags.Location = new System.Drawing.Point(737, 45);
            this.lblFrags.Name = "lblFrags";
            this.lblFrags.Size = new System.Drawing.Size(71, 30);
            this.lblFrags.TabIndex = 4;
            this.lblFrags.Text = "There are";
            this.lblFrags.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblcorrectCount
            // 
            this.lblcorrectCount.AutoSize = true;
            this.lblcorrectCount.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblcorrectCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblcorrectCount.Location = new System.Drawing.Point(811, 52);
            this.lblcorrectCount.Name = "lblcorrectCount";
            this.lblcorrectCount.Size = new System.Drawing.Size(16, 16);
            this.lblcorrectCount.TabIndex = 5;
            this.lblcorrectCount.Text = "0";
            this.lblcorrectCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFrag
            // 
            this.lblFrag.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblFrag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblFrag.Location = new System.Drawing.Point(833, 49);
            this.lblFrag.Name = "lblFrag";
            this.lblFrag.Size = new System.Drawing.Size(126, 23);
            this.lblFrag.TabIndex = 6;
            this.lblFrag.Text = "questions correct.";
            this.lblFrag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalScore
            // 
            this.lblTotalScore.AutoSize = true;
            this.lblTotalScore.Font = new System.Drawing.Font("Arial", 27F);
            this.lblTotalScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.lblTotalScore.Location = new System.Drawing.Point(673, 28);
            this.lblTotalScore.Name = "lblTotalScore";
            this.lblTotalScore.Size = new System.Drawing.Size(58, 41);
            this.lblTotalScore.TabIndex = 7;
            this.lblTotalScore.Text = "00";
            this.lblTotalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1000, 768);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape2.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rectangleShape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.rectangleShape2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(227)))));
            this.rectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape2.Location = new System.Drawing.Point(160, 230);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(800, 30);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.rectangleShape1.CornerRadius = 3;
            this.rectangleShape1.Location = new System.Drawing.Point(30, 230);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(100, 30);
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 36;
            this.lineShape1.X2 = 971;
            this.lineShape1.Y1 = 76;
            this.lineShape1.Y2 = 75;
            // 
            // lblGetScoreValue
            // 
            this.lblGetScoreValue.AutoSize = true;
            this.lblGetScoreValue.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblGetScoreValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblGetScoreValue.Location = new System.Drawing.Point(406, 162);
            this.lblGetScoreValue.Name = "lblGetScoreValue";
            this.lblGetScoreValue.Size = new System.Drawing.Size(40, 16);
            this.lblGetScoreValue.TabIndex = 38;
            this.lblGetScoreValue.Text = "Total";
            // 
            // lblTotalScoreValue
            // 
            this.lblTotalScoreValue.AutoSize = true;
            this.lblTotalScoreValue.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblTotalScoreValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblTotalScoreValue.Location = new System.Drawing.Point(406, 136);
            this.lblTotalScoreValue.Name = "lblTotalScoreValue";
            this.lblTotalScoreValue.Size = new System.Drawing.Size(81, 16);
            this.lblTotalScoreValue.TabIndex = 37;
            this.lblTotalScoreValue.Text = "Total Score";
            // 
            // lblIdValue
            // 
            this.lblIdValue.AutoSize = true;
            this.lblIdValue.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblIdValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblIdValue.Location = new System.Drawing.Point(347, 110);
            this.lblIdValue.Name = "lblIdValue";
            this.lblIdValue.Size = new System.Drawing.Size(25, 16);
            this.lblIdValue.TabIndex = 36;
            this.lblIdValue.Text = "ID:";
            // 
            // lblQuestionCountValue
            // 
            this.lblQuestionCountValue.AutoSize = true;
            this.lblQuestionCountValue.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblQuestionCountValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblQuestionCountValue.Location = new System.Drawing.Point(103, 190);
            this.lblQuestionCountValue.Name = "lblQuestionCountValue";
            this.lblQuestionCountValue.Size = new System.Drawing.Size(76, 16);
            this.lblQuestionCountValue.TabIndex = 35;
            this.lblQuestionCountValue.Text = "Questions:";
            // 
            // lblDurationvalue
            // 
            this.lblDurationvalue.AutoSize = true;
            this.lblDurationvalue.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblDurationvalue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblDurationvalue.Location = new System.Drawing.Point(92, 162);
            this.lblDurationvalue.Name = "lblDurationvalue";
            this.lblDurationvalue.Size = new System.Drawing.Size(66, 16);
            this.lblDurationvalue.TabIndex = 34;
            this.lblDurationvalue.Text = "Duration:";
            // 
            // lblNameValue
            // 
            this.lblNameValue.AutoSize = true;
            this.lblNameValue.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblNameValue.Location = new System.Drawing.Point(79, 110);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(48, 16);
            this.lblNameValue.TabIndex = 33;
            this.lblNameValue.Text = "Name:";
            // 
            // lblEffectiveTimeValue
            // 
            this.lblEffectiveTimeValue.AutoSize = true;
            this.lblEffectiveTimeValue.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblEffectiveTimeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblEffectiveTimeValue.Location = new System.Drawing.Point(137, 136);
            this.lblEffectiveTimeValue.Name = "lblEffectiveTimeValue";
            this.lblEffectiveTimeValue.Size = new System.Drawing.Size(101, 16);
            this.lblEffectiveTimeValue.TabIndex = 32;
            this.lblEffectiveTimeValue.Text = "Effective Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.5F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label6.Location = new System.Drawing.Point(319, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Exam Score:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.5F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label5.Location = new System.Drawing.Point(319, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Total Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.5F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label4.Location = new System.Drawing.Point(319, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.5F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label3.Location = new System.Drawing.Point(30, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Questions:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.5F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label2.Location = new System.Drawing.Point(30, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Duration:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.5F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label1.Location = new System.Drawing.Point(30, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Effective Time:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 10.5F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblName.Location = new System.Drawing.Point(30, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 16);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Name:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 13.5F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label7.Location = new System.Drawing.Point(35, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 23);
            this.label7.TabIndex = 39;
            this.label7.Text = "The Key:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormResultDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1000, 768);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblGetScoreValue);
            this.Controls.Add(this.lblTotalScoreValue);
            this.Controls.Add(this.lblIdValue);
            this.Controls.Add(this.lblQuestionCountValue);
            this.Controls.Add(this.lblDurationvalue);
            this.Controls.Add(this.lblNameValue);
            this.Controls.Add(this.lblEffectiveTimeValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTotalScore);
            this.Controls.Add(this.lblFrag);
            this.Controls.Add(this.lblcorrectCount);
            this.Controls.Add(this.lblFrags);
            this.Controls.Add(this.lblExamScore);
            this.Controls.Add(this.lblExamres);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormResultDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormResultDetails";
            this.Load += new System.EventHandler(this.FormResultDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblExamres;
        private System.Windows.Forms.Label lblExamScore;
        private System.Windows.Forms.Label lblFrags;
        private System.Windows.Forms.Label lblcorrectCount;
        private System.Windows.Forms.Label lblFrag;
        private System.Windows.Forms.Label lblTotalScore;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label lblGetScoreValue;
        private System.Windows.Forms.Label lblTotalScoreValue;
        private System.Windows.Forms.Label lblIdValue;
        private System.Windows.Forms.Label lblQuestionCountValue;
        private System.Windows.Forms.Label lblDurationvalue;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label lblEffectiveTimeValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label7;
    }
}