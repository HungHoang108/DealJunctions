using System.ComponentModel.DataAnnotations.Schema;

namespace DealJunctions.Entities.Models
{
    public class Notification
    {
        public int Id { get; set; }

        [NotMapped]
        public Company? Company { get; set; } = null!;
        public int CompanyId { get; set; }

        [NotMapped]
        public Promotion? Promotion { get; set; } = null!;
        public int PromotionId { get; set; }

        public DateTime NotificationDate { get; set; }
    }
}
