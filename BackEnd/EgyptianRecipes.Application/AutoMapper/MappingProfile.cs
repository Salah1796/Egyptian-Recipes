using AutoMapper;
using EgyptianRecipes.Application.Common.Responses;
using EgyptianRecipes.Application.Features.Branchs.Commands.CreateBranch;
using EgyptianRecipes.Application.Features.Branchs.Commands.UpdateBranch;
using EgyptianRecipes.Application.Features.Branchs.Queries.GetBranchesList;
using EgyptianRecipes.Application.Models.ViewModels.Branch;
using EgyptianRecipes.Domain.Entities;
using MinistryOfHealthService.Core.Models.ViewModels;

namespace EgyptianRecipes.Application.AutoMapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {

            CreateMap<Branch, CreateBranchResponseViewModel>();
            CreateMap<CreateBranchCommand, Branch>();
            CreateMap<Branch, GetBranchesListRespnseViewModel>();

            CreateMap<BranchSearchModel, GetBranchesListQuery>();
            CreateMap<GetBranchesListRespnseViewModel, BrandLightViewModel>();


            CreateMap<BranchCreateViewModel, CreateBranchCommand>();
            CreateMap<CreateBranchResponseViewModel, BranchViewModel>();

            CreateMap<Branch, UpdateBranchResponseViewModel>();
            CreateMap<BranchEditViewModel, UpdateBranchCommand>();
            CreateMap<UpdateBranchCommand, Branch>();
            CreateMap<UpdateBranchResponseViewModel, BranchViewModel>();
            CreateMap<UpdateBranchCommandResponse, BaseResponse<BranchViewModel>>();

        }
    }
}
