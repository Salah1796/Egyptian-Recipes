using EgyptianRecipes.Application.Common.Responses;
using EgyptianRecipes.Application.Models.ViewModels.Branch;
using System.Collections.Generic;

namespace EgyptianRecipes.Application.Features.Branchs.Queries.GetBranchesList
{
    public class GetBranchesListResponse : BasePaginatedResponse<List<GetBranchesListRespnseViewModel>>
    {
        public GetBranchesListResponse(): base()
        {

        }

    }
}