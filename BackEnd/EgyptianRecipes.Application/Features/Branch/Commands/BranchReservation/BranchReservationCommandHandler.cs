using AutoMapper;
using EgyptianRecipes.Application.Contracts.Persistence;
using EgyptianRecipes.Application.Contracts.Persistence.IRepositories;
using EgyptianRecipes.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EgyptianRecipes.Application.AutoMapper;
using EgyptianRecipes.Application.Validation.Branch;
using FluentValidation;
using EgyptianRecipes.Application.Models.ViewModels.BranchReservation;

namespace EgyptianRecipes.Application.Features.Branchs.Commands.BranchReservation
{
    public class BranchReservationCommandHandler : IRequestHandler<BranchReservationCommand, BranchReservationCommandResponse>
    {
        private readonly IBranchReservationRepository _branchReservationRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWorkAsync _unitOfWorkAsync;
        private readonly IValidator<BranchReservationCommand> _validator;

        public BranchReservationCommandHandler(IMapper mapper, IUnitOfWorkAsync unitOfWorkAsync, IValidator<BranchReservationCommand> validator, IBranchReservationRepository branchReservationRepository)
        {
            _mapper = mapper;
            _unitOfWorkAsync = unitOfWorkAsync;
            _validator = validator;
            _branchReservationRepository = branchReservationRepository;
        }

        public async Task<BranchReservationCommandResponse> Handle(BranchReservationCommand request, CancellationToken cancellationToken)
        {
            var branchReservationCommandResponse = new BranchReservationCommandResponse();

            var validationResult = await _validator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                branchReservationCommandResponse.Success = false;
                branchReservationCommandResponse.Code = Common.Enums.StatusCode.ValidationError;
                branchReservationCommandResponse.ValidationErrors = validationResult.Errors.Select(x => x.ErrorMessage).ToList();
            }
            else 
            {
                var branchReservation = _mapper.Map<Domain.Entities.BranchReservation>(request);
                branchReservation = await _branchReservationRepository.AddAsync(branchReservation);
                await  _unitOfWorkAsync.CommitAsync();
                branchReservationCommandResponse.Data = _mapper.Map<BranchReservationResponseViewModel>(branchReservation); 
            }
            return branchReservationCommandResponse;
        }
    }
}
