using BookingProject.Infrastructure.Abstracts;
using BookingProject.Infrastructure.Repositories;
using BookingProject.Service.Abstracts;
using BookingProject.Service.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace BookingProject.Service
{
		public static class ModuleServiceDependecies
	{
		public static IServiceCollection AddServiceDependecies(this IServiceCollection services)
		{
			services.AddTransient<ICustomerService, CustomerService>();
			services.AddTransient<IReservationService, ReservationService>();

			return services;
		}
	}
}