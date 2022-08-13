using MediatR;
using System;

namespace EgyptianRecipes.Application.Features.Branchs.Commands.CreateBranch
{
    public class CreateBranchCommand : IRequest<CreateBranchCommandResponse>
    {
        public string Title { get; set; }
        public DateTime OpeningHour { get; set; }
        public DateTime ClosingHour { get; set; }
        public Guid ManagerId { get; set; }
    }
}
