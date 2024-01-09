using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DealJunctions.Entities.Models
{
    public class Promotion : BaseModel
    {
        public int CompanyId { get; set; }

        [Required]
        [StringLength(250)]
        [Column("Title", TypeName = "nvarchar(250)")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(500)]
        [Column("Description", TypeName = "nvarchar(500)")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        [Column("PromoCode", TypeName = "nvarchar(50)")]
        public string PromoCode { get; set; } = string.Empty;
    }
}
