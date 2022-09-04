using Library_API.Entity;
using Library_API.Models;

namespace Library_API.Service.Interfaces
{
    public interface ICustomerService
    {
        public List<Customer> GetAllCustomers();
        string CreateCustomer(CreateCustomerDto dto);
        Customer GetCustomer(string guid);
        bool DeleteCustomer(string guid);
        Customer PatchCustomer(Customer customerToPatch);
    }
}