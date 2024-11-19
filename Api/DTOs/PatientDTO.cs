using System.ComponentModel.DataAnnotations;

namespace Api.DTOs
{
    public class PatientDTO
    {
        [Required(ErrorMessage = "The User ID is required")]
        public required int UserId { get; set; }

        [Required(ErrorMessage = "The Medical Record is required")]
        [MaxLength(500, ErrorMessage = "Medical Record must be 500 characters or less")]
        [MinLength(10, ErrorMessage = "Medical Record must be at least 10 characters")]
        public required string MedicalRecord { get; set; }
    }
}