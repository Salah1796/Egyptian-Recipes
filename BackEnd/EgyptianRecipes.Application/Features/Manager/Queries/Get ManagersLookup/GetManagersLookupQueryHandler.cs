using AutoMapper;
using EgyptianRecipes.Application.Contracts.Persistence;
using EgyptianRecipes.Application.Contracts.Persistence.IRepositories;
using EgyptianRecipes.Application.Validation.Branch;
using EgyptianRecipes.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoMapper.QueryableExtensions;
using EgyptianRecipes.Application.Models.ViewModels.Branch;
using EgyptianRecipes.Application.Models.ViewModels.Manager;

namespace EgyptianRecipes.Application.Features.Manger.Queries.GetManagersLookup
{
    public class GetManagersLookupQueryHandler : IRequestHandler<GetManagersLookupQuery, GetManagersLookupResponse>
    {
        private readonly IManagerRepository _managerRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWorkAsync _unitOfWorkAsync;

        public GetManagersLookupQueryHandler(IMapper mapper, IUnitOfWorkAsync unitOfWorkAsync, IManagerRepository managerRepository)
        {
            _mapper = mapper;
            _unitOfWorkAsync = unitOfWorkAsync;
            _managerRepository = managerRepository;
        }

        public async Task<GetManagersLookupResponse> Handle(GetManagersLookupQuery request, CancellationToken cancellationToken)
        {
            var response = new GetManagersLookupResponse();
            var managersQuery = _managerRepository.Get();
            var managersLookupsQuery = managersQuery
                .ProjectTo<GetManagersListRespnseViewModel>(_mapper.ConfigurationProvider);

            response.Data = await managersLookupsQuery.ToListAsync(); ;
            return response;
        }
    }
}
