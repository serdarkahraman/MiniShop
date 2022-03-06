using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MiniShop.Entities
{
    public class Invoice
    {
        public Invoice()
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
        public Customer Customer { get; set; }

        ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
