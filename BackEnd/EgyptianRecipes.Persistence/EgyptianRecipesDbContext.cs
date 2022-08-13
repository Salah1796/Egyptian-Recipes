using EgyptianRecipes.Domain.Common;
using EgyptianRecipes.Domain.Entities;
using EgyptianRecipes.Persistence.Repositories.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EgyptianRecipes.Persistence
{
    public class EgyptianRecipesDbContext : DbContext
    {
        public EgyptianRecipesDbContext(DbContextOptions<EgyptianRecipesDbContext> options)
           : base(options)
        {
        }

        public DbSet<Branch> Branches { get; set; }
        public DbSet<Manager> Managers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BranchMap());
        }

    }
}
