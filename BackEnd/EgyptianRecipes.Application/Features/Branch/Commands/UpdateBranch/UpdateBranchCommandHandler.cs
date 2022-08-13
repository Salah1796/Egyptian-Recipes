using AutoMapper;
using EgyptianRecipes.Application.Contracts.Persistence;
using EgyptianRecipes.Application.Contracts.Persistence.IRepositories;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EgyptianRecipes.Application.AutoMapper;
using EgyptianRecipes.Application.Validation.Branch;
using FluentValidation;

namespace EgyptianRecipes.Application.Features.Branchs.Commands.UpdateBranch
{
    public class UpdateBranchCommandHandler : IRequestHandler<UpdateBranchCommand, UpdateBranchCommandResponse>
    {
        private readonly IBranchRepository _branchRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWorkAsync _unitOfWorkAsync;
        private readonly IValidator<UpdateBranchCommand> _validator;
        public UpdateBranchCommandHandler(IMapper mapper, IBranchRepository branchRepository, IUnitOfWorkAsync unitOfWorkAsync, IValidator<UpdateBranchCommand> validator)
        {
            _mapper = mapper;
            _branchRepository = branchRepository;
            _unitOfWorkAsync = unitOfWorkAsync;
            _validator = validator;
        }

        public async Task<UpdateBranchCommandResponse> Handle(UpdateBranchCommand request, CancellationToken cancellationToken)
        {
            var createCategoryCommandResponse = new UpdateBranchCommandResponse();

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

                branch =  _branchRepository.Update(branch);
                await  _unitOfWorkAsync.CommitAsync();
                createCategoryCommandResponse.Data = branch.ToUpdateResponseViewModel(_mapper);
            }
            return createCategoryCommandResponse;
        }

    }
}
