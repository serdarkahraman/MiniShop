using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MiniShop.Entities
{
    public class DiscountType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(25)]
        public string Type { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Rate { get; set; }
        public bool IsRatePercentage { get; set; }

    }
}
