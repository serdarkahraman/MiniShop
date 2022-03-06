using MiniShop.Entities;

namespace MiniShop.Repositories.Interfaces
{
    public interface IDiscountRepository
    {
        Task<IEnumerable<DiscountType>> GetAllDiscounts();
        Task<DiscountType> GetDiscountPercentageByType(string type);
        void CreateDiscountType(DiscountType discount);
        string DiscountPercentage(DiscountType discount);
    }
}
