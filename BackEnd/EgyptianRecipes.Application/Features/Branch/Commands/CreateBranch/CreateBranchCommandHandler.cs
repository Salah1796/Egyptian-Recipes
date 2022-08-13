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

namespace EgyptianRecipes.Application.Features.Branchs.Commands.CreateBranch
{
    public class CreateBranchCommandHandler : IRequestHandler<CreateBranchCommand, CreateBranchCommandResponse>
    {
        private readonly IBranchRepository _branchRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWorkAsync _unitOfWorkAsync;
        private readonly IValidator<CreateBranchCommand> _validator;

        public CreateBranchCommandHandler(IMapper mapper, IBranchRepository branchRepository, IUnitOfWorkAsync unitOfWorkAsync, IValidator<CreateBranchCommand> validator)
        {
            _mapper = mapper;
            _branchRepository = branchRepository;
            _unitOfWorkAsync = unitOfWorkAsync;
            _validator = validator;
        }

        public async Task<CreateBranchCommandResponse> Handle(CreateBranchCommand request, CancellationToken cancellationToken)
        {
            var createCategoryCommandResponse = new CreateBranchCommandResponse();

            var validationResult = await _validator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                createCategoryCommandResponse.Success = false;
                createCategoryCommandResponse.Code = Common.Enums.StatusCode.ValidationError;
                createCategoryCommandResponse.ValidationErrors = validationResult.Errors.Select(x => x.ErrorMessage).ToList();
            }
            else 
            {
                var branch = request.ToModel(_mapper);

                branch = await _branchRepository.AddAsync(branch);
                await  _unitOfWorkAsync.CommitAsync();

                createCategoryCommandResponse.Data = branch.ToCreateResponseViewModel(_mapper);
            }
            return createCategoryCommandResponse;
        }
    }
}
