using Library_API.Enums;

namespace Library_API.Entity
{
    public class Customer
    {
        public string? Id { get; set; }
        public string Name { get; set; }
        public string Surname {get; set; }
        public Gender Gender { get; set; }
        public DateTime Birth { get; set; }
        public string PhoneNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }

    }
}
