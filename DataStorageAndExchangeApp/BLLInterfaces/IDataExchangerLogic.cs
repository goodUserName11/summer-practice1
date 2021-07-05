using Common.MyFile;
using Common.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLInterfaces
{
    public interface IDataExchangerLogic
    {
        bool WriteFile(int fileId, string fileName);

        User LogIn(string login, string password);

        User SignUp(string login, string nickname, string password);

        bool CreateFile(string fileName, string descrition, int userId);

        List<User> GetUsers(string filter);

        List<MyFile> GetFiles(string filter);

        User GetUserInfo(int userId);

        bool ChangeUserInfo(int userId, int changerId, string firstname, string lastname,
            string nickname, string description);

        bool ChangeUserPassword(int userId, int changerId, string password);

        bool ChangeFile(int fileId, int userId, string fileName, string description);

        bool DeleteFile(int fileId, int userId);

        bool DeleteUser(int userId, int deleterId);

        //DeleteUserAdmin
    }
}
