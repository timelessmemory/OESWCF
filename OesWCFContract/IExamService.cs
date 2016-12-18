using System;
using System.ServiceModel;

namespace OesWCFContract
{
    [ServiceContract]
    public interface IExamService
    {
        [OperationContract]
        ExamDS.examDataTable GetExamById(int id);

        [OperationContract]
        int GetExamCount(string username, string keyword);

        [OperationContract]
        void InsertExamResultById(int userId, int examId, double score, string isPassed);

        [OperationContract]
        UserDS.SearchExamDataTable SearchExam(string sortName, string sortDirection, int currentPage, 
            int pageSize, string keyword, string userName);

        [OperationContract]
        ExamDS.exam_exceptionDataTable GetExceptionOccurTime(int userId, int examId);

        [OperationContract]
        void InsertExamExceptionTime(int userId, int examId, DateTime dataTime);

        [OperationContract]
        ExamDS.ExamNoticeDataTable GetExamNoticeById(int userId);

        [OperationContract]
        TeacherExamManager.SearchExamListDataTable GetTeacherExamList(string sortName, string sortDirection, 
            int currentIndex, int pageSize, DateTime fromDate, DateTime toDate, string examName);

        [OperationContract]
        int GetTeacherExamListCount(DateTime fromDate, DateTime toDate, string examName);

        [OperationContract]
        TeacherExamManager.ExamListDetailDataTable GetExamDetail(string sortName, string sortDirection,
            int currentIndex, int pageSize, string userName, int examId);

        [OperationContract]
        int GetExamDetailCount(string userName, int examId);

        [OperationContract]
        void UpdateExamAsFinished(int examId);

        [OperationContract]
        bool ValidationIsHasTokenExam(int userId, int examId);
    }
}
