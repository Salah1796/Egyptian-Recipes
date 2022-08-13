using EgyptianRecipes.Application.Features.Branchs.Commands.CreateBranch;
using EgyptianRecipes.Application.Features.Branchs.Commands.UpdateBranch;
using FluentValidation;
using System;

namespace EgyptianRecipes.Application.Validation.Branch
{
    public class UpdateBranchCommandValidator : AbstractValidator<UpdateBranchCommand>
    {
        public UpdateBranchCommandValidator()
        {
            RuleFor(p => p.Id)
              .NotEqual(Guid.Empty).WithMessage("{PropertyName} is required.");

            RuleFor(p => p.Title)
                  .NotEmpty().WithMessage("{PropertyName} is required.")
                  .MaximumLength(200).WithMessage("{PropertyName} must not exceed 200 characters.");

            RuleFor(p => p.ManagerName)
               .NotEmpty().WithMessage("{PropertyName} is required.")
               .MaximumLength(250).WithMessage("{PropertyName} must not exceed 250 characters.");

            RuleFor(p => p.ClosingHour.TimeOfDay)
               .NotEmpty().WithMessage("{PropertyName} is required.")
               .GreaterThan(p => p.OpeningHour.TimeOfDay).WithMessage("ClosingHour must be Greater than  OpeningHour")
               ;
            RuleFor(p => p.OpeningHour.TimeOfDay)
               .NotEmpty().WithMessage("{PropertyName} is required.");

            RuleFor(p => p.ClosingHour.TimeOfDay.Subtract(p.OpeningHour.TimeOfDay).TotalMinutes)
                .Equal(30)
                .WithMessage("Openning Time  must be 30 minutes  ");
        }
    }
}
