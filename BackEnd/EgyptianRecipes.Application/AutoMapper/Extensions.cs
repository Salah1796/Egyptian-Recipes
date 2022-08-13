using AutoMapper;
using EgyptianRecipes.Application.Common.Responses;
using EgyptianRecipes.Application.Features.Branchs.Commands.CreateBranch;
using EgyptianRecipes.Application.Features.Branchs.Commands.UpdateBranch;
using EgyptianRecipes.Application.Features.Branchs.Queries.GetBranchesList;
using EgyptianRecipes.Application.Models.ViewModels.Branch;
using EgyptianRecipes.Domain.Entities;
using MinistryOfHealthService.Core.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EgyptianRecipes.Application.AutoMapper
{
    public static class Extensions
    {
        #region Branch
        public static CreateBranchResponseViewModel ToCreateResponseViewModel(this Branch entity, IMapper mapper)
        {
            var result = mapper.Map<Branch, CreateBranchResponseViewModel>(entity);
            return result;
        }
        public static Branch ToModel(this CreateBranchCommand entity, IMapper mapper)
        {
            var result = mapper.Map<CreateBranchCommand, Branch>(entity);
            return result;
        }
        public static UpdateBranchResponseViewModel ToUpdateResponseViewModel(this Branch entity, IMapper mapper)
        {
            var result = mapper.Map<Branch, UpdateBranchResponseViewModel>(entity);
            return result;
        }
        public static Branch ToModel(this UpdateBranchCommand entity, IMapper mapper)
        {
            var result = mapper.Map<UpdateBranchCommand, Branch>(entity);
            return result;
        }

        public static GetBranchesListQuery ToBranchesListQuery(this BranchSearchModel entity, IMapper mapper)
        {
            var result = mapper.Map<BranchSearchModel, GetBranchesListQuery>(entity);
            return result;
        }

        public static BrandLightViewModel ToBrancheLightViewModel(this GetBranchesListRespnseViewModel entity, IMapper mapper)
        {
            var result = mapper.Map<GetBranchesListRespnseViewModel, BrandLightViewModel>(entity);
            return result;
        }

        public static CreateBranchCommand ToBranchCreateCommand(this BranchCreateViewModel entity, IMapper mapper)
        {
            var result = mapper.Map<BranchCreateViewModel, CreateBranchCommand>(entity);
            return result;
        }
        public static BranchViewModel ToBranchViewModel(this CreateBranchResponseViewModel entity, IMapper mapper)
        {
            var result = mapper.Map<CreateBranchResponseViewModel, BranchViewModel>(entity);
            return result;
        }


        public static UpdateBranchCommand ToBranchUpdateCommand(this BranchEditViewModel entity, IMapper mapper)
        {
            var result = mapper.Map<BranchEditViewModel, UpdateBranchCommand>(entity);
            return result;
        }
        public static BranchViewModel ToBranchViewModel(this UpdateBranchResponseViewModel entity, IMapper mapper)
        {
            var result = mapper.Map<UpdateBranchResponseViewModel, BranchViewModel>(entity);
            return result;
        }

        public static BaseResponse<BranchViewModel> ToBaseResponse(this UpdateBranchCommandResponse entity, IMapper mapper)
        {
            var result = mapper.Map<UpdateBranchCommandResponse, BaseResponse<BranchViewModel>>(entity);
            return result;
        }
        #endregion

    }
}
