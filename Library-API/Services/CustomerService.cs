using Library_API.Database;
using Library_API.Entity;
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

        public void CreateCustomer()
        {
            
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
           
            return _dbContext.Customers.ToList();
        }
    }
}
