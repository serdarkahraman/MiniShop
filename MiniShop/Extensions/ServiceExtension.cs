using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MiniShop.Data;
using MiniShop.Data.Configurations;
using MiniShop.Repositories;
using MiniShop.Repositories.Interfaces;

namespace MiniShop.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();


        public static void ConfigureSqlLite(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<MiniShopContext>(options =>
            options.UseSqlite(configuration.GetConnectionString("MiniShopConnection")));
    }
}
