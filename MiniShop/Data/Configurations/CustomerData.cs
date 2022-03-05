using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniShop.Entities;

namespace MiniShop.Data.Configurations
{
    public class CustomerData : IEntityTypeConfiguration<Customers>
    {
        public void Configure(EntityTypeBuilder<Customers> builder)
        {
            builder.HasData
            (
                new Customers { Id = 1, FirstName = "Serdar", LastName = "Kahraman", Email = "serdar@kahraman.com", PhoneNumber = "05324480153", CustomerType = "Employee", Created = DateTime.Now.AddYears(-33) },
                new Customers { Id = 2, FirstName = "Sevgi", LastName = "Kahraman", Email = "sevgi@kahraman.com", PhoneNumber = "05324480154", CustomerType = "Affiliate", Created = DateTime.Now.AddMonths(-28) },
                new Customers { Id = 3, FirstName = "Alya", LastName = "Kahraman", Email = "alya@kahraman.com", PhoneNumber = "05324480155", CustomerType = "Customer", Created = DateTime.Now.AddYears(-4) },
                new Customers { Id = 4, FirstName = "Alparslan", LastName = "Kahraman", Email = "alparslan@kahraman.com", PhoneNumber = "05324480156", CustomerType = "Customer", Created = DateTime.Now }
            );
        }
    }
}
