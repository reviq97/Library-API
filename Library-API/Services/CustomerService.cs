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

        public string CreateCustomer(CreateCustomerDto dto)
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

            return newCustomer.Id;
        }
        
        public Customer GetCustomer(string guid)
        {
            var customer = _dbContext.Customers.FirstOrDefault(x => x.Id == guid);

            if(customer is null)
            {
                throw new Exception("Customer not found");
            }

            return customer;
        }

        public List<Customer> GetAllCustomers()
        {
            return _dbContext.Customers.ToList();
        }

        public bool DeleteCustomer(string guid)
        {
            var customer =_dbContext.Customers.FirstOrDefault(x => x.Id == guid);

            if(customer is null)
            {
                throw new Exception("Customer not found");
            }

            _dbContext.Customers.Remove(customer);
            _dbContext.SaveChanges();

            return true;
        }

        // For clarity of code, i wont change code duplicate like _dbContext.Book.FirstOrDefault. For me it's much clearer
        public Customer PatchCustomer(Customer customerToPatch)
        {
            var customer = _dbContext.Customers.FirstOrDefault(x => x.Id == customerToPatch.Id);

            if (customer is null)
            {
                throw new Exception("Book not found");
            }

            _dbContext.Customers.Update(customer);
            _dbContext.SaveChanges();

            return customer;
        }
    }
}
