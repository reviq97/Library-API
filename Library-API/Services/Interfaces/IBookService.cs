using Library_API.Entity;
using Library_API.Models;

namespace Library_API.Services.Interfaces;

public interface IBookService
{
    public IEnumerable<Book> GetAllBooks();
    int AddNewBook(AddBookDto book);
}