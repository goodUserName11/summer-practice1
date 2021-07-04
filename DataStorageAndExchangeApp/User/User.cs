using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonUser
{
    public class User
    {
        public int ID { get; set; }
        public string Login { get; private set; }
        public string  Nickname { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string UserDescription { get; set; }
        public int FilesAdded { get; private set; }
        public int FilesDownloaded { get; private set; }
        public DateTime RegistrationDate { get; private set; }
        public int RoleID { get; set; }

        public User(int iD, string login, string nickname, string firstName, 
            string lastName, string password, string userDescription, 
            int filesAdded, int filesDownloaded, DateTime registrationDate, int roleID)
        {
            ID = iD;
            Login = login;
            Nickname = nickname;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            UserDescription = userDescription;
            FilesAdded = filesAdded;
            FilesDownloaded = filesDownloaded;
            RegistrationDate = registrationDate;
            RoleID = roleID;
        }

        public User(int iD, string nickname, string firstName, string lastName,
            string password, string userDescription, int filesAdded, 
            int filesDownloaded, DateTime registrationDate, int roleID)
        {
            ID = iD;
            Nickname = nickname;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            UserDescription = userDescription;
            FilesAdded = filesAdded;
            FilesDownloaded = filesDownloaded;
            RegistrationDate = registrationDate;
            RoleID = roleID;
        }

        public User(int iD, string login, string nickname, string firstName, 
            string lastName, string password, string userDescription)
        {
            ID = iD;
            Login = login;
            Nickname = nickname;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            UserDescription = userDescription;
        }


        public User() { }
    }
}
