using Library.Data;
using Library.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositiories
{
    internal class BookRepositiories
    {
        public GenericResponse<List<Book>> GetAllBooks()
        {
            var books = DataStorage.Books;
            return new GenericResponse<List<Book>>
            {
                Success = true,
                Data = books,
            };
        }

        public GenericResponse<Book> GetBookById(int id)
        {
            var book = DataStorage.Books.FirstOrDefault(x => x.Id == id);
            if (book == null)
            {
                return new GenericResponse<Book>
                {
                    Success = false,
                    Message = "Book not found",
                };
            }

            return new GenericResponse<Book>
            {
                Success = true,
                Data = book,
            };
        }

        public GenericResponse<List<Book>> SearchBooksByName(string name)
        {
            var books = DataStorage.Books
                .Where(b => b.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            return new GenericResponse<List<Book>>
            {
                Success = true,
                Data = books
            };
        }

    }
}
