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

        public DbSet<Customers> Customers { get; set; }
        public DbSet<Invoices> Invoices { get; set; }
        public DbSet<InvoiceDetails> InvoiceDetails { get; set; }
        public DbSet<DiscountTypes> DiscountType { get; set; }

    }
}
