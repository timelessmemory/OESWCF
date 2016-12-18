using System;
using NUnit.Framework;
using OesDAL.ExamDSTableAdapters;
using OesDAL.UserDSTableAdapters;
using OesLogic;

namespace OesUI.test
{
    [TestFixture]
    public class TeacherExamListTest
    {
        private TeacherExamManager examManager;
        private UserTableAdapter userAdapter;
        private user_examTableAdapter UEAdapter;
        private examTableAdapter examAdapter;
        private int userId = 0;
        private int examId = 0;
        private int ueId = 0;

        [SetUp]
        public void SetUp()
        {
            examManager = new TeacherExamManager();
            userAdapter = new UserTableAdapter();
            UEAdapter = new user_examTableAdapter();
            examAdapter = new examTableAdapter();
            userId = Convert.ToInt32(userAdapter.InsertUser("test", "123", "ceshiyuan", "male", "158", "HJKH@qq.com", null));
            examId = Convert.ToInt32(examAdapter.InsertExam("computer", "easy", 4, 20, 60, 80, DateTime.Parse("2015-10-01"), DateTime.Parse("2015-10-01"),
                DateTime.Parse("2015-09-01"), 1, "Mario", 60, 0, 0));
            ueId = Convert.ToInt32(UEAdapter.InsertUserExamResult(userId, examId, 90, "Pass"));
        }

        [TearDown]
        public void TearDown()
        {
            userAdapter.DeleteUserById(userId);
            examAdapter.DeleteExamById(examId);
            UEAdapter.DeleteExamResult(ueId);
        }

        [TestCase]
        public void TestGetTeacherExamList()
        {
            OesDAL.TeacherExamManager.SearchExamListDataTable table = examManager.GetTeacherExamList("id", "asc", 1, 10, new DateTime(2015, 10, 1), new DateTime(2015, 10, 1), null);

            foreach (var item in table)
            {
                Assert.AreEqual(90, item.averageScore);
                Assert.AreEqual(1, item.examineeCount);
            }
        }

        [TestCase]
        public void TestGetTeacherExamListCount()
        {
            int count = examManager.GetTeacherExamListCount(new DateTime(2015, 10, 1), new DateTime(2015, 10, 1), null);
            Assert.AreEqual(1, count);
        }

        [TestCase]
        public void TestGetExamDetail()
        {
            OesDAL.TeacherExamManager.ExamListDetailDataTable table = examManager.GetExamDetail("name", "asc", 1, 10, null, examId);
            
            foreach (var item in table)
            {
                Assert.AreEqual("test", item.UserName);
            }
        }

        [TestCase]
        public void TestGetExamDetailCount()
        {
            int count = examManager.GetExamDetailCount(null, examId);
            Assert.AreEqual(1, count);
        }
    }
}
