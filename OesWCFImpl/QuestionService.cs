using OesLogic;
using OesWCFContract;

namespace OesWCFImpl
{
    public class QuestionService : IQuestionService
    {
        /// <summary>
        /// query qustions associated with one exam
        /// </summary>
        /// <param name="id">examid</param>
        /// <returns>question datatable</returns>
        public QuestionDS.ExamQuestionDataTable FindQuestionByExamId(int? id)
        {
            QuestionManager manager = new QuestionManager();
            QuestionDS.ExamQuestionDataTable table = new QuestionDS.ExamQuestionDataTable();
            table.Merge(manager.FindQuestionByExamId(id));
            return table;
        }

        /// <summary>
        /// query count of one exam
        /// </summary>
        /// <param name="id">examid</param>
        /// <returns>count</returns>
        public int? QueryQuestionCount(int id)
        {
            QuestionManager manager = new QuestionManager();
            return manager.QueryQuestionCount(id);
        }

        /// <summary>
        /// query student answered question, used when exception occured
        /// </summary>
        /// <param name="userId">userId</param>
        /// <param name="examId">ExamId</param>
        /// <returns>count</returns>
        public int QueryHaveAnsweredQuestionNumber(int userId, int examId)
        {
            QuestionManager manager = new QuestionManager();
            return manager.QueryHaveAnsweredQuestionNumber(userId, examId);
        }

        /// <summary>
        /// query examinee answer
        /// </summary>
        /// <param name="userId">userId</param>
        /// <param name="examId">examId</param>
        /// <returns>examinee answer datatable</returns>
        public QuestionDS.exam_answer_detailDataTable FindUserAnswer(int userId, int examId)
        {
            QuestionManager manager = new QuestionManager();
            QuestionDS.exam_answer_detailDataTable table = new QuestionDS.exam_answer_detailDataTable();
            table.Merge(manager.FindUserAnswer(userId, examId));
            return table;
        }

        /// <summary>
        /// save examinee answer
        /// </summary>
        /// <param name="userId">userid</param>
        /// <param name="examId">examid</param>
        /// <param name="questionId">question id</param>
        /// <param name="userAnswer">user answer</param>
        public int InsertUserAnswer(int userId, int examId, int questionId, string userAnswer)
        {
            QuestionManager manager = new QuestionManager();
            return manager.InsertUserAnswer(userId, examId, questionId, userAnswer);
        }
    }
}
