using System;
using System.ComponentModel.DataAnnotations;

namespace Api.DTOs
{
    public class ScheduleDTO
    {
        [Required(ErrorMessage = "The Doctor ID is required")]
        public required int DoctorId { get; set; }

        [Required(ErrorMessage = "The Day of Week is required")]
        [MaxLength(20, ErrorMessage = "Day of Week must be 20 characters or less")]
        public required string DayOfWeek { get; set; }

        [Required(ErrorMessage = "The Start Time is required")]
        [RegularExpression(@"^([01]?[0-9]|2[0-3]):([0-5][0-9])$", ErrorMessage = "Invalid time format. Please use HH:mm")]
        public required TimeSpan StartTime { get; set; }

        [Required(ErrorMessage = "The End Time is required")]
        [RegularExpression(@"^([01]?[0-9]|2[0-3]):([0-5][0-9])$", ErrorMessage = "Invalid time format. Please use HH:mm")]
        public required TimeSpan EndTime { get; set; }
    }
}