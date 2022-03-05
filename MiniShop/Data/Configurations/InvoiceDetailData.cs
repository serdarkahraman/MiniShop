using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniShop.Entities;

namespace MiniShop.Data.Configurations
{
    public class InvoiceDetailsData : IEntityTypeConfiguration<InvoiceDetails>
    {
        public void Configure(EntityTypeBuilder<InvoiceDetails> builder)
        {
            builder.HasData
            (
               new InvoiceDetails { Id = 1, InvoiceId = 1, ProductId = 1, ProductName = "Ürün 1", ProductPrice = 10, Quantity = 1, DiscountPrice = 1 },
               new InvoiceDetails { Id = 2, InvoiceId = 1, ProductId = 2, ProductName = "Ürün 2", ProductPrice = 20, Quantity = 2, DiscountPrice = 2 },
               new InvoiceDetails { Id = 3, InvoiceId = 2, ProductId = 3, ProductName = "Ürün 3", ProductPrice = 30, Quantity = 3, DiscountPrice = 3 },
               new InvoiceDetails { Id = 4, InvoiceId = 3, ProductId = 4, ProductName = "Ürün 4", ProductPrice = 40, Quantity = 4, DiscountPrice = 4 }
            );
        }
    }
}
