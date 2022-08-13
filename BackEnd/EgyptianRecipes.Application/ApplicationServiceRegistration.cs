using AutoMapper;
using EgyptianRecipes.Application.Features.Branchs.Commands.CreateBranch;
using EgyptianRecipes.Application.Features.Branchs.Commands.UpdateBranch;
using EgyptianRecipes.Application.Validation.Branch;
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


            return services;
        }
    }
}
