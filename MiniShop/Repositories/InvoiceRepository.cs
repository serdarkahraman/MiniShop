using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Configurations;
using MiniShop.Entities;
using MiniShop.Repositories.Interfaces;

namespace MiniShop.Repositories
{
    public class InvoiceRepository : Repository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(MiniShopContext context) :base(context) { }

        public void GenerateInvoiceForCustomer(int customerId, Invoice invoice)
        {
            invoice.CustomerId = customerId;
            Create(invoice);
        }

        public async Task<Invoice> GetTotalInvoiceAmount(string billNumber) =>
             await FindByCondition(i => i.InvoiceNumber.Equals(billNumber)).SingleOrDefaultAsync();
    }
}
