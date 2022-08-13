using EgyptianRecipes.Application.Features.Branchs.Commands.CreateBranch;
using FluentValidation;
using System;

namespace EgyptianRecipes.Application.Validation.Branch
{
    public class CreateBranchCommandValidator: AbstractValidator<CreateBranchCommand>
    {
        public CreateBranchCommandValidator()
        {
            

            RuleFor(p => p.Title)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .MaximumLength(200).WithMessage("{PropertyName} must not exceed 200 characters.");

            RuleFor(p => p.ManagerId)
               .NotEmpty().WithMessage("Manager is required.");

            ;


            DateTime today = DateTime.Today;
            DateTime minDate = new DateTime(today.Year, today.Month, today.Day, 0, 0, 0);
            DateTime maxDate = new DateTime(today.Year, today.Month, today.Day, 23, 30, 0);

            RuleFor(p => p.OpeningHour.TimeOfDay)
               .NotEmpty().WithMessage("{PropertyName} is required.")
               .GreaterThanOrEqualTo(minDate.TimeOfDay)
               .WithMessage($"Opening Hour must be Greater Than Or Equal To {minDate.TimeOfDay}")
               .LessThanOrEqualTo(maxDate.TimeOfDay)
               .WithMessage($"Opening Hour must be Less Than Or Equal To {maxDate.TimeOfDay}");
              


            RuleFor(p => p.ClosingHour.TimeOfDay)
               .NotEmpty().WithMessage("{PropertyName} is required.")
               .GreaterThan(p => p.OpeningHour.TimeOfDay).WithMessage("ClosingHour must be Greater than  OpeningHour")
               .WithMessage($"Closing Hour must be Greater Than Or Equal To {minDate.TimeOfDay}")
               .LessThanOrEqualTo(maxDate.TimeOfDay)
               .WithMessage($"Closing Hour must be Less Than Or Equal To {maxDate.TimeOfDay}");


            RuleFor(p => p.ClosingHour.TimeOfDay.Subtract(p.OpeningHour.TimeOfDay).TotalMinutes)
                .Equal(30)
                .WithMessage("Openning Time  must be 30 minutes");


        }
    }
}
