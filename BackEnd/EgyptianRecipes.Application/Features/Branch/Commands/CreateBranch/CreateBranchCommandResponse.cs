using EgyptianRecipes.Application.Models.ViewModels.Branch;
using EgyptianRecipes.Application.Common.Responses;

namespace EgyptianRecipes.Application.Features.Branchs.Commands.CreateBranch
{
    public class CreateBranchCommandResponse: BaseResponse<CreateBranchResponseViewModel>
    {
        public CreateBranchCommandResponse(): base()
        {

        }

    }
}