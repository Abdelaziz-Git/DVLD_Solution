// clsLicensesData.cs
using DVLD_Models1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess1
{
    public class clsLicensesData
    {
        public static LicensesDTO GetLicenseInfoByID(int licenseID)
        {
            LicensesDTO license = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    string query = "SELECT * FROM Licenses WHERE LicenseID = @LicenseID;";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@LicenseID", licenseID);
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                license = new LicensesDTO
                                {
                                    LicenseID = reader.GetInt32(reader.GetOrdinal("LicenseID")),
                                    ApplicationID = reader.GetInt32(reader.GetOrdinal("ApplicationID")),
                                    LicenseClassID = reader.GetInt32(reader.GetOrdinal("LicenseClassID")),
                                    DriverID = reader.GetInt32(reader.GetOrdinal("DriverID")),
                                    IssueDate = reader.GetDateTime(reader.GetOrdinal("IssueDate")),
                                    ExpiryDate = reader.GetDateTime(reader.GetOrdinal("ExpiryDate")),
                                    Notes = reader.IsDBNull(reader.GetOrdinal("Notes")) ? null : reader.GetString(reader.GetOrdinal("Notes")),
                                    PaidFees = reader.GetDecimal(reader.GetOrdinal("PaidFees")),
                                    IssueReason = reader.GetByte(reader.GetOrdinal("IssueReason")),
                                    IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                    CreatedByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving license information.", ex);
            }
            return license;
        }

        public static LicensesDTO GetLicenseInfoByApplicationID(int applicationID)
        {
            LicensesDTO license = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    string query = "SELECT * FROM Licenses WHERE ApplicationID = @ApplicationID;";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@ApplicationID", applicationID);
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                license = new LicensesDTO
                                {
                                    LicenseID = reader.GetInt32(reader.GetOrdinal("LicenseID")),
                                    ApplicationID = reader.GetInt32(reader.GetOrdinal("ApplicationID")),
                                    LicenseClassID = reader.GetInt32(reader.GetOrdinal("LicenseClassID")),
                                    DriverID = reader.GetInt32(reader.GetOrdinal("DriverID")),
                                    IssueDate = reader.GetDateTime(reader.GetOrdinal("IssueDate")),
                                    ExpiryDate = reader.GetDateTime(reader.GetOrdinal("ExpiryDate")),
                                    Notes = reader.IsDBNull(reader.GetOrdinal("Notes")) ? null : reader.GetString(reader.GetOrdinal("Notes")),
                                    PaidFees = reader.GetDecimal(reader.GetOrdinal("PaidFees")),
                                    IssueReason = reader.GetByte(reader.GetOrdinal("IssueReason")),
                                    IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                    CreatedByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving license by application ID.", ex);
            }
            return license;
        }
        public static bool LicenseExistsByApplicationID(int applicationID)
        {
            bool exists = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    string query = "SELECT 1 FROM Licenses WHERE ApplicationID = @ApplicationID;";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@ApplicationID", applicationID);
                        connection.Open();
                        var result = cmd.ExecuteScalar();
                        exists = result != null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while checking if license exists by application ID.", ex);
            }
            return exists;
        }

        public static List<LicensesDTO> GetLicensesByLicenseClassID(int licenseClassID)
        {
            List<LicensesDTO> licenses = new List<LicensesDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    string query = "SELECT * FROM Licenses WHERE LicenseClassID = @LicenseClassID;";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@LicenseClassID", licenseClassID);
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                licenses.Add(new LicensesDTO
                                {
                                    LicenseID = reader.GetInt32(reader.GetOrdinal("LicenseID")),
                                    ApplicationID = reader.GetInt32(reader.GetOrdinal("ApplicationID")),
                                    LicenseClassID = reader.GetInt32(reader.GetOrdinal("LicenseClassID")),
                                    DriverID = reader.GetInt32(reader.GetOrdinal("DriverID")),
                                    IssueDate = reader.GetDateTime(reader.GetOrdinal("IssueDate")),
                                    ExpiryDate = reader.GetDateTime(reader.GetOrdinal("ExpiryDate")),
                                    Notes = reader.IsDBNull(reader.GetOrdinal("Notes")) ? null : reader.GetString(reader.GetOrdinal("Notes")),
                                    PaidFees = reader.GetDecimal(reader.GetOrdinal("PaidFees")),
                                    IssueReason = reader.GetByte(reader.GetOrdinal("IssueReason")),
                                    IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                    CreatedByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"))
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving licenses by license class ID.", ex);
            }
            return licenses;
        }

        public static List<LicensesDTO> GetLicensesByDriverID(int driverID)
        {
            List<LicensesDTO> licenses = new List<LicensesDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    string query = "SELECT * FROM Licenses WHERE DriverID = @DriverID;";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@DriverID", driverID);
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                licenses.Add(new LicensesDTO
                                {
                                    LicenseID = reader.GetInt32(reader.GetOrdinal("LicenseID")),
                                    ApplicationID = reader.GetInt32(reader.GetOrdinal("ApplicationID")),
                                    LicenseClassID = reader.GetInt32(reader.GetOrdinal("LicenseClassID")),
                                    DriverID = reader.GetInt32(reader.GetOrdinal("DriverID")),
                                    IssueDate = reader.GetDateTime(reader.GetOrdinal("IssueDate")),
                                    ExpiryDate = reader.GetDateTime(reader.GetOrdinal("ExpiryDate")),
                                    Notes = reader.IsDBNull(reader.GetOrdinal("Notes")) ? null : reader.GetString(reader.GetOrdinal("Notes")),
                                    PaidFees = reader.GetDecimal(reader.GetOrdinal("PaidFees")),
                                    IssueReason = reader.GetByte(reader.GetOrdinal("IssueReason")),
                                    IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                    CreatedByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"))
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving licenses by driver ID.", ex);
            }
            return licenses;
        }

        public static int AddNewLicense(LicensesDTO license)
        {
            int licenseID = -1;
            try
            {
                string query = @"INSERT INTO Licenses (
                                    ApplicationID, LicenseClassID, DriverID, IssueDate, ExpiryDate,
                                    Notes, PaidFees, IssueReason, IsActive, CreatedByUserID
                                 ) VALUES (
                                    @ApplicationID, @LicenseClassID, @DriverID, @IssueDate, @ExpiryDate,
                                    @Notes, @PaidFees, @IssueReason, @IsActive, @CreatedByUserID
                                 );
                                 SELECT SCOPE_IDENTITY();";
                using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ApplicationID", license.ApplicationID);
                    cmd.Parameters.AddWithValue("@LicenseClassID", license.LicenseClassID);
                    cmd.Parameters.AddWithValue("@DriverID", license.DriverID);
                    cmd.Parameters.AddWithValue("@IssueDate", license.IssueDate);
                    cmd.Parameters.AddWithValue("@ExpiryDate", license.ExpiryDate);
                    cmd.Parameters.AddWithValue("@Notes", (object)license.Notes ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@PaidFees", license.PaidFees);
                    cmd.Parameters.AddWithValue("@IssueReason", license.IssueReason);
                    cmd.Parameters.AddWithValue("@IsActive", license.IsActive);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", license.CreatedByUserID);
                    conn.Open();
                    licenseID = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while adding a new license.", ex);
            }
            return licenseID;
        }

        public static bool UpdateLicense(LicensesDTO license)
        {
            bool isUpdated = false;
            try
            {
                string query = @"UPDATE Licenses SET
                                    ApplicationID = @ApplicationID,
                                    LicenseClassID = @LicenseClassID,
                                    DriverID = @DriverID,
                                    IssueDate = @IssueDate,
                                    ExpiryDate = @ExpiryDate,
                                    Notes = @Notes,
                                    PaidFees = @PaidFees,
                                    IssueReason = @IssueReason,
                                    IsActive = @IsActive,
                                    CreatedByUserID = @CreatedByUserID
                                 WHERE LicenseID = @LicenseID;";
                using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@LicenseID", license.LicenseID);
                    cmd.Parameters.AddWithValue("@ApplicationID", license.ApplicationID);
                    cmd.Parameters.AddWithValue("@LicenseClassID", license.LicenseClassID);
                    cmd.Parameters.AddWithValue("@DriverID", license.DriverID);
                    cmd.Parameters.AddWithValue("@IssueDate", license.IssueDate);
                    cmd.Parameters.AddWithValue("@ExpiryDate", license.ExpiryDate);
                    cmd.Parameters.AddWithValue("@Notes", (object)license.Notes ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@PaidFees", license.PaidFees);
                    cmd.Parameters.AddWithValue("@IssueReason", license.IssueReason);
                    cmd.Parameters.AddWithValue("@IsActive", license.IsActive);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", license.CreatedByUserID);
                    conn.Open();
                    isUpdated = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while updating the license.", ex);
            }
            return isUpdated;
        }

        public static bool DeleteLicense(int licenseID)
        {
            bool isDeleted = false;
            try
            {
                string query = "DELETE FROM Licenses WHERE LicenseID = @LicenseID;";
                using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@LicenseID", licenseID);
                    conn.Open();
                    isDeleted = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while deleting the license.", ex);
            }
            return isDeleted;
        }

        public static List<LicensesDTO> GetAllLicenses()
        {
            List<LicensesDTO> licenses = new List<LicensesDTO>();
            try
            {
                string query = "SELECT * FROM Licenses;";
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.CommandType = CommandType.Text;
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            licenses.Add(new LicensesDTO
                            {
                                LicenseID = reader.GetInt32(reader.GetOrdinal("LicenseID")),
                                ApplicationID = reader.GetInt32(reader.GetOrdinal("ApplicationID")),
                                LicenseClassID = reader.GetInt32(reader.GetOrdinal("LicenseClassID")),
                                DriverID = reader.GetInt32(reader.GetOrdinal("DriverID")),
                                IssueDate = reader.GetDateTime(reader.GetOrdinal("IssueDate")),
                                ExpiryDate = reader.GetDateTime(reader.GetOrdinal("ExpiryDate")),
                                Notes = reader.IsDBNull(reader.GetOrdinal("Notes")) ? null : reader.GetString(reader.GetOrdinal("Notes")),
                                PaidFees = reader.GetDecimal(reader.GetOrdinal("PaidFees")),
                                IssueReason = reader.GetByte(reader.GetOrdinal("IssueReason")),
                                IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                CreatedByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"))
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving all licenses.", ex);
            }
            return licenses;
        }
    }
}
