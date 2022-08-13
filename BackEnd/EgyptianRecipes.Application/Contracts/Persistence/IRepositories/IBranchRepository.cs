using EgyptianRecipes.Application.Contracts.Persistence.IRepositories.Base;
using EgyptianRecipes.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EgyptianRecipes.Application.Contracts.Persistence.IRepositories
{
    public interface IBranchRepository : IBaseRepositoryAsync<Branch, System.Guid>
    {
    }
}
