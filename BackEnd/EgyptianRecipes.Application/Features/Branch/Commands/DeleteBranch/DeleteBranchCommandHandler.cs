using AutoMapper;
using EgyptianRecipes.Application.Contracts.Persistence;
using EgyptianRecipes.Application.Contracts.Persistence.IRepositories;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EgyptianRecipes.Application.AutoMapper;
using EgyptianRecipes.Application.Validation.Branch;

namespace EgyptianRecipes.Application.Features.Branchs.Commands.CreateBranch
{
    public class DeleteBranchCommandHandler : IRequestHandler<DeleteBranchCommand, DeleteBranchCommandResponse>
    {
        private readonly IBranchRepository _branchRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWorkAsync _unitOfWorkAsync;

        public DeleteBranchCommandHandler(IMapper mapper, IBranchRepository branchRepository, IUnitOfWorkAsync unitOfWorkAsync)
        {
            _mapper = mapper;
            _branchRepository = branchRepository;
            _unitOfWorkAsync = unitOfWorkAsync;
        }

        public async Task<DeleteBranchCommandResponse> Handle(DeleteBranchCommand request, CancellationToken cancellationToken)
        {
            var deleteBranchCommandResponse = new DeleteBranchCommandResponse();

            var validator = new DeleteBranchCommandValidator();
            var validationResult = await validator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                deleteBranchCommandResponse.Success = false;
                deleteBranchCommandResponse.ValidationErrors = validationResult.Errors.Select(x => x.ErrorMessage).ToList();

            }
            else 
            {

                await _branchRepository.Delete(request.Id);
                await  _unitOfWorkAsync.CommitAsync();
                deleteBranchCommandResponse.Data = true;
            }
            return deleteBranchCommandResponse;
        }

    }
}
