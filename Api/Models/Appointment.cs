using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("appointment")]
    public class Appointment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("doctor_id")]
        public int DoctorId { get; set; }

        [ForeignKey("DoctorId")]
        public required Doctor Doctor { get; set; } // Utiliza 'required' para asegurar que no sea null

        [Column("patient_id")]
        public int PatientId { get; set; }

        [ForeignKey("PatientId")]
        public required Patient Patient { get; set; } // Utiliza 'required' para asegurar que no sea null

        [Column("appointment_reason_id")]
        public int AppointmentReasonId { get; set; }

        [ForeignKey("AppointmentReasonId")]
        public required AppointmentReason AppointmentReason { get; set; } // Utiliza 'required' para asegurar que no sea null

        [Column("appointment_date")]
        public DateTime AppointmentDate { get; set; }

        [Column("status")]
        [MaxLength(50)]
        public string Status { get; set; } = string.Empty;

        public Appointment(int doctorId, Doctor doctor, int patientId, Patient patient, int appointmentReasonId, AppointmentReason appointmentReason, DateTime appointmentDate, string status)
        {
            DoctorId = doctorId;
            Doctor = doctor; // Inicialización de Doctor requerida
            PatientId = patientId;
            Patient = patient; // Inicialización de Patient requerida
            AppointmentReasonId = appointmentReasonId;
            AppointmentReason = appointmentReason; // Inicialización de AppointmentReason requerida
            AppointmentDate = appointmentDate;
            Status = status;
        }
    }
}