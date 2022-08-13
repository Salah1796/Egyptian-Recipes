using AutoMapper;
using EgyptianRecipes.Application.AutoMapper;
using EgyptianRecipes.Application.Common.Responses;
using EgyptianRecipes.Application.Features.Branchs.Queries.GetBranchesList;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using MinistryOfHealthService.Core.Models.ViewModels;

namespace EgyptianRecipes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {

        #region Data Members
        private readonly IMediator _mediator;
        private readonly ILogger<BranchController> _logger;
        private readonly IMapper _mapper;
        #endregion

        public BranchController(ILogger<BranchController> logger, IMediator mediator, IMapper mapper)
        {
            _logger = logger;
            _mediator = mediator;
            _mapper = mapper;
        }

        [Route("Get")]
        [HttpPost]
        public async Task<BasePaginatedResponse<List<BrandLightViewModel>>> Get(BranchSearchModel branchSearchModel)
        {
            var result = new BasePaginatedResponse<List<BrandLightViewModel>>();
            var branchesListQuery = branchSearchModel.ToBranchesListQuery(_mapper);
            if (branchesListQuery != null)
            {
                var response = await _mediator.Send(branchesListQuery);
                result = new BasePaginatedResponse<List<BrandLightViewModel>>()
                {
                    Pagination = response.Pagination,
                    Code = response.Code,
                    Data = response.Data.Select(e => e.ToBrancheLightViewModel(_mapper)).ToList(),
                    Message = response.Message,
                    Success = response.Success,
                    ValidationErrors = response.ValidationErrors
                };
            }
            return result;
        }

        [Route("Add")]
        [HttpPost]
        public async Task<BaseResponse<BranchViewModel>> Add(BranchCreateViewModel branchCreateViewModel)
        {
            var result = new BaseResponse<BranchViewModel>();
            var branchCreateCommand = branchCreateViewModel.ToBranchCreateCommand(_mapper);
            if (branchCreateCommand != null)
            {
                var response = await _mediator.Send(branchCreateCommand);
                result = new BaseResponse<BranchViewModel>()
                {
                    Code = response.Code,
                    Data = response.Data?.ToBranchViewModel(_mapper),
                    Message = response.Message,
                    Success = response.Success,
                    ValidationErrors = response.ValidationErrors
                };
            }
            return result;
        }

        [Route("Update")]
        [HttpPost]
        public async Task<BaseResponse<BranchViewModel>> Update(BranchEditViewModel branchCreateViewModel)
        {
            var result = new BaseResponse<BranchViewModel>();
            var branchUpdateCommand = branchCreateViewModel.ToBranchUpdateCommand(_mapper);
            if (branchUpdateCommand != null)
            {
                var response = await _mediator.Send(branchUpdateCommand);
                result = response.ToBaseResponse(_mapper);
                //result = new BaseResponse<BranchViewModel>()
                //{
                //    Code = response.Code,
                //    Data = response.Data?.ToBranchViewModel(_mapper),
                //    Message = response.Message,
                //    Success = response.Success,
                //    ValidationErrors = response.ValidationErrors
                //};
            }
            return result;
        }
    }
}
    
