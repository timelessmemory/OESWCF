using System;
using NUnit.Framework;
using OesDAL;
using OesDAL.ExamDSTableAdapters;
using OesDAL.UserDSTableAdapters;
using OesLogic;

namespace OesUI.test
{
    [TestFixture]
    public class ExamManagerTest
    {
        private ExamManager examManager;
        private UserTableAdapter userAdapter;
        private examTableAdapter examAdapter;
        private user_examTableAdapter UEAdapter;
        private int ueId = 0;
        private int userId = 0;
        private int examId = 0;

        [SetUp]
        public void SetUp()
        {
           examManager = new ExamManager();
           userAdapter = new UserTableAdapter();
           examAdapter = new examTableAdapter();
           UEAdapter = new user_examTableAdapter();
           userId = Convert.ToInt32(userAdapter.InsertUser("test", "123", "ceshiyuan", "male", "158", "HJKH@qq.com", null));
           examId = Convert.ToInt32(examAdapter.InsertExam("computer", "easy", 4, 20, 60, 80, DateTime.Parse("2015-10-01"), DateTime.Parse("2015-09-01"),
               DateTime.Parse("2015-09-01"), 0, "Mario", 60, 0, 0));
           ueId = Convert.ToInt32(UEAdapter.InsertUserExamResult(userId, examId, -1, "Do it"));
        }

        [TearDown]
        public void TearDown()
        {
            userAdapter.DeleteUserById(userId);
            examAdapter.DeleteExamById(examId);
            UEAdapter.DeleteExamResult(ueId);
        }

        [TestCase]
        public void TestSearchExam()
        {
            UserDS.SearchExamDataTable table = examManager.SearchExam("id", "asc", 1, 10, "unfinished", "test");

            foreach (var item in table)
            {
                Assert.AreEqual("computer", item.exam_name);
                Assert.AreEqual(60, item.pass_criteria);
            }
        }

        [TestCase]
        public void TestGetExamCount()
        {
            Assert.AreEqual(1, examManager.GetExamCount("test", "all"));
            Assert.AreEqual(1, examManager.GetExamCount("test", "unfinished"));
            Assert.AreEqual(0, examManager.GetExamCount("test", "finished"));
        }

        [TestCase]
        public void TestGetExamById()
        {
            ExamDS.examDataTable table = examManager.GetExamById(examId);

            foreach (var item in table)
            {
                Assert.AreEqual("computer", item.exam_name);
                Assert.AreEqual(60, item.pass_criteria);
            }
        }

        [TestCase]
        public void TestInsertExamResultById()
        {
            examManager.InsertExamResultById(userId, examId, 100, "Pass");
            user_examTableAdapter adapter = new user_examTableAdapter();
            var table = adapter.QueryExamResult(ueId);
            foreach (var item in table)
            {
                Assert.AreEqual("Pass", item.is_pass);
                Assert.AreEqual(100, item.score);
            }
        }

        [TestCase]
        public void TestGetExceptionOccurTime()
        {
            exam_exceptionTableAdapter exceptionAdapter = new exam_exceptionTableAdapter();
            int exceptionid = Convert.ToInt32(exceptionAdapter.InsertExceptionTime(userId, examId, DateTime.Parse("2015-09-09")));

            var table = examManager.GetExceptionOccurTime(userId, examId);
            foreach (var item in table)
            {
                Assert.AreEqual("2015-9-9 0:00:00", item.occur_time.ToString());
            }
            exceptionAdapter.DeleteException(exceptionid);
        }

        [TestCase]
        public void TestInsertExamExceptionTime()
        {
            exam_exceptionTableAdapter exceptionAdapter = new exam_exceptionTableAdapter();
            int exceptionid = Convert.ToInt32(exceptionAdapter.InsertExceptionTime(userId, examId, DateTime.Parse("2015-09-09")));

            var table = examManager.GetExceptionOccurTime(userId, examId);
            foreach (var item in table)
            {
                Assert.AreEqual("2015-9-9 0:00:00", item.occur_time.ToString());
            }
            exceptionAdapter.DeleteException(exceptionid);
        }

        [TestCase]
        public void TestGetExamNoticeById()
        {
            ExamDS.ExamNoticeDataTable table = examManager.GetExamNoticeById(userId);

            foreach (var item in table)
            {
                Assert.AreEqual("computer", item.exam_name);
                Assert.AreEqual("2015-10-1 0:00:00", item.effective_time.ToString());
            }
        }

        [TestCase]
        public void TestUpdateExamAsFinished()
        {
            examManager.UpdateExamAsFinished(examId);
            var table = examAdapter.GetExamById(examId);
            foreach (var item in table)
            {
                Assert.AreEqual(1, item.is_finished);
            }
        }

        [TestCase]
        public void TestIsHasTokenExam()
        {
            bool result = examManager.ValidationIsHasTokenExam(userId, examId);
            Assert.AreEqual(false, result);
        }
    }
}
