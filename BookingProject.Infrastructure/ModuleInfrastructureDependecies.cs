
using BookingProject.Infrastructure.Abstracts;
using BookingProject.Infrastructure.InfrastructureBases;
using BookingProject.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
namespace BookingProject.Infrastructure
{
	public static class ModuleInfrastructureDependecies
	{
		public static IServiceCollection AddInfrastructureDependecies(this IServiceCollection services)
		{
			services.AddTransient<ICustomerRepository, CustomerRepository>();
			services.AddTransient<IReservationRepository, ReservationRepository>();

			services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
			return services;
		}
	}
}