using Library_API.Entity;
using Library_API.Models;
using Library_API.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Library_API.Controllers
{
    [Route("api/customer/")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [Route("{guid}")]
        public ActionResult<Customer> GetCustomer([FromRoute] string guid)
        {
            var customer = _customerService.GetCustomer(guid);

            return Ok(customer);
        }

        [HttpGet]
        public ActionResult<List<Customer>> GetAllCustomers()
        {
            return Ok(_customerService.GetAllCustomers());

        }

        [HttpPost]
        public ActionResult<Customer> CreateCustomer([FromBody] CreateCustomerDto customer)
        {
            var customerId = _customerService.CreateCustomer(customer);

            return Created($"api/customer/{customerId}", null);
        }

        [HttpDelete]        
        public ActionResult<Customer> DeleteCustomer([FromRoute] string guid)
        {
            var customer = _customerService.DeleteCustomer(guid);

            return NoContent();
        }

        [HttpPatch]
        public ActionResult<Customer> PatchCustomer([FromBody] Customer customerToPatch)
        {
            var customer = _customerService.PatchCustomer(customerToPatch);

            return Created($"api/customer/{customerToPatch.Id}", customerToPatch);
        }
    }
}
