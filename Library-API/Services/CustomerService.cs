using Library_API.Database;
using Library_API.Entity;
using Library_API.Service.Interfaces;

namespace Library_API.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ApplicationDbContext _dbContext;

        public CustomerService(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
           
            return _dbContext.Customers.ToList();
        }
    }
}
