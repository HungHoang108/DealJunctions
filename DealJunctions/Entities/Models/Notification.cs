using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DealJunctions.Entities.Models
{
    public class Notification
    {
        [Key]
        public int Id { get; set; }

        [NotMapped]
        public Company? Company { get; set; } = null!;
        public int CompanyId { get; set; }

        [NotMapped]
        public Promotion? Promotion { get; set; } = null!;
        public int PromotionId { get; set; }

        [Required(ErrorMessage = "Please add notification date")]
        [DataType(DataType.Date)]
        public DateTime NotificationDate { get; set; }
    }
}
