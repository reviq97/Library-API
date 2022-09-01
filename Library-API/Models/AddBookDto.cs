namespace Library_API.Models;

public class AddBookDto
{
    public string? Title { get; set; }
    public string? Author { get; set; }
    public DateTime? Written { get; set; }
}