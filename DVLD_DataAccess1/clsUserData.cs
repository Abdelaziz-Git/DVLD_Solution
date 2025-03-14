using DVLD_Models1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess1
{
    public class clsUserData
    {
        public static UserDTO GetUserInfo(int UserID)
        {
            UserDTO User = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand cmd = new SqlCommand("Users.GetUserInfoByID", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", UserID);

                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            User = new UserDTO
                            {
                                UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                                PersonID = reader.GetInt32(reader.GetOrdinal("PersonID")),
                                UserName = reader.GetString(reader.GetOrdinal("UserName")),
                                PasswordHash = (byte[])reader["PasswordHash"],
                                Salt = reader.GetString(reader.GetOrdinal("Salt")),
                                IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                Permissions = reader.GetInt32(reader.GetOrdinal("Permissions"))
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving User information.", ex);
            }

            return User;
        }
        public static UserDTO GetUserInfo(string Username,string Password)
        {
            UserDTO User = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand cmd = new SqlCommand("Users.GetUserInfoByUsernameAndPassword", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserName", Username);
                    cmd.Parameters.AddWithValue("@Password", Password);

                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            User = new UserDTO
                            {
                                UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                                PersonID = reader.GetInt32(reader.GetOrdinal("PersonID")),
                                UserName = reader.GetString(reader.GetOrdinal("UserName")),
                                PasswordHash = (byte[])reader["PasswordHash"],
                                Salt = reader.GetString(reader.GetOrdinal("Salt")),
                                IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                Permissions = reader.GetInt32(reader.GetOrdinal("Permissions"))
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving User information.", ex);
            }

            return User;
        }
        public static UserDTO GetUserInfoByPersonID(int PersonID)
        {
            UserDTO User = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand cmd = new SqlCommand("Users.GetUserInfoByPersonID", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            User = new UserDTO
                            {
                                UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                                PersonID = reader.GetInt32(reader.GetOrdinal("PersonID")),
                                UserName = reader.GetString(reader.GetOrdinal("UserName")),
                                PasswordHash = (byte[])reader["PasswordHash"],
                                Salt = reader.GetString(reader.GetOrdinal("Salt")),
                                IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                Permissions = reader.GetInt32(reader.GetOrdinal("Permissions"))
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving User information.", ex);
            }
            return User;
        }
        public static int AddNewUser(int PersonID,string UserName,string Password,bool IsActive,int Permissions)
        {
            int NewID = -1;
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand cmd = new SqlCommand("Users.AddNewUser", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);
                    cmd.Parameters.AddWithValue("@UserName", UserName);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@IsActive", IsActive);
                    cmd.Parameters.AddWithValue("@Permissions", Permissions);

                    conn.Open();
                    NewID = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while adding new User.", ex);
            }
            return NewID;
        }

        public static bool UpdateUser(int UserID, string UserName, bool IsActive, int Permissions)
        {
            bool IsUpdated = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand cmd = new SqlCommand("Users.UpdateUser", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    cmd.Parameters.AddWithValue("@UserName", UserName);
                    cmd.Parameters.AddWithValue("@IsActive", IsActive);
                    cmd.Parameters.AddWithValue("@Permissions", Permissions);

                    conn.Open();
                    IsUpdated = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while updating User.", ex);
            }
            return IsUpdated;
        }

        public static bool DeleteUser(int UserID)
        {
            bool IsDeleted = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand cmd = new SqlCommand("Users.DeleteUserByID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    conn.Open();
                    IsDeleted = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while deleting User.", ex);
            }
            return IsDeleted;
        }

        public static bool IsUserExistByUserID(int UserID)
        {
            bool IsExist = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand command = new SqlCommand("Users.IsUserExistByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", UserID);
                    connection.Open();
                    IsExist = Convert.ToBoolean(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while checking if User exists.", ex);
            }
            return IsExist;
        }
        public static bool IsUserExistByPersonID(int PersonID)
        {
            bool IsExist = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand command = new SqlCommand("Users.IsUserExistByPersonID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    connection.Open();
                    IsExist = Convert.ToBoolean(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while checking if Person id exists.", ex);
            }
            return IsExist;
        }

        public static bool IsUserNameExists(string UserName)
        {
            bool IsExist = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand command = new SqlCommand("Users.IsUserNameExists", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserName", UserName);
                    connection.Open();
                    IsExist = Convert.ToBoolean(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while checking if UserName exists.", ex);
            }
            return IsExist;
        }
        public static bool IsCorrectPassword(int UserID, string Password)
        {
            bool IsCorrect = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand command = new SqlCommand("Users.IsCorrectPassword", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@Password", Password);
                    connection.Open();
                    IsCorrect = Convert.ToBoolean(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while checking if password is correct.", ex);
            }
            return IsCorrect;
        }
        public static bool ChangePassword(int UserID, string NewPassword)
        {
            bool IsChanged = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand cmd = new SqlCommand("Users.ChangePassword", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    cmd.Parameters.AddWithValue("@NewPassword", NewPassword);
                    conn.Open();
                    IsChanged = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while changing password.", ex);
            }
            return IsChanged;
        }

        public static DataView GetAllUsers()
        {
            DataView dv = new DataView();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand command = new SqlCommand("Users.GetAllUsers", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dv = dt.DefaultView;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving all Users.", ex);
            }
            return dv;
        }

        public static DataView GetAllUsersDetails()
        {
            DataView dv = new DataView();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand command = new SqlCommand("Users.GetAllUsersDetails", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dv = dt.DefaultView;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving all Users.", ex);
            }
            return dv;
        }
    }

}
