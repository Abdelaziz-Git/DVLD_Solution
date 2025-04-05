using DVLD_Models1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;


namespace DVLD_DataAccess1
{
    public class clsTestTypesData
    {
        public static TestTypesDTO GetById(int id)
        {
            TestTypesDTO TestTypes = null;
            string Query = @"SELECT * FROM TestTypes where TestTypeID = @Id";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@id", id);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                TestTypes = new TestTypesDTO();
                                TestTypes.Id = reader.GetInt32(reader.GetOrdinal("TestTypeID"));
                                TestTypes.Title = reader.GetString(reader.GetOrdinal("TestTypeTitle"));
                                TestTypes.Description = reader.GetString(reader.GetOrdinal("TestTypeDescription"));
                                TestTypes.Fees = reader.GetDecimal(reader.GetOrdinal("TestTypeFees"));
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving Test types.", ex);
            }
            return TestTypes;
        }
        public static List<TestTypesDTO> GetAll()
        {
            List<TestTypesDTO> TestTypes = new List<TestTypesDTO>();
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    string Query = @"SELECT * FROM TestTypes";
                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TestTypesDTO TestType = new TestTypesDTO();
                                TestType.Id = reader.GetInt32(reader.GetOrdinal("TestTypeID"));
                                TestType.Title = reader.GetString(reader.GetOrdinal("TestTypeTitle"));
                                TestType.Description = reader.GetString(reader.GetOrdinal("TestTypeDescription"));
                                TestType.Fees = reader.GetDecimal(reader.GetOrdinal("TestTypeFees"));
                                TestTypes.Add(TestType);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving all Test types.", ex);
            }
            return TestTypes;
        }
        public static bool Update(TestTypesDTO TestTypes)
        {
            if (TestTypes == null)
                return false;

            bool IsUpdated = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    string Query = @"UPDATE TestTypes SET TestTypeTitle = @TestTypeTitle, TestTypeDescription = @TestTypeDescription,
                                   TestTypeFees = @TestTypeFees WHERE TestTypeID = @TestTypeID";
                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@TestTypeID", TestTypes.Id);
                        cmd.Parameters.AddWithValue("@TestTypeTitle", TestTypes.Title);
                        cmd.Parameters.AddWithValue("@TestTypeDescription", TestTypes.Description);
                        cmd.Parameters.AddWithValue("@TestTypeFees", TestTypes.Fees);
                        conn.Open();
                        IsUpdated = cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while updating Test Type.", ex);
            }
            return IsUpdated;
        }
    }
}
