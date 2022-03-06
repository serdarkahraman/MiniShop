using Microsoft.EntityFrameworkCore;
using MiniShop.Entities;

namespace MiniShop.Data.Configurations
{
    public class MiniShopContext : DbContext
    {
        public MiniShopContext(DbContextOptions<MiniShopContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerData());
            modelBuilder.ApplyConfiguration(new DiscountData());
            modelBuilder.ApplyConfiguration(new InvoiceData());
            modelBuilder.ApplyConfiguration(new InvoiceDetailsData());
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<DiscountType> DiscountType { get; set; }

    }
}
