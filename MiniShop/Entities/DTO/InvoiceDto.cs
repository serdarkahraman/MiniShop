namespace MiniShop.Entities.DTO
{
    public class InvoiceDto
    {
        public int InvoiceId { get; set; }
        public string InvoiceNumber { get; set; }
        public int OrderId { get; set; }
        public DateTime Created { get; set; }
        public decimal Total { get; set; }
    }
}
