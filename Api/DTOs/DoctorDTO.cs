using System.ComponentModel.DataAnnotations;

namespace Api.DTOs
{
    public class DoctorDTO
    {
        [Required(ErrorMessage = "The User ID is required")]
        public required int UserId { get; set; }

        [Required(ErrorMessage = "The Specialty ID is required")]
        public required int SpecialtyId { get; set; }

        [Required(ErrorMessage = "The Availability status is required")]
        public required bool IsAvailable { get; set; }
    }
}