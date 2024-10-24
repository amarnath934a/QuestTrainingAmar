using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public static class DatabaseInitializer
    {
        private static readonly string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Amar\\OneDrive\\Documents\\hospital.mdf;Integrated Security=True;";

        public static string GetConnectionString()
        {
            return _connectionString;
        }

        public static void InitializeDatabase(string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var command = new SqlCommand(@"
                IF NOT EXISTS (SELECT name FROM sys.tables WHERE name = 'Patients')
                CREATE TABLE Patients (
                    Id INT IDENTITY(1,1) PRIMARY KEY,
                    Name NVARCHAR(100),
                    Gender NVARCHAR(10),
                    Age INT,
                    MedicalCondition NVARCHAR(200)
                );

                IF NOT EXISTS (SELECT name FROM sys.tables WHERE name = 'Doctors')
                CREATE TABLE Doctors (
                    Id INT IDENTITY(1,1) PRIMARY KEY,
                    Name NVARCHAR(100),
                    Specialization NVARCHAR(100),
                    Gender NVARCHAR(10),
                    PatientId INT NULL,
                    FOREIGN KEY (PatientId) REFERENCES Patients(Id)
                );", conn);

                command.ExecuteNonQuery();
            }
        }
    }
}
