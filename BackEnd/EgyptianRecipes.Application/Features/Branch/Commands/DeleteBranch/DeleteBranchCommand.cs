using MediatR;
using System;

namespace EgyptianRecipes.Application.Features.Branchs.Commands.CreateBranch
{
    public class DeleteBranchCommand : IRequest<DeleteBranchCommandResponse>
    {
        public Guid Id { get; set; }
    }
}
