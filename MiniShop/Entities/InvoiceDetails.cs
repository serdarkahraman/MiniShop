using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniShop.Entities
{
    public class InvoiceDetails
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

        [Column(TypeName = "decimal(18, 2)")]
        public decimal DiscountPrice { get; set; }

        [ForeignKey(nameof(Invoice))]
        public int InvoiceId { get; set; }
        public Invoices Invoice { get; set; }
    }
}
