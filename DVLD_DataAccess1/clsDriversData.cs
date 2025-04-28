using DVLD_Models1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess1
{
    public class clsDriversData
    {
        public static DriversDTO GetDriverByID(int driverID)
        {
            DriversDTO driver = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    string query = "SELECT * FROM Drivers WHERE DriverID = @DriverID;";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@DriverID", driverID);

                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                driver = new DriversDTO
                                {
                                    DriverID = reader.GetInt32(reader.GetOrdinal("DriverID")),
                                    PersonID = reader.GetInt32(reader.GetOrdinal("PersonID")),
                                    CreatedByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID")),
                                    CreatedDate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error retrieving driver information", ex);
            }

            return driver;
        }

        public static DriversDTO GetDriverByPersonID(int personID)
        {
            DriversDTO driver = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    string query = "SELECT * FROM Drivers WHERE PersonID = @PersonID;";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@PersonID", personID);

                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                driver = new DriversDTO
                                {
                                    DriverID = reader.GetInt32(reader.GetOrdinal("DriverID")),
                                    PersonID = reader.GetInt32(reader.GetOrdinal("PersonID")),
                                    CreatedByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID")),
                                    CreatedDate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error retrieving driver by person ID", ex);
            }

            return driver;
        }

        public static int AddNewDriver(DriversDTO driver)
        {
            int newID = -1;

            try
            {
                string query = @"INSERT INTO Drivers (
                                    PersonID,
                                    CreatedByUserID,
                                    CreatedDate
                                 ) VALUES (
                                    @PersonID,
                                    @CreatedByUserID,
                                    @CreatedDate
                                 );
                                 SELECT SCOPE_IDENTITY();";

                using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PersonID", driver.PersonID);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", driver.CreatedByUserID);
                    cmd.Parameters.AddWithValue("@CreatedDate", driver.CreatedDate);

                    conn.Open();
                    newID = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error adding new driver", ex);
            }

            return newID;
        }

        public static bool UpdateDriver(DriversDTO driver)
        {
            bool success = false;

            try
            {
                string query = @"UPDATE Drivers SET
                                    PersonID = @PersonID,
                                    CreatedByUserID = @CreatedByUserID,
                                    CreatedDate = @CreatedDate
                                  WHERE DriverID = @DriverID;";

                using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DriverID", driver.DriverID);
                    cmd.Parameters.AddWithValue("@PersonID", driver.PersonID);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", driver.CreatedByUserID);
                    cmd.Parameters.AddWithValue("@CreatedDate", driver.CreatedDate);

                    conn.Open();
                    success = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error updating driver", ex);
            }

            return success;
        }

        public static bool DeleteDriver(int driverID)
        {
            bool isDeleted = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    string query = "DELETE FROM Drivers WHERE DriverID = @DriverID;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@DriverID", driverID);

                        conn.Open();
                        isDeleted = cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error deleting driver", ex);
            }

            return isDeleted;
        }

        public static List<DriversDTO> GetAllDrivers()
        {
            List<DriversDTO> driversList = new List<DriversDTO>();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    string query = "SELECT * FROM Drivers;";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DriversDTO driver = new DriversDTO
                                {
                                    DriverID = reader.GetInt32(reader.GetOrdinal("DriverID")),
                                    PersonID = reader.GetInt32(reader.GetOrdinal("PersonID")),
                                    CreatedByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID")),
                                    CreatedDate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"))
                                };

                                driversList.Add(driver);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error retrieving all drivers", ex);
            }

            return driversList;
        }
        public static byte GetActiveLicensesCount(int driverID)
        {
            byte count = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    string query = "SELECT COUNT(*) FROM Licenses WHERE DriverID = @DriverID AND IsActive = 1;";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@DriverID", driverID);
                        connection.Open();
                        count = Convert.ToByte(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error retrieving active license count", ex);
            }
            return count;
        }

    }
}