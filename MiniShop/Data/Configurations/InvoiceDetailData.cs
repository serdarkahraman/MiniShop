using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniShop.Entities;

namespace MiniShop.Data.Configurations
{
    public class InvoiceDetailsData : IEntityTypeConfiguration<InvoiceDetail>
    {
        public void Configure(EntityTypeBuilder<InvoiceDetail> builder)
        {
            builder.HasData
            (
               new InvoiceDetail { Id = 1, InvoiceId = 1, ProductId = 1, ProductName = "Ürün 1", ProductPrice = 100, Quantity = 1, ProductCost = 100, DiscountPrice = 10 },
               new InvoiceDetail { Id = 2, InvoiceId = 1, ProductId = 2, ProductName = "Ürün 2", ProductPrice = 200, Quantity = 2, ProductCost = 200, DiscountPrice = 20 },
               new InvoiceDetail { Id = 3, InvoiceId = 2, ProductId = 3, ProductName = "Ürün 3", ProductPrice = 300, Quantity = 3, ProductCost = 300, DiscountPrice = 30 },
               new InvoiceDetail { Id = 4, InvoiceId = 3, ProductId = 4, ProductName = "Ürün 4", ProductPrice = 400, Quantity = 4, ProductCost = 400, DiscountPrice = 40 }
            );
        }
    }
}
