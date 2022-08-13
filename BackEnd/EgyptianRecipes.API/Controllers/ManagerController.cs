using AutoMapper;
using EgyptianRecipes.Application.AutoMapper;
using EgyptianRecipes.Application.Common.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using MinistryOfHealthService.Core.Models.ViewModels;

namespace EgyptianRecipes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {

        #region Data Members
        private readonly IMediator _mediator;
        private readonly ILogger<ManagerController> _logger;
        private readonly IMapper _mapper;
        #endregion

        public ManagerController(ILogger<ManagerController> logger, IMediator mediator, IMapper mapper)
        {
            _logger = logger;
            _mediator = mediator;
            _mapper = mapper;
        }

        [Route("Get")]
        [HttpPost]
        public async Task<BaseResponse<List<ManagerLookupViewModel>>> Get(ManagerSearchModel ManagerSearchModel)
        {
            var result = new BaseResponse<List<ManagerLookupViewModel>>();
            var ManageresListQuery = ManagerSearchModel.ToManageresListQuery(_mapper);
            if (ManageresListQuery != null)
            {
                var response = await _mediator.Send(ManageresListQuery);
                result = response.ToBaseResponse<List<ManagerLookupViewModel>>(_mapper);
            }
            return result;
        }

        [Route("Add")]
        [HttpPost]
        public async Task<BaseResponse<ManagerViewModel>> Add(ManagerCreateViewModel ManagerCreateViewModel)
        {
            var result = new BaseResponse<ManagerViewModel>();
            var ManagerCreateCommand = ManagerCreateViewModel.ToManagerCreateCommand(_mapper);
            if (ManagerCreateCommand != null)
            {
                var response = await _mediator.Send(ManagerCreateCommand);
                result = response.ToBaseResponse<ManagerViewModel>(_mapper);
            }
            return result;
        }
    }
}
    
