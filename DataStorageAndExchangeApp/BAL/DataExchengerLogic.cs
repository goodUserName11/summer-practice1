using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.MyFile;
using Common.User;
using Common.UserRole;
using DALInterfaces;
using BLLInterfaces;

namespace BLL
{
    public class DataExchengerLogic : IDataExchangerLogic
    {
        private IDataExchangerDao _dao;

        public DataExchengerLogic(IDataExchangerDao dao)
        {
            _dao = dao;
        }

        public DataExchengerLogic() { }

        public bool WriteFile (int fileId, string fileName)
        {
            byte[] fileData = _dao.GetFileData(fileId);

            using (System.IO.FileStream fs = 
                new System.IO.FileStream(fileName, System.IO.FileMode.OpenOrCreate))
            {
                if (fileData != null)
                {
                    fs.Write(fileData, 0, fileData.Length);

                    return true;
                }
                else return false;
            }
        }

        public User LogIn(string login, string password)
        {
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
            {
                return _dao.GetUser(login, password);
            }
            else throw new ArgumentException("Login and password cannot be empty!");
        }

        public User SignUp(string login, string nickname, string password)
        {
            if(!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password) 
                && !string.IsNullOrEmpty(nickname))
            {
                if (!_dao.UserExsist(login)) 
                {
                    _dao.CreateUser(login, password, nickname);
                    return LogIn(login, password);
                }
                else throw new InvalidOperationException("Such login already used!");
            }
            else throw new ArgumentException("Login, password and nickname cannot be empty!");
        }

        public bool CreateFile(string fileName, string descrition, int userId)
        {
            byte[] data;

            string shortFileName = fileName.Substring(fileName.LastIndexOf('\\') + 1);

            using (System.IO.FileStream fs = new System.IO.FileStream(fileName, System.IO.FileMode.Open))
            {
                data = new byte[fs.Length];
                fs.Read(data, 0, data.Length);
            }

            _dao.CreateFile(shortFileName, data, descrition, userId);

            return true;
        }

        public List<User> GetUsers(string filter)
        {
            List<User> list = new List<User>();

            foreach (User item in _dao.GetUsers(filter))
            {
                list.Add(item);
            }

            return list;

        }

        public List<MyFile> GetFiles(string filter)
        {
            List<MyFile> list = new List<MyFile>();
            
            foreach(MyFile item in _dao.GetFiles(filter))
            {
                list.Add(item);
            }

            return list;
        }

        public User GetUserInfo(int userId)
        {
            return _dao.GetUserInfo(userId);
        }

        public bool ChangeUserInfo(int userId, int changerId, string firstname, string lastname,
            string nickname, string description)
        {
            if (string.IsNullOrEmpty(nickname))
                throw new ArgumentException("Nickname cannot be empty");

            _dao.ChangeUserInfo(userId, changerId, firstname, lastname, nickname, description);

            return true;
        }

        public bool ChangeUserPassword(int userId, int changerId, string password)
        {
            if (string.IsNullOrEmpty(password))
                throw new ArgumentException("Password cannot be empty");

            _dao.ChangeUserPassword(userId, changerId, password);

            return true;
        }

        public bool ChangeFile(int fileId, int userId, string fileName, string description)
        {
            if (string.IsNullOrEmpty(fileName))
                throw new ArgumentException("File name cannot be empty");

            _dao.ChangeFile(fileId, userId, fileName, description);

            return true;
        }

        public bool DeleteFile(int fileId, int userId)
        {
            _dao.DeleteFile(fileId, userId);

            return true;
        }

        public bool DeleteUser(int userId, int deleterId)
        {
            _dao.DeleteUser(userId, deleterId);

            return true; 
        }


    }
}
