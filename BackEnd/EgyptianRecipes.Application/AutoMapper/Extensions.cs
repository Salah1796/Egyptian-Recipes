using AutoMapper;
using EgyptianRecipes.Application.Common.Responses;
using EgyptianRecipes.Application.Features.Branchs.Commands.BranchReservation;
using EgyptianRecipes.Application.Features.Branchs.Commands.CreateBranch;
using EgyptianRecipes.Application.Features.Branchs.Commands.CreateManager;
using EgyptianRecipes.Application.Features.Branchs.Commands.UpdateBranch;
using EgyptianRecipes.Application.Features.Branchs.Queries.GetBranchesList;
using EgyptianRecipes.Application.Features.Manger.Queries.GetManagersLookup;
using EgyptianRecipes.Application.Models.ViewModels.Branch;
using EgyptianRecipes.Application.Models.ViewModels.Manager;
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

        public static BranchLightViewModel ToBrancheLightViewModel(this GetBranchesListRespnseViewModel entity, IMapper mapper)
        {
            var result = mapper.Map<GetBranchesListRespnseViewModel, BranchLightViewModel>(entity);
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

        public static BaseResponse<T> ToBaseResponse<T>(this UpdateBranchCommandResponse entity, IMapper mapper)
        {
            var result = mapper.Map<UpdateBranchCommandResponse, BaseResponse<T>>(entity);
            return result;
        }
        public static BaseResponse<T> ToBaseResponse<T>(this CreateBranchCommandResponse entity, IMapper mapper)
        {
            var result = mapper.Map<CreateBranchCommandResponse, BaseResponse<T>>(entity);
            return result;
        }

        public static BasePaginatedResponse<T> BasePaginatedResponse<T>(this GetBranchesListResponse entity, IMapper mapper)
        {
            var result = mapper.Map<GetBranchesListResponse, BasePaginatedResponse<T>>(entity);
            return result;
        }

        public static BranchReservationCommand ToBranchReservationViewModel(this BranchReservationViewModel entity, IMapper mapper)
        {
            var result = mapper.Map<BranchReservationViewModel, BranchReservationCommand>(entity);
            return result;
        }

        #endregion


        #region Manager
        public static CreateManagerResponseViewModel ToCreateResponseViewModel(this Manager entity, IMapper mapper)
        {
            var result = mapper.Map<Manager, CreateManagerResponseViewModel>(entity);
            return result;
        }
        public static Manager ToModel(this CreateManagerCommand entity, IMapper mapper)
        {
            var result = mapper.Map<CreateManagerCommand, Manager>(entity);
            return result;
        }
       
     

        public static GetManagersLookupQuery ToManageresListQuery(this ManagerSearchModel entity, IMapper mapper)
        {
            var result = mapper.Map<ManagerSearchModel, GetManagersLookupQuery>(entity);
            return result;
        }

        public static ManagerLookupViewModel ToManagereLookupViewModel(this GetManagersListRespnseViewModel entity, IMapper mapper)
        {
            var result = mapper.Map<GetManagersListRespnseViewModel, ManagerLookupViewModel>(entity);
            return result;
        }

        public static CreateManagerCommand ToManagerCreateCommand(this ManagerCreateViewModel entity, IMapper mapper)
        {
            var result = mapper.Map<ManagerCreateViewModel, CreateManagerCommand>(entity);
            return result;
        }
        public static ManagerViewModel ToManagerViewModel(this CreateManagerResponseViewModel entity, IMapper mapper)
        {
            var result = mapper.Map<CreateManagerResponseViewModel, ManagerViewModel>(entity);
            return result;
        }
        public static BaseResponse<T> ToBaseResponse<T>(this CreateManagerCommandResponse entity, IMapper mapper)
        {
            var result = mapper.Map<CreateManagerCommandResponse, BaseResponse<T>>(entity);
            return result;
        }

        public static BaseResponse<T> ToBaseResponse<T>(this GetManagersLookupResponse entity, IMapper mapper)
        {
            var result = mapper.Map<GetManagersLookupResponse, BaseResponse<T>>(entity);
            return result;
        }
        #endregion

    }
}
