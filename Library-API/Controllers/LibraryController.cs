using Library_API.Entity;
using Library_API.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LibraryController : Controller
    {
        private readonly IBooksService _booksService;

        public LibraryController(IBooksService booksService)
        {
            _booksService = booksService;
        }
        
        [HttpGet]
        [Route("[action]")]
        public ActionResult<IEnumerable<Book>> GetAllBooks()
        {
            var booksList = _booksService.GetAllBooks();

            if (!booksList.Any())
            {
                return NotFound();
            }

            return Ok(booksList.ToList());
        }


    }
}
