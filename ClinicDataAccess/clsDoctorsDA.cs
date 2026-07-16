using ClinicDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicDataAccess
{
    public class clsDoctorsDA
    {
        public static int AddNewDoctor(string firstName, string lastName, DateTime dateOfBirth, string phone, string email, string address, string gender, string photoURL, int specializationID)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_AddNewDoctor", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Handle FirstName (required)
                if (string.IsNullOrEmpty(firstName))
                {
                    throw new ArgumentException("First name is required", nameof(firstName));
                }
                command.Parameters.AddWithValue("@FirstName", firstName);

                // Handle LastName (required)
                if (string.IsNullOrEmpty(lastName))
                {
                    throw new ArgumentException("Last name is required", nameof(lastName));
                }
                command.Parameters.AddWithValue("@LastName", lastName);

                // Handle DateOfBirth (required)
                command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);

                // Handle Phone (required)
                if (string.IsNullOrEmpty(phone))
                {
                    throw new ArgumentException("Phone is required", nameof(phone));
                }
                command.Parameters.AddWithValue("@Phone", phone);

                // Handle Email (nullable)
                if (string.IsNullOrEmpty(email))
                {
                    command.Parameters.AddWithValue("@Email", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@Email", email);
                }

                // Handle Address (nullable)
                if (string.IsNullOrEmpty(address))
                {
                    command.Parameters.AddWithValue("@Address", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@Address", address);
                }

                // Handle Gender (nullable)
                if (string.IsNullOrEmpty(gender))
                {
                    command.Parameters.AddWithValue("@Gender", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@Gender", gender);
                }

                // Handle PhotoURL (nullable)
                if (string.IsNullOrEmpty(photoURL))
                {
                    command.Parameters.AddWithValue("@PhotoURL", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@PhotoURL", photoURL);
                }

                // Handle SpecializationID (required)
                command.Parameters.AddWithValue("@SpecializationID", specializationID);

                // Output parameter for the new Doctor ID
                var outputIdParam = new SqlParameter("@NewDoctorID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputIdParam);

                try
                {
                    // Execute the stored procedure
                    connection.Open();
                    command.ExecuteNonQuery();

                    // Return the newly generated Doctor ID
                    return (int)outputIdParam.Value;
                }
                catch (Exception ex)
                {
                    // Handle exception (log it, etc.)
                    return -1; // Return -1 to indicate failure
                }
            }
        }
        public static bool UpdateDoctor(int doctorID, string firstName, string lastName, DateTime dateOfBirth, string phone, string email, string address, string gender, string photoURL, int specializationID)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_UpdateDoctor", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add Doctor ID parameter
                command.Parameters.AddWithValue("@DoctorID", doctorID);

                // Add FirstName parameter
                command.Parameters.AddWithValue("@FirstName", firstName);

                // Add LastName parameter
                command.Parameters.AddWithValue("@LastName", lastName);

                // Add DateOfBirth parameter
                command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);

                // Add Phone parameter
                command.Parameters.AddWithValue("@Phone", phone);

                // Handle Email (nullable)
                if (string.IsNullOrEmpty(email))
                {
                    command.Parameters.AddWithValue("@Email", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@Email", email);
                }

                // Handle Address (nullable)
                if (string.IsNullOrEmpty(address))
                {
                    command.Parameters.AddWithValue("@Address", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@Address", address);
                }

                // Handle Gender (nullable)
                if (string.IsNullOrEmpty(gender))
                {
                    command.Parameters.AddWithValue("@Gender", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@Gender", gender);
                }

                // Handle PhotoURL (nullable)
                if (string.IsNullOrEmpty(photoURL))
                {
                    command.Parameters.AddWithValue("@PhotoURL", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@PhotoURL", photoURL);
                }

                // Add SpecializationID parameter
                command.Parameters.AddWithValue("@SpecializationID", specializationID);

                try
                {
                    connection.Open();
                  return  command.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    // Handle exception (log it, etc.)
                    return false;
                }
            }
        }

        public static DoctorDTO FindDoctorByID(int DoctorID)
        {
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_FindDoctorByID", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DoctorID", DoctorID);

                    try
                    {
                        conx.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Handle nullable fields
                                var EmailOrdinal = reader.GetOrdinal("Email");
                                string Email = reader.IsDBNull(EmailOrdinal) ? "" : reader.GetString(EmailOrdinal);

                                var AddressOrdinal = reader.GetOrdinal("Address");
                                string Address = reader.IsDBNull(AddressOrdinal) ? "" : reader.GetString(AddressOrdinal);

                                var GenderOrdinal = reader.GetOrdinal("Gender");
                                string Gender = reader.IsDBNull(GenderOrdinal) ? "" : reader.GetString(GenderOrdinal);

                                var PhotoURLOrdinal = reader.GetOrdinal("PhotoURL");
                                string PhotoURL = reader.IsDBNull(PhotoURLOrdinal) ? "" : reader.GetString(PhotoURLOrdinal);

                                return new DoctorDTO(
                                    reader.GetInt32(reader.GetOrdinal("DoctorID")),
                                    reader.GetString(reader.GetOrdinal("FirstName")),
                                    reader.GetString(reader.GetOrdinal("LastName")),
                                    reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                                    reader.GetString(reader.GetOrdinal("Phone")),
                                    Email,
                                    Address,
                                    Gender,
                                    PhotoURL,
                                    reader.GetInt32(reader.GetOrdinal("SpecializationID"))
                                );
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle exception (log it, etc.)
                        return null;
                    }
                }
            }
            return null;
        }


    }
}
