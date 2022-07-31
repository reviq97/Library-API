using Library_API.Entity;

namespace Library_API.Service.Interfaces;

public interface IBooksService
{
    public IEnumerable<Book> GetAllBooks();
}