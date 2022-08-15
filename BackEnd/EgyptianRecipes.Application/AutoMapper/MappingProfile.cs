using AutoMapper;
using EgyptianRecipes.Application.Common.Responses;
using EgyptianRecipes.Application.Features.Branchs.Commands.BranchReservation;
using EgyptianRecipes.Application.Features.Branchs.Commands.CreateBranch;
using EgyptianRecipes.Application.Features.Branchs.Commands.CreateManager;
using EgyptianRecipes.Application.Features.Branchs.Commands.UpdateBranch;
using EgyptianRecipes.Application.Features.Branchs.Queries.GetBranchesList;
using EgyptianRecipes.Application.Features.Manger.Queries.GetManagersLookup;
using EgyptianRecipes.Application.Models.ViewModels.Branch;
using EgyptianRecipes.Application.Models.ViewModels.BranchReservation;
using EgyptianRecipes.Application.Models.ViewModels.Manager;
using EgyptianRecipes.Domain.Entities;
using EgyptianRecipes.Application.Models.ViewModels;
using System.Collections.Generic;

namespace EgyptianRecipes.Application.AutoMapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {

            #region Branch

            #region Create
            CreateMap<BranchCreateViewModel, CreateBranchCommand>();
            CreateMap<CreateBranchCommand, Branch>();
            CreateMap<Branch, CreateBranchResponseViewModel>();
            CreateMap<CreateBranchResponseViewModel, BranchViewModel>();
            CreateMap<CreateBranchCommandResponse, BaseResponse<BranchViewModel>>();

            #endregion

            #region Update
            CreateMap<BranchEditViewModel, UpdateBranchCommand>();
            CreateMap<UpdateBranchCommand, Branch>();
            CreateMap<Branch, UpdateBranchResponseViewModel>();
            CreateMap<UpdateBranchResponseViewModel, BranchViewModel>();
            CreateMap<UpdateBranchCommandResponse, BaseResponse<BranchViewModel>>();
            #endregion

            #region Search
            CreateMap<BranchSearchModel, GetBranchesListQuery>();
            CreateMap<Branch, GetBranchesListRespnseViewModel>()
                .ForMember(x=>x.ManagerName , op => op.MapFrom(x=>x.Manager.Name));
            CreateMap<GetBranchesListRespnseViewModel, BranchLightViewModel>();
            CreateMap<GetBranchesListResponse, BasePaginatedResponse<List<BranchLightViewModel>>>();
            #endregion

            #region Reservation
            CreateMap<BranchReservationCreateViewModel, BranchReservationCommand>();
            CreateMap<BranchReservationCommand, BranchReservation>();
            CreateMap<BranchReservation, BranchReservationResponseViewModel>();
            CreateMap<BranchReservationResponseViewModel, BranchReservationViewModel>();
            CreateMap<BranchReservationCommandResponse, BaseResponse<BranchReservationViewModel>>();

            #endregion
            #endregion




            #region Manager
            #region Create
            CreateMap<ManagerCreateViewModel, CreateManagerCommand>();
            CreateMap<CreateManagerCommand, Manager>();
            CreateMap<Manager, CreateManagerResponseViewModel>();
            CreateMap<CreateManagerResponseViewModel, ManagerViewModel>();
            CreateMap<CreateManagerCommandResponse, BaseResponse<ManagerViewModel>>();

            #endregion
            #region Lookup
            CreateMap<ManagerSearchModel, GetManagersLookupQuery>();
            CreateMap<Manager, GetManagersListRespnseViewModel>();
            CreateMap<GetManagersListRespnseViewModel, ManagerLookupViewModel>();
            CreateMap<GetManagersLookupResponse, BaseResponse<List<ManagerLookupViewModel>>>();
            #endregion

            #endregion

        }
    }
}
