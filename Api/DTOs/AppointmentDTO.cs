using System;
using System.ComponentModel.DataAnnotations;

namespace Api.DTOs
{
    public class AppointmentDTO
    {
        [Required(ErrorMessage = "The Doctor ID is required")]
        public required int DoctorId { get; set; }

        [Required(ErrorMessage = "The Patient ID is required")]
        public required int PatientId { get; set; }

        [Required(ErrorMessage = "The Appointment Reason ID is required")]
        public required int AppointmentReasonId { get; set; }

        [Required(ErrorMessage = "The Appointment Date is required")]
        public required DateTime AppointmentDate { get; set; }

        [Required(ErrorMessage = "The Status is required")]
        [MaxLength(50, ErrorMessage = "Status must be 50 characters or less")]
        [MinLength(3, ErrorMessage = "Status must be at least 3 characters")]
        public required string Status { get; set; }
    }
}