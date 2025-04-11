using DVLD_Models1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess1
{
    public class clsTestAppointmentsData
    {
        public static TestAppointmentsDTO GetTestAppointmentInfoByID(int testAppointmentID)
        {
            TestAppointmentsDTO appointment = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    string query = "SELECT * FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID;";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);

                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                appointment = new TestAppointmentsDTO
                                {
                                    TestAppointmentID = reader.GetInt32(reader.GetOrdinal("TestAppointmentID")),
                                    LocalDrivingLicenseApplicationID = reader.GetInt32(reader.GetOrdinal("LocalDrivingLicenseApplicationID")),
                                    TestTypeID = reader.GetInt32(reader.GetOrdinal("TestTypeID")),
                                    AppointmentDate = reader.GetDateTime(reader.GetOrdinal("AppointmentDate")),
                                    PaidFees = reader.GetDecimal(reader.GetOrdinal("PaidFees")),
                                    IsLocked = reader.GetBoolean(reader.GetOrdinal("IsLocked")),
                                    CreatedByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID")),
                                    RetakeTestApplicationID = reader.IsDBNull(reader.GetOrdinal("RetakeTestApplicationID")) ?
                                        (int?)null : reader.GetInt32(reader.GetOrdinal("RetakeTestApplicationID"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error retrieving test appointment information", ex);
            }

            return appointment;
        }

        public static int AddNewTestAppointment(TestAppointmentsDTO appointment)
        {
            int newID = -1;

            try
            {
                string query = @"INSERT INTO TestAppointments (
                                    LocalDrivingLicenseApplicationID,
                                    TestTypeID,
                                    AppointmentDate,
                                    PaidFees,
                                    IsLocked,
                                    CreatedByUserID,
                                    RetakeTestApplicationID
                                 ) VALUES (
                                    @LocalDrivingLicenseApplicationID,
                                    @TestTypeID,
                                    @AppointmentDate,
                                    @PaidFees,
                                    @IsLocked,
                                    @CreatedByUserID,
                                    @RetakeTestApplicationID
                                 );
                                 SELECT SCOPE_IDENTITY();";

                using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", appointment.LocalDrivingLicenseApplicationID);
                    cmd.Parameters.AddWithValue("@TestTypeID", appointment.TestTypeID);
                    cmd.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate);
                    cmd.Parameters.AddWithValue("@PaidFees", appointment.PaidFees);
                    cmd.Parameters.AddWithValue("@IsLocked", appointment.IsLocked);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", appointment.CreatedByUserID);
                    cmd.Parameters.AddWithValue("@RetakeTestApplicationID",
                        appointment.RetakeTestApplicationID.HasValue ?
                        (object)appointment.RetakeTestApplicationID.Value : DBNull.Value);

                    conn.Open();
                    newID = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error adding new test appointment", ex);
            }

            return newID;
        }

        public static bool UpdateTestAppointment(TestAppointmentsDTO appointment)
        {
            bool success = false;

            try
            {
                string query = @"UPDATE TestAppointments SET
                                    LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID,
                                    TestTypeID = @TestTypeID,
                                    AppointmentDate = @AppointmentDate,
                                    PaidFees = @PaidFees,
                                    IsLocked = @IsLocked,
                                    CreatedByUserID = @CreatedByUserID,
                                    RetakeTestApplicationID = @RetakeTestApplicationID
                                 WHERE TestAppointmentID = @TestAppointmentID;";

                using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TestAppointmentID", appointment.TestAppointmentID);
                    cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", appointment.LocalDrivingLicenseApplicationID);
                    cmd.Parameters.AddWithValue("@TestTypeID", appointment.TestTypeID);
                    cmd.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate);
                    cmd.Parameters.AddWithValue("@PaidFees", appointment.PaidFees);
                    cmd.Parameters.AddWithValue("@IsLocked", appointment.IsLocked);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", appointment.CreatedByUserID);
                    cmd.Parameters.AddWithValue("@RetakeTestApplicationID",
                        appointment.RetakeTestApplicationID.HasValue ?
                        (object)appointment.RetakeTestApplicationID.Value : DBNull.Value);

                    conn.Open();
                    success = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error updating test appointment", ex);
            }

            return success;
        }
        public static bool DeleteTestAppointment(int testAppointmentID)
        {
            bool isDeleted = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    string query = "DELETE FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);

                        conn.Open();
                        isDeleted = cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error deleting test appointment", ex);
            }

            return isDeleted;
        }
        public static List<TestAppointmentsDTO> GetAllTestAppointments()
        {
            List<TestAppointmentsDTO> appointmentsList = new List<TestAppointmentsDTO>();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    string query = "SELECT * FROM TestAppointments;";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TestAppointmentsDTO appointment = new TestAppointmentsDTO
                                {
                                    TestAppointmentID = reader.GetInt32(reader.GetOrdinal("TestAppointmentID")),
                                    LocalDrivingLicenseApplicationID = reader.GetInt32(reader.GetOrdinal("LocalDrivingLicenseApplicationID")),
                                    TestTypeID = reader.GetInt32(reader.GetOrdinal("TestTypeID")),
                                    AppointmentDate = reader.GetDateTime(reader.GetOrdinal("AppointmentDate")),
                                    PaidFees = reader.GetDecimal(reader.GetOrdinal("PaidFees")),
                                    IsLocked = reader.GetBoolean(reader.GetOrdinal("IsLocked")),
                                    CreatedByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID")),
                                    RetakeTestApplicationID = reader.IsDBNull(reader.GetOrdinal("RetakeTestApplicationID")) ?
                                        (int?)null : reader.GetInt32(reader.GetOrdinal("RetakeTestApplicationID"))
                                };

                                appointmentsList.Add(appointment);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error retrieving test appointments", ex);
            }

            return appointmentsList;
        }
    }
}