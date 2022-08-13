using EgyptianRecipes.Application.Models.ViewModels.Branch;
using EgyptianRecipes.Application.Common.Responses;
using EgyptianRecipes.Application.Models.ViewModels.Manager;

namespace EgyptianRecipes.Application.Features.Branchs.Commands.CreateManager
{
    public class CreateManagerCommandResponse : BaseResponse<CreateManagerResponseViewModel>
    {
        public CreateManagerCommandResponse(): base()
        {

        }

    }
}