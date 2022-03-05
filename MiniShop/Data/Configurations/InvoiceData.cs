using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniShop.Entities;

namespace MiniShop.Data.Configurations
{
    public class InvoiceData : IEntityTypeConfiguration<Invoices>
    {
        public void Configure(EntityTypeBuilder<Invoices> builder)
        {
            builder.HasData
            (
                new Invoices { InvoiceId = 1, OrderId = 1, InvoiceNumber = "Ms01", CustomerId = 1, Total = 100 },
                new Invoices { InvoiceId = 2, OrderId = 2, InvoiceNumber = "Ms02", CustomerId = 2, Total = 200 },
                new Invoices { InvoiceId = 3, OrderId = 3, InvoiceNumber = "Ms03", CustomerId = 3, Total = 300 },
                new Invoices { InvoiceId = 4, OrderId = 4, InvoiceNumber = "Ms04", CustomerId = 4, Total = 400 }
            );
        }
    }
}
