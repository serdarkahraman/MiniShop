using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Configurations;
using MiniShop.Data;
using MiniShop.Repositories.Interfaces;

namespace MiniShop.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private readonly MiniShopContext _context;

        public Repository(MiniShopContext context)
        {
            _context = context;
        }
        public void Create(T entity) => _context.Set<T>().Add(entity);

        public IQueryable<T> GetAll() => _context.Set<T>().AsNoTracking();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) => _context.Set<T>().Where(expression).AsNoTracking();

        public void Update(T entity) => _context.Set<T>().Update(entity);
    }
}
