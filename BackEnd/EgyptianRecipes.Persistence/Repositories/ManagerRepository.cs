using EgyptianRecipes.Application.Contracts.Persistence;
using EgyptianRecipes.Application.Contracts.Persistence.IRepositories;
using EgyptianRecipes.Domain.Entities;
using EgyptianRecipes.Persistence.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EgyptianRecipes.Persistence.Repositories
{
    public class ManagerRepository : BaseRepository<Manager,Guid>, IManagerRepository
    {
        public ManagerRepository(EgyptianRecipesDbContext dbContext) : base(dbContext)
        {
        }
    }
}
