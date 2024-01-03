using System.ComponentModel.DataAnnotations.Schema;

namespace DealJunctions.Models
{
    public class Employee : BaseModel
    {
        public int CompanyId { get; set; }

        [NotMapped]
        public Company? Company { get; set; } = null!;
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int PhoneNumber { get; set; }

    }
}
