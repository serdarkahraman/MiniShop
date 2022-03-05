using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MiniShop.Entities
{
    public class Invoices
    {
        public Invoices()
        {
            Created = DateTime.Now;
        }

        [Key]
        public int InvoiceId { get; set; }

        [Required]
        [MaxLength(50)]
        public string InvoiceNumber { get; set; }

        [Required]
        [MaxLength(50)]
        public int OrderId { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal OrderTotal { get; set; }
        public DateTime Created { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Total { get; set; }


        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public Customers Customer { get; set; }

        ICollection<InvoiceDetails> InvoiceDetails { get; set; }
    }
}
