using EgyptianRecipes.Application.Features.Branchs.Commands.CreateBranch;
using FluentValidation;
using System;

namespace EgyptianRecipes.Application.Validation.Branch
{
    public class DeleteBranchCommandValidator : AbstractValidator<DeleteBranchCommand>
    {
        public DeleteBranchCommandValidator()
        {
            RuleFor(p => p.Id)
           .NotEqual(Guid.Empty).WithMessage("{PropertyName} is required.");
        }
    }
}
