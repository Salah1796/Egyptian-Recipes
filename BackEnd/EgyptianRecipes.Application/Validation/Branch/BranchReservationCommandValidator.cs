using EgyptianRecipes.Application.Contracts.Persistence.IRepositories;
using EgyptianRecipes.Application.Features.Branchs.Commands.BranchReservation;
using FluentValidation;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace EgyptianRecipes.Application.Validation.BranchReservation
{
    public class BranchReservationCommandValidator : AbstractValidator<BranchReservationCommand>
    {
        private readonly IBranchRepository _branchRepository;
        public BranchReservationCommandValidator(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository;

            RuleFor(p => p.BranchId)
               .NotEmpty().WithMessage("Branch is required.");

            RuleFor(x => new { x.BranchId, x.Date }).MustAsync(async (reserv, cancellation) =>
           {
               bool validReservationDate = true;
               validReservationDate = await _branchRepository.Get()
               .AnyAsync(br => br.Id == reserv.BranchId
               && br.OpeningHour.TimeOfDay <= reserv.Date.TimeOfDay
               && br.ClosingHour.TimeOfDay >= reserv.Date.TimeOfDay
                );
               return validReservationDate;
           }).WithMessage("Branch not Exist or not open at this time ");
        }
    }
}
