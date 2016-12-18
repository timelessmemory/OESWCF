using System;
using OesDAL;
using OesDAL.QuestionDSTableAdapters;

namespace OesLogic
{
    public class QuestionManager
    {
        /// <summary>
        /// Query exam question
        /// </summary>
        /// <param name="id">examId</param>
        /// <returns></returns>
        public OesDAL.QuestionDS.ExamQuestionDataTable FindQuestionByExamId(int? id) 
        {
            try
            {
                ExamQuestionTableAdapter questionAdapter = new ExamQuestionTableAdapter();
                return questionAdapter.FindQuestionByExamId(id);
            }
            catch (Exception e)
            {
                Log4NetHelper.WriteErrorLog(typeof(QuestionManager), e);
            }
            return null;
        }

        //get question total
        public int? QueryQuestionCount(int id)
        {
            try
            {
                questionTableAdapter questionAdapter = new questionTableAdapter();
                return questionAdapter.QueryQuestionCount(id);
            }
            catch (Exception e)
            {
                Log4NetHelper.WriteErrorLog(typeof(QuestionManager), e);
            }
            return null;
        }

        public int QueryHaveAnsweredQuestionNumber(int userId, int examId)
        {
            try
            {
                exam_answer_detailTableAdapter detailAdapter = new exam_answer_detailTableAdapter();
                return Convert.ToInt32(detailAdapter.QueryHaveAnsweredQuestionNumber(userId, examId));
            }
            catch (Exception e)
            {
                Log4NetHelper.WriteErrorLog(typeof(QuestionManager), e);
            }
            return 0;
        }

        public QuestionDS.exam_answer_detailDataTable FindUserAnswer(int userId, int examId)
        {
            try
            {
                exam_answer_detailTableAdapter adapter = new exam_answer_detailTableAdapter();
                return adapter.FindUserAnswer(userId, examId);
            }
            catch (Exception e)
            {
                Log4NetHelper.WriteErrorLog(typeof(QuestionManager), e);
            }
            return null;
        }

        /// <summary>
        /// Save user answer
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="examId"></param>
        /// <param name="questionId"></param>
        /// <param name="userAnswer"></param>
        public int InsertUserAnswer(int userId, int examId, int questionId, string userAnswer)
        {
            int answerId = 0;
            try
            {
                exam_answer_detailTableAdapter adapter = new exam_answer_detailTableAdapter();
                answerId = Convert.ToInt32(adapter.InsertUserAnswer(userId, examId, questionId, userAnswer));
            }
            catch (Exception e)
            {
                Log4NetHelper.WriteErrorLog(typeof(QuestionManager), e);
            }
            return answerId;
        }
    }
}
