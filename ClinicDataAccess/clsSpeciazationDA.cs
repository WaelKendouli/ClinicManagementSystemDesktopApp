using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicDataAccess
{
    public class clsSpeciazationDA
    {
        public static Dictionary<string, int> GetSpecialazations()
        {
            Dictionary<string, int> DicSpecializations = new Dictionary<string, int>();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("SP_GetSpecialazations", conx))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                conx.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string specializationName = reader.GetString(reader.GetOrdinal("Specialization"));
                        int specializationID = reader.GetInt32(reader.GetOrdinal("SpecialazationID"));

                        if (!DicSpecializations.ContainsKey(specializationName))
                        {
                            DicSpecializations.Add(specializationName, specializationID);
                        }
                    }
                }
            }
            return DicSpecializations;
        }
    }
}
