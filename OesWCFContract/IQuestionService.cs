using System;
using System.ServiceModel;

namespace OesWCFContract
{
    [ServiceContract]
    public interface IQuestionService
    {
        [OperationContract]
        QuestionDS.ExamQuestionDataTable FindQuestionByExamId(int? id);

        [OperationContract]
        int? QueryQuestionCount(int id);

        [OperationContract]
        int QueryHaveAnsweredQuestionNumber(int userId, int examId);

        [OperationContract]
        QuestionDS.exam_answer_detailDataTable FindUserAnswer(int userId, int examId);

        [OperationContract]
        int InsertUserAnswer(int userId, int examId, int questionId, string userAnswer);
    }
}
