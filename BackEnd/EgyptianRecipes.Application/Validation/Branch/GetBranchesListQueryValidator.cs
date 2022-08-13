using EgyptianRecipes.Application.Features.Branchs.Queries.GetBranchesList;
using FluentValidation;

namespace EgyptianRecipes.Application.Validation.Branch
{
    public class GetBranchesListQueryValidator : AbstractValidator<GetBranchesListQuery>
    {
        public GetBranchesListQueryValidator()
        {
        }
    }
}
