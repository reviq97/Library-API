using System.ComponentModel.DataAnnotations;

namespace Library_API.Models
{
    public class RegisterUserDto
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        public string Password { get; set; }
        public string Nationality { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string RoleId { get; set; }
    }
}