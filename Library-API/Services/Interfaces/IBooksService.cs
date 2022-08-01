using Library_API.Entity;

namespace Library_API.Services.Interfaces;

public interface IBooksService
{
    public IEnumerable<Book> GetAllBooks();
}