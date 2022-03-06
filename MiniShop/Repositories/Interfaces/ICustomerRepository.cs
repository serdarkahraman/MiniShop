using MiniShop.Entities;

namespace MiniShop.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        void CreateCustomer(Customer customer, string customerType);

        Task<IEnumerable<Customer>> GetAll();
        Task<Customer> GetById(int id);
        Task<Customer> GetByName(string name); 
    }
}
