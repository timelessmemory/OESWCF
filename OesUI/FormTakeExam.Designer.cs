namespace OesUI
{
    partial class FormTakeExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTakeExam));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblfragmenttwo = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblEachPoint = new System.Windows.Forms.Label();
            this.lblTimeTitle = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblfragmentone = new System.Windows.Forms.Label();
            this.lblQuesNum = new System.Windows.Forms.Label();
            this.lblQuesTitle = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblAnswerA = new System.Windows.Forms.Label();
            this.lblAnswerB = new System.Windows.Forms.Label();
            this.lblAnswerC = new System.Windows.Forms.Label();
            this.lblAnswerD = new System.Windows.Forms.Label();
            this.pnlMainLayout = new System.Windows.Forms.Panel();
            this.pnlGroupBox = new System.Windows.Forms.Panel();
            this.rbtD = new System.Windows.Forms.RadioButton();
            this.rbtB = new System.Windows.Forms.RadioButton();
            this.rbtC = new System.Windows.Forms.RadioButton();
            this.rbtA = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlExamResult = new System.Windows.Forms.Panel();
            this.lblCorrectCount = new System.Windows.Forms.Label();
            this.lblFragTwo = new System.Windows.Forms.Label();
            this.lblGetScore = new System.Windows.Forms.Label();
            this.lblFragOne = new System.Windows.Forms.Label();
            this.lblViewDetail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlAutoResult = new System.Windows.Forms.Panel();
            this.lblAtuoTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAutoCorrectNum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAutoGetScore = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAutoSub = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlMainLayout.SuspendLayout();
            this.pnlGroupBox.SuspendLayout();
            this.pnlExamResult.SuspendLayout();
            this.pnlAutoResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblfragmenttwo);
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Controls.Add(this.lblEachPoint);
            this.panel1.Controls.Add(this.lblTimeTitle);
            this.panel1.Controls.Add(this.lblPercent);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblfragmentone);
            this.panel1.Location = new System.Drawing.Point(28, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 50);
            this.panel1.TabIndex = 0;
            // 
            // lblfragmenttwo
            // 
            this.lblfragmenttwo.AutoSize = true;
            this.lblfragmenttwo.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfragmenttwo.Location = new System.Drawing.Point(316, 15);
            this.lblfragmenttwo.Name = "lblfragmenttwo";
            this.lblfragmenttwo.Size = new System.Drawing.Size(94, 16);
            this.lblfragmenttwo.TabIndex = 6;
            this.lblfragmenttwo.Text = "points each.";
            this.lblfragmenttwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Arial", 22.5F, System.Drawing.FontStyle.Bold);
            this.lblTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.lblTimer.Location = new System.Drawing.Point(766, 2);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(160, 45);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "00:00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEachPoint
            // 
            this.lblEachPoint.AutoSize = true;
            this.lblEachPoint.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEachPoint.Location = new System.Drawing.Point(286, 16);
            this.lblEachPoint.Name = "lblEachPoint";
            this.lblEachPoint.Size = new System.Drawing.Size(16, 16);
            this.lblEachPoint.TabIndex = 5;
            this.lblEachPoint.Text = "0";
            this.lblEachPoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTimeTitle
            // 
            this.lblTimeTitle.AutoSize = true;
            this.lblTimeTitle.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeTitle.Location = new System.Drawing.Point(684, 16);
            this.lblTimeTitle.Name = "lblTimeTitle";
            this.lblTimeTitle.Size = new System.Drawing.Size(54, 16);
            this.lblTimeTitle.TabIndex = 3;
            this.lblTimeTitle.Text = "Timing";
            // 
            // lblPercent
            // 
            this.lblPercent.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.Location = new System.Drawing.Point(466, 16);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(36, 16);
            this.lblPercent.TabIndex = 2;
            this.lblPercent.Text = "1/25";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choice";
            // 
            // lblfragmentone
            // 
            this.lblfragmentone.AutoSize = true;
            this.lblfragmentone.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfragmentone.Location = new System.Drawing.Point(101, 15);
            this.lblfragmentone.Name = "lblfragmentone";
            this.lblfragmentone.Size = new System.Drawing.Size(184, 16);
            this.lblfragmentone.TabIndex = 1;
            this.lblfragmentone.Text = "Only one correct answer,";
            this.lblfragmentone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuesNum
            // 
            this.lblQuesNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuesNum.Location = new System.Drawing.Point(121, 118);
            this.lblQuesNum.Name = "lblQuesNum";
            this.lblQuesNum.Size = new System.Drawing.Size(15, 15);
            this.lblQuesNum.TabIndex = 1;
            this.lblQuesNum.Text = "1";
            this.lblQuesNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuesTitle
            // 
            this.lblQuesTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuesTitle.Location = new System.Drawing.Point(140, 116);
            this.lblQuesTitle.Name = "lblQuesTitle";
            this.lblQuesTitle.Size = new System.Drawing.Size(800, 20);
            this.lblQuesTitle.TabIndex = 2;
            this.lblQuesTitle.Text = "Which city do you like best?";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Arial", 10.5F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(419, 470);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(150, 30);
            this.btnNext.TabIndex = 7;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "Next Question";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblAnswerA
            // 
            this.lblAnswerA.AutoSize = true;
            this.lblAnswerA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblAnswerA.Location = new System.Drawing.Point(166, 171);
            this.lblAnswerA.Name = "lblAnswerA";
            this.lblAnswerA.Size = new System.Drawing.Size(99, 19);
            this.lblAnswerA.TabIndex = 8;
            this.lblAnswerA.Text = "ChangZhou";
            // 
            // lblAnswerB
            // 
            this.lblAnswerB.AutoSize = true;
            this.lblAnswerB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblAnswerB.Location = new System.Drawing.Point(167, 211);
            this.lblAnswerB.Name = "lblAnswerB";
            this.lblAnswerB.Size = new System.Drawing.Size(80, 19);
            this.lblAnswerB.TabIndex = 9;
            this.lblAnswerB.Text = "NanTong";
            // 
            // lblAnswerC
            // 
            this.lblAnswerC.AutoSize = true;
            this.lblAnswerC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblAnswerC.Location = new System.Drawing.Point(167, 247);
            this.lblAnswerC.Name = "lblAnswerC";
            this.lblAnswerC.Size = new System.Drawing.Size(87, 19);
            this.lblAnswerC.TabIndex = 10;
            this.lblAnswerC.Text = "YangZhou";
            // 
            // lblAnswerD
            // 
            this.lblAnswerD.AutoSize = true;
            this.lblAnswerD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblAnswerD.Location = new System.Drawing.Point(166, 283);
            this.lblAnswerD.Name = "lblAnswerD";
            this.lblAnswerD.Size = new System.Drawing.Size(84, 19);
            this.lblAnswerD.TabIndex = 11;
            this.lblAnswerD.Text = "ShangHai";
            // 
            // pnlMainLayout
            // 
            this.pnlMainLayout.Controls.Add(this.pnlGroupBox);
            this.pnlMainLayout.Controls.Add(this.btnSubmit);
            this.pnlMainLayout.Controls.Add(this.panel1);
            this.pnlMainLayout.Controls.Add(this.btnNext);
            this.pnlMainLayout.Controls.Add(this.lblAnswerD);
            this.pnlMainLayout.Controls.Add(this.lblQuesNum);
            this.pnlMainLayout.Controls.Add(this.lblAnswerC);
            this.pnlMainLayout.Controls.Add(this.lblQuesTitle);
            this.pnlMainLayout.Controls.Add(this.lblAnswerB);
            this.pnlMainLayout.Controls.Add(this.lblAnswerA);
            this.pnlMainLayout.Controls.Add(this.shapeContainer2);
            this.pnlMainLayout.Location = new System.Drawing.Point(5, 36);
            this.pnlMainLayout.Name = "pnlMainLayout";
            this.pnlMainLayout.Size = new System.Drawing.Size(1022, 674);
            this.pnlMainLayout.TabIndex = 12;
            // 
            // pnlGroupBox
            // 
            this.pnlGroupBox.Controls.Add(this.rbtD);
            this.pnlGroupBox.Controls.Add(this.rbtB);
            this.pnlGroupBox.Controls.Add(this.rbtC);
            this.pnlGroupBox.Controls.Add(this.rbtA);
            this.pnlGroupBox.Location = new System.Drawing.Point(113, 165);
            this.pnlGroupBox.Name = "pnlGroupBox";
            this.pnlGroupBox.Size = new System.Drawing.Size(53, 150);
            this.pnlGroupBox.TabIndex = 14;
            // 
            // rbtD
            // 
            this.rbtD.AutoSize = true;
            this.rbtD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.rbtD.Location = new System.Drawing.Point(9, 118);
            this.rbtD.Name = "rbtD";
            this.rbtD.Size = new System.Drawing.Size(39, 23);
            this.rbtD.TabIndex = 3;
            this.rbtD.Text = "D";
            this.rbtD.UseVisualStyleBackColor = true;
            // 
            // rbtB
            // 
            this.rbtB.AutoSize = true;
            this.rbtB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.rbtB.Location = new System.Drawing.Point(9, 46);
            this.rbtB.Name = "rbtB";
            this.rbtB.Size = new System.Drawing.Size(39, 23);
            this.rbtB.TabIndex = 1;
            this.rbtB.Text = "B";
            this.rbtB.UseVisualStyleBackColor = true;
            // 
            // rbtC
            // 
            this.rbtC.AutoSize = true;
            this.rbtC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.rbtC.Location = new System.Drawing.Point(9, 82);
            this.rbtC.Name = "rbtC";
            this.rbtC.Size = new System.Drawing.Size(39, 23);
            this.rbtC.TabIndex = 2;
            this.rbtC.Text = "C";
            this.rbtC.UseVisualStyleBackColor = true;
            // 
            // rbtA
            // 
            this.rbtA.AutoSize = true;
            this.rbtA.Checked = true;
            this.rbtA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.rbtA.Location = new System.Drawing.Point(9, 6);
            this.rbtA.Name = "rbtA";
            this.rbtA.Size = new System.Drawing.Size(38, 23);
            this.rbtA.TabIndex = 0;
            this.rbtA.TabStop = true;
            this.rbtA.Text = "A";
            this.rbtA.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 10.5F);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(419, 470);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 30);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.TabStop = false;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(1022, 674);
            this.shapeContainer2.TabIndex = 16;
            this.shapeContainer2.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.rectangleShape1.FillColor = System.Drawing.Color.Gray;
            this.rectangleShape1.FillGradientColor = System.Drawing.Color.White;
            this.rectangleShape1.Location = new System.Drawing.Point(118, 116);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(20, 20);
            // 
            // lblTitle
            // 
            this.lblTitle.Image = ((System.Drawing.Image)(resources.GetObject("lblTitle.Image")));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1024, 23);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            // 
            // lblClose
            // 
            this.lblClose.Image = ((System.Drawing.Image)(resources.GetObject("lblClose.Image")));
            this.lblClose.Location = new System.Drawing.Point(986, 2);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(20, 20);
            this.lblClose.TabIndex = 14;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pnlExamResult
            // 
            this.pnlExamResult.Controls.Add(this.lblCorrectCount);
            this.pnlExamResult.Controls.Add(this.lblFragTwo);
            this.pnlExamResult.Controls.Add(this.lblGetScore);
            this.pnlExamResult.Controls.Add(this.lblFragOne);
            this.pnlExamResult.Controls.Add(this.lblViewDetail);
            this.pnlExamResult.Controls.Add(this.label3);
            this.pnlExamResult.Location = new System.Drawing.Point(2, 36);
            this.pnlExamResult.Name = "pnlExamResult";
            this.pnlExamResult.Size = new System.Drawing.Size(1022, 342);
            this.pnlExamResult.TabIndex = 15;
            this.pnlExamResult.Visible = false;
            // 
            // lblCorrectCount
            // 
            this.lblCorrectCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorrectCount.AutoSize = true;
            this.lblCorrectCount.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblCorrectCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblCorrectCount.Location = new System.Drawing.Point(550, 79);
            this.lblCorrectCount.Name = "lblCorrectCount";
            this.lblCorrectCount.Size = new System.Drawing.Size(20, 21);
            this.lblCorrectCount.TabIndex = 4;
            this.lblCorrectCount.Text = "0";
            this.lblCorrectCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFragTwo
            // 
            this.lblFragTwo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFragTwo.AutoSize = true;
            this.lblFragTwo.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblFragTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblFragTwo.Location = new System.Drawing.Point(395, 78);
            this.lblFragTwo.Name = "lblFragTwo";
            this.lblFragTwo.Size = new System.Drawing.Size(140, 21);
            this.lblFragTwo.TabIndex = 3;
            this.lblFragTwo.Text = "points, you got";
            // 
            // lblGetScore
            // 
            this.lblGetScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGetScore.AutoSize = true;
            this.lblGetScore.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblGetScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblGetScore.Location = new System.Drawing.Point(344, 79);
            this.lblGetScore.Name = "lblGetScore";
            this.lblGetScore.Size = new System.Drawing.Size(45, 21);
            this.lblGetScore.TabIndex = 2;
            this.lblGetScore.Text = "100 ";
            this.lblGetScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFragOne
            // 
            this.lblFragOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFragOne.AutoSize = true;
            this.lblFragOne.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblFragOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblFragOne.Location = new System.Drawing.Point(207, 78);
            this.lblFragOne.Name = "lblFragOne";
            this.lblFragOne.Size = new System.Drawing.Size(131, 21);
            this.lblFragOne.TabIndex = 1;
            this.lblFragOne.Text = "Your score is ";
            // 
            // lblViewDetail
            // 
            this.lblViewDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblViewDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblViewDetail.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblViewDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.lblViewDetail.Location = new System.Drawing.Point(406, 181);
            this.lblViewDetail.Name = "lblViewDetail";
            this.lblViewDetail.Size = new System.Drawing.Size(245, 50);
            this.lblViewDetail.TabIndex = 0;
            this.lblViewDetail.Text = "View the exam results detail";
            this.lblViewDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblViewDetail.Click += new System.EventHandler(this.lblViewDetail_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label3.Location = new System.Drawing.Point(575, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "questions in this test.";
            // 
            // pnlAutoResult
            // 
            this.pnlAutoResult.Controls.Add(this.lblAtuoTitle);
            this.pnlAutoResult.Controls.Add(this.label2);
            this.pnlAutoResult.Controls.Add(this.lblAutoCorrectNum);
            this.pnlAutoResult.Controls.Add(this.label5);
            this.pnlAutoResult.Controls.Add(this.lblAutoGetScore);
            this.pnlAutoResult.Controls.Add(this.label7);
            this.pnlAutoResult.Controls.Add(this.lblAutoSub);
            this.pnlAutoResult.Location = new System.Drawing.Point(6, 403);
            this.pnlAutoResult.Name = "pnlAutoResult";
            this.pnlAutoResult.Size = new System.Drawing.Size(1022, 342);
            this.pnlAutoResult.TabIndex = 16;
            this.pnlAutoResult.Visible = false;
            // 
            // lblAtuoTitle
            // 
            this.lblAtuoTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAtuoTitle.AutoSize = true;
            this.lblAtuoTitle.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblAtuoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblAtuoTitle.Location = new System.Drawing.Point(205, 86);
            this.lblAtuoTitle.Name = "lblAtuoTitle";
            this.lblAtuoTitle.Size = new System.Drawing.Size(605, 21);
            this.lblAtuoTitle.TabIndex = 6;
            this.lblAtuoTitle.Text = "Your time is up, the system has automatically submitted to the test! ";
            this.lblAtuoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label2.Location = new System.Drawing.Point(574, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "questions in this test.";
            // 
            // lblAutoCorrectNum
            // 
            this.lblAutoCorrectNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAutoCorrectNum.AutoSize = true;
            this.lblAutoCorrectNum.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblAutoCorrectNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblAutoCorrectNum.Location = new System.Drawing.Point(548, 123);
            this.lblAutoCorrectNum.Name = "lblAutoCorrectNum";
            this.lblAutoCorrectNum.Size = new System.Drawing.Size(20, 21);
            this.lblAutoCorrectNum.TabIndex = 4;
            this.lblAutoCorrectNum.Text = "0";
            this.lblAutoCorrectNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label5.Location = new System.Drawing.Point(402, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "points, you got";
            // 
            // lblAutoGetScore
            // 
            this.lblAutoGetScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAutoGetScore.AutoSize = true;
            this.lblAutoGetScore.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblAutoGetScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblAutoGetScore.Location = new System.Drawing.Point(370, 124);
            this.lblAutoGetScore.Name = "lblAutoGetScore";
            this.lblAutoGetScore.Size = new System.Drawing.Size(25, 21);
            this.lblAutoGetScore.TabIndex = 2;
            this.lblAutoGetScore.Text = "0 ";
            this.lblAutoGetScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label7.Location = new System.Drawing.Point(231, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Your score is ";
            // 
            // lblAutoSub
            // 
            this.lblAutoSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAutoSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAutoSub.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblAutoSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.lblAutoSub.Location = new System.Drawing.Point(406, 230);
            this.lblAutoSub.Name = "lblAutoSub";
            this.lblAutoSub.Size = new System.Drawing.Size(245, 50);
            this.lblAutoSub.TabIndex = 0;
            this.lblAutoSub.Text = "View the exam results detail";
            this.lblAutoSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAutoSub.Click += new System.EventHandler(this.Submit_Click);
            // 
            // FormTakeExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.pnlMainLayout);
            this.Controls.Add(this.pnlAutoResult);
            this.Controls.Add(this.pnlExamResult);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTakeExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTakeExam";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTakeExam_FormClosed);
            this.Load += new System.EventHandler(this.FormTakeExam_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMainLayout.ResumeLayout(false);
            this.pnlMainLayout.PerformLayout();
            this.pnlGroupBox.ResumeLayout(false);
            this.pnlGroupBox.PerformLayout();
            this.pnlExamResult.ResumeLayout(false);
            this.pnlExamResult.PerformLayout();
            this.pnlAutoResult.ResumeLayout(false);
            this.pnlAutoResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTimeTitle;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblfragmentone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuesNum;
        private System.Windows.Forms.Label lblQuesTitle;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblAnswerA;
        private System.Windows.Forms.Label lblAnswerB;
        private System.Windows.Forms.Label lblAnswerC;
        private System.Windows.Forms.Label lblAnswerD;
        private System.Windows.Forms.Panel pnlMainLayout;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.RadioButton rbtD;
        private System.Windows.Forms.RadioButton rbtC;
        private System.Windows.Forms.RadioButton rbtB;
        private System.Windows.Forms.RadioButton rbtA;
        private System.Windows.Forms.Panel pnlGroupBox;
        private System.Windows.Forms.Panel pnlExamResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCorrectCount;
        private System.Windows.Forms.Label lblFragTwo;
        private System.Windows.Forms.Label lblGetScore;
        private System.Windows.Forms.Label lblFragOne;
        private System.Windows.Forms.Label lblViewDetail;
        private System.Windows.Forms.Label lblfragmenttwo;
        private System.Windows.Forms.Label lblEachPoint;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Panel pnlAutoResult;
        private System.Windows.Forms.Label lblAtuoTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAutoCorrectNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAutoGetScore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAutoSub;

    }
}