using EgyptianRecipes.Application.Contracts.Persistence.IRepositories.Base;
using EgyptianRecipes.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EgyptianRecipes.Application.Contracts.Persistence.IRepositories
{
    public interface IManagerRepository : IBaseRepositoryAsync<Manager, System.Guid>
    {
    }
}
