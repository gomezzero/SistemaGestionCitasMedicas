using System.ComponentModel.DataAnnotations;

namespace Api.DTOs
{
    public class UserDTO
    {
        [Required(ErrorMessage = "The Username is required")]
        [MaxLength(50, ErrorMessage = "Username must be 50 characters or less")]
        [MinLength(3, ErrorMessage = "Username must be at least 3 characters")]
        public required string UserName { get; set; }

        [Required(ErrorMessage = "The Email is required")]
        [EmailAddress(ErrorMessage = "The Email isn't valid")]
        [MaxLength(100, ErrorMessage = "Email must be 100 characters or less")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "The Password is required")]
        [MaxLength(50, ErrorMessage = "Password must be 50 characters or less")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
        public required string Password { get; set; }

        [Required(ErrorMessage = "The Full Name is required")]
        [MaxLength(100, ErrorMessage = "Full Name must be 100 characters or less")]
        [MinLength(3, ErrorMessage = "Full Name must be at least 3 characters")]
        public required string FullName { get; set; }

        [Required(ErrorMessage = "The Role is required")]
        [MaxLength(20, ErrorMessage = "Role must be 20 characters or less")]
        public required string Role { get; set; }

        [MaxLength(20, ErrorMessage = "Phone Number must be 20 characters or less")]
        public string? PhoneNumber { get; set; }

        public int? SpecialtyId { get; set; }
    }
}