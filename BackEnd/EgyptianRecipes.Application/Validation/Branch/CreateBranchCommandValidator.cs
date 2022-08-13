using EgyptianRecipes.Application.Features.Branchs.Commands.CreateBranch;
using FluentValidation;

namespace EgyptianRecipes.Application.Validation.Branch
{
    public class CreateBranchCommandValidator: AbstractValidator<CreateBranchCommand>
    {
        public CreateBranchCommandValidator()
        {
            

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
