using MediatR;
using System;

namespace EgyptianRecipes.Application.Features.Branchs.Commands.CreateManager
{
    public class CreateManagerCommand : IRequest<CreateManagerCommandResponse>
    {
        public string Name { get; set; }
    
    }
}
