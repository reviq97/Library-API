using Library_API.Entity;
using Library_API.Models;

namespace Library_API.Service.Interfaces
{
    public interface ICustomerService
    {
        public IEnumerable<Customer> GetAllCustomers();
        void CreateCustomer(CustomerAndAddressDto dto);
    }
}