using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Configurations;
using MiniShop.Entities;
using MiniShop.Repositories.Interfaces;

namespace MiniShop.Repositories
{
    public class DiscountRepository : Repository<DiscountType>, IDiscountRepository
    {
        public DiscountRepository(MiniShopContext context) :base(context) { }

        public void CreateDiscountType(DiscountType discount) => Create(discount);

        public string DiscountPercentage(DiscountType discount)
        {
            if (discount.IsRatePercentage) return $"{discount.Rate}%";
            return null;
        }

        public async Task<IEnumerable<DiscountType>> GetAllDiscounts() =>
            await GetAll().OrderBy(d => d.Name).ToListAsync();

        public async Task<DiscountType> GetDiscountPercentageByType(string type) =>
            await FindByCondition(d => d.Type.Trim().ToLower()
                .Equals(type.Trim().ToLower())).SingleOrDefaultAsync();
    }
}
