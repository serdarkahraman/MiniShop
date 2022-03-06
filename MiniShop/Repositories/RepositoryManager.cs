using MiniShop.Data.Configurations;
using MiniShop.Repositories.Interfaces;

namespace MiniShop.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        MiniShopContext _context; IDiscountRepository _discount; IInvoiceRepository _invoice; ICustomerRepository _customer;
        public RepositoryManager(MiniShopContext context) => _context = context;


        public IDiscountRepository Discount
        {
            get
            {
                if (_discount == null) _discount = new DiscountRepository(_context);
                return _discount;
            }
        }

        public IInvoiceRepository Invoice
        {
            get
            {
                if (_invoice == null) _invoice = new InvoiceRepository(_context);
                return _invoice;
            }
        }

        public ICustomerRepository Customer
        {
            get
            {
                if (_customer == null) _customer = new CustomerRepository(_context);
                return _customer;
            }
        }
        public async Task SaveAsync() => await _context.SaveChangesAsync(); 
    }
}
