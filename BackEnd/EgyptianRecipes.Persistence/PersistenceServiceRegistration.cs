using EgyptianRecipes.Persistence;
using EgyptianRecipes.Application.Contracts.Persistence;
using EgyptianRecipes.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using EgyptianRecipes.Application.Contracts.Persistence.IRepositories;
using EgyptianRecipes.Application.Contracts.Persistence.IRepositories.Base;
using EgyptianRecipes.Persistence.Repositories.Base;
namespace EgyptianRecipes.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EgyptianRecipesDbContext>(options =>
            {
                options.UseSqlServer(configuration["ConnectionString:EgyptianRecipesConnection"],
                b => b.MigrationsAssembly("EgyptianRecipes.Persistence"));
            });
            services.AddScoped<IBranchRepository, BranchRepository>();
            services.AddScoped<IUnitOfWorkAsync, UnitOfWorkAsync>();

            return services;    
        }
    }
}
