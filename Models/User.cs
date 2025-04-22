using System.ComponentModel.DataAnnotations;

namespace CDNFreelancers.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Phone]
        [StringLength(20)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        public string Skillsets { get; set; } = string.Empty;

        public string? Hobby { get; set; }

        public bool IsActive { get; set; } = true; // Default to active
    }
} 