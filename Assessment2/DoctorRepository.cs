using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class DoctorRepository
    {
        private readonly string _connectionString;

        public DoctorRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Doctor doctor)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var command = new SqlCommand("INSERT INTO Doctors (Name, Specialization, Gender, PatientId) OUTPUT INSERTED.Id VALUES (@Name, @Specialization, @Gender, @PatientId)", conn);
                command.Parameters.AddWithValue("@Name", doctor.Name);
                command.Parameters.AddWithValue("@Specialization", doctor.Specialization);
                command.Parameters.AddWithValue("@Gender", doctor.Gender);
                command.Parameters.AddWithValue("@PatientId", doctor.PatientId);
                doctor.Id = (int)command.ExecuteScalar();
            }
        }

        public Doctor[] GetAll()
        {
            List<Doctor> doctors = new List<Doctor>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var command = new SqlCommand("SELECT Id, Name, Specialization, Gender, PatientId FROM Doctors", conn);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var doctor = new Doctor(
                            reader["Name"].ToString(),
                            reader["Gender"].ToString(),
                            reader["Specialization"].ToString(),
                            (int)reader["PatientId"])
                        {
                            Id = (int)reader["Id"]
                        };
                        doctors.Add(doctor);
                    }
                }
            }

            return doctors.ToArray();
        }

        public Doctor GetById(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var command = new SqlCommand("SELECT Id, Name, Specialization, Gender, PatientId FROM Doctors WHERE Id = @Id", conn);
                command.Parameters.AddWithValue("@Id", id);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Doctor(
                            reader["Name"].ToString(),
                            reader["Gender"].ToString(),
                            reader["Specialization"].ToString(),
                            (int)reader["PatientId"])
                        {
                            Id = (int)reader["Id"]
                        };
                    }
                }
            }
            return null;
        }

        public void Update(Doctor doctor)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var command = new SqlCommand("UPDATE Doctors SET Name = @Name, Specialization = @Specialization, Gender = @Gender, PatientId = @PatientId WHERE Id = @Id", conn);
                command.Parameters.AddWithValue("@Name", doctor.Name);
                command.Parameters.AddWithValue("@Specialization", doctor.Specialization);
                command.Parameters.AddWithValue("@Gender", doctor.Gender);
                command.Parameters.AddWithValue("@PatientId", doctor.PatientId);
                command.Parameters.AddWithValue("@Id", doctor.Id);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var command = new SqlCommand("DELETE FROM Doctors WHERE Id = @Id", conn);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteDocName(string name)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var command = new SqlCommand("delete from doctors where Name = @name",conn);
                command.Parameters.AddWithValue("@Name", name);
                command.ExecuteNonQuery();
            }
        }
    }
}
