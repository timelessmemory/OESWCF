using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OesLogic;
using System.Collections;
using System.Runtime.InteropServices;
using OesUI.Custom;
using OesWCFContract;

namespace OesUI
{
    public partial class FormTakeExam : Form
    {
        private const string NO = "No";
        private const string XIE = "/";
        private const string PASS = "Pass";
        private const string NOPASS = "No Pass";
        //questionCount
        private static int? questionCount;

        private QuestionService.QuestionServiceClient questionManager = new QuestionService.QuestionServiceClient();
        private ExamService.ExamServiceClient examManager = new ExamService.ExamServiceClient();

        //Current question order 
        private static int? questionNumber;

        private int currentQuestionId;

        //save DAL method return data
        private QuestionDS.ExamQuestionDataTable questionTable;

        //Store student answer
        private List<string> answerList = new List<string>();

        //Store corrext answer
        private List<string> correctAnswerList = new List<string>();

        private int studentCorrectQuestionCount;
        private double studentGetScore;

        //set a flag to express isfinish exam
        private bool isExit;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        public const int VM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        /// <summary>
        /// Init parameter
        /// </summary>
        public FormTakeExam()
        {
            questionNumber = FormPassValue.questionSerial;
            studentCorrectQuestionCount = 0;
            studentGetScore = 0;
            isExit = false;

            InitializeComponent();
        }

        //Show Parent window
        private void FormTakeExam_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if exit exception, should record time
            if (!isExit)
            {
                examManager.InsertExamExceptionTime(RememberSomeParameter.userId, FormPassValue.examId, DateTime.Now);
            }

            this.Owner.Show();
        }

