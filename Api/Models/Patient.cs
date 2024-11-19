using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("patient")]
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [Column("medical_record")]
        [MaxLength(500)]
        public  string MedicalRecord { get; set; }

        public Patient(int userId, User user, string medicalRecord)
        {
            UserId = userId;
            User = user; // Inicialización de User requerida
            MedicalRecord = medicalRecord;
        }
    }
}