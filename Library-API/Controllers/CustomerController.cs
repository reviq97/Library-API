using Library_API.Entity;
using Library_API.Models;
using Library_API.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Library_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult<IEnumerable<Customer>> GetAllCustomers()
        {
            return Ok(_customerService.GetAllCustomers());

        }

        public ActionResult<Customer> CreateCustomer([FromBody] CustomerAndAddressDto dto)
        {
            _customerService.CreateCustomer(dto);

            return Ok();
        }
    }
}
