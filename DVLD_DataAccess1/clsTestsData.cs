using DVLD_Models1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess1
{
    public class clsTestsData
    {
        public static TestsDTO GetTestByID(int testID)
        {
            TestsDTO test = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    string query = "SELECT * FROM Tests WHERE TestID = @TestID;";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@TestID", testID);

                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                test = new TestsDTO
                                {
                                    TestID = reader.GetInt32(reader.GetOrdinal("TestID")),
                                    TestAppointmentID = reader.GetInt32(reader.GetOrdinal("TestAppointmentID")),
                                    TestResult = reader.GetBoolean(reader.GetOrdinal("TestResult")),
                                    Notes = reader.IsDBNull(reader.GetOrdinal("Notes")) ?
                                            null : reader.GetString(reader.GetOrdinal("Notes")),
                                    CreatedByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error retrieving test information", ex);
            }

            return test;
        }

        public static int AddNewTest(TestsDTO test)
        {
            int newID = -1;

            try
            {
                string query = @"INSERT INTO Tests (
                                    TestAppointmentID,
                                    TestResult,
                                    Notes,
                                    CreatedByUserID
                                 ) VALUES (
                                    @TestAppointmentID,
                                    @TestResult,
                                    @Notes,
                                    @CreatedByUserID
                                 );
                                 SELECT SCOPE_IDENTITY();";

                using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TestAppointmentID", test.TestAppointmentID);
                    cmd.Parameters.AddWithValue("@TestResult", test.TestResult);
                    cmd.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(test.Notes) ?
                                                        (object)DBNull.Value : test.Notes);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", test.CreatedByUserID);

                    conn.Open();
                    newID = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error adding new test", ex);
            }

            return newID;
        }

        public static bool UpdateTest(TestsDTO test)
        {
            bool success = false;

            try
            {
                string query = @"UPDATE Tests SET
                                    TestAppointmentID = @TestAppointmentID,
                                    TestResult = @TestResult,
                                    Notes = @Notes,
                                    CreatedByUserID = @CreatedByUserID
                                  WHERE TestID = @TestID;";

                using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TestID", test.TestID);
                    cmd.Parameters.AddWithValue("@TestAppointmentID", test.TestAppointmentID);
                    cmd.Parameters.AddWithValue("@TestResult", test.TestResult);
                    cmd.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(test.Notes) ?
                                                         (object)DBNull.Value : test.Notes);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", test.CreatedByUserID);

                    conn.Open();
                    success = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error updating test", ex);
            }

            return success;
        }

        public static bool DeleteTest(int testID)
        {
            bool isDeleted = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    string query = "DELETE FROM Tests WHERE TestID = @TestID;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@TestID", testID);

                        conn.Open();
                        isDeleted = cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error deleting test", ex);
            }

            return isDeleted;
        }

        public static List<TestsDTO> GetAllTests()
        {
            List<TestsDTO> testsList = new List<TestsDTO>();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    string query = "SELECT * FROM Tests;";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TestsDTO test = new TestsDTO
                                {
                                    TestID = reader.GetInt32(reader.GetOrdinal("TestID")),
                                    TestAppointmentID = reader.GetInt32(reader.GetOrdinal("TestAppointmentID")),
                                    TestResult = reader.GetBoolean(reader.GetOrdinal("TestResult")),
                                    Notes = reader.IsDBNull(reader.GetOrdinal("Notes")) ?
                                            null : reader.GetString(reader.GetOrdinal("Notes")),
                                    CreatedByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"))
                                };

                                testsList.Add(test);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error retrieving all tests", ex);
            }

            return testsList;
        }
    }
}