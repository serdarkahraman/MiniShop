using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniShop.Entities
{
    public class InvoiceDetail
    {
        [Key]

        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        [MaxLength(50)]
        public string ProductName { get; set; }

        [Required]
        [MaxLength(20)]
        public decimal ProductPrice { get; set; }

        [Required]
        [MaxLength(20)]
        public int Quantity { get; set; }


        [Required]
        [Column(TypeName = "decimal(19, 2)")]
        public decimal ProductCost { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal DiscountPrice { get; set; }

        [ForeignKey(nameof(Invoice))]
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
    }
}
