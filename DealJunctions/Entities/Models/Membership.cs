﻿namespace DealJunctions.Entities.Models
{
    public class Membership
    {
        public int Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
    }
}
