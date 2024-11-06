using NoteTakingConsoleApplication.Database;
using NoteTakingConsoleApplication.Logging;
using NoteTakingConsoleApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTakingConsoleApplication.Database
{
    public class DatabaseInitializer
    {
        public void Initialize()
        {
            try
            {
                using (var connection = new SqlConnection(DatabaseConnectionString.ConnectionString))
                {
                    connection.Open();
                    string createTableQuery = @"
                        IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Notes')
                        CREATE TABLE Notes (
                            Id INT PRIMARY KEY IDENTITY(1,1),
                            Title NVARCHAR(100) NOT NULL,
                            Content NVARCHAR(MAX) NOT NULL,
                            CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
                            UpdatedAt DATETIME
                        )";

                    using (var command = new SqlCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                        Logger.Log("Table creation successfull.");
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                Console.WriteLine("Error occured.");
            }
        }
    }
}

