using System.ComponentModel.DataAnnotations;

namespace MiniShop.Entities.DTO
{
    public class DiscountDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Rate { get; set; }
        public bool IsRatePercentage { get; set; }
    }
}
