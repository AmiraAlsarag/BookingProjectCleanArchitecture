using BookingProject.Data.Entities;
using BookingProject.Infrastructure.Abstracts;
using BookingProject.Infrastructure.Data;
using BookingProject.Infrastructure.InfrastructureBases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Infrastructure.Repositories
{
	public class CustomerRepository :GenericRepositoryAsync<Customer>, ICustomerRepository
	{
		#region Fields
		private readonly DbSet<Customer> _customers;
		#endregion

		#region Constructors
		public CustomerRepository(ApplicationDBContext dBContext) :base(dBContext)
		{
			_customers = dBContext.Set<Customer>();
		}
		#endregion

		#region Handle Functions
		public async Task<List<Customer>> GetCustomersListAsync()
		{
			return await _customers.ToListAsync();

		}
		#endregion
	}
}
