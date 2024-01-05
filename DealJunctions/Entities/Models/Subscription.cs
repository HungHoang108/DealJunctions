namespace DealJunctions.Entities.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public string MaxPromotions {  get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
    }
}
