using MiniShop.Entities;

namespace MiniShop.Repository
{
    public interface IDiscountRepository
    {
        Task<IEnumerable<DiscountTypes>> GetAllDiscounts();
        Task<DiscountTypes> GetDiscountPercentageByType(string type);
        void CreateDiscountType(DiscountTypes discount);
        string DiscountPercentage(DiscountTypes discount);
    }
}
