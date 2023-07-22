using BookingProject.Data.Entities;
using BookingProject.Infrastructure.InfrastructureBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Infrastructure.Abstracts
{
	public interface ICustomerRepository :IGenericRepositoryAsync<Customer>
	{
		public Task<List<Customer>>GetCustomersListAsync();

	}
}
