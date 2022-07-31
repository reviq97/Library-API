using Library_API.Database;
using Library_API.Entity;
using Library_API.Service.Interfaces;

namespace Library_API.Service;

public class LibraryService : ILibraryService
{
    private readonly ApplicationDbContext _dbContext;

    public LibraryService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public IEnumerable<Book> GetAllBooks()
    {
        return _dbContext.
    }
}