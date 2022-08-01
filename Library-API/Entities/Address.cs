namespace Library_API.Entity
{
    public class Address
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }

        public Address()
        {

        }
    }
}
