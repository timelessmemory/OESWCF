using System;
using OesDAL;
using OesDAL.UserDSTableAdapters;

namespace OesLogic
{
    public class UserManager
    {
        private const int onlyOneRecord = 1;
        private const string Teacher = "Teacher";

        /// <summary>
        /// Verify user login
        /// </summary>
        /// <param name="username">username</param>
        /// <param name="password">passsword</param>
        /// <returns>is login success</returns>
        public bool VerifyUserLogin(string userName, string password)
        {
            UsersTableAdapter userAdapter = new UsersTableAdapter();
            int? userNameCheck = userAdapter.VerifyUserName(userName);

            if (!userNameCheck.HasValue || userNameCheck.Value != onlyOneRecord)
            {
                throw new UserNameNotExistentException();
            }

            int? result = userAdapter.VerifyLogin(userName, password);
            return result.HasValue && result.Value == onlyOneRecord;
        }

        public bool VerifyIsTeacher(int userId)
        {
            try
            {
                RoleTableAdapter adapter = new RoleTableAdapter();
                UserDS.RoleDataTable table = adapter.GetUserRole(userId);

                foreach (var item in table)
                {
                    if (item.name.Equals(Teacher))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                Log4NetHelper.WriteErrorLog(typeof(UserManager), e);
            }
            return false;
        }

        public Object QueryUserIdByName(string name)
        {
            try
            {
                UsersTableAdapter userAdapter = new UsersTableAdapter();
                return userAdapter.QueryUserIdByName(name);
            }
            catch (Exception e)
            {
                Log4NetHelper.WriteErrorLog(typeof(UserManager), e);
            }
            return null;
        }

        public OesDAL.UserDS.UserDataTable GetUserInformation(int userId)
        {
            try
            {
                UserTableAdapter adapter = new UserTableAdapter();
                return adapter.GetUserById(userId);
            }
            catch (Exception e)
            {
                Log4NetHelper.WriteErrorLog(typeof(UserManager), e);
            }
            return null;
        }

        public void UpdatePassword(string password, int userId)
        {
            try
            {
                UserTableAdapter adapter = new UserTableAdapter();
                adapter.UpdatePassword(password, userId);
            }
            catch (Exception e)
            {
                Log4NetHelper.WriteErrorLog(typeof(UserManager), e);
            }
        }

        public void UpdatePhoto(int userId, byte[] pic)
        {
            try
            {
                UserTableAdapter adapter = new UserTableAdapter();
                adapter.UpdatePhoto(pic, userId);
            }
            catch (Exception e)
            {
                Log4NetHelper.WriteErrorLog(typeof(UserManager), e);
            }
        }

        public bool ValidateUserAndEmail(string userName, string email)
        {
            bool result = false;
            try
            {
                UserEmailTableAdapter adapter = new UserEmailTableAdapter();
                UserDS.UserEmailDataTable table = adapter.ValidateUserAndEmail(userName, email);

                foreach (var item in table)
                {
                    if (item.count > 0)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            catch (Exception e)
            {
                Log4NetHelper.WriteErrorLog(typeof(UserManager), e);
            }

            return result;
        }
    }
}
