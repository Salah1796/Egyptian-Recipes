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

namespace EgyptianRecipes.Application.Features.Branchs.Queries.GetBranchesList
{
    public class GetBranchsListQueryHandler : IRequestHandler<GetBranchesListQuery, GetBranchesListResponse>
    {
        private readonly IBranchRepository _branchRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWorkAsync _unitOfWorkAsync;

        public GetBranchsListQueryHandler(IMapper mapper, IBranchRepository branchRepository, IUnitOfWorkAsync unitOfWorkAsync)
        {
            _mapper = mapper;
            _branchRepository = branchRepository;
            _unitOfWorkAsync = unitOfWorkAsync;
        }

        public async Task<GetBranchesListResponse> Handle(GetBranchesListQuery request, CancellationToken cancellationToken)
        {
            var response = new GetBranchesListResponse();

            var validator = new GetBranchesListQueryValidator();
            var validationResult = await validator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                response.Success = false;
                response.ValidationErrors = validationResult.Errors.Select(x => x.ErrorMessage).ToList();

            }
            else
            {
                var branchesQuery = _branchRepository.Get();

                #region Pagination & Sorting
                request.Pagination = await this._branchRepository.SetPaginationCount(branchesQuery, request.Pagination);
                branchesQuery = _branchRepository.SetPagination(branchesQuery, request.Pagination);
                branchesQuery = this._branchRepository.SetSortOrder(branchesQuery, request.Sorting);
                #endregion

                #region Build Query
                if (!string.IsNullOrEmpty(request.Title))
                {
                    branchesQuery = branchesQuery.Where(br => br.Title.Contains(request.Title));
                }
                if (!string.IsNullOrEmpty(request.ManagerName))
                {
                    branchesQuery = branchesQuery.Where(br => br.ManagerName.Contains(request.ManagerName));
                }
                if (request.FromClosingHour.HasValue)
                {
                    branchesQuery = branchesQuery.Where(br => br.OpeningHour >= request.FromOpeningHour);
                }
                if (request.ToOpeningHour.HasValue)
                {
                    branchesQuery = branchesQuery.Where(br => br.OpeningHour <= request.ToOpeningHour);
                }
                if (request.FromClosingHour.HasValue)
                {
                    branchesQuery = branchesQuery.Where(br => br.ClosingHour >= request.FromClosingHour);
                }
                if (request.ToClosingHour.HasValue)
                {
                    branchesQuery = branchesQuery.Where(br => br.ClosingHour <= request.ToClosingHour);
                }
                #endregion

                var BranchesList = await branchesQuery
                    .ProjectTo<GetBranchesListRespnseViewModel>(_mapper.ConfigurationProvider)
                    .ToListAsync();

                response.Data = BranchesList;
                response.Pagination = request.Pagination;
            }
            return response;
        }
    }
}
