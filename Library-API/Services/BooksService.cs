using Library_API.Database;
using Library_API.Entity;
using Library_API.Services.Interfaces;

namespace Library_API.Services;

public class BooksService : IBookService
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