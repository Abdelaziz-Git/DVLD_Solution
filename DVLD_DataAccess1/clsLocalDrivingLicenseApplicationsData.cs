using DVLD_Models1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess1
{
    public class clsLocalDrivingLicenseApplicationsData
    {
        public static LocalDrivingLicenseApplicationsDTO GetInfoByID(int localDrivingLicenseApplicationID)
        {
            LocalDrivingLicenseApplicationsDTO application = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    string query = "SELECT * FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                application = new LocalDrivingLicenseApplicationsDTO(
                                    reader.GetInt32(reader.GetOrdinal("LocalDrivingLicenseApplicationID")),
                                    reader.GetInt32(reader.GetOrdinal("ApplicationID")),
                                    reader.GetInt32(reader.GetOrdinal("LicenseClassID"))
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error retrieving local driving license application.", ex);
            }

            return application;
        }
        public static int AddNew(LocalDrivingLicenseApplicationsDTO application)
        {
            int newID = -1;

            try
            {
                string query = @"INSERT INTO LocalDrivingLicenseApplications (
                                    ApplicationID,
                                    LicenseClassID
                                 ) VALUES (
                                    @ApplicationID,
                                    @LicenseClassID
                                 );
                                 SELECT SCOPE_IDENTITY();";

                using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ApplicationID", application.ApplicationID);
                    cmd.Parameters.AddWithValue("@LicenseClassID", application.LicenseClassID);

                    conn.Open();
                    newID = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error adding new local driving license application.", ex);
            }

            return newID;
        }
        public static bool Update(LocalDrivingLicenseApplicationsDTO application)
        {
            bool isUpdated = false;

            try
            {
                string query = @"UPDATE LocalDrivingLicenseApplications SET
                                    ApplicationID = @ApplicationID,
                                    LicenseClassID = @LicenseClassID
                                 WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

                using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", application.LocalDrivingLicenseApplicationID);
                    cmd.Parameters.AddWithValue("@ApplicationID", application.ApplicationID);
                    cmd.Parameters.AddWithValue("@LicenseClassID", application.LicenseClassID);

                    conn.Open();
                    isUpdated = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error updating local driving license application.", ex);
            }

            return isUpdated;
        }
        public static bool Delete(int localDrivingLicenseApplicationID)
        {
            bool isDeleted = false;

            try
            {
                string query = "DELETE FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

                using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
                    conn.Open();
                    isDeleted = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error deleting local driving license application.", ex);
            }

            return isDeleted;
        }
        public static List<LocalDrivingLicenseApplicationsDTO> GetAll()
        {
            List<LocalDrivingLicenseApplicationsDTO> list = new List<LocalDrivingLicenseApplicationsDTO>();

            try
            {
                string query = "SELECT * FROM LocalDrivingLicenseApplications;";

                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new LocalDrivingLicenseApplicationsDTO(
                                reader.GetInt32(reader.GetOrdinal("LocalDrivingLicenseApplicationID")),
                                reader.GetInt32(reader.GetOrdinal("ApplicationID")),
                                reader.GetInt32(reader.GetOrdinal("LicenseClassID"))
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error retrieving all applications.", ex);
            }

            return list;
        }
        public static DataView LocalDrivingLicenseApplicationsDataView()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM LocalDrivingLicenseApplications_View;";
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error retrieving local driving license applications data view.", ex);
            }
            return dt.DefaultView;
        }
        public static byte GetPassedTests(int localDrivingLicenseApplicationID)
        {
            byte passedTests = 0;
            try
            {
                string query = @"select Count(TestAppointments.TestTypeID) From TestAppointments 
                                 inner join Tests ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                                 where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                                 AND IsLocked = 1 AND Tests.TestResult = 1;";

                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
                    connection.Open();
                    passedTests = Convert.ToByte(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error retrieving passed tests count.", ex);
            }
            return passedTests;
        }
    }
}