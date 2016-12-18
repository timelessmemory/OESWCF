using System;
using OesDAL.TeacherExamManagerTableAdapters;

namespace OesLogic
{
    public class TeacherExamManager
    {
        /// <summary>
        /// Get each exam result information, such as average score
        /// </summary>
        /// <param name="sortName"></param>
        /// <param name="sortDirection"></param>
        /// <param name="currentIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="examName"></param>
        /// <returns></returns>
        public OesDAL.TeacherExamManager.SearchExamListDataTable GetTeacherExamList(string sortName, string sortDirection, int currentIndex, int pageSize,
            DateTime fromDate, DateTime toDate, string examName)
        {
            try
            {
                SearchExamListTableAdapter adapter = new SearchExamListTableAdapter();
                return adapter.GetTeacherExamList(sortName, sortDirection, currentIndex, pageSize, fromDate, toDate, examName);
            }
            catch (Exception e)
            {
                Log4NetHelper.WriteErrorLog(typeof(TeacherExamManager), e);
            }
            return null;
        }

        //get total count for pagination
        public int GetTeacherExamListCount(DateTime fromDate, DateTime toDate, string examName)
        {
            SearchExamListCountTableAdapter adapter = new SearchExamListCountTableAdapter();
            int count = 0;
            try
            {
                OesDAL.TeacherExamManager.SearchExamListCountDataTable table = adapter.GetTeacherExamlistCount(fromDate, toDate, examName);
                foreach (var item in table)
                {
                    count = item.totalCount;
                }
            }
            catch (Exception e)
            {
                Log4NetHelper.WriteErrorLog(typeof(TeacherExamManager), e);
            }
            return count;
        }

        /// <summary>
        /// Get each examinee information, such as score and whether passed the exam
        /// </summary>
        /// <param name="sortName"></param>
        /// <param name="sortDirection"></param>
        /// <param name="currentIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="userName"></param>
        /// <param name="examId"></param>
        /// <returns></returns>
        public OesDAL.TeacherExamManager.ExamListDetailDataTable GetExamDetail(string sortName, string sortDirection,
            int currentIndex, int pageSize, string userName, int examId)
        {
            try
            {
                ExamListDetailTableAdapter adapter = new ExamListDetailTableAdapter();
                return adapter.GetExamDetail(sortName, sortDirection, currentIndex, pageSize, userName, examId);
            }
            catch (Exception e)
            {
                Log4NetHelper.WriteErrorLog(typeof(TeacherExamManager), e);
            }
            return null;
        }

        public int GetExamDetailCount(string userName, int examId)
        {
            ExamListDetailCountTableAdapter adapter = new ExamListDetailCountTableAdapter();
            int count = 0;
            try
            {
                OesDAL.TeacherExamManager.ExamListDetailCountDataTable table = adapter.GetExamDetailCount(userName, examId);
                foreach (var item in table)
                {
                    count = item.totalCount;
                }
            }
            catch (Exception e)
            {
                Log4NetHelper.WriteErrorLog(typeof(TeacherExamManager), e);
            }
            return count;
        }
    }
}