        /// <summary>
        /// Next question
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            questionNumber += 1;
            FillAnswer();
            FillQuestionData(questionNumber, questionCount);
        }

        //save user answer into database
        private void InsertUserAnswer(string userAnswer)
        {
            questionManager.InsertUserAnswer(RememberSomeParameter.userId, FormPassValue.examId, currentQuestionId, userAnswer);
        }

        /// <summary>
        /// Record student question answer
        /// </summary>
        private void FillAnswer()
        {
            if (this.rbtA.Checked == true)
            {
                InsertUserAnswer(this.rbtA.Text);
            }
            else if (this.rbtB.Checked == true)
            {
                InsertUserAnswer(this.rbtB.Text);
            }
            else if (this.rbtC.Checked == true)
            {
                InsertUserAnswer(this.rbtC.Text);
            }
            else if (this.rbtD.Checked == true)
            {
                InsertUserAnswer(this.rbtD.Text);
            }

            this.rbtA.Checked = true;
        }

        //load first question
        private void FormTakeExam_Load(object sender, EventArgs e)
        {
            questionCount = FormPassValue.questionQuantity;
            questionTable = questionManager.FindQuestionByExamId(FormPassValue.examId);
            FormPassValue.questionTable = questionTable;
            
            FillQuestionData(questionNumber, questionCount);
            this.lblEachPoint.Text = FormPassValue.eachQuestionPoint.ToString();
        }

        /// <summary>
        /// Fill question in exam paper
        /// </summary>
        /// <param name="questionNum"></param>
        /// <param name="questionQuantity"></param>
        private void FillQuestionData(int? questionNum, int? questionQuantity)
        {
            //Database should return row_number as "No" column
            var afterQuestions = from q in questionTable where Convert.ToInt32((q[NO])) == questionNum select new { No = (q[NO]), q.id, q.title, q.answer_a, q.answer_b, q.answer_c, q.answer_d, q.correct_answer };
            
            foreach (var item in afterQuestions)
            {
                this.lblQuesNum.Text = questionNum.ToString();
                this.lblQuesTitle.Text = item.title;
                this.lblAnswerA.Text = item.answer_a;
                this.lblAnswerB.Text = item.answer_b;
                this.lblAnswerC.Text = item.answer_c;
                this.lblAnswerD.Text = item.answer_d;
                this.lblPercent.Text = questionNum + XIE + questionQuantity;

                currentQuestionId = item.id;
            }

            if (questionNumber == questionCount)
            {
                this.btnNext.Visible = false;
                this.btnSubmit.Visible = true;
            }
        }

        /// <summary>
        /// Student submits exam calculate result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Submit_Click(object sender, EventArgs e)
        {
            FillAnswer();

            CalculateResult(false);

            isExit = true;

            //hide exam panel
            this.pnlMainLayout.Visible = false;

            //show result panel
            this.pnlExamResult.Visible = true;
        }

        //load user answer and correct answer
        private void GetUserAnswerAndCorrectAnswer()
        {
            //query userAnswer

            QuestionDS.exam_answer_detailDataTable tableAdapter = questionManager.FindUserAnswer(RememberSomeParameter.userId, FormPassValue.examId);
            var rs = from s in tableAdapter select new { s.user_answer };
            foreach (var item in rs)
            {
                answerList.Add(item.user_answer);
            }

            //query correct answer
            var afterQuestions = from q in questionTable select new { q.correct_answer };
            foreach (var item in afterQuestions)
            {
                correctAnswerList.Add(item.correct_answer);
            }
        }

        /// <summary>
        /// Calculate exam result and insert result to database,
        /// then show result to student
        /// </summary>
        private void CalculateResult(bool isAutoCommit)
        {
            GetUserAnswerAndCorrectAnswer();
            FormPassValue.answerList = answerList;
            FormPassValue.correctAnswerList = correctAnswerList;

            for (int i = 0; i < answerList.Count; i++)
            {
                if (answerList[i].Equals(correctAnswerList[i]))
                {
                    studentCorrectQuestionCount++;
                    studentGetScore += FormPassValue.eachQuestionPoint;
                }
            }

            DealWithExamResult();

            if (isAutoCommit)
            {
                this.lblAutoGetScore.Text = studentGetScore.ToString();
                this.lblAutoCorrectNum.Text = studentCorrectQuestionCount.ToString();
            }
            else
            {
                this.lblGetScore.Text = studentGetScore.ToString();
                this.lblCorrectCount.Text = studentCorrectQuestionCount.ToString();
            }

            FormPassValue.getScore = studentGetScore;
            FormPassValue.correctCount = studentCorrectQuestionCount;
        }

        //close window
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// DealWithStudentAnswer
        /// </summary>
        private void DealWithExamResult()
        {
            string isPassed = Constants.emptyStr;
            if (studentGetScore < FormPassValue.passCriteria)
            {
                isPassed = NOPASS;
            }
            else if (studentGetScore > FormPassValue.passCriteria)
            {
                isPassed = PASS;
            }

            // insert student grade and isPassed
            ExamService.ExamServiceClient examManager = new ExamService.ExamServiceClient();

            //if need to query grade randomly, should insert correct quantity
            examManager.InsertExanResultById(RememberSomeParameter.userId, FormPassValue.examId, studentGetScore, isPassed);
            
            // update dataGridView dataSource so that avoid student take exam again
            MyExam form = (this.Owner as FormExamList).GetPnlMyExam();
            form.GetAllExam().GetDgvExamList().DataSource =
                examManager.SearchExam(QueryExamState.SortColumn, QueryExamState.SortDirection, form.GetCurrentPage(),
                form.GetPageSize(), QueryExamState.KeywordState, RememberSomeParameter.username);
        }

        /// <summary>
        /// Timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime Now = DateTime.Now;
            TimeSpan durationTime = Now - FormPassValue.effectiveTime;
            string tsHour = durationTime.Hours.ToString();
            string tsMin = durationTime.Minutes.ToString();
            string tsSecond = durationTime.Seconds.ToString();

            this.lblTimer.Text = tsHour + ":" + tsMin + ":" + tsSecond;

            //Calculate isOverTime
            TimeSpan tsEndTiem = new TimeSpan(FormPassValue.endTime.Ticks);
            TimeSpan tsNow = new TimeSpan(DateTime.Now.Ticks);
            double timeInterval = tsNow.Subtract(tsEndTiem).TotalSeconds;

            //if over time then auto submit
            if (timeInterval >= 0 && this.pnlAutoResult.Visible == false)
            {
                CalculateResult(true);

                //hide exam panel
                this.pnlMainLayout.Visible = false;

                //show result panel
                this.pnlAutoResult.Visible = true;
            }
        }

        //show student exam answer details form
        private void lblViewDetail_Click(object sender, EventArgs e)
        {
            //show result details
            FormResultDetails formResultDetails = new FormResultDetails();
            formResultDetails.Show(this.Owner);
            this.Close();
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, VM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
    }
}
