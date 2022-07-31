using Library_API.Entity;

namespace Library_API.Service.Interfaces;

public interface ILibraryService
{
    public IEnumerable<Book> GetAllBooks();
}