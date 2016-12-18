using System;
using OesDAL;
using OesDAL.ExamDSTableAdapters;
using OesDAL.UserDSTableAdapters;

namespace OesLogic
{
    public class ExamManager
    {
        /// <summary>
        /// Search exam as some condition
        /// </summary>
        /// <param name="sortName">order by which column</param>
        /// <param name="sortDirection">asc or desc</param>
        /// <param name="currentPage">paginatiion current page</param>
        /// <param name="pageSize">pagination per page size</param>
        /// <param name="keyword">all or unfinsihed or finished</param>
        /// <returns>exam result you query</returns>
        public UserDS.SearchExamDataTable SearchExam(string sortName, string sortDirection, int currentPage,
            int pageSize, string keyword, string userName)
        {
            try
            {
                SearchExamTableAdapter searchExamAdapter = new SearchExamTableAdapter();
                return searchExamAdapter.SearchExam(sortName, sortDirection, currentPage, pageSize, userName, keyword);
            }
            catch (Exception e)
            {
                Log4NetHelper.WriteErrorLog(typeof(ExamManager), e);
            }
            return null;
        }

        //pagination, get total count
        public int GetExamCount(string userName, string keyword)
        {
            int count = 0;
            try
            {
                SearchExamTableAdapter tableAdapter = new SearchExamTableAdapter();
                count = Convert.ToInt32(tableAdapter.SearchExamCount(userName, keyword, null, null, null));
            }
            catch (Exception e)
            {
                Log4NetHelper.WriteErrorLog(typeof(ExamManager), e);
            }
            return count;
        }

        public ExamDS.examDataTable GetExamById(int id)
        {
            try
            {
                examTableAdapter examAdapter = new examTableAdapter();
                return examAdapter.GetExamById(id);
            }
            catch (Exception e)
            {
                Log4NetHelper.WriteErrorLog(typeof(ExamManager), e);
            }
            return null;
        }

        public void InsertExamResultById(int userId, int examId, double score, string isPassed)
        {
            try
            {
                user_examTableAdapter adapter = new user_examTableAdapter();
                adapter.InsertExamResultByUserIdAndExamId(score, isPassed, userId, examId);
            }
            catch (Exception e)
            {
                Log4NetHelper.WriteErrorLog(typeof(ExamManager), e);
            }
        }

        public ExamDS.exam_exceptionDataTable GetExceptionOccurTime(int userId, int examId)
        {
            try
            {
                exam_exceptionTableAdapter adapter = new exam_exceptionTableAdapter();
                return adapter.GetOccurTime(userId, examId);
            }
            catch (Exception e)
            {
                Log4NetHelper.WriteErrorLog(typeof(ExamManager), e);
            }
            return null;
        }

        public void InsertExamExceptionTime(int userId, int examId, DateTime dataTime)
        {
            try
            {
                exam_exceptionTableAdapter adapter = new exam_exceptionTableAdapter();
                adapter.InsertExamExceptionTime(userId, examId, dataTime);
            }
            catch (Exception e)
            {
                Log4NetHelper.WriteErrorLog(typeof(ExamManager), e);
            }
        }

        public ExamDS.ExamNoticeDataTable GetExamNoticeById(int userId)
        {
            try
            {
                ExamNoticeTableAdapter adapter = new ExamNoticeTableAdapter();
                return adapter.GetExamByUserID(userId);
            }
            catch (Exception e)
            {
                Log4NetHelper.WriteErrorLog(typeof(ExamManager), e);
            }
            return null;
        }

        public void UpdateExamAsFinished(int examId)
        {
            try
            {
                UpdateExamTableAdapter adapter = new UpdateExamTableAdapter();
                adapter.UpdateExamAsFinished(examId);
            }
            catch(Exception e)
            {
                Log4NetHelper.WriteErrorLog(typeof(ExamManager), e);
            }
        }

        public bool ValidationIsHasTokenExam(int userId, int examId)
        {
            bool result = true;
            try
            {
                ValidateIsToken adapter = new ValidateIsToken();
                ExamDS.UserExamDataTable table = adapter.ValidationIsHasTokenExam(userId, examId);

                foreach (var item in table)
                {
                    if (item.count > 0)
                    {
                        result = false;
                    }
                    else
                    {
                        result = true;
                    }
                }
            }
            catch (Exception e)
            {
                Log4NetHelper.WriteErrorLog(typeof(ExamManager), e);
            }

            return result;
        }
    }
}
