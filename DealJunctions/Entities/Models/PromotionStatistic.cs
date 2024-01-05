namespace DealJunctions.Entities.Models
{
    public class PromotionStatistic
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int NumberOfClicks { get; set; }
        public DateTime Clicked_at { get; set; }
    }
}
