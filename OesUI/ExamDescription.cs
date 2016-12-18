using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OesLogic;
using System.Runtime.InteropServices;
using OesWCFContract;

namespace OesUI
{
    public partial class ExamDescription : Form
    {
        private const string haveNotStartMessage = "The exam hasn't gotton time!";
        private const string haveEndMessage = "The exam has finished!";
        private const string ZERO = "0";
        private const string DAY = " day ";
        private const string COLON = ":";
        private const string EOO = "E00";
        private const string MIN = "min";

        private ExamService.ExamServiceClient examManager = new ExamService.ExamServiceClient();
        private QuestionService.QuestionServiceClient questionManager = new QuestionService.QuestionServiceClient();
        //save it so that other method can use it
        private DateTime effectiveTime;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        public const int VM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        public ExamDescription()
        {
            InitializeComponent();
        }

        private void StartTest_Click(object sender, EventArgs e)
        {
            ExamDS.exam_exceptionDataTable datatable = examManager.GetExceptionOccurTime(RememberSomeParameter.userId, FormPassValue.examId);

               //exception
            if (datatable.Rows.Count > 0)
            {
                DateTime exceptiontime;
                var rs = from dt in datatable select new { dt.occur_time };

                foreach (var item in rs)
                {
                    exceptiontime = item.occur_time;
                }

                //if (DateTime.Now - exceptiontime)
                //whether add exption duration to endtime
                int haveAnsweredNum = questionManager.QueryHaveAnsweredQuestionNumber(RememberSomeParameter.userId, FormPassValue.examId);
                
                //begin from which question
                FormPassValue.questionSerial = haveAnsweredNum + 1;
                this.DialogResult = DialogResult.OK;
            }
            else
                //normal
            {
                TimeSpan tsNow = new TimeSpan((DateTime.Now).Ticks);
                TimeSpan tsEffective = new TimeSpan(effectiveTime.Ticks);
                double timeInterval = tsEffective.Subtract(tsNow).TotalSeconds;

                if (timeInterval > 0)
                {
                    this.lblHintMessage.Text = haveNotStartMessage;
                    this.pnlHint.Visible = true;
                }
                else
                {
                    TimeSpan tsEnd = new TimeSpan(FormPassValue.endTime.Ticks);
                    double endTimeInterval = tsNow.Subtract(tsEnd).TotalSeconds;

                    if (endTimeInterval >= 0)
                    {
                        this.lblHintMessage.Text = haveEndMessage;
                        this.pnlHint.Visible = true;
                        return;
                    }
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime Now = DateTime.Now;
            TimeSpan durationTime = effectiveTime - Now;
            string tsDay = durationTime.Days.ToString();
            string tsHour = durationTime.Hours.ToString();
            string tsMin = durationTime.Minutes.ToString();
            string tsSecond = durationTime.Seconds.ToString();
            if (tsDay.Equals(ZERO))
            {
                this.TimerShow.Text = tsHour + COLON + tsMin + COLON + tsSecond;
            }
            else
            {
                this.TimerShow.Text = tsDay + DAY + tsHour + COLON + tsMin + COLON + tsSecond;
            }
        }

        //Show exam information and transfer value
        private void ExamDescription_Load(object sender, EventArgs e)
        {
            QueryExamInfo();

            timer1.Start();
        }

        /// <summary>
        /// Query exam information
        /// </summary>
        private void QueryExamInfo()
        {
            int examId = FormPassValue.examId;
            var exam = examManager.getExamById(examId);

            //just get one record
            foreach (var item in exam)
            {
                FormPassValue.eachQuestionPoint = item.single_question_score;
                FormPassValue.passCriteria = item.pass_criteria;

                FormPassValue.examName = item.exam_name;
                this.lblNameValue.Text = FormPassValue.examName;
                this.lblIdValue.Text = EOO + examId;

                DateTime TmpEffectiveTime = item.effective_time;
                effectiveTime = TmpEffectiveTime;
                FormPassValue.effectiveTime = TmpEffectiveTime;
                this.lblEffectiveTimeValue.Text = TmpEffectiveTime.ToString();

                FormPassValue.endTime = TmpEffectiveTime.AddMinutes(item.duration);
                this.lblEndTimeValue.Text = FormPassValue.endTime.ToString();
                FormPassValue.duration = item.duration;
                this.lblDurationvalue.Text = FormPassValue.duration + MIN;

                FormPassValue.totalScore = item.total_score;
                this.lblTotalScoreValue.Text = FormPassValue.totalScore.ToString();

                FormPassValue.questionQuantity = item.question_quantity;
                this.lblQuestionCountValue.Text = FormPassValue.questionQuantity.ToString();
            }
        }

        //Close exam description dialogform
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Hide hint panel
        private void lblHintClose_Click(object sender, EventArgs e)
        {
            this.pnlHint.Visible = false;
        }

        //Hide hint panel
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.pnlHint.Visible = false;
        }

        private void lblTitleBack_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, VM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
    }
}
