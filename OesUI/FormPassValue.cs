using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OesWCFContract;

namespace OesUI
{
    public static class FormPassValue
    {
        public static int examId;
        public static DateTime effectiveTime;
        public static double eachQuestionPoint;
        public static DateTime endTime;
        public static double passCriteria;
        public static string examName;
        public static int duration;
        public static int questionQuantity;
        public static double totalScore;
        public static double getScore;
        public static int correctCount;

        public static List<string> answerList = new List<string>();
        public static List<string> correctAnswerList = new List<string>();
        public static QuestionDS.ExamQuestionDataTable questionTable;

        public static int questionSerial = 1;
    }
}
