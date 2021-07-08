using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.UserRole;

namespace Common.User
{
    public class User
    {
        public int ID { get; set; }
        public string Login { get; private set; }
        public string Nickname { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string UserDescription { get; set; }
        public DateTime RegistrationDate { get; private set; }
        public int RoleID { get; set; }

        public UserRole.UserRole UserRole { get; private set; }

        public User(int iD, string nickname, string firstName, string lastName,
            string userDescription, DateTime registrationDate,
            UserRole.UserRole userRole) : this(iD, nickname)
        {
            FirstName = firstName;
            LastName = lastName;
            UserDescription = userDescription;
            RegistrationDate = registrationDate;
            UserRole = userRole;
        }

        public User(int iD, string nickname)
        {
            ID = iD;
            Nickname = nickname;
        }

        public User() { }
    }
}
