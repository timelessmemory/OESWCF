using System;
using OesWCFContract;
using OesLogic;

namespace OesWCFImpl
{
    public class ExamService : IExamService
    {
        /// <summary>
        /// get exam information by exam id
        /// </summary>
        /// <param name="id">examid</param>
        /// <returns>exam information datatable</returns>
        public ExamDS.examDataTable GetExamById(int id)
        {
            ExamManager examManager = new ExamManager();
            ExamDS.examDataTable dataTable = new ExamDS.examDataTable();
            dataTable.Merge(examManager.GetExamById(id));
            return dataTable;
        }

        /// <summary>
        /// get exam count according to condition
        /// </summary>
        /// <param name="username">username</param>
        /// <param name="keyword">all or finished or unfinished</param>
        /// <returns>count</returns>
        public int GetExamCount(string username, string keyword)
        {
            ExamManager examManager = new ExamManager();
            return examManager.GetExamCount(username, keyword);
        }

        /// <summary>
        /// InsertExamResult
        /// </summary>
        /// <param name="userId">userid</param>
        /// <param name="examId">examid</param>
        /// <param name="score">user score</param>
        /// <param name="isPassed">isPassed</param>
        public void InsertExamResultById(int userId, int examId, double score, string isPassed)
        {
            ExamManager examManager = new ExamManager();
            examManager.InsertExamResultById(userId, examId, score, isPassed);
        }

        /// <summary>
        /// Search exam 
        /// </summary>
        /// <param name="sortName">which column to be sorted</param>
        /// <param name="sortDirection">asc or desc</param>
        /// <param name="currentPage">currentPage</param>
        /// <param name="pageSize">pageSize</param>
        /// <param name="keyword">all or finished or unfinished</param>
        /// <param name="userName">userName</param>
        /// <returns></returns>
        public UserDS.SearchExamDataTable SearchExam(string sortName, string sortDirection, int currentPage, 
            int pageSize, string keyword, string userName)
        {
            ExamManager examManager = new ExamManager();
            UserDS.SearchExamDataTable table = new UserDS.SearchExamDataTable();
            table.Merge(examManager.SearchExam(sortName, sortDirection, currentPage, pageSize, keyword, userName));
            return table;
        }

        /// <summary>
        /// query exception time
        /// </summary>
        /// <param name="userId">userid</param>
        /// <param name="examId">examid</param>
        /// <returns>exception time datatable</returns>
        public ExamDS.exam_exceptionDataTable GetExceptionOccurTime(int userId, int examId)
        {
            ExamManager examManager = new ExamManager();
            ExamDS.exam_exceptionDataTable table = new ExamDS.exam_exceptionDataTable();
            table.Merge(examManager.GetExceptionOccurTime(userId, examId));
            return table;
        }

        /// <summary>
        /// Insert exam exception time
        /// </summary>
        /// <param name="userId">userid</param>
        /// <param name="examId">examid</param>
        /// <param name="dataTime">exception time</param>
        public void InsertExamExceptionTime(int userId, int examId, DateTime dataTime)
        {
            ExamManager examManager = new ExamManager();
            examManager.InsertExamExceptionTime(userId, examId, dataTime);
        }

        /// <summary>
        /// notice exam coming
        /// </summary>
        /// <param name="userId">userid</param>
        /// <returns>stduent's coming exam Name datatable</returns>
        public ExamDS.ExamNoticeDataTable GetExamNoticeById(int userId)
        {
            ExamManager examManager = new ExamManager();
            OesWCFContract.ExamDS.ExamNoticeDataTable table = new ExamDS.ExamNoticeDataTable();
            table.Merge(examManager.GetExamNoticeById(userId));
            return table;
        }

        /// <summary>
        /// get each exam information such as average
        /// </summary>
        /// <param name="sortName">which column</param>
        /// <param name="sortDirection">asc or desc</param>
        /// <param name="currentIndex">currentIndex</param>
        /// <param name="pageSize">PageSize</param>
        /// <param name="fromDate">start day</param>
        /// <param name="toDate">end day</param>
        /// <param name="examName">exam Name</param>
        /// <returns></returns>
        public OesWCFContract.TeacherExamManager.SearchExamListDataTable GetTeacherExamList(string sortName, string sortDirection,
            int currentIndex, int pageSize, DateTime fromDate, DateTime toDate, string examName)
        {
            OesLogic.TeacherExamManager examManager = new OesLogic.TeacherExamManager();
            OesWCFContract.TeacherExamManager.SearchExamListDataTable table = new OesWCFContract.TeacherExamManager.SearchExamListDataTable();
            table.Merge(examManager.GetTeacherExamList(sortName, sortDirection,
                currentIndex, pageSize, fromDate, toDate, examName));
            return table;
        }

        /// <summary>
        /// get total count for pagination
        /// </summary>
        /// <param name="fromDate">start day</param>
        /// <param name="toDate">end day</param>
        /// <param name="examName">exam Name</param>
        /// <returns></returns>
        public int GetTeacherExamListCount(DateTime fromDate, DateTime toDate, string examName)
        {
            OesLogic.TeacherExamManager examManager = new OesLogic.TeacherExamManager();
            return examManager.GetTeacherExamListCount(fromDate, toDate, examName);
        }

        /// <summary>
        /// query each exam detail information such as examinee score
        /// </summary>
        /// <param name="sortName">which column</param>
        /// <param name="sortDirection">asc or desc</param>
        /// <param name="currentIndex">current index</param>
        /// <param name="pageSize">pageSize</param>
        /// <param name="userName">user Name</param>
        /// <param name="examId">examid</param>
        /// <returns>exam detail information</returns>
        public OesWCFContract.TeacherExamManager.ExamListDetailDataTable GetExamDetail(string sortName, string sortDirection,
            int currentIndex, int pageSize, string userName, int examId)
        {
            OesLogic.TeacherExamManager examManager = new OesLogic.TeacherExamManager();
            OesWCFContract.TeacherExamManager.ExamListDetailDataTable table = new OesWCFContract.TeacherExamManager.ExamListDetailDataTable();
            table.Merge(examManager.GetExamDetail(sortName, sortDirection, currentIndex, pageSize, userName, examId));
            return table;
        }

        /// <summary>
        /// get total count for pagination
        /// </summary>
        /// <param name="userName">username</param>
        /// <param name="examId">examId</param>
        /// <returns>count</returns>
        public int GetExamDetailCount(string userName, int examId)
        {
            OesLogic.TeacherExamManager examManager = new OesLogic.TeacherExamManager();
            return examManager.GetExamDetailCount(userName, examId);
        }

        /// <summary>
        /// set exam state to be finished 
        /// </summary>
        /// <param name="examId">Examid</param>
        public void UpdateExamAsFinished(int examId)
        {
             ExamManager examManager = new ExamManager();
             examManager.UpdateExamAsFinished(examId);
        }

        /// <summary>
        /// Validate whether user has token exam
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="examId"></param>
        /// <returns></returns>
        public bool ValidationIsHasTokenExam(int userId, int examId)
        {
            ExamManager examManager = new ExamManager();
            return examManager.ValidationIsHasTokenExam(userId, examId);
        }
    }
}
