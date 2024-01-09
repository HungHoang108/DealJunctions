using System.ComponentModel.DataAnnotations;

namespace DealJunctions.Entities.Models
{
    public class Subscription
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public string MaxPromotions { get; set; } = string.Empty;
        public decimal Price { get; set; }

        [Range(0, 100)]
        public int Discount { get; set; }
    }
}
