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

        

        [HttpGet("[action]")]
        public ActionResult<List<Customer>> GetAllCustomers()
        {
            return Ok(_customerService.GetAllCustomers());

        }

        [HttpPost("[action]")]
        public ActionResult<Customer> CreateCustomer([FromBody] Customer customer)
        {
            _customerService.CreateCustomer(customer);

            return Ok();
        }
    }
}
