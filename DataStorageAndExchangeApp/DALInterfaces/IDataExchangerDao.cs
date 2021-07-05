using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.MyFile;
using Common.User;

namespace DALInterfaces
{
    public interface IDataExchangerDao
    {
        User GetUser(string login, string password);

        bool UserExsist(string login);

        IEnumerable<User> GetUsers(string filter);

        IEnumerable<MyFile> GetFiles(string filter);

        byte[] GetFileData(int fileId);

        void ChangeUserInfo(int userId, int changerId, string firstname, string lastname,
            string nickname, string description);

        void ChangeUserPassword(int userId, int changerId, string password);

        void ChangeFile(int fileId, int userId, string fileName, string description);

        void CreateUser(string login, string password, string nickname);

        void CreateFile(string fileName, byte[] fileData,
            string fileDescription, int creatorID);

        void DeleteUser(int userId, int deleterId);

        void DeleteUserAdmin(int userId, int deleteUserId);

        void DeleteFile(int fileId, int userId);

        User GetUserInfo(int userId);
    }
}
