using Library_API.Models;
using Library_API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Library_API.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountControler : ControllerBase
    {
        private readonly IAccountServices _accountServices;

        public AccountControler(IAccountServices accountServices)
        {
            _accountServices = accountServices;
        }

        [HttpPost("register")]
        public ActionResult RegisterUser([FromBody] RegisterUserDto dto)
        {
               _accountServices.RegisterUser(dto);

                //logic to finish
        }
    }
}
