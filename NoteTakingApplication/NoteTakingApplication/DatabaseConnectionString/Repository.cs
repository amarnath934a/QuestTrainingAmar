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
    public class NoteRepository
    {
        public void Create(Note note)
        {
            try
            {
                using (var connection = new SqlConnection(DatabaseConnectionString.ConnectionString))
                {
                    connection.Open();
                    var command = new SqlCommand("INSERT INTO Notes (Title, Content, CreatedAt) VALUES (@Title, @Content, @CreatedAt)", connection);
                    command.Parameters.AddWithValue("@Title", note.Title);
                    command.Parameters.AddWithValue("@Content", note.Content);
                    command.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                    command.ExecuteNonQuery();
                    Logger.Log("Note created successfully.");
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                Console.WriteLine("Error creating note.");
            }
        }

        public List<Note> GetAll()
        {
            var notes = new List<Note>();
            try
            {
                using (var connection = new SqlConnection(DatabaseConnectionString.ConnectionString))
                {
                    connection.Open();
                    var command = new SqlCommand("SELECT Id, Title, Content,CreatedAt,UpdatedAt FROM Notes", connection);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            notes.Add(new Note
                            {
                                Id = (int)reader["Id"],
                                Title = (string)reader["Title"],
                                Content = (string)reader["Content"],
                                CreatedAt = (DateTime)reader["CreatedAt"],
                                UpdatedAt = reader["UpdatedAt"] as DateTime?
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                Console.WriteLine("Error retrieving notes.");
            }
            return notes;
        }

        public void Update(Note note)
        {
            try
            {
                using (var connection = new SqlConnection(DatabaseConnectionString.ConnectionString))
                {
                    connection.Open();
                    var command = new SqlCommand("UPDATE Notes SET Title = @Title, Content = @Content, UpdatedAt = @UpdatedAt WHERE Id = @Id", connection);
                    command.Parameters.AddWithValue("@Id", note.Id);
                    command.Parameters.AddWithValue("@Title", note.Title);
                    command.Parameters.AddWithValue("@Content", note.Content);
                    command.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);
                    command.ExecuteNonQuery();
                    Logger.Log("Note updated successfully.");
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                Console.WriteLine("Error updating note.");
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (var connection = new SqlConnection(DatabaseConnectionString.ConnectionString))
                {
                    connection.Open();
                    var command = new SqlCommand("DELETE FROM Notes WHERE Id = @Id", connection);
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                    Logger.Log("Note deleted successfully.");
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                Console.WriteLine("Error deleting note.");
            }
        }
    }
}
