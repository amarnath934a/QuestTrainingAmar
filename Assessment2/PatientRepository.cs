using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class PatientRepository
    {
        private readonly string _connectionString;

        public PatientRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Patient patient)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var command = new SqlCommand("INSERT INTO Patients (Name, Gender, Age, MedicalCondition) OUTPUT INSERTED.Id VALUES (@Name, @Gender, @Age, @MedicalCondition)", conn);
                command.Parameters.AddWithValue("@Name", patient.Name);
                command.Parameters.AddWithValue("@Gender", patient.Gender);
                command.Parameters.AddWithValue("@Age", patient.Age);
                command.Parameters.AddWithValue("@MedicalCondition", patient.MedicalCondition);
                patient.Id = (int)command.ExecuteScalar();
            }
        }

        public Patient[] GetAll()
        {
            List<Patient> patients = new List<Patient>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var command = new SqlCommand("SELECT Id, Name, Gender, Age, MedicalCondition FROM Patients", conn);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var patient = new Patient(
                            reader["Name"].ToString(),
                            reader["Gender"].ToString(),
                            (int)reader["Age"],
                            reader["MedicalCondition"].ToString())
                        {
                            Id = (int)reader["Id"]
                        };
                        patients.Add(patient);
                    }
                }
            }

            return patients.ToArray();
        }

        public Patient GetById(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var command = new SqlCommand("SELECT Id, Name, Gender, Age, MedicalCondition FROM Patients WHERE Id = @Id", conn);
                command.Parameters.AddWithValue("@Id", id);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Patient(
                            reader["Name"].ToString(),
                            reader["Gender"].ToString(),
                            (int)reader["Age"],
                            reader["MedicalCondition"].ToString())
                        {
                            Id = (int)reader["Id"]
                        };
                    }
                }
            }
            return null;
        }

        public void Update(Patient patient)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var command = new SqlCommand("UPDATE Patients SET Name = @Name, Gender = @Gender, Age = @Age, MedicalCondition = @MedicalCondition WHERE Id = @Id", conn);
                command.Parameters.AddWithValue("@Name", patient.Name);
                command.Parameters.AddWithValue("@Gender", patient.Gender);
                command.Parameters.AddWithValue("@Age", patient.Age);
                command.Parameters.AddWithValue("@MedicalCondition", patient.MedicalCondition);
                command.Parameters.AddWithValue("@Id", patient.Id);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var command = new SqlCommand("DELETE FROM Patients WHERE Id = @Id", conn);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteName(string name)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var command = new SqlCommand("DELETE FROM Patients WHERE Name =@Name", conn);
                command.Parameters.AddWithValue("@Name", name);
                command.ExecuteNonQuery();
            }
        }
    }
}
