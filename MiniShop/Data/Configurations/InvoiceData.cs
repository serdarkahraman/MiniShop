using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniShop.Entities;

namespace MiniShop.Data.Configurations
{
    public class InvoiceData : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.HasData
            (
                new Invoice { InvoiceId = 1, OrderId = 1, InvoiceNumber = "Ms01", CustomerId = 1, Total = 100 },
                new Invoice { InvoiceId = 2, OrderId = 2, InvoiceNumber = "Ms02", CustomerId = 2, Total = 200 },
                new Invoice { InvoiceId = 3, OrderId = 3, InvoiceNumber = "Ms03", CustomerId = 3, Total = 300 },
                new Invoice { InvoiceId = 4, OrderId = 4, InvoiceNumber = "Ms04", CustomerId = 4, Total = 400 }
            );
        }
    }
}
