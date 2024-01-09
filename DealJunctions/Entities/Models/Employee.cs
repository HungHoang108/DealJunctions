using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DealJunctions.Entities.Models
{
    public class Employee : IdentityUser<int>
    {
        [Key]
        public override int Id { get; set; }
        [NotMapped]
        public Company? Company { get; set; } = null!;
        public int CompanyId { get; set; }

        [Required]
        [StringLength(100)]
        [Column("FullName", TypeName = "nvarchar(100)")]
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}
