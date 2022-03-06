using MiniShop.Entities;

namespace MiniShop.Repositories.Interfaces
{
    public interface IInvoiceRepository
    {
        Task<Invoice> GetTotalInvoiceAmount(string billNumber);
        void GenerateInvoiceForCustomer(int customerId, Invoice invoice);
    }
}
