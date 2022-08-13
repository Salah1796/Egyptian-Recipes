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

namespace EgyptianRecipes.Application.Features.Branchs.Commands.CreateManager
{
    public class CreateManagerCommandHandler : IRequestHandler<CreateManagerCommand, CreateManagerCommandResponse>
    {
        private readonly IManagerRepository _managerRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWorkAsync _unitOfWorkAsync;
        private readonly IValidator<CreateManagerCommand> _validator;

        public CreateManagerCommandHandler(IMapper mapper, IUnitOfWorkAsync unitOfWorkAsync, IValidator<CreateManagerCommand> validator, IManagerRepository managerRepository)
        {
            _mapper = mapper;
            _unitOfWorkAsync = unitOfWorkAsync;
            _validator = validator;
            _managerRepository = managerRepository;
        }

        public async Task<CreateManagerCommandResponse> Handle(CreateManagerCommand request, CancellationToken cancellationToken)
        {
            var createCategoryCommandResponse = new CreateManagerCommandResponse();

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

                branch = await _managerRepository.AddAsync(branch);
                await  _unitOfWorkAsync.CommitAsync();

                createCategoryCommandResponse.Data = branch.ToCreateResponseViewModel(_mapper);
            }
            return createCategoryCommandResponse;
        }
    }
}
