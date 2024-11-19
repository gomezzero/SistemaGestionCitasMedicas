using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("doctor")]
    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public required User User { get; set; }

        [Column("specialty_id")]
        public int SpecialtyId { get; set; }

        [Column("is_available")]
        public bool IsAvailable { get; set; }

        [ForeignKey("SpecialtyId")]
        public required Specialty Specialty { get; set; }

        public Doctor(int userId, int specialtyId)
        {
            UserId = userId;
            SpecialtyId = specialtyId;
            IsAvailable = true;
        }
    }
}