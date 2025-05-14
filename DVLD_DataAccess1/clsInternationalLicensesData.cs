using DVLD_Models1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess1
{
    public class clsInternationalLicensesData
    {
        public static InternationalLicensesDTO GetInternationalLicenseByID(int internationalLicenseID)
        {
            InternationalLicensesDTO license = null;

            using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID;", connection))
            {
                cmd.Parameters.AddWithValue("@InternationalLicenseID", internationalLicenseID);
                connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        license = MapReaderToLicense(reader);
                    }
                }
            }

            return license;
        }

        public static InternationalLicensesDTO GetInternationalLicenseByApplicationID(int applicationID)
        {
            InternationalLicensesDTO license = null;

            using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM InternationalLicenses WHERE ApplicationID = @ApplicationID;", connection))
            {
                cmd.Parameters.AddWithValue("@ApplicationID", applicationID);
                connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        license = MapReaderToLicense(reader);
                    }
                }
            }

            return license;
        }

        public static List<InternationalLicensesDTO> GetInternationalLicensesByDriverID(int driverID)
        {
            List<InternationalLicensesDTO> licenses = new List<InternationalLicensesDTO>();

            using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM InternationalLicenses WHERE DriverID = @DriverID;", connection))
            {
                cmd.Parameters.AddWithValue("@DriverID", driverID);
                connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        licenses.Add(MapReaderToLicense(reader));
                    }
                }
            }

            return licenses;
        }

        public static List<InternationalLicensesDTO> GetInternationalLicensesByIssuedUsingLocalLicenseID(int issuedUsingLocalLicenseID)
        {
            List<InternationalLicensesDTO> licenses = new List<InternationalLicensesDTO>();

            using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM InternationalLicenses WHERE IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID;", connection))
            {
                cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", issuedUsingLocalLicenseID);
                connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        licenses.Add(MapReaderToLicense(reader));
                    }
                }
            }

            return licenses;
        }

        public static int AddNewInternationalLicense(InternationalLicensesDTO license)
        {
            int newID = -1;

            string query = @"INSERT INTO InternationalLicenses (
                                ApplicationID, DriverID, IssuedUsingLocalLicenseID, 
                                IssueDate, ExpirationDate, IsActive, CreatedByUserID
                              ) VALUES (
                                @ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, 
                                @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID
                              );
                              SELECT SCOPE_IDENTITY();";

            using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                SetCommandParameters(cmd, license);
                conn.Open();
                newID = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return newID;
        }

        public static bool UpdateInternationalLicense(InternationalLicensesDTO license)
        {
            int rowsAffected = 0;

            string query = @"UPDATE InternationalLicenses SET
                                ApplicationID = @ApplicationID,
                                DriverID = @DriverID,
                                IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID,
                                IssueDate = @IssueDate,
                                ExpirationDate = @ExpirationDate,
                                IsActive = @IsActive,
                                CreatedByUserID = @CreatedByUserID
                             WHERE InternationalLicenseID = @InternationalLicenseID;";

            using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@InternationalLicenseID", license.InternationalLicenseID);
                SetCommandParameters(cmd, license);
                conn.Open();
                rowsAffected = cmd.ExecuteNonQuery();
            }

            return rowsAffected > 0;
        }

        public static bool DeleteInternationalLicense(int internationalLicenseID)
        {
            int rowsAffected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("DELETE FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID;", conn))
            {
                cmd.Parameters.AddWithValue("@InternationalLicenseID", internationalLicenseID);
                conn.Open();
                rowsAffected = cmd.ExecuteNonQuery();
            }

            return rowsAffected > 0;
        }
        public static List<InternationalLicensesDTO> GetAllInternationalLicenses()
        {
            List<InternationalLicensesDTO> internationalLicensesDTOs = new List<InternationalLicensesDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    string Query = @"Select * From InternationalLicenses";
                    using (SqlCommand cmd = new SqlCommand(Query,connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                internationalLicensesDTOs.Add(MapReaderToLicense(reader));
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return internationalLicensesDTOs;
        }
            
        private static InternationalLicensesDTO MapReaderToLicense(SqlDataReader reader)
        {
            return new InternationalLicensesDTO(
                internationalLicenseID: reader.GetInt32(reader.GetOrdinal("InternationalLicenseID")),
                applicationID: reader.GetInt32(reader.GetOrdinal("ApplicationID")),
                driverID: reader.GetInt32(reader.GetOrdinal("DriverID")),
                issuedUsingLocalLicenseID: reader.GetInt32(reader.GetOrdinal("IssuedUsingLocalLicenseID")),
                issueDate: reader.GetDateTime(reader.GetOrdinal("IssueDate")),
                expirationDate: reader.GetDateTime(reader.GetOrdinal("ExpirationDate")),
                isActive: reader.GetBoolean(reader.GetOrdinal("IsActive")),
                createdByUserID: reader.GetInt32(reader.GetOrdinal("CreatedByUserID"))
            );
        }

        private static void SetCommandParameters(SqlCommand cmd, InternationalLicensesDTO license)
        {
            cmd.Parameters.AddWithValue("@ApplicationID", license.ApplicationID);
            cmd.Parameters.AddWithValue("@DriverID", license.DriverID);
            cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", license.IssuedUsingLocalLicenseID);
            cmd.Parameters.AddWithValue("@IssueDate", license.IssueDate);
            cmd.Parameters.AddWithValue("@ExpirationDate", license.ExpirationDate);
            cmd.Parameters.AddWithValue("@IsActive", license.IsActive);
            cmd.Parameters.AddWithValue("@CreatedByUserID", license.CreatedByUserID);
        }
    }
}