using DVLD_Models1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess1
{
    public class clsApplicationTypeData
    {
        public static ApplicationTypeDTO GetById(int id)
        {
            ApplicationTypeDTO applicationType = null;
            string Query = @"SELECT * FROM ApplicationTypes where ApplicationTypeID = @Id";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@id", id);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                applicationType = new ApplicationTypeDTO();
                                applicationType.ID = reader.GetInt32(reader.GetOrdinal("ApplicationTypeID"));
                                applicationType.Title = reader.GetString(reader.GetOrdinal("ApplicationTypeTitle"));
                                applicationType.Fees = reader.GetDecimal(reader.GetOrdinal("ApplicationTypeFees"));
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving all Applications types.", ex);
            }
            return applicationType;
        }
        public static List<ApplicationTypeDTO> GetAll()
        {
            List<ApplicationTypeDTO> ApplicationsTypes = new List<ApplicationTypeDTO>();
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("ApplicationsTypes.GetAllApp", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        using(SqlDataReader reader=cmd.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                ApplicationTypeDTO applicationType = new ApplicationTypeDTO();
                                applicationType.ID = (int)reader["ApplicationTypeID"];
                                applicationType.Title = (string)reader["ApplicationTypeTitle"];
                                applicationType.Fees = (decimal)reader["ApplicationTypeFees"];
                                ApplicationsTypes.Add(applicationType);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving all Applications types.", ex);
            }
            return ApplicationsTypes;
        }
        public static bool Update(ApplicationTypeDTO applicationType)
        {
            if(applicationType == null)
                return false;

            bool IsUpdated = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataConfig.ConnectionString))
                using (SqlCommand cmd = new SqlCommand("ApplicationsTypes.UpdateApp", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ApplicationTypeID", applicationType.ID);
                    cmd.Parameters.AddWithValue("@ApplicationTypeTitle", applicationType.Title);
                    cmd.Parameters.AddWithValue("@ApplicationTypeFees", applicationType.Fees);
                    conn.Open();
                    IsUpdated = cmd.ExecuteNonQuery() > 0;
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while updating Application Type.", ex);
            }
            return IsUpdated;
        }
    }
}
