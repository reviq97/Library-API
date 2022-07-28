namespace Library_API.Entity
{
    public class Book
    {
        public long Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public DateTime? Written { get; set; }
    }
}
