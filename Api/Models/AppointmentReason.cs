using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("appointment_reason")]
    public class AppointmentReason
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("description")]
        [MaxLength(200)]
        [Required]
        public string Description { get; set; }

        public AppointmentReason(string description)
        {
            Description = description;
        }
    }
}