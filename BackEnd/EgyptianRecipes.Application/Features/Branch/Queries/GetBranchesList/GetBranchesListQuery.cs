using EgyptianRecipes.Application.Common.Models;
using MediatR;
using System;
using System.Collections.Generic;

namespace EgyptianRecipes.Application.Features.Branchs.Queries.GetBranchesList
{
    public class GetBranchesListQuery : BaseFilter ,IRequest<GetBranchesListResponse>
    {
        public string Title { get; set; }
        public DateTime? FromOpeningHour { get; set; }
        public DateTime? ToOpeningHour { get; set; }
        public DateTime? FromClosingHour { get; set; }
        public DateTime? ToClosingHour { get; set; }
        public string ManagerName { get; set; }

    }
}
