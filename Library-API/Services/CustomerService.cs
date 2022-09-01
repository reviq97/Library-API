using AutoMapper;
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

        public void CreateCustomer(Customer dto)
        {
            var customerGuid = Guid.NewGuid().ToString();
            var newCustomer = new Customer
            {
                Id = customerGuid,
                Name = dto.Name,
                Surname = dto.Surname,
                Gender = dto.Gender,
                Birth = Convert.ToDateTime(dto.Birth.ToString("dd/MM/yyyy")),
                City = dto.City,
                PhoneNumber = dto.PhoneNumber,
                PostalCode = dto.PostalCode,
                Region = dto.Region,
                Street = dto.Street
            };

            _dbContext.Customers.Add(newCustomer);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _dbContext.Customers.ToList();
        }
    }
}
