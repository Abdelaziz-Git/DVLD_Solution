using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Models;

namespace DVLD_DataAccess
{
    public class clsPersonData
    {
        public static PersonDTO GetPersonInfoByID(int personID)
        {
            PersonDTO person = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("GetPersonInfoByID", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PersonID", personID);

                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                person = new PersonDTO
                                {
                                    ID = reader.GetInt32(reader.GetOrdinal("PersonID")),
                                    NationalNo = reader.GetString(reader.GetOrdinal("NationalNo")),
                                    FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                                    SecondName = reader.IsDBNull(reader.GetOrdinal("SecondName")) ? null : reader.GetString(reader.GetOrdinal("SecondName")),
                                    ThirdName = reader.IsDBNull(reader.GetOrdinal("ThirdName")) ? null : reader.GetString(reader.GetOrdinal("ThirdName")),
                                    LastName = reader.GetString(reader.GetOrdinal("LastName")),
                                    Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader.GetString(reader.GetOrdinal("Email")),
                                    PhoneNum = reader.GetString(reader.GetOrdinal("Phone")),
                                    Address = reader.GetString(reader.GetOrdinal("Address")),
                                    BirthDate = reader.GetDateTime(reader.GetOrdinal("BirthDate")),
                                    Gender = reader.GetByte(reader.GetOrdinal("Gender")),
                                    ImagePath = reader.IsDBNull(reader.GetOrdinal("ImagePath")) ? null : reader.GetString(reader.GetOrdinal("ImagePath")),
                                    CountryID = reader.GetInt16(reader.GetOrdinal("CountryID"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception (use a logging framework like Serilog, NLog, etc.)
                // Example: Logger.LogError(ex, "Error retrieving person info by ID.");
                throw new ApplicationException("An error occurred while retrieving person information.", ex);
            }

            return person;
        }
        public static PersonDTO GetPersonInfoByNationalNo(string nationalNo)
        {
            PersonDTO person = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("GetPersonInfoByNationalNo", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NationalNo", nationalNo);
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                person = new PersonDTO
                                {
                                    ID = reader.GetInt32(reader.GetOrdinal("PersonID")),
                                    NationalNo = reader.GetString(reader.GetOrdinal("NationalNo")),
                                    FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                                    SecondName = reader.IsDBNull(reader.GetOrdinal("SecondName")) ? null : reader.GetString(reader.GetOrdinal("SecondName")),
                                    ThirdName = reader.IsDBNull(reader.GetOrdinal("ThirdName")) ? null : reader.GetString(reader.GetOrdinal("ThirdName")),
                                    LastName = reader.GetString(reader.GetOrdinal("LastName")),
                                    Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader.GetString(reader.GetOrdinal("Email")),
                                    PhoneNum = reader.GetString(reader.GetOrdinal("Phone")),
                                    Address = reader.GetString(reader.GetOrdinal("Address")),
                                    BirthDate = reader.GetDateTime(reader.GetOrdinal("BirthDate")),
                                    Gender = reader.GetByte(reader.GetOrdinal("Gender")),
                                    ImagePath = reader.IsDBNull(reader.GetOrdinal("ImagePath")) ? null : reader.GetString(reader.GetOrdinal("ImagePath")),
                                    CountryID = reader.GetInt16(reader.GetOrdinal("CountryID"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception (use a logging framework like Serilog, NLog, etc.)
                // Example: Logger.LogError(ex, "Error retrieving person info by ID.");
                throw new ApplicationException("An error occurred while retrieving person information.", ex);
            }

            return person;
        }
        public static int AddNewPerson(PersonDTO person)
        {
            person.ID = -1;
            try
            {
                using(SqlConnection conn=new SqlConnection(clsDataConfig.ConnectionString))
                using(SqlCommand cmd=new SqlCommand("AddNewPerson",conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NationalNo", person.NationalNo);
                    cmd.Parameters.AddWithValue("@FirstName", person.FirstName);
                    cmd.Parameters.AddWithValue("@SecondName", string.IsNullOrWhiteSpace(person.SecondName) ? (object)DBNull.Value : person.SecondName);
                    cmd.Parameters.AddWithValue("@ThirdName", string.IsNullOrWhiteSpace(person.ThirdName) ? (object)DBNull.Value : person.ThirdName);
                    cmd.Parameters.AddWithValue("@LastName", person.LastName);
                    cmd.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(person.Email) ? (object)DBNull.Value : person.Email);
                    cmd.Parameters.AddWithValue("@Phone", person.PhoneNum);
                    cmd.Parameters.AddWithValue("@Address", person.Address);
                    cmd.Parameters.AddWithValue("@BirthDate", person.BirthDate);
                    cmd.Parameters.AddWithValue("@Gender", person.Gender);
                    cmd.Parameters.AddWithValue("@ImagePath", string.IsNullOrWhiteSpace(person.ImagePath) ? (object)DBNull.Value : person.ImagePath);
                    cmd.Parameters.AddWithValue("@CountryID", person.CountryID);
                    conn.Open();
                    person.ID = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                // Log the exception (use a logging framework like Serilog, NLog, etc.)
                // Example: Logger.LogError(ex, "Error adding new person.");
                throw new ApplicationException("An error occurred while adding new person.", ex);
            }
            return person.ID;
        }
        public static bool UpdatePerson(PersonDTO person)
        {
            if (person == null) return false;
            bool IsUpdated = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand cmd = new SqlCommand("UpdatePerson", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PersonID", person.ID);
                    cmd.Parameters.AddWithValue("@NationalNo", person.NationalNo);
                    cmd.Parameters.AddWithValue("@FirstName", person.FirstName);
                    cmd.Parameters.AddWithValue("@SecondName", string.IsNullOrWhiteSpace(person.SecondName) ? (object)DBNull.Value : person.SecondName);
                    cmd.Parameters.AddWithValue("@ThirdName", string.IsNullOrWhiteSpace(person.ThirdName) ? (object)DBNull.Value : person.ThirdName);
                    cmd.Parameters.AddWithValue("@LastName", person.LastName);
                    cmd.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(person.Email) ? (object)DBNull.Value : person.Email);
                    cmd.Parameters.AddWithValue("@Phone", person.PhoneNum);
                    cmd.Parameters.AddWithValue("@Address", person.Address);
                    cmd.Parameters.AddWithValue("@BirthDate", person.BirthDate);
                    cmd.Parameters.AddWithValue("@Gender", person.Gender);
                    cmd.Parameters.AddWithValue("@ImagePath", string.IsNullOrWhiteSpace(person.ImagePath) ? (object)DBNull.Value : person.ImagePath);
                    cmd.Parameters.AddWithValue("@CountryID", person.CountryID);
                    conn.Open();
                    IsUpdated = cmd.ExecuteNonQuery() > 0;
                }

            }
            catch(Exception ex)
            {
                // Log the exception (use a logging framework like Serilog, NLog, etc.)
                // Example: Logger.LogError(ex, "Error updating person.");
                throw new ApplicationException("An error occurred while updating person.", ex);
            }
            return IsUpdated;
        }
        public static bool DeletePerson(int personID)
        {
            bool IsDeleted = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand cmd = new SqlCommand("DeletePerson", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PersonID", personID);
                    conn.Open();
                    IsDeleted = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                // Log the exception (use a logging framework like Serilog, NLog, etc.)
                // Example: Logger.LogError(ex, "Error deleting person.");
                throw new ApplicationException("An error occurred while deleting person.", ex);
            }
            return IsDeleted;
        }
        public static bool IsPersonExistByID(int personID)
        {
            bool IsExist = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand command = new SqlCommand("IsPersonExistByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("PersonID", personID);
                    connection.Open();
                    IsExist = Convert.ToBoolean(command.ExecuteScalar());
                }
            }
            catch(Exception ex)
            {
                // Log the exception (use a logging framework like Serilog, NLog, etc.)
                // Example: Logger.LogError(ex, "Error checking if person exists.");
                throw new ApplicationException("An error occurred while checking if person exists.", ex);
            }
            
            return IsExist;
        }
        public static bool IsPersonExistByNationalNo(string nationalNo)
        {
            bool IsExist = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand command = new SqlCommand("IsPersonExistByNationalNo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("NationalNo", nationalNo);
                    connection.Open();
                    IsExist = Convert.ToBoolean(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                // Log the exception (use a logging framework like Serilog, NLog, etc.)
                // Example: Logger.LogError(ex, "Error checking if person exists.");
                throw new ApplicationException("An error occurred while checking if person exists.", ex);
            }
            return IsExist;
        }
        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand command = new SqlCommand("GetAllPeople", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            dt.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception (use a logging framework like Serilog, NLog, etc.)
                // Example: Logger.LogError(ex, "Error retrieving all people.");
                throw new ApplicationException("An error occurred while retrieving all people.", ex);
            }
            return dt;
        }   
        public static DataTable GetAllPeopleDetails()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand command = new SqlCommand("GetAllPeopleDetails", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            dt.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception (use a logging framework like Serilog, NLog, etc.)
                // Example: Logger.LogError(ex, "Error retrieving all people.");
                throw new ApplicationException("An error occurred while retrieving all people.", ex);
            }
            return dt;
        }
    }  
}
