using EgyptianRecipes.Application.Features.Branchs.Commands.CreateBranch;
using EgyptianRecipes.Application.Features.Branchs.Commands.CreateManager;
using FluentValidation;
using System;

namespace EgyptianRecipes.Application.Validation.Branch
{
    public class CreateManagerCommandValidator : AbstractValidator<CreateManagerCommand>
    {
        public CreateManagerCommandValidator()
        {

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .MaximumLength(200).WithMessage("{PropertyName} must not exceed 250 characters.");
        }
    }
}
