using System;
using System.ServiceModel;
using OesLogic;
using OesWCFContract;

namespace OesWCFImpl
{
    public class UserService : IUserService
    {
        /// <summary>
        /// query user's id according to user's name
        /// </summary>
        /// <param name="name">userName</param>
        /// <returns></returns>
        public object QueryUserIdByName(string name)
        {
            UserManager manager = new UserManager();
            return manager.QueryUserIdByName(name);
        }

        /// <summary>
        /// validate whether user can sign in system
        /// </summary>
        /// <param name="username">userName</param>
        /// <param name="password">password</param>
        /// <returns></returns>
        public bool VerifyUserLogin(string username, string password)
        {
            try
            {
                UserManager manager = new UserManager();
                return manager.VerifyUserLogin(username, password);
            }
            catch (UserNameNotExistentException ex)
            {
                var e = new UserNameNotExistent();
                e.Messge = ex.Message;
                throw new FaultException<UserNameNotExistent>(e, new FaultReason(ex.Message));
            }
            catch (Exception)
            {
                throw new Exception("Unknown Exception");
            }
        }

        /// <summary>
        /// query user information according to user id
        /// </summary>
        /// <param name="userId">userid</param>
        /// <returns>information datatable</returns>
        public UserDS.UserDataTable GetUserInformation(int userId)
        {
            UserManager manager = new UserManager();
            UserDS.UserDataTable table = new UserDS.UserDataTable();
            table.Merge(manager.GetUserInformation(userId));
            return table;
        }

        /// <summary>
        /// change user password
        /// </summary>
        /// <param name="password">new password</param>
        /// <param name="userId">userid</param>
        public void UpdatePassword(string password, int userId)
        {
            UserManager manager = new UserManager();
            manager.UpdatePassword(password, userId);
        }

        /// <summary>
        /// change user avatar
        /// </summary>
        /// <param name="userId">userid</param>
        /// <param name="pic">user new avatar</param>
        public void UpdatePhoto(int userId, byte[] pic)
        {
            UserManager manager = new UserManager();
            manager.UpdatePhoto(userId, pic);
        }

        /// <summary>
        /// query whether user is teacher
        /// </summary>
        /// <param name="userId">userid</param>
        /// <returns>true or false</returns>
        public bool VerifyIsTeacher(int userId)
        {
            UserManager manager = new UserManager();
            return manager.VerifyIsTeacher(userId);
        }

        /// <summary>
        /// validate is exist this user and email
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool ValidateUserAndEmail(string userName, string email)
        {
            UserManager manager = new UserManager();
            return manager.ValidateUserAndEmail(userName, email);
        }
    }
}
