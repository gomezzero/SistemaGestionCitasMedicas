using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    [Table("user")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("user_name")]
        [MaxLength(50)]
        public required  string UserName { get; set; }

        [Column("email")]
        [MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [Column("password_hash")]
        public required  string PasswordHash { get; set; }


        [Column("full_name")]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Column("role")]
        public UserRole Role { get; set; }

        [Column("phone_number")]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        [Column("is_active")]
        public bool IsActive { get; set; }


        [Column("specialty_id")]
        // Foreign Key to Specialty (only if the user is a Doctor)
        public int? SpecialtyId { get; set; }

        public enum UserRole
        {
            Admin,
            Doctor,
            Patient
        }

        public User(string username, string email, string passwordHash, string fullName, UserRole role, string phoneNumber, int? specialtyId = null)
        {
            UserName = username;
            Email = email;
            PasswordHash = passwordHash;
            FullName = fullName;
            Role = role;
            PhoneNumber = phoneNumber;
            SpecialtyId = specialtyId;
            IsActive = true;
        }
    }
}