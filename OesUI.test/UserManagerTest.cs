using System;
using System.Text;
using NUnit.Framework;
using OesDAL;
using OesDAL.UserDSTableAdapters;
using OesLogic;

namespace OesUI.test
{
    [TestFixture]
    public class UserManagerTest
    {
        private UserManager userManager;
        private UserTableAdapter adapter;
        private int id = 0;

        [SetUp]
        public void SetUp()
        {
            userManager = new UserManager();
            adapter = new UserTableAdapter();
            id = Convert.ToInt32(adapter.InsertUser("test", "123", "ceshiyuan", "male", "158", "klkl@kldc.com", null));
        }

        [TearDown]
        public void TearDown()
        {
            adapter.DeleteUserById(id);
        }

        [TestCase]
        public void TestVerifyUserLogin()
        {
            bool isLogin = userManager.VerifyUserLogin("test", "123");
            Assert.AreEqual(true, isLogin);
        }

        [TestCase]
        public void TestQueryUserIdByName()
        {
            int idResult = Convert.ToInt32(userManager.QueryUserIdByName("test"));
            Assert.AreEqual(id, idResult);
        }

        [TestCase]
        public void TestGetUserInformation()
        {
            UserDS.UserDataTable table = userManager.GetUserInformation(id);

            foreach (var item in table)
            {
                Assert.AreEqual(id, item.ID);
                Assert.AreEqual("test", item.UserName);
            }
        }

        [TestCase]
        public void TestUpdatePassword()
        {
            userManager.UpdatePassword("222", id);

            UserDS.UserDataTable table = userManager.GetUserInformation(id);
            foreach (var item in table)
            {
                Assert.AreEqual("222", item.Password);
            }
        }

        [TestCase]
        public void TestUpdatePhoto()
        {
            byte[] bs = Encoding.UTF8.GetBytes("12");
            userManager.UpdatePhoto(id, bs);

            UserDS.UserDataTable table = userManager.GetUserInformation(id);
            foreach (var item in table)
            {
                Assert.AreEqual(bs, item.Pic);
            }
        }

        [TestCase]
        public void TestValidateUserAndEmail()
        {
            bool result = userManager.ValidateUserAndEmail("test", "klkl@kldc.com");
            Assert.AreEqual(true, result);
        }
    }
}
