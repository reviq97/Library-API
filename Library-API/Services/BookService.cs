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

    public string AddNewBook(AddBookDto bookDto)
    {
        var findBook = _dbContext.Book.FirstOrDefault(x => x.Author == bookDto.Author && x.Title == bookDto.Author);

        if (findBook is not null)
        {
            throw new Exception("Book already exist");
        }

        var book = new Book()
        {
            Id = Guid.NewGuid().ToString(),
            Author = bookDto.Author,
            Title = bookDto.Title,
            Written = bookDto.Written,
        };

        _dbContext.Book.Add(book);
        _dbContext.SaveChanges();

        return book.Id;
    }

    public Book GetBook(string guid)
    {
        var book = _dbContext.Book.FirstOrDefault(x => x.Id == guid);
        if (book is null)
        {
            throw new Exception("Book not found");
        }

        return book;
    }

    public bool RemoveBook(string guid)
    {
        var book = GetBook(guid);

        return true;
    }

    // For clarity of code, i wont change code duplicate like _dbContext.Book.FirstOrDefault. For me it's much clearer
    public Book PatchBook(Book bookToPatch)
    {
        var book = _dbContext.Book.FirstOrDefault(x => x.Id == bookToPatch.Id);

        if (book is null)
        {
            throw new Exception("Book not found");
        }

        _dbContext.Book.Update(book);
        _dbContext.SaveChanges();

        return book;
    }
}