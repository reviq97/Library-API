namespace Library_API.Entities
{
    public class User
    {
        public string Id{ get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string CustomerId { get; set; }
        public string RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}
