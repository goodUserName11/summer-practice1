using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.User;
using DALInterfaces;
using System.Configuration;
using System.Data.SqlClient;
using Common.MyFile;
using Common.UserRole;

namespace SQLDAL
{
    public class DataExchangerSqlDao : IDataExchangerDao
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        private static SqlConnection _connection;

        public User GetUser(string login, string password)
        {
            using (_connection = new SqlConnection(_connectionString))
            {
                var query = $"SELECT * FROM GetUserFunc(@login, @password)";

                var command = new SqlCommand(query, _connection);

                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);

                _connection.Open();

                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new User(
                        iD: (int)reader["ID"],
                        nickname: reader["Nickname"] as string);
                }

                throw new InvalidOperationException($"Cannot find User with login = {login} or invalid password");
            }
        }

        public bool UserExsist(string login)
        {
            using (_connection = new SqlConnection(_connectionString))
            {
                var proc = "FindUserByLogin";

                var command = new SqlCommand(proc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@login", login);

                _connection.Open();


                int count = (int)command.ExecuteScalar();
                if (count > 0) return true;
                else return false;
            }
        }

        public IEnumerable<User> GetUsers(string filter)
        {
            using (_connection = new SqlConnection(_connectionString))
            {
                var query = $"SELECT * FROM GetUsersFunc(@filter)";

                var command = new SqlCommand(query, _connection);

                command.Parameters.AddWithValue("@filter", filter);

                _connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    yield return new User(
                        iD: (int)reader["ID"],
                        nickname: reader["Nickname"] as string);
                }
                yield break;
            }
        }

        public IEnumerable<MyFile> GetFiles(string filter)
        {
            using (_connection = new SqlConnection(_connectionString))
            {
                var query = $"SELECT * FROM GetFilesFunc(@filter)";

                var command = new SqlCommand(query, _connection);

                command.Parameters.AddWithValue("@filter", filter);

                _connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    yield return new MyFile(
                        id: (int)reader["ID"],
                        fileName: reader["FileName"] as string,
                        creator: reader["Adder"] as string,
                        creatorID: (int)reader["AdderID"],
                        description: reader["Description"] as string,
                        addingDate: (DateTime)reader["AddingDate"]);
                }
                yield break;
            }
        }

        public byte[] GetFileData(int fileId)
        {
            using (_connection = new SqlConnection(_connectionString))
            {
                var query = "SELECT dbo.GetFileData(@id)";

                var command = new SqlCommand(query, _connection);

                command.Parameters.AddWithValue("@id", fileId);

                _connection.Open();

                byte[] data = (byte[])command.ExecuteScalar();

                return data;
            }
        }

        public void ChangeUserInfo(int userId, int changerId, string firstname, string lastname,
            string nickname, string description)
        {
            using (_connection = new SqlConnection(_connectionString))
            {
                var proc = "ChangeUserData";

                var command = new SqlCommand(proc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@changerId", changerId);
                command.Parameters.AddWithValue("@firstname", firstname);
                command.Parameters.AddWithValue("@lastname", lastname);
                command.Parameters.AddWithValue("@newNickname", nickname);
                command.Parameters.AddWithValue("@description", description);

                _connection.Open();

                if (command.ExecuteNonQuery() <= 0)
                    throw new ArgumentException("Cannot change user that does not belong to user");
            }
        }

        public void ChangeUserPassword(int userId, int changerId, string password)
        {
            using (_connection = new SqlConnection(_connectionString))
            {
                var proc = "ChangeUserPassword";

                var command = new SqlCommand(proc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@changerId", userId);
                command.Parameters.AddWithValue("@newPassword", password);

                _connection.Open();

                if (command.ExecuteNonQuery() <= 0)
                    throw new ArgumentException("Cannot change user password that does not belong to user");
            }
        }

        public void ChangeFile(int fileId, int userId, string fileName, string description)
        {
            using (_connection = new SqlConnection(_connectionString))
            {
                var proc = "ChangeFileNameDesc";

                var command = new SqlCommand(proc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@fileId", fileId);
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@fileName", fileName);
                command.Parameters.AddWithValue("@description", description);

                _connection.Open();

                if (command.ExecuteNonQuery() <= 0)
                    throw new ArgumentException("Cannot Change file that does not belong to user");
            }
        }

        public void CreateUser(string login, string password, string nickname)
        {
            using (_connection = new SqlConnection(_connectionString))
            {
                var proc = "AddUser";

                var command = new SqlCommand(proc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@nickname", nickname);
                command.Parameters.AddWithValue("@password", password);

                _connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void CreateFile(string fileName, byte[] fileData,
            string fileDescription, int creatorID)
        {
            using (_connection = new SqlConnection(_connectionString))
            {
                var proc = "AddFile";

                var command = new SqlCommand(proc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@fileName", fileName);
                command.Parameters.AddWithValue("@fileData", fileData);
                command.Parameters.AddWithValue("@fileDescription", fileDescription);
                command.Parameters.AddWithValue("@creatorID", creatorID);

                _connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void DeleteUser(int userId, int deleterId)
        {
            using (_connection = new SqlConnection(_connectionString))
            {
                var proc = "DeleteUser";

                var command = new SqlCommand(proc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@deleterId", deleterId);


                _connection.Open();

                if (command.ExecuteNonQuery() <= 0)
                    throw new ArgumentException("Cannot delete user that does not belong to user");
            }
        }

        public void DeleteUserAdmin(int userId, int deleteUserId)
        {
            using (_connection = new SqlConnection(_connectionString))
            {
                var proc = "DeleteUserAdmin";

                var command = new SqlCommand(proc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@deleteUserId", deleteUserId);

                _connection.Open();

                if (command.ExecuteNonQuery() <= 0)
                    throw new InvalidOperationException("Not enough rights to delete user");
            }
        }

        public void DeleteFile(int fileId, int userId)
        {
            using (_connection = new SqlConnection(_connectionString))
            {
                var proc = "DeleteFile";

                var command = new SqlCommand(proc, _connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@fileId", fileId);
                command.Parameters.AddWithValue("@userId", userId);

                _connection.Open();

                if (command.ExecuteNonQuery() <= 0)
                    throw new ArgumentException("Cannot delete file that does not belong to user");
            }
        }

        public User GetUserInfo(int userId)
        {
            using (_connection = new SqlConnection(_connectionString))
            {
                var query = $"SELECT * FROM GetUserInfoFunc(@userId)";

                var command = new SqlCommand(query, _connection);

                command.Parameters.AddWithValue("@userId", userId);

                _connection.Open();

                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new User(
                        iD: (int)reader["ID"],
                        nickname: reader["Nickname"] as string,
                        firstName: reader["FirstName"] as string,
                        lastName: reader["LastName"] as string,
                        userDescription: reader["Description"] as string,
                        registrationDate: (DateTime)reader["RegistrationDate"],
                        userRole: (UserRole)(int)reader["RoleID"]);
                }
                throw new InvalidOperationException($"Cannot find User with ID = " + userId);
            }
        }

        //public UserRole GetUserRole(int userId)
    }
}