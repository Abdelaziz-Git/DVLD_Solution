using DVLD_Models1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess1
{
    public class clsDetainedLicensesData
    {
        public static DetainedLicensesDTO GetDetainedLicenseByID(int detainedID)
        {
            DetainedLicensesDTO license = null;

            using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM DetainedLicenses WHERE DetainedID = @DetainedID;", connection))
            {
                cmd.Parameters.AddWithValue("@DetainedID", detainedID);
                connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        license = MapReaderToDetainedLicense(reader);
                    }
                }
            }

            return license;
        }

        public static DetainedLicensesDTO GetDetainedLicenseByLicenseID(int licenseID)
        {
            DetainedLicensesDTO license = null;
            string Query = @"SELECT * FROM DetainedLicenses WHERE LicenseID = @LicenseID 
                            and (IsRelease = 0 or IsRelease is null ) ";
            using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(Query, connection))
            {
                cmd.Parameters.AddWithValue("@LicenseID", licenseID);
                connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        license = MapReaderToDetainedLicense(reader);
                    }
                }
            }

            return license;
        }

        public static int AddNewDetainedLicense(DetainedLicensesDTO license)
        {
            int newID = -1;

            string query = @"INSERT INTO DetainedLicenses (
                                LicenseID, DetainedDate, FineFees, 
                                CreatedByUserID, IsRelease, ReleaseDate, 
                                ReleasedByUserID, ReleaseApplicationID
                              ) VALUES (
                                @LicenseID, @DetainedDate, @FineFees, 
                                @CreatedByUserID, @IsRelease, @ReleaseDate, 
                                @ReleasedByUserID, @ReleaseApplicationID
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

        public static bool UpdateDetainedLicense(DetainedLicensesDTO license)
        {
            int rowsAffected = 0;

            string query = @"UPDATE DetainedLicenses SET
                                LicenseID = @LicenseID,
                                DetainedDate = @DetainedDate,
                                FineFees = @FineFees,
                                CreatedByUserID = @CreatedByUserID,
                                IsRelease = @IsRelease,
                                ReleaseDate = @ReleaseDate,
                                ReleasedByUserID = @ReleasedByUserID,
                                ReleaseApplicationID = @ReleaseApplicationID
                             WHERE DetainedID = @DetainedID;";

            using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@DetainedID", license.DetainedID);
                SetCommandParameters(cmd, license);
                conn.Open();
                rowsAffected = cmd.ExecuteNonQuery();
            }

            return rowsAffected > 0;
        }

        public static bool DeleteDetainedLicense(int detainedID)
        {
            int rowsAffected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("DELETE FROM DetainedLicenses WHERE DetainedID = @DetainedID;", conn))
            {
                cmd.Parameters.AddWithValue("@DetainedID", detainedID);
                conn.Open();
                rowsAffected = cmd.ExecuteNonQuery();
            }

            return rowsAffected > 0;
        }

        public static List<DetainedLicensesDTO> GetAllDetainedLicenses()
        {
            List<DetainedLicensesDTO> licenses = new List<DetainedLicensesDTO>();

            using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM DetainedLicenses;", connection))
            {
                connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        licenses.Add(MapReaderToDetainedLicense(reader));
                    }
                }
            }

            return licenses;
        }

        private static DetainedLicensesDTO MapReaderToDetainedLicense(SqlDataReader reader)
        {
            return new DetainedLicensesDTO(
                detainedID: reader.GetInt32(reader.GetOrdinal("DetainedID")),
                licenseID: reader.GetInt32(reader.GetOrdinal("LicenseID")),
                detainedDate: reader.GetDateTime(reader.GetOrdinal("DetainedDate")),
                fineFees: reader.GetDecimal(reader.GetOrdinal("FineFees")),
                createdByUserID: reader.GetInt32(reader.GetOrdinal("CreatedByUserID")),
                isRelease: reader.IsDBNull(reader.GetOrdinal("IsRelease")) ? (bool?)null : reader.GetBoolean(reader.GetOrdinal("IsRelease")),
                releaseDate: reader.IsDBNull(reader.GetOrdinal("ReleaseDate")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("ReleaseDate")),
                releasedByUserID: reader.IsDBNull(reader.GetOrdinal("ReleasedByUserID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("ReleasedByUserID")),
                releaseApplicationID: reader.IsDBNull(reader.GetOrdinal("ReleaseApplicationID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("ReleaseApplicationID"))
            );
        }

        private static void SetCommandParameters(SqlCommand cmd, DetainedLicensesDTO license)
        {
            cmd.Parameters.AddWithValue("@LicenseID", license.LicenseID);
            cmd.Parameters.AddWithValue("@DetainedDate", license.DetainedDate);
            cmd.Parameters.AddWithValue("@FineFees", license.FineFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", license.CreatedByUserID);
            cmd.Parameters.AddWithValue("@IsRelease", (object)license.IsRelease ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@ReleaseDate", (object)license.ReleaseDate ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@ReleasedByUserID", (object)license.ReleasedByUserID ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@ReleaseApplicationID", (object)license.ReleaseApplicationID ?? DBNull.Value);
        }
    }
}