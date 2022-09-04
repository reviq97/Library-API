using Library_API.Entity;
using Library_API.Models;
using Library_API.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library_API.Controllers
{
    [Route("/api/book")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly IBookService _booksService;

        public BookController(IBookService booksService)
        {
            _booksService = booksService;
        }
        
        [HttpGet]
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

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Book> GetBook([FromRoute] string id)
        {
            var book = _booksService.GetBook(id);

            return Ok(book);
        }

        [HttpPost]
        public ActionResult<string> AddNewBook([FromBody] AddBookDto book)
        {
            var bookId = _booksService.AddNewBook(book);


            return Created($"api/book/{bookId}", null);
        }

        [HttpDelete]
        public ActionResult DeleteBook([FromRoute] string guid)
        {
            var book = _booksService.RemoveBook(guid);

            return NoContent();
        }

        [HttpPatch]
        public ActionResult<Book> PatchBook([FromBody] Book bookToPatch)
        {
            var book = _booksService.PatchBook(bookToPatch);

            return Created($"api/book/{book.Id}", book);
        }


    }
    
}
