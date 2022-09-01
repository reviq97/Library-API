using Library_API.Entity;
using Library_API.Models;
using Library_API.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : Controller
    {
        private readonly IBookService _booksService;

        public BookController(IBookService booksService)
        {
            _booksService = booksService;
        }
        
        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<Book>> GetAllBooks()
        {
            var booksList = _booksService.GetAllBooks();

            var enumerable = booksList.ToList();
            if (!enumerable.Any())
            {
                return NotFound();
            }

            return Ok(enumerable.ToList());
        }

        [HttpPost]
        [Route("[action]")]
        public ActionResult<int> AddNewBook([FromBody] AddBookDto book)
        {
            _booksService.AddNewBook(book);

            return 1;
        }


    }
    
}
