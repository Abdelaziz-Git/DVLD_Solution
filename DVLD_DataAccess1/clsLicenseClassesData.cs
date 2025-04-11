using DVLD_Models1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess1
{
    public class clsLicenseClassesData
    {
        public static LicenseClassesDTO GetById(int id)
        {
            LicenseClassesDTO licenseClass = null;
            string query = @"SELECT * FROM LicenseClasses WHERE LicenseClassID = @Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@Id", id);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                licenseClass = new LicenseClassesDTO
                                {
                                    LicenseClassID = reader.GetInt32(reader.GetOrdinal("LicenseClassID")),
                                    ClassName = reader.GetString(reader.GetOrdinal("ClassName")),
                                    ClassDescription = reader.GetString(reader.GetOrdinal("ClassDescription")),
                                    MinimumAllowedAge = reader.GetByte(reader.GetOrdinal("MinimumAllowedAge")),
                                    ValidityLength = reader.GetByte(reader.GetOrdinal("ValidityLength")),
                                    ClassFees = reader.GetDecimal(reader.GetOrdinal("ClassFees"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving License Class by ID.", ex);
            }

            return licenseClass;
        }

        public static List<LicenseClassesDTO> GetAll()
        {
            List<LicenseClassesDTO> licenseClasses = new List<LicenseClassesDTO>();
            string query = @"SELECT * FROM LicenseClasses";

            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                LicenseClassesDTO licenseClass = new LicenseClassesDTO
                                {
                                    LicenseClassID = reader.GetInt32(reader.GetOrdinal("LicenseClassID")),
                                    ClassName = reader.GetString(reader.GetOrdinal("ClassName")),
                                    ClassDescription = reader.GetString(reader.GetOrdinal("ClassDescription")),
                                    MinimumAllowedAge = reader.GetByte(reader.GetOrdinal("MinimumAllowedAge")),
                                    ValidityLength = reader.GetByte(reader.GetOrdinal("ValidityLength")),
                                    ClassFees = reader.GetDecimal(reader.GetOrdinal("ClassFees"))
                                };
                                licenseClasses.Add(licenseClass);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving all License Classes.", ex);
            }

            return licenseClasses;
        }

        public static bool Update(LicenseClassesDTO licenseClass)
        {
            if (licenseClass == null)
                return false;

            bool isUpdated = false;
            string query = @"UPDATE LicenseClasses 
                             SET ClassName = @ClassName,
                                 ClassDescription = @ClassDescription,
                                 MinimumAllowedAge = @MinimumAllowedAge,
                                 ValidityLength = @ValidityLength,
                                 ClassFees = @ClassFees
                             WHERE LicenseClassID = @LicenseClassID";

            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@LicenseClassID", licenseClass.LicenseClassID);
                        cmd.Parameters.AddWithValue("@ClassName", licenseClass.ClassName);
                        cmd.Parameters.AddWithValue("@ClassDescription", licenseClass.ClassDescription);
                        cmd.Parameters.AddWithValue("@MinimumAllowedAge", licenseClass.MinimumAllowedAge);
                        cmd.Parameters.AddWithValue("@ValidityLength", licenseClass.ValidityLength);
                        cmd.Parameters.AddWithValue("@ClassFees", licenseClass.ClassFees);

                        conn.Open();
                        isUpdated = cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while updating License Class.", ex);
            }

            return isUpdated;
        }
    }
}

