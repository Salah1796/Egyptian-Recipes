using MediatR;
using System;

namespace EgyptianRecipes.Application.Features.Branchs.Commands.BranchReservation
{
    public class BranchReservationCommand : IRequest<BranchReservationCommandResponse>
    {
        public Guid BranchId { get; set; }
        public DateTime Date { get; set; }  
    }
}
