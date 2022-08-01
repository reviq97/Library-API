using Library_API.Entity;

namespace Library_API.Service.Interfaces
{
    public interface ICustomerService
    {
        public IEnumerable<Customer> GetAllCustomers();
    }
}