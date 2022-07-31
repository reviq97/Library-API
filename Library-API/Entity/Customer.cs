using Library_API.Enums;

namespace Library_API.Entity
{
    public class Customer
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname {get; set; }
        public Gender Gender { get; set; }
        public DateTime Birth { get; set; }
        public string PhoneNumber { get; set; }
        public long AddressId { get; set; }
        public virtual Address Address { get; set; }

        public Customer()
        {

        }
    }
}
