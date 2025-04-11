using DVLD_Models1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess1
{
    public class clsApplicationsData
    {
        public static bool ApplicantPersonHasNewOrCompleted_L_D_L_ApplicationWithSameLicenseClass(int PersonID, int LicenseClasseID)
        {
            bool hasApplication = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    string query = @"select 1 From LocalDrivingLicenseApplications 
                                     inner join Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
                                     where Applications.ApplicantPersonID = @PersonID And Applications.ApplicationTypeID = 1 
                                     And Applications.ApplicationStatus in (1,3)
                                     And LocalDrivingLicenseApplications.LicenseClassID=@LicenseClasseID;";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@PersonID", PersonID);
                        cmd.Parameters.AddWithValue("@LicenseClasseID", LicenseClasseID);
                        connection.Open();
                        var result = cmd.ExecuteScalar();
                        hasApplication = result != null && (int)result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while checking for existing L_D_L_Applications.", ex);
            }
            return hasApplication;
        }
        public static ApplicationsDTO GetApplicationInfoByID(int applicationID)
        {
            ApplicationsDTO application = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    string query = "SELECT * FROM Applications WHERE ApplicationID = @ApplicationID;";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@ApplicationID", applicationID);

                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                application = new ApplicationsDTO
                                {
                                    ApplicationID = reader.GetInt32(reader.GetOrdinal("ApplicationID")),
                                    ApplicantPersonID = reader.GetInt32(reader.GetOrdinal("ApplicantPersonID")),
                                    ApplicationTypeID = reader.GetInt32(reader.GetOrdinal("ApplicationTypeID")),
                                    ApplicationDate = reader.GetDateTime(reader.GetOrdinal("ApplicationDate")),
                                    ApplicationStatus = reader.GetByte(reader.GetOrdinal("ApplicationStatus")),
                                    LastStatusDate = reader.GetDateTime(reader.GetOrdinal("LastStatusDate")),
                                    PaidFees = reader.GetDecimal(reader.GetOrdinal("PaidFees")),
                                    CreatedByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving application information.", ex);
            }

            return application;
        }
        public static ApplicationsDTO GetApplicationInfoByPersonID(int PersonID)
        {
            ApplicationsDTO application = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    string query = "SELECT * FROM Applications WHERE PersonID = @PersonID;";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@PersonID", PersonID);

                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                application = new ApplicationsDTO
                                {
                                    ApplicationID = reader.GetInt32(reader.GetOrdinal("ApplicationID")),
                                    ApplicantPersonID = reader.GetInt32(reader.GetOrdinal("ApplicantPersonID")),
                                    ApplicationTypeID = reader.GetInt32(reader.GetOrdinal("ApplicationTypeID")),
                                    ApplicationDate = reader.GetDateTime(reader.GetOrdinal("ApplicationDate")),
                                    ApplicationStatus = reader.GetByte(reader.GetOrdinal("ApplicationStatus")),
                                    LastStatusDate = reader.GetDateTime(reader.GetOrdinal("LastStatusDate")),
                                    PaidFees = reader.GetDecimal(reader.GetOrdinal("PaidFees")),
                                    CreatedByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving application information.", ex);
            }

            return application;
        }
        public static int AddNewApplication(ApplicationsDTO application)
        {
            int applicationID = -1;

            try
            {
                string query = @"INSERT INTO Applications (
                                    ApplicantPersonID,
                                    ApplicationTypeID,
                                    ApplicationDate,
                                    ApplicationStatus,
                                    LastStatusDate,
                                    PaidFees,
                                    CreatedByUserID
                                 ) VALUES (
                                    @ApplicantPersonID,
                                    @ApplicationTypeID,
                                    @ApplicationDate,
                                    @ApplicationStatus,
                                    @LastStatusDate,
                                    @PaidFees,
                                    @CreatedByUserID
                                 );
                                 SELECT SCOPE_IDENTITY();";

                using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ApplicantPersonID", application.ApplicantPersonID);
                    cmd.Parameters.AddWithValue("@ApplicationTypeID", application.ApplicationTypeID);
                    cmd.Parameters.AddWithValue("@ApplicationDate", application.ApplicationDate);
                    cmd.Parameters.AddWithValue("@ApplicationStatus", application.ApplicationStatus);
                    cmd.Parameters.AddWithValue("@LastStatusDate", application.LastStatusDate);
                    cmd.Parameters.AddWithValue("@PaidFees", application.PaidFees);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", application.CreatedByUserID);

                    conn.Open();
                    applicationID = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while adding a new application.", ex);
            }

            return applicationID;
        }

        public static bool UpdateApplication(ApplicationsDTO application)
        {
            bool isUpdated = false;

            try
            {
                string query = @"UPDATE Applications SET
                                    ApplicantPersonID = @ApplicantPersonID,
                                    ApplicationTypeID = @ApplicationTypeID,
                                    ApplicationDate = @ApplicationDate,
                                    ApplicationStatus = @ApplicationStatus,
                                    LastStatusDate = @LastStatusDate,
                                    PaidFees = @PaidFees,
                                    CreatedByUserID = @CreatedByUserID
                                 WHERE ApplicationID = @ApplicationID;";

                using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ApplicationID", application.ApplicationID);
                    cmd.Parameters.AddWithValue("@ApplicantPersonID", application.ApplicantPersonID);
                    cmd.Parameters.AddWithValue("@ApplicationTypeID", application.ApplicationTypeID);
                    cmd.Parameters.AddWithValue("@ApplicationDate", application.ApplicationDate);
                    cmd.Parameters.AddWithValue("@ApplicationStatus", application.ApplicationStatus);
                    cmd.Parameters.AddWithValue("@LastStatusDate", application.LastStatusDate);
                    cmd.Parameters.AddWithValue("@PaidFees", application.PaidFees);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", application.CreatedByUserID);

                    conn.Open();
                    isUpdated = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while updating the application.", ex);
            }

            return isUpdated;
        }

        public static bool DeleteApplication(int applicationID)
        {
            bool isDeleted = false;

            try
            {
                string query = "DELETE FROM Applications WHERE ApplicationID = @ApplicationID;";

                using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ApplicationID", applicationID);

                    conn.Open();
                    isDeleted = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while deleting the application.", ex);
            }

            return isDeleted;
        }

        public static List<ApplicationsDTO> GetAllApplications()
        {
            List<ApplicationsDTO> applicationsList = new List<ApplicationsDTO>();

            try
            {
                string query = "SELECT * FROM Applications;";

                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ApplicationsDTO application = new ApplicationsDTO
                            {
                                ApplicationID = reader.GetInt32(reader.GetOrdinal("ApplicationID")),
                                ApplicantPersonID = reader.GetInt32(reader.GetOrdinal("ApplicantPersonID")),
                                ApplicationTypeID = reader.GetInt32(reader.GetOrdinal("ApplicationTypeID")),
                                ApplicationDate = reader.GetDateTime(reader.GetOrdinal("ApplicationDate")),
                                ApplicationStatus = reader.GetByte(reader.GetOrdinal("ApplicationStatus")),
                                LastStatusDate = reader.GetDateTime(reader.GetOrdinal("LastStatusDate")),
                                PaidFees = reader.GetDecimal(reader.GetOrdinal("PaidFees")),
                                CreatedByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"))
                            };

                            applicationsList.Add(application);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving all applications.", ex);
            }

            return applicationsList;
        }
    }
}