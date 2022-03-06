using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniShop.Entities;

namespace MiniShop.Data.Configurations
{
    public class CustomerData : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData
            (
                new Customer { Id = 1, FirstName = "Serdar", LastName = "Kahraman", Email = "serdar@kahraman.com", PhoneNumber = "05324480153", CustomerType = "Employee", Address = "1", Created = DateTime.Now.AddYears(-33) },
                new Customer { Id = 2, FirstName = "Sevgi", LastName = "Kahraman", Email = "sevgi@kahraman.com", PhoneNumber = "05324480154", CustomerType = "Affiliate", Address = "1", Created = DateTime.Now.AddMonths(-28) },
                new Customer { Id = 3, FirstName = "Alya", LastName = "Kahraman", Email = "alya@kahraman.com", PhoneNumber = "05324480155", CustomerType = "Customer", Address = "1", Created = DateTime.Now.AddYears(-4) },
                new Customer { Id = 4, FirstName = "Alparslan", LastName = "Kahraman", Email = "alparslan@kahraman.com", PhoneNumber = "05324480156", CustomerType = "Customer", Address = "1", Created = DateTime.Now }
            );
        }
    }
}
