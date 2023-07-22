using BookingProject.Core.Behaviors;
using BookingProject.Service.Abstracts;
using BookingProject.Service.Implementations;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BookingProject.Core
{
	public static class ModuleCoreDependecies
	{
		public static IServiceCollection AddCoreDependecies(this IServiceCollection services)
		{
			//Configuration of Mediator
			services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
			//Configuration of AutoMapper
			services.AddAutoMapper(Assembly.GetExecutingAssembly());

			// Get Validators
			services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
			// 
			services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

			return services;
		}

	}
}