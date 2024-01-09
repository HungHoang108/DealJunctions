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
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public int PostalCode { get; set; }
        public string Country { get; set; } = string.Empty;

        [Required]
        [Column("PhoneNumber", TypeName = "int")]
        [StringLength(15)]
        public int PhoneNumber { get; set; }
    }
}
