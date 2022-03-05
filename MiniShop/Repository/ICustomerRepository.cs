using MiniShop.Entities;

namespace MiniShop.Repository
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customers>> GetAll();
        void Create(Customers customer, string customerType);
        Task<Customers> GetById(int customerId);
        Task<Customers> GetByName(string name); 
    }
}
