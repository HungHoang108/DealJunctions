
namespace DealJunctions.Models
{
    public class Company : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public string HomePage { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;     
        public string City { get; set; } = string.Empty;
        public int PostalCode { get; set; }
        public string Country { get; set; } = string.Empty;
        public int PhoneNumber { get; set; }
    }
}
