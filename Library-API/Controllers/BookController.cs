﻿using Library_API.Entity;
using Library_API.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : Controller
    {
        private readonly IBooksService _booksService;

        public BookController(IBooksService booksService)
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