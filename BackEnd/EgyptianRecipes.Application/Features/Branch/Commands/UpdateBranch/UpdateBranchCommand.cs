using MediatR;
using System;

namespace EgyptianRecipes.Application.Features.Branchs.Commands.UpdateBranch
{
    public class UpdateBranchCommand : IRequest<UpdateBranchCommandResponse>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime OpeningHour { get; set; }
        public DateTime ClosingHour { get; set; }
        public Guid ManagerId { get; set; }
    }
}
