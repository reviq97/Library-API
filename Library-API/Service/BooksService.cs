using Library_API.Database;
using Library_API.Entity;
using Library_API.Service.Interfaces;

namespace Library_API.Service;

public class BooksService : IBooksService
{
    private readonly ApplicationDbContext _dbContext;

    public BooksService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public IEnumerable<Book> GetAllBooks()
    {
        if (_dbContext.Book.Any())
        {
            return _dbContext.Book.ToList();
        }
        return Enumerable.Empty<Book>();
    }
}