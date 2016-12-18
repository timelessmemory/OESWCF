using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OesLogic;

namespace OesUI.Custom
{
    public partial class ExamList : UserControl
    {
        private ExamService.ExamServiceClient examManager = new ExamService.ExamServiceClient();

        public ExamList()
        {
            InitializeComponent();
        }

        //extract repeated code
        private void DynamicSort(ExamService.ExamServiceClient examManager, string SortColumn, string SortDirection)
        {
            QueryExamState.SortColumn = SortColumn;
            QueryExamState.SortDirection = SortDirection;
            this.dgvExamList.DataSource = examManager.SearchExam(QueryExamState.SortColumn, QueryExamState.SortDirection, 
                ((MyExam)this.Parent).GetCurrentPage(), 
                ((MyExam)this.Parent).GetPageSize(), QueryExamState.KeywordState, RememberSomeParameter.username);
        }

        //Sort
        //ID
        private void lblIDIncrease_Click(object sender, EventArgs e)
        {
            this.lblIDdecrease.Visible = true;
            this.lblIDIncrease.Visible = false;
            DynamicSort(examManager, Constants.idColumn, Constants.decrease);
        }

        private void lblIDdecrease_Click(object sender, EventArgs e)
        {
            this.lblIDdecrease.Visible = false;
            this.lblIDIncrease.Visible = true;
            DynamicSort(examManager, Constants.idColumn, Constants.increase);
        }

        //Name
        private void lblNameDecrease_Click(object sender, EventArgs e)
        {
            this.lblNameDecrease.Visible = false;
            this.lblNameIncrease.Visible = true;
            DynamicSort(examManager, Constants.nameColumn, Constants.increase);
        }

        private void lblNameIncrease_Click(object sender, EventArgs e)
        {
            this.lblNameDecrease.Visible = true;
            this.lblNameIncrease.Visible = false;
            DynamicSort(examManager, Constants.nameColumn, Constants.decrease);
        }

        //time
        private void lblTimeDecrease_Click(object sender, EventArgs e)
        {
            this.lblTimeDecrease.Visible = false;
            this.lblTimeIncrease.Visible = true;
            DynamicSort(examManager, Constants.effectiveTimeColumn, Constants.increase);
        }

        private void lblTimeIncrease_Click(object sender, EventArgs e)
        {
            this.lblTimeDecrease.Visible = true;
            this.lblTimeIncrease.Visible = false;
            DynamicSort(examManager, Constants.effectiveTimeColumn, Constants.decrease);
        }

        //pass
        private void lblPassDecrease_Click(object sender, EventArgs e)
        {
            this.lblPassDecrease.Visible = false;
            this.lblPassIncrease.Visible = true;
            DynamicSort(examManager, Constants.passCriteriaColumn, Constants.increase);
        }

        private void lblPassIncrease_Click(object sender, EventArgs e)
        {
            this.lblPassDecrease.Visible = true;
            this.lblPassIncrease.Visible = false;
            DynamicSort(examManager, Constants.passCriteriaColumn, Constants.decrease);
        }

        //total
        private void lblTotalDecrease_Click(object sender, EventArgs e)
        {
            this.lblTotalDecrease.Visible = false;
            this.lblTotalIncrease.Visible = true;
            DynamicSort(examManager, Constants.totalScoreColumn, Constants.increase);
        }

        private void lblTotalIncrease_Click(object sender, EventArgs e)
        {
            this.lblTotalDecrease.Visible = true;
            this.lblTotalIncrease.Visible = false;
            DynamicSort(examManager, Constants.totalScoreColumn, Constants.decrease);
        }

        //criteria
        private void lblCriteriaDecre_Click(object sender, EventArgs e)
        {
            this.lblCriteriaDecre.Visible = false;
            this.lblCriteriaIncre.Visible = true;
            DynamicSort(examManager, Constants.operationColumn, Constants.increase);
        }

        private void lblCriteriaIncre_Click(object sender, EventArgs e)
        {
            this.lblCriteriaDecre.Visible = true;
            this.lblCriteriaIncre.Visible = false;
            
            DynamicSort(examManager, Constants.operationColumn, Constants.decrease);
        }

        //datagridview bgcolor
        private void dgvExamList_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvExamList.CurrentRow != null)
            {
                dgvExamList.Rows[dgvExamList.CurrentRow.Index].DefaultCellStyle.SelectionBackColor = Color.AliceBlue;
            }
        }

        //Do it
        private void dgvExamList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && this.dgvExamList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Equals(Constants.doIt))
            {
                ExamDescription examDescription = new ExamDescription();
                //transfer examId
                FormPassValue.examId = Convert.ToInt32(this.dgvExamList.Rows[e.RowIndex].Cells[2].Value);
                DialogResult result = examDescription.ShowDialog();

                if (result == DialogResult.OK)
                {
                    //avoid write outside, that run form take exam timer
                    FormTakeExam formTakeExam = new FormTakeExam();

                    //show take exam form and transfer main form object
                    formTakeExam.Show(this.Parent.Parent.Parent.Parent.Parent);
                    //Hide main form
                    this.Parent.Parent.Parent.Parent.Parent.Hide();
                }
            }
        }

        private void dgvExamList_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                dgvExamList.Rows[e.RowIndex].Selected = true;
                dgvExamList.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            }
        }

        private void dgvExamList_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvExamList.Rows[e.RowIndex].Selected = false;
                dgvExamList.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.White;
            }
        }

    }
}
