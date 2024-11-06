using NoteTakingConsoleApplication.Database;
using NoteTakingConsoleApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTakingConsoleApplication.Services
{
    public class NoteService
    {
        private readonly NoteRepository _noteRepository;

        public NoteService(NoteRepository noteRepository)
        {
            _noteRepository = noteRepository;

        }

        public void CreateNote()
        {
            Console.Write("Enter title:");
            string title = Console.ReadLine();
            Console.Write("Enter content:");
            string content = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(content))
            {
                Console.WriteLine("Title and content cannot be empty.");
                return;
            }

            var note = new Note { Title = title, Content = content, CreatedAt = DateTime.Now };
            _noteRepository.Create(note);
        }

        public void ViewAllNotes()
        {
            var notes = _noteRepository.GetAll();
            if (notes.Count == 0)
            {
                Console.WriteLine("Notes not available.");
                return;
            }

            foreach (var note in notes)
            {
                Console.WriteLine($"ID: {note.Id}, Title: {note.Title}, Created At: {note.CreatedAt}, Content: {note.Content.Substring(0, Math.Min(note.Content.Length, 30))}...");
            }

        }

        public void UpdateNote()
        {
            Console.Write("Enter Id to update: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var notes = _noteRepository.GetAll();
                var note = notes.Find(n => n.Id == id);

                if (note != null)
                {
                    Console.WriteLine($"Current title: {note.Title}");
                    Console.WriteLine($"Current content: {note.Content}");
                    Console.Write("Enter new title: ");
                    string newTitle = Console.ReadLine();
                    Console.Write("Enter new content: ");
                    string newContent = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(newTitle)) note.Title = newTitle;
                    if (!string.IsNullOrWhiteSpace(newContent)) note.Content = newContent;

                    _noteRepository.Update(note);
                }
                else
                {
                    Console.WriteLine("Notes not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID.");
            }
        }

        public void DeleteNote()
        {
            Console.Write("Enter Id to delete: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                _noteRepository.Delete(id);
            }
            else
            {
                Console.WriteLine("Invalid Id.");
            }
        }
    }
}
