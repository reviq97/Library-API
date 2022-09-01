using System.Net;
using Library_API.Database;
using Library_API.Entity;
using Library_API.Models;
using Library_API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Library_API.Services;

public class BookService : IBookService
{
    private readonly ApplicationDbContext _dbContext;

    public BookService(ApplicationDbContext dbContext)
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

    public int AddNewBook(AddBookDto bookDto)
    {
        var findBook = _dbContext.Book.FirstOrDefault(x => x.Author == bookDto.Author && x.Title == bookDto.Author);

        if (findBook is not null)
        {
            throw new Exception("Book already exist");
        }

        var book = new Book();

        return 1;
    }
}