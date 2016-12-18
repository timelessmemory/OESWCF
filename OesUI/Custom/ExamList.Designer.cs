using System.Windows.Forms;
namespace OesUI.Custom
{
    public partial class ExamList
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamList));
            this.dgvExamList = new System.Windows.Forms.DataGridView();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effectivetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passcriteriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalscoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchExamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oesDataSet = new OesUI.oesDataSet();
            this.lblIDIncrease = new System.Windows.Forms.Label();
            this.lblIDdecrease = new System.Windows.Forms.Label();
            this.lblNameDecrease = new System.Windows.Forms.Label();
            this.lblNameIncrease = new System.Windows.Forms.Label();
            this.lblTimeIncrease = new System.Windows.Forms.Label();
            this.lblTimeDecrease = new System.Windows.Forms.Label();
            this.lblPassIncrease = new System.Windows.Forms.Label();
            this.lblPassDecrease = new System.Windows.Forms.Label();
            this.lblTotalIncrease = new System.Windows.Forms.Label();
            this.lblTotalDecrease = new System.Windows.Forms.Label();
            this.lblCriteriaIncre = new System.Windows.Forms.Label();
            this.lblCriteriaDecre = new System.Windows.Forms.Label();
            this.searchExamTableAdapter = new OesUI.oesDataSetTableAdapters.SearchExamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchExamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExamList
            // 
            this.dgvExamList.AllowUserToAddRows = false;
            this.dgvExamList.AllowUserToDeleteRows = false;
            this.dgvExamList.AllowUserToResizeColumns = false;
            this.dgvExamList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.dgvExamList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExamList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExamList.AutoGenerateColumns = false;
            this.dgvExamList.BackgroundColor = System.Drawing.Color.White;
            this.dgvExamList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvExamList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExamList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExamList.ColumnHeadersHeight = 40;
            this.dgvExamList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvExamList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.examnameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.effectivetimeDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.passcriteriaDataGridViewTextBoxColumn,
            this.totalscoreDataGridViewTextBoxColumn,
            this.operationDataGridViewTextBoxColumn});
            this.dgvExamList.DataSource = this.searchExamBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExamList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExamList.EnableHeadersVisualStyles = false;
            this.dgvExamList.GridColor = System.Drawing.Color.White;
            this.dgvExamList.Location = new System.Drawing.Point(0, 0);
            this.dgvExamList.Margin = new System.Windows.Forms.Padding(0);
            this.dgvExamList.Name = "dgvExamList";
            this.dgvExamList.ReadOnly = true;
            this.dgvExamList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExamList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExamList.RowHeadersWidth = 5;
            this.dgvExamList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvExamList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvExamList.RowTemplate.Height = 23;
            this.dgvExamList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExamList.Size = new System.Drawing.Size(980, 422);
            this.dgvExamList.TabIndex = 0;
            this.dgvExamList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExamList_CellClick);
            this.dgvExamList.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExamList_CellMouseEnter);
            this.dgvExamList.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExamList_CellMouseLeave);
            this.dgvExamList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvExamList_MouseClick);
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.HeaderText = "";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.ReadOnly = true;
            this.noDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.noDataGridViewTextBoxColumn.Width = 70;
            // 
            // examnameDataGridViewTextBoxColumn
            // 
            this.examnameDataGridViewTextBoxColumn.DataPropertyName = "exam_name";
            this.examnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.examnameDataGridViewTextBoxColumn.Name = "examnameDataGridViewTextBoxColumn";
            this.examnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.examnameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // effectivetimeDataGridViewTextBoxColumn
            // 
            this.effectivetimeDataGridViewTextBoxColumn.DataPropertyName = "effective_time";
            this.effectivetimeDataGridViewTextBoxColumn.HeaderText = "Effective Time";
            this.effectivetimeDataGridViewTextBoxColumn.Name = "effectivetimeDataGridViewTextBoxColumn";
            this.effectivetimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.effectivetimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.effectivetimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration(Mins)";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            this.durationDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.durationDataGridViewTextBoxColumn.Width = 150;
            // 
            // passcriteriaDataGridViewTextBoxColumn
            // 
            this.passcriteriaDataGridViewTextBoxColumn.DataPropertyName = "pass_criteria";
            this.passcriteriaDataGridViewTextBoxColumn.HeaderText = "Pass Criteria";
            this.passcriteriaDataGridViewTextBoxColumn.Name = "passcriteriaDataGridViewTextBoxColumn";
            this.passcriteriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.passcriteriaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.passcriteriaDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalscoreDataGridViewTextBoxColumn
            // 
            this.totalscoreDataGridViewTextBoxColumn.DataPropertyName = "total_score";
            this.totalscoreDataGridViewTextBoxColumn.HeaderText = "Exam/Total Score";
            this.totalscoreDataGridViewTextBoxColumn.Name = "totalscoreDataGridViewTextBoxColumn";
            this.totalscoreDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalscoreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.totalscoreDataGridViewTextBoxColumn.Width = 150;
            // 
            // operationDataGridViewTextBoxColumn
            // 
            this.operationDataGridViewTextBoxColumn.DataPropertyName = "operation";
            this.operationDataGridViewTextBoxColumn.HeaderText = "Operation";
            this.operationDataGridViewTextBoxColumn.Name = "operationDataGridViewTextBoxColumn";
            this.operationDataGridViewTextBoxColumn.ReadOnly = true;
            this.operationDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // searchExamBindingSource
            // 
            this.searchExamBindingSource.DataMember = "SearchExam";
            this.searchExamBindingSource.DataSource = this.oesDataSet;
            // 
            // oesDataSet
            // 
            this.oesDataSet.DataSetName = "oesDataSet";
            this.oesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblIDIncrease
            // 
            this.lblIDIncrease.BackColor = System.Drawing.Color.White;
            this.lblIDIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIDIncrease.Image = ((System.Drawing.Image)(resources.GetObject("lblIDIncrease.Image")));
            this.lblIDIncrease.Location = new System.Drawing.Point(225, 13);
            this.lblIDIncrease.Name = "lblIDIncrease";
            this.lblIDIncrease.Size = new System.Drawing.Size(10, 15);
            this.lblIDIncrease.TabIndex = 1;
            this.lblIDIncrease.Tag = "1";
            this.lblIDIncrease.Click += new System.EventHandler(this.lblIDIncrease_Click);
            // 
            // lblIDdecrease
            // 
            this.lblIDdecrease.BackColor = System.Drawing.Color.White;
            this.lblIDdecrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIDdecrease.Image = ((System.Drawing.Image)(resources.GetObject("lblIDdecrease.Image")));
            this.lblIDdecrease.Location = new System.Drawing.Point(225, 13);
            this.lblIDdecrease.Name = "lblIDdecrease";
            this.lblIDdecrease.Size = new System.Drawing.Size(10, 15);
            this.lblIDdecrease.TabIndex = 2;
            this.lblIDdecrease.Tag = "2";
            this.lblIDdecrease.Visible = false;
            this.lblIDdecrease.Click += new System.EventHandler(this.lblIDdecrease_Click);
            // 
            // lblNameDecrease
            // 
            this.lblNameDecrease.BackColor = System.Drawing.Color.White;
            this.lblNameDecrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNameDecrease.Image = ((System.Drawing.Image)(resources.GetObject("lblNameDecrease.Image")));
            this.lblNameDecrease.Location = new System.Drawing.Point(139, 12);
            this.lblNameDecrease.Name = "lblNameDecrease";
            this.lblNameDecrease.Size = new System.Drawing.Size(10, 15);
            this.lblNameDecrease.TabIndex = 3;
            this.lblNameDecrease.Tag = "2";
            this.lblNameDecrease.Visible = false;
            this.lblNameDecrease.Click += new System.EventHandler(this.lblNameDecrease_Click);
            // 
            // lblNameIncrease
            // 
            this.lblNameIncrease.BackColor = System.Drawing.Color.White;
            this.lblNameIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNameIncrease.Image = ((System.Drawing.Image)(resources.GetObject("lblNameIncrease.Image")));
            this.lblNameIncrease.Location = new System.Drawing.Point(139, 13);
            this.lblNameIncrease.Name = "lblNameIncrease";
            this.lblNameIncrease.Size = new System.Drawing.Size(10, 15);
            this.lblNameIncrease.TabIndex = 4;
            this.lblNameIncrease.Tag = "1";
            this.lblNameIncrease.Click += new System.EventHandler(this.lblNameIncrease_Click);
            // 
            // lblTimeIncrease
            // 
            this.lblTimeIncrease.BackColor = System.Drawing.Color.White;
            this.lblTimeIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTimeIncrease.Image = ((System.Drawing.Image)(resources.GetObject("lblTimeIncrease.Image")));
            this.lblTimeIncrease.Location = new System.Drawing.Point(385, 13);
            this.lblTimeIncrease.Name = "lblTimeIncrease";
            this.lblTimeIncrease.Size = new System.Drawing.Size(10, 15);
            this.lblTimeIncrease.TabIndex = 6;
            this.lblTimeIncrease.Tag = "1";
            this.lblTimeIncrease.Click += new System.EventHandler(this.lblTimeIncrease_Click);
            // 
            // lblTimeDecrease
            // 
            this.lblTimeDecrease.BackColor = System.Drawing.Color.White;
            this.lblTimeDecrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTimeDecrease.Image = ((System.Drawing.Image)(resources.GetObject("lblTimeDecrease.Image")));
            this.lblTimeDecrease.Location = new System.Drawing.Point(385, 12);
            this.lblTimeDecrease.Name = "lblTimeDecrease";
            this.lblTimeDecrease.Size = new System.Drawing.Size(10, 15);
            this.lblTimeDecrease.TabIndex = 5;
            this.lblTimeDecrease.Tag = "2";
            this.lblTimeDecrease.Visible = false;
            this.lblTimeDecrease.Click += new System.EventHandler(this.lblTimeDecrease_Click);
            // 
            // lblPassIncrease
            // 
            this.lblPassIncrease.BackColor = System.Drawing.Color.White;
            this.lblPassIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPassIncrease.Image = ((System.Drawing.Image)(resources.GetObject("lblPassIncrease.Image")));
            this.lblPassIncrease.Location = new System.Drawing.Point(682, 13);
            this.lblPassIncrease.Name = "lblPassIncrease";
            this.lblPassIncrease.Size = new System.Drawing.Size(10, 15);
            this.lblPassIncrease.TabIndex = 8;
            this.lblPassIncrease.Tag = "1";
            this.lblPassIncrease.Click += new System.EventHandler(this.lblPassIncrease_Click);
            // 
            // lblPassDecrease
            // 
            this.lblPassDecrease.BackColor = System.Drawing.Color.White;
            this.lblPassDecrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPassDecrease.Image = ((System.Drawing.Image)(resources.GetObject("lblPassDecrease.Image")));
            this.lblPassDecrease.Location = new System.Drawing.Point(682, 13);
            this.lblPassDecrease.Name = "lblPassDecrease";
            this.lblPassDecrease.Size = new System.Drawing.Size(10, 15);
            this.lblPassDecrease.TabIndex = 7;
            this.lblPassDecrease.Tag = "2";
            this.lblPassDecrease.Visible = false;
            this.lblPassDecrease.Click += new System.EventHandler(this.lblPassDecrease_Click);
            // 
            // lblTotalIncrease
            // 
            this.lblTotalIncrease.BackColor = System.Drawing.Color.White;
            this.lblTotalIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTotalIncrease.Image = ((System.Drawing.Image)(resources.GetObject("lblTotalIncrease.Image")));
            this.lblTotalIncrease.Location = new System.Drawing.Point(848, 13);
            this.lblTotalIncrease.Name = "lblTotalIncrease";
            this.lblTotalIncrease.Size = new System.Drawing.Size(10, 15);
            this.lblTotalIncrease.TabIndex = 10;
            this.lblTotalIncrease.Tag = "1";
            this.lblTotalIncrease.Click += new System.EventHandler(this.lblTotalIncrease_Click);
            // 
            // lblTotalDecrease
            // 
            this.lblTotalDecrease.BackColor = System.Drawing.Color.White;
            this.lblTotalDecrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTotalDecrease.Image = ((System.Drawing.Image)(resources.GetObject("lblTotalDecrease.Image")));
            this.lblTotalDecrease.Location = new System.Drawing.Point(848, 13);
            this.lblTotalDecrease.Name = "lblTotalDecrease";
            this.lblTotalDecrease.Size = new System.Drawing.Size(10, 15);
            this.lblTotalDecrease.TabIndex = 9;
            this.lblTotalDecrease.Tag = "2";
            this.lblTotalDecrease.Visible = false;
            this.lblTotalDecrease.Click += new System.EventHandler(this.lblTotalDecrease_Click);
            // 
            // lblCriteriaIncre
            // 
            this.lblCriteriaIncre.BackColor = System.Drawing.Color.White;
            this.lblCriteriaIncre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCriteriaIncre.Image = ((System.Drawing.Image)(resources.GetObject("lblCriteriaIncre.Image")));
            this.lblCriteriaIncre.Location = new System.Drawing.Point(950, 13);
            this.lblCriteriaIncre.Name = "lblCriteriaIncre";
            this.lblCriteriaIncre.Size = new System.Drawing.Size(10, 15);
            this.lblCriteriaIncre.TabIndex = 12;
            this.lblCriteriaIncre.Tag = "1";
            this.lblCriteriaIncre.Click += new System.EventHandler(this.lblCriteriaIncre_Click);
            // 
            // lblCriteriaDecre
            // 
            this.lblCriteriaDecre.BackColor = System.Drawing.Color.White;
            this.lblCriteriaDecre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCriteriaDecre.Image = ((System.Drawing.Image)(resources.GetObject("lblCriteriaDecre.Image")));
            this.lblCriteriaDecre.Location = new System.Drawing.Point(950, 12);
            this.lblCriteriaDecre.Name = "lblCriteriaDecre";
            this.lblCriteriaDecre.Size = new System.Drawing.Size(10, 15);
            this.lblCriteriaDecre.TabIndex = 11;
            this.lblCriteriaDecre.Tag = "2";
            this.lblCriteriaDecre.Visible = false;
            this.lblCriteriaDecre.Click += new System.EventHandler(this.lblCriteriaDecre_Click);
            // 
            // searchExamTableAdapter
            // 
            this.searchExamTableAdapter.ClearBeforeFill = true;
            // 
            // ExamList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCriteriaIncre);
            this.Controls.Add(this.lblCriteriaDecre);
            this.Controls.Add(this.lblTotalIncrease);
            this.Controls.Add(this.lblTotalDecrease);
            this.Controls.Add(this.lblPassIncrease);
            this.Controls.Add(this.lblPassDecrease);
            this.Controls.Add(this.lblTimeIncrease);
            this.Controls.Add(this.lblTimeDecrease);
            this.Controls.Add(this.lblNameIncrease);
            this.Controls.Add(this.lblNameDecrease);
            this.Controls.Add(this.lblIDdecrease);
            this.Controls.Add(this.lblIDIncrease);
            this.Controls.Add(this.dgvExamList);
            this.Name = "ExamList";
            this.Size = new System.Drawing.Size(980, 340);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchExamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExamList;

        public DataGridView GetDgvExamList() 
        {
            return this.dgvExamList;
        }
        private Label lblIDIncrease;
        private Label lblIDdecrease;
        private Label lblNameDecrease;
        private Label lblNameIncrease;
        private Label lblTimeIncrease;
        private Label lblTimeDecrease;
        private Label lblPassIncrease;
        private Label lblPassDecrease;
        private Label lblTotalIncrease;
        private Label lblTotalDecrease;
        private Label lblCriteriaIncre;
        private Label lblCriteriaDecre;
        private BindingSource searchExamBindingSource;
        private oesDataSet oesDataSet;
        private oesDataSetTableAdapters.SearchExamTableAdapter searchExamTableAdapter;
        private DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn examnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn effectivetimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passcriteriaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalscoreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn operationDataGridViewTextBoxColumn;
        
    }
}
