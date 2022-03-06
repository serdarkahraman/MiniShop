using System.Linq.Expressions;
namespace MiniShop.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void Update(T entity);

    }
}
