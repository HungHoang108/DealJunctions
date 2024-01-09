using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DealJunctions.Entities.Models
{
    public class Company : BaseModel
    {
        [Required]
        [StringLength(250)]
        [Column("FullName", TypeName = "nvarchar(250)")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(1000)]
        [Column("WebsiteUrl", TypeName = "nvarchar(1000)")]
        public string WebsiteUrl { get; set; } = string.Empty;

        [Required]
        [StringLength(250)]
        [Column("Address", TypeName = "nvarchar(250)")]
        public string Address { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        [Column("City", TypeName = "nvarchar(50)")]
        public string City { get; set; } = string.Empty;

        [Required]
        [StringLength(15)]
        [Column("PostalCode", TypeName = "nvarchar(15)")]
        public int PostalCode { get; set; }

        [Required]
        [StringLength(50)]
        [Column("Country", TypeName = "nvarchar(50)")]
        public string Country { get; set; } = string.Empty;

        [Required]
        [Column("PhoneNumber", TypeName = "int")]
        [StringLength(15)]
        public int PhoneNumber { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public ICollection<Promotion> Promotions { get; set; } = new List<Promotion>();
    }
}
