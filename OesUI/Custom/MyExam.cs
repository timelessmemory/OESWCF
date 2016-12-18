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
    public partial class MyExam : UserControl
    {
        private const string showWhichSortIcon = "1";
        private Color stateBackColor = Color.FromArgb(46, 67, 88);
        private int[] pageSizeCollection = new int[] { 5, 10, 15};
        private const string hintFirst = "This is the first page!";
        private const string hintLast = "This is the last page!";
        private string tipPageInput = "Please input page number!";

        //private ExamManager examManager = new ExamManager();
        private ExamService.ExamServiceClient examManager = new ExamService.ExamServiceClient();
        private PaginationUtils paginationUtils;

        public int GetCurrentPage()
        {
            return paginationUtils.CurrentPage;
        }

        public int GetPageSize()
        {
            return paginationUtils.PageSize;
        }

        public MyExam()
        {
            InitializeComponent();

            paginationUtils = new PaginationUtils(this.pnlPagination, this.customTipDialog1, hintFirst,
                hintLast, tipPageInput, pageSizeCollection, MultiPosibilityQuery);
        }

        //reset sort direction
        private void ResetSortBtn(UserControl userControl)
        {
            foreach (Control item in userControl.Controls)
            {
                if (item is Label)
                {
                    Label label = item as Label;
                    if (label.Tag.Equals(showWhichSortIcon))
                    {
                        label.Visible = true;
                    }
                    else
                    {
                        label.Visible =false;
                    }
                }
            }
        }

        //Tab
        private void lblAll_Click(object sender, EventArgs e)
        {
            //reset parameter and update all exam data
            QueryExamState.KeywordState = Constants.allState;
            QueryExamState.SortColumn = Constants.idColumn;
            QueryExamState.SortDirection = Constants.increase;
            paginationUtils.CurrentPage = 1;
            ResetSortBtn(this.AllExam);///TODO
            GetAllExamData();

            this.lblAll.BackColor = stateBackColor;
            this.lblAll.ForeColor = Color.White;

            this.lblFinishedExam.BackColor = Color.White;
            this.lblFinishedExam.ForeColor = Color.Black;

            this.lblUnfinishedExam.BackColor = Color.White;
            this.lblUnfinishedExam.ForeColor = Color.Black;
        }

        private void lblFinishedExam_Click(object sender, EventArgs e)
        {
            //reset parameter and update finished exam data
            QueryExamState.KeywordState = Constants.finishedState;
            QueryExamState.SortColumn = Constants.idColumn;
            QueryExamState.SortDirection = Constants.increase;
            paginationUtils.CurrentPage = 1;
            GetFinishedExamData();

            this.lblAll.BackColor = Color.White;
            this.lblAll.ForeColor = Color.Black;

            this.lblFinishedExam.BackColor = stateBackColor;
            this.lblFinishedExam.ForeColor = Color.White;

            this.lblUnfinishedExam.BackColor = Color.White;
            this.lblUnfinishedExam.ForeColor = Color.Black;
        }

        private void lblUnfinishedExam_Click(object sender, EventArgs e)
        {
            //reset parameter and update unfinished exam data
            QueryExamState.KeywordState = Constants.unfinishedState;
            QueryExamState.SortColumn = Constants.idColumn;
            QueryExamState.SortDirection = Constants.increase;
            paginationUtils.CurrentPage = 1;
            GetUnfinishedExamData();

            this.lblAll.BackColor = Color.White;
            this.lblAll.ForeColor = Color.Black;

            this.lblFinishedExam.BackColor = Color.White;
            this.lblFinishedExam.ForeColor = Color.Black;

            this.lblUnfinishedExam.BackColor = stateBackColor;
            this.lblUnfinishedExam.ForeColor = Color.White;
        }

        private void GetUnfinishedExamData()
        {
            MultiPosibilityQuery();
            paginationUtils.CustPagination(paginationUtils.CurrentPage, paginationUtils.TotalPage);
        }

        private void GetFinishedExamData()
        {
            MultiPosibilityQuery();
            paginationUtils.CustPagination(paginationUtils.CurrentPage, paginationUtils.TotalPage);
        }

        private void GetAllExamData()
        {
            MultiPosibilityQuery();
            paginationUtils.CustPagination(paginationUtils.CurrentPage, paginationUtils.TotalPage);
        }

        private void AllExam_Load(object sender, EventArgs e)
        {
            GetAllExamData();
        }

        private void MultiPosibilityQuery()
        {
            paginationUtils.TotalRecord = examManager.getExamCount(RememberSomeParameter.username, QueryExamState.KeywordState);
            this.AllExam.GetDgvExamList().DataSource = examManager.SearchExam(QueryExamState.SortColumn, QueryExamState.SortDirection,
                paginationUtils.CurrentPage, paginationUtils.PageSize, QueryExamState.KeywordState, RememberSomeParameter.username);
        }

        private void MyExam_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
