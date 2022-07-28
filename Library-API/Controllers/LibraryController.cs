using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LibraryController : Controller
    {
        [HttpGet]
        [Route("[action]")]
        public ActionResult GetAllBooks()
        {
            return Ok();
        }


    }
}
