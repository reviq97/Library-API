using Library_API.Entity;
using Library_API.Models;

namespace Library_API.Services.Interfaces;

public interface IBookService
{
    public IEnumerable<Book> GetAllBooks();
    string AddNewBook(AddBookDto book);
    Book GetBook(string guid);
    bool RemoveBook(string guid);
    Book PatchBook(Book book);
}