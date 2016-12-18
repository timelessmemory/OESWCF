using System;
using NUnit.Framework;
using OesDAL;
using OesDAL.ExamDSTableAdapters;
using OesDAL.QuestionDSTableAdapters;
using OesDAL.UserDSTableAdapters;
using OesLogic;

namespace OesUI.test
{
    [TestFixture]
    public class QuestionManagerTest
    {
        private QuestionManager questionManager;
        private questionTableAdapter questionAdapter;
        private examTableAdapter examAdapter;
        private EQTableAdapter eqAdapter;
        private UserTableAdapter userAdapter;
        private exam_answer_detailTableAdapter answerAdapter;
        private int questionId = 0;
        private int examId = 0;
        private int eqId = 0;
        private int userId = 0;

        [SetUp]
        public void SetUp()
        {
            questionManager = new QuestionManager();

            questionAdapter = new questionTableAdapter();
            examAdapter = new examTableAdapter();
            eqAdapter = new EQTableAdapter();
            userAdapter = new UserTableAdapter();
            answerAdapter = new exam_answer_detailTableAdapter();
            questionId = Convert.ToInt32(questionAdapter.InsertQuestion("how do you do?", "a", "b", "c", "d", "a", DateTime.Now, DateTime.Now, 0));
            examId = Convert.ToInt32(examAdapter.InsertExam("computer", "easy", 4, 20, 60, 80, DateTime.Parse("2015-09-01"), DateTime.Parse("2015-09-01"), 
                DateTime.Parse("2015-09-01"), 0, "Mario", 60, 0, 0));
            eqId = Convert.ToInt32(eqAdapter.InsertEQ(examId, questionId, "how do you do?", "a", "b", "c", "d", "a", 0));
        }

        [TearDown]
        public void TearDown()
        {
            questionAdapter.DeleteQuestionById(questionId);
            examAdapter.DeleteExamById(examId);
            eqAdapter.DeleteEQ(eqId);
        }

        [TestCase]
        public void TestFindQuestionByExamId()
        {
            QuestionDS.ExamQuestionDataTable table = questionManager.FindQuestionByExamId(examId);
            foreach (var item in table)
            {
                Assert.AreEqual("how do you do?", item.title);
            }
        }

        [TestCase]
        public void TestQueryQuestionCount()
        {
            int? count = questionManager.QueryQuestionCount(examId);
            Assert.AreEqual(1, count);
        }

        [TestCase]
        public void TestQueryHaveAnsweredQuestionNumber()
        {
            userId = Convert.ToInt32(userAdapter.InsertUser("test", "123", "ceshiyuan", "male", "158", "HJKH@qq.com", null));

            int answerId = questionManager.InsertUserAnswer(userId, examId, questionId, "A");
            int count = questionManager.QueryHaveAnsweredQuestionNumber(userId, examId);
            Assert.AreEqual(1, count);

            userAdapter.DeleteUserById(userId);
            answerAdapter.DeleteUserAnswer(answerId);
        }

        [TestCase]
        public void TestFindUserAnswer()
        {
            userId = Convert.ToInt32(userAdapter.InsertUser("test", "123", "ceshiyuan", "male", "158", "HJKH@qq.com", null));

            int answerId = questionManager.InsertUserAnswer(userId, examId, questionId, "A");
            QuestionDS.exam_answer_detailDataTable table = questionManager.FindUserAnswer(userId, examId);
            foreach (var item in table)
            {
                Assert.AreEqual("A", item.user_answer);
            }

            userAdapter.DeleteUserById(userId);
            answerAdapter.DeleteUserAnswer(answerId);
        }

        [TestCase]
        public void TestInsertUserAnswer()
        {
            userId = Convert.ToInt32(userAdapter.InsertUser("test", "123", "ceshiyuan", "male", "158", "HJKH@qq.com", null));

            int answerId = questionManager.InsertUserAnswer(userId, examId, questionId, "A");
            QuestionDS.exam_answer_detailDataTable table = questionManager.FindUserAnswer(userId, examId);
            foreach (var item in table)
            {
                Assert.AreEqual("A", item.user_answer);
            }

            userAdapter.DeleteUserById(userId);
            answerAdapter.DeleteUserAnswer(answerId);
        }
    }
}
