using Library_API.Database;
using Library_API.Entity;
using Library_API.Models;
using Library_API.Service.Interfaces;

namespace Library_API.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ApplicationDbContext _dbContext;

        public CustomerService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateCustomer(CustomerAndAddressDto dto)
        {
            if(dto is not null)
            {
                var customer = new Customer()
                {
                    Id = dto.Customer.Id,
                    Name = dto.Customer.Name,
                    Surname = dto.Customer.Surname,
                    Birth = dto.Customer.Birth,
                    Gender = dto.Customer.Gender,
                    PhoneNumber = dto.Customer.PhoneNumber,
                };

                var address = new Address()
                {
                };
            }
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
           
            return _dbContext.Customers.ToList();
        }
    }
}
