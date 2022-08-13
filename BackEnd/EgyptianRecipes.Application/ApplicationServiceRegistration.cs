using AutoMapper;
using EgyptianRecipes.Application.Features.Branchs.Commands.BranchReservation;
using EgyptianRecipes.Application.Features.Branchs.Commands.CreateBranch;
using EgyptianRecipes.Application.Features.Branchs.Commands.CreateManager;
using EgyptianRecipes.Application.Features.Branchs.Commands.UpdateBranch;
using EgyptianRecipes.Application.Validation.Branch;
using EgyptianRecipes.Application.Validation.BranchReservation;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace EgyptianRecipes.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddScoped<IValidator<CreateBranchCommand>, CreateBranchCommandValidator>();
            services.AddScoped<IValidator<UpdateBranchCommand>, UpdateBranchCommandValidator>();
            services.AddScoped<IValidator<CreateManagerCommand>, CreateManagerCommandValidator>();
            services.AddScoped<IValidator<BranchReservationCommand>, BranchReservationCommandValidator>();

            return services;
        }
    }
}
