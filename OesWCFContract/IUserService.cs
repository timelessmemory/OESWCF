using System;
using System.ServiceModel;

namespace OesWCFContract
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        object QueryUserIdByName(string name);

        [OperationContract]
        [FaultContract(typeof(UserNameNotExistent))]
        bool VerifyUserLogin(string username, string password);

        [OperationContract]
        UserDS.UserDataTable GetUserInformation(int userId);

        [OperationContract]
        void UpdatePassword(string password, int userId);

        [OperationContract]
        void UpdatePhoto(int userId, byte[] pic);

        [OperationContract]
        bool VerifyIsTeacher(int userId);

        [OperationContract]
        bool ValidateUserAndEmail(string userName, string email);
    }
}
