using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string DisplayName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [RegularExpression("(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{8,200}$", ErrorMessage = "Password must be complex. (at least 8 characters, 1 number, 1 lowercase letter, 1 uppercase letter)")]
        public string Password { get; set; }
        [Required]
        public string Username { get; set; }
        
    }
}