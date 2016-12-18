using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using OesLogic;
using OesUI.Custom;
using System.Runtime.InteropServices;
using OesWCFContract;

namespace OesUI
{
    public partial class FormResultDetails : Form
    {
        private const string NO = "No";
        private const string MIN = "min";
        private QuestionDS.ExamQuestionDataTable questionTable;
        private static List<string> answerList = new List<string>();
        private static List<string> correctAnswerList = new List<string>();
        private Color correctAnswerOptionColor = Color.FromArgb(210, 218, 227);
        private Color formalAnswerOptionColor = Color.White;

        //questionCount
        private static int questionCount;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        public const int VM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        public FormResultDetails()
        {
            InitializeComponent();
        }

        //show result detail
        private void FormResultDetails_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();

            //prepare data
            questionCount = FormPassValue.questionQuantity;
            questionTable = FormPassValue.questionTable;
            answerList = FormPassValue.answerList;
            correctAnswerList = FormPassValue.correctAnswerList;

            //fill exam information
            FillData();

            //isCorrectIcon parameter
            int isCorrectIconX = 130;
            int isCorrectIconY = 290;
            int isCorrectIconWidth = 30;
            int isCorrectIconHeight = 30;

            //question serial parameter
            Font questionSerialAndTitleFont = new Font(Constants.Arial, 15);
            int questionSerialX = 190;
            int questionSerialY = 290;
            int questionSerialWidth = 30;
            int questionSerialHeight = 25;
            Color fontColor = Color.FromArgb(10, 10, 10);
            Color correctBorderColor = Color.FromArgb(254, 153, 1);
            Color incorrectBorderColor = Color.FromArgb(185, 31, 31);

            //question title parameter
            int questionTitlelblHeight = 30;
            int questionTitlelblWidth = 700;
            int questionTitlelblX = 230;
            int questionTitlelblY = 290;

            //public parameter
            Font answerOptionFont = new Font(Constants.Arial, 13.5f);
            int rdoWidth = 40;
            int rdoHeight = 20;
            int answerlblWidth = 720;
            int answerlblHeight = 20;

            //answerA radio position
            int answerArdoX = 190;
            int answerArdoY = 350;

            //answerA item position
            int answerAX = 240;
            int answerAY = 350;

            int answerBrdoX = 190;
            int answerBrdoY = 390;

            int answerBX = 240;
            int answerBY = 390;

            int answerCrdoX = 190;
            int answerCrdoY = 430;

            int answerCX = 240;
            int answerCY = 430;

            int answerDrdoX = 190;
            int answerDrdoY = 470;

            int answerDX = 240;
            int answerDY = 470;

            //question position offset
            int positionYOffset = 250;

            Color optionBgColor = Color.White;
            bool isChecked = false;

            for (int i = 1; i <= questionCount; i++)
            {
                string title = Constants.emptyStr;
                string answerA = Constants.emptyStr;
                string answerB = Constants.emptyStr;
                string answerC = Constants.emptyStr;
                string answerD = Constants.emptyStr;

                var question = from q in questionTable where Convert.ToInt32((q[NO])) == i 
                               select new { No = (q[NO]), q.title, q.answer_a, q.answer_b, q.answer_c, q.answer_d };

                foreach(var item in question)
                {
                    title = item.title;
                    answerA = item.answer_a;
                    answerB = item.answer_b;
                    answerC = item.answer_c;
                    answerD = item.answer_d;
                }

                int tmpNum = i - 1;

                if (tmpNum < answerList.Count && answerList[tmpNum].Equals(correctAnswerList[tmpNum]))
                {
                    //correct icon
                    CreateIsCorrectIcon(OesUI.Properties.Resources.ICN_Right_15x15, isCorrectIconWidth, 
                        isCorrectIconHeight, isCorrectIconX, isCorrectIconY);
                    
                    //questionSerial
                    CreateQuestionSerial(questionSerialAndTitleFont, i.ToString(), questionSerialHeight, questionSerialWidth,
                        questionSerialX, questionSerialY, correctBorderColor, fontColor);
                }
                else
                {
                    //inCorrect icon
                    CreateIsCorrectIcon(OesUI.Properties.Resources.ICN_Wrong_15x15, isCorrectIconWidth, 
                        isCorrectIconHeight, isCorrectIconX, isCorrectIconY);

                    //incorrect questionSerial
                    CreateQuestionSerial(questionSerialAndTitleFont, i.ToString(), questionSerialHeight, 
                        questionSerialWidth, questionSerialX, questionSerialY, incorrectBorderColor, fontColor);
                }

                //questionTitle
                CreateQuestionTitle(questionSerialAndTitleFont, title, questionTitlelblHeight, questionTitlelblWidth, 
                    questionTitlelblX, questionTitlelblY);

                //answerARadio
                string tmpCorrectAnswer = correctAnswerList[tmpNum];
                string tmpUserAnswer = Constants.emptyStr;

                if (tmpNum < answerList.Count)
                {
                    tmpUserAnswer = answerList[tmpNum];
                }

                isChecked = ChooseUserAnswerRadio(tmpUserAnswer, Constants.aOption, isChecked);
                CreateAnswerRadio(isChecked, questionSerialAndTitleFont, Constants.aOption, rdoWidth, rdoHeight, answerArdoX, answerArdoY);

                //answerAItem
                optionBgColor = ChooseWhichColor(tmpCorrectAnswer, Constants.aOption, optionBgColor);
                CreateAnswerItem(optionBgColor, answerOptionFont, answerA, answerlblWidth, answerlblHeight, answerAX, answerAY);

                //answerBRadio
                isChecked = ChooseUserAnswerRadio(tmpUserAnswer, Constants.bOption, isChecked);
                CreateAnswerRadio(isChecked, questionSerialAndTitleFont, Constants.bOption, rdoWidth, rdoHeight, answerBrdoX, answerBrdoY);

                //answerBItem
                optionBgColor = ChooseWhichColor(tmpCorrectAnswer, Constants.bOption, optionBgColor);
                CreateAnswerItem(optionBgColor, answerOptionFont, answerB, answerlblWidth, answerlblHeight, answerBX, answerBY);

                //answerCRadio
                isChecked = ChooseUserAnswerRadio(tmpUserAnswer, Constants.cOption, isChecked);
                CreateAnswerRadio(isChecked, questionSerialAndTitleFont, Constants.cOption, rdoWidth, rdoHeight, answerCrdoX, answerCrdoY);

                //answerCItem
                optionBgColor = ChooseWhichColor(tmpCorrectAnswer, Constants.cOption, optionBgColor);
                CreateAnswerItem(optionBgColor, answerOptionFont, answerC, answerlblWidth, answerlblHeight, answerCX, answerCY);

                //answerDRadio
                isChecked = ChooseUserAnswerRadio(tmpUserAnswer, Constants.dOption, isChecked);
                CreateAnswerRadio(isChecked, questionSerialAndTitleFont, Constants.dOption, rdoWidth, rdoHeight, answerDrdoX, answerDrdoY);

                //answerDItem
                optionBgColor = ChooseWhichColor(tmpCorrectAnswer, Constants.dOption, optionBgColor);
                CreateAnswerItem(optionBgColor, answerOptionFont, answerD, answerlblWidth, answerlblHeight, answerDX, answerDY);

                //position offset
                isCorrectIconY += positionYOffset;
                questionSerialY += positionYOffset;
                questionTitlelblY += positionYOffset;
                answerArdoY += positionYOffset;
                answerAY += positionYOffset;
                answerBrdoY += positionYOffset;
                answerBY += positionYOffset;
                answerCrdoY += positionYOffset;
                answerCY += positionYOffset;
                answerDrdoY += positionYOffset;
                answerDY += positionYOffset;
            }
        }

        private bool ChooseUserAnswerRadio(string userAnswer, string option, bool isCheck)
        {
            if (userAnswer.Equals(option))
            {
                isCheck = true;
            }
            else
            {
                isCheck = false;
            }
            return isCheck;
        }

        private Color ChooseWhichColor(string correctAnswer, string option, Color origin)
        {
            if (correctAnswer.Equals(option))
            {
                origin = correctAnswerOptionColor;
            }
            else
            {
                origin = formalAnswerOptionColor;
            }
            return origin;
        }

        private void CreateIsCorrectIcon(Image image ,int width, int height, int x, int y)
        {
            Label isCorrectIcon = new Label();
            isCorrectIcon.Image = image;
            isCorrectIcon.AutoSize = false;
            isCorrectIcon.Width = width;
            isCorrectIcon.Height = height;
            Point isCorrectIconLoc = new Point(x, y);
            isCorrectIcon.Location = isCorrectIconLoc;
            this.Controls.Add(isCorrectIcon);
        }

        private void CreateQuestionSerial(Font font, string text, int height, int width, int x, int y, Color borderColor, Color fontColor)
        {
            QuestionSerial questionSerial = new QuestionSerial();
            questionSerial.BorderColor = borderColor;
            questionSerial.FontColor = fontColor;
            questionSerial.Font = font;
            questionSerial.Text = text;
            questionSerial.Height = height;
            questionSerial.Width = width;
            Point questionSerialLoc = new Point(x, y);
            questionSerial.Location = questionSerialLoc;
            this.Controls.Add(questionSerial);
        }

        private void CreateQuestionTitle(Font font, string text, int height, int width, int x, int y)
        {
            Label questionTitlelbl = new Label();
            questionTitlelbl.TextAlign = ContentAlignment.MiddleLeft;
            questionTitlelbl.Font = font;
            questionTitlelbl.Text = text;
            questionTitlelbl.AutoSize = false;
            questionTitlelbl.Height = height;
            questionTitlelbl.Width = width;
            Point questionTitlelblLoc = new Point(x, y);
            questionTitlelbl.Location = questionTitlelblLoc;
            this.Controls.Add(questionTitlelbl);
        }

        private void CreateAnswerRadio(bool isChecked, Font font,string radioText, int radioWidth, int radioHeight, int radioX, int radioY)
        {
            RadioButton answerRadio = new RadioButton();
            answerRadio.Checked = isChecked;
            answerRadio.Enabled = false;
            answerRadio.Font = font;
            answerRadio.Text = radioText;
            answerRadio.AutoSize = false;
            answerRadio.Width = radioWidth;
            answerRadio.Height = radioHeight;
            Point answerRadioLoc = new Point(radioX, radioY);
            answerRadio.Location = answerRadioLoc;
            this.Controls.Add(answerRadio);
        }

        private void CreateAnswerItem(Color answerBgColor, Font font, string text, int width, int height, int x, int y)
        {
            Label answerItem = new Label();
            answerItem.Font = font;
            answerItem.Text = text;
            answerItem.BackColor = answerBgColor;
            answerItem.AutoSize = false;
            answerItem.Width = width;
            answerItem.Height = height;
            Point answerItemLoc = new Point(x, y);
            answerItem.Location = answerItemLoc;
            this.Controls.Add(answerItem);
        }

        private void FillData()
        {
            this.lblNameValue.Text = FormPassValue.examName;
            this.lblIdValue.Text = FormPassValue.examId.ToString();
            this.lblEffectiveTimeValue.Text = FormPassValue.effectiveTime.ToString();
            this.lblTotalScore.Text = FormPassValue.getScore.ToString();
            this.lblTotalScoreValue.Text = FormPassValue.totalScore.ToString();
            this.lblDurationvalue.Text = FormPassValue.duration + MIN;
            this.lblGetScoreValue.Text = FormPassValue.getScore.ToString();
            this.lblcorrectCount.Text = FormPassValue.correctCount.ToString();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, VM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
    }
}
