using Library_API.Entity;

namespace Library_API.Services.Interfaces;

public interface IBookService
{
    public IEnumerable<Book> GetAllBooks();
}