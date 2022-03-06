using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Configurations;
using MiniShop.Entities;
using MiniShop.Repositories;
using MiniShop.Repositories.Interfaces;

namespace MiniShop.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(MiniShopContext context) : base(context) { }
        public void CreateCustomer(Customer customer, string customerType)
        {
            customer.CustomerType = customerType;
            Create(customer);
        }

        public async Task<Customer> GetById(int id) => 
            await FindByCondition(c => c.Id.Equals(id)).SingleOrDefaultAsync();

        public async Task<IEnumerable<Customer>> GetAll() => 
            await FindByCondition(u => u.CustomerType.Equals("Customer")).ToListAsync();

        public async Task<Customer> GetCustomerById(int customerId) => 
            await FindByCondition(c => c.Id == customerId && c.CustomerType.Equals("Customer")).SingleOrDefaultAsync();


        public async Task<Customer> GetByName(string name) => 
            await FindByCondition(c => c.FirstName.Contains(name) && c.CustomerType.Equals("Customer")).SingleOrDefaultAsync();


    }
}
