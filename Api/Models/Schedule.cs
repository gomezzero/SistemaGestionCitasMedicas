
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("schedule")]
    public class Schedule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("doctor_id")]
        public int DoctorId { get; set; }

        [ForeignKey("DoctorId")]
        public required Doctor Doctor { get; set; } // Utiliza 'required' para asegurar que no sea null

        [Column("day_of_week")]
        [MaxLength(20)]
        public string DayOfWeek { get; set; } = string.Empty;

        [Column("start_time")]
        public TimeSpan StartTime { get; set; }

        [Column("end_time")]
        public TimeSpan EndTime { get; set; }

        public Schedule(int doctorId, Doctor doctor, string dayOfWeek, TimeSpan startTime, TimeSpan endTime)
        {
            DoctorId = doctorId;
            Doctor = doctor; // Inicialización de Doctor requerida
            DayOfWeek = dayOfWeek;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}