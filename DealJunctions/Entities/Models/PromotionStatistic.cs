using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DealJunctions.Entities.Models
{
    public class PromotionStatistic
    {
        [Key]
        public int Id { get; set; }

        [NotMapped]
        public Promotion Promotion { get; set; } = null!;
        public int PromotionId { get; set; }
        public int NumberOfClicks { get; set; }
        public DateTime Clicked_at { get; set; }
    }
}
