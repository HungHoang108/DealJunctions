namespace DealJunctions.Entities.Models
{
    public class Promotion : BaseModel
    {
        public int CompanyId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string PromoCode { get; set; } = string.Empty;
    }
}
