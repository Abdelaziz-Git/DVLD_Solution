using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Models1;

namespace DVLD_DataAccess1
{
    public class clsCountryData
    {
        public static CountryDTO GetCountryInfo(int CountryID)
        {
            CountryDTO Country = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("GetCountryInfoByID", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CountryID", CountryID);

                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Country = new CountryDTO
                                {
                                    Id = (int)reader.GetInt16(reader.GetOrdinal("CountryID")),
                                    Name = reader.GetString(reader.GetOrdinal("CountryName"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
                throw new ApplicationException("An error occurred while retrieving Country information.", ex);
            }

            return Country;
        }
        public static CountryDTO GetCountryInfo(string CountryName)
        {
            CountryDTO Country = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("GetCountryInfoByName", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CountryName", CountryName);

                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Country = new CountryDTO
                                {
                                    Id = (int)reader.GetInt16(reader.GetOrdinal("CountryID")),
                                    Name = reader.GetString(reader.GetOrdinal("CountryName"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
                throw new ApplicationException("An error occurred while retrieving Country information.", ex);
            }

            return Country;
        }
        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("GetAllCountries", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader != null)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
                throw new ApplicationException("An error occurred while retrieving all Countries.", ex);
            }
            return dt;
        }
        public static bool IsCountryExistByName(string CountryName)
        {
            bool result = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("IsCountryExistByName", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CountryName", CountryName);
                        connection.Open();
                        result = (bool)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
               
                throw new ApplicationException("An error occurred while checking if Country exists by name.", ex);
            }
            return result;


        }
    }
}
