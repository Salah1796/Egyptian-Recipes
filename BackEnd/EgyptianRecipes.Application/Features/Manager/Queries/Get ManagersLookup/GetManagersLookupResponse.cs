using EgyptianRecipes.Application.Common.Responses;
using EgyptianRecipes.Application.Models.ViewModels.Branch;
using EgyptianRecipes.Application.Models.ViewModels.Manager;
using EgyptianRecipes.Application.Models.ViewModels;
using System.Collections.Generic;

namespace EgyptianRecipes.Application.Features.Manger.Queries.GetManagersLookup
{
    public class GetManagersLookupResponse : BaseResponse<List<GetManagersListRespnseViewModel>>
    {
        public GetManagersLookupResponse(): base()
        {

        }

    }
}