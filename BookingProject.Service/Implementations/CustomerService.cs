using BookingProject.Data.Entities;
using BookingProject.Infrastructure.Abstracts;
using BookingProject.Service.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Service.Implementations
{
	public class CustomerService : ICustomerService
	{
		#region Fields
		private readonly ICustomerRepository _customerRepository;
		#endregion

		#region Constructors
		public CustomerService(ICustomerRepository customerRepository)
		{
			_customerRepository = customerRepository;
		}

		
		#endregion

		#region Handle Functions
		public async Task<List<Customer>> GetCustomersListAsync()
		{
			return await _customerRepository.GetCustomersListAsync();
		}
		public async Task<Customer> GetCustomerByIDAsync(int id)
		{
			var customer =  _customerRepository.GetTableNoTracking().Where(x => x.Id.Equals(id)).FirstOrDefault();
				return customer;
		}

		public async Task<string> AddAsync(Customer customer)
		{
			
			
			//Add Customer
			await _customerRepository.AddAsync(customer);
			return "Success";


		}

		public async Task<bool> IsNameExist(string name)
		{

			//check if name existed
			var customer = _customerRepository.GetTableNoTracking().Where(x => x.Name.Equals(name)).FirstOrDefault();
			if (customer == null)
			return false; 
			else
				return true;

		}

		public async Task<bool> IsNameExistExcludeSelf(string name, int id)
		{
			var customer =await _customerRepository.GetTableNoTracking().Where(x => x.Name.Equals(name)&!x.Id.Equals(id)).FirstOrDefaultAsync();
			if (customer == null)
				return false;
			else
				return true;
		}

		public async Task<string> EditAsync(Customer customer)
		{ 
			await _customerRepository.UpdateAsync(customer);
			return "Success";

		}

		public async Task<string> DeleteAsync(Customer customer)
		{
			var trans = _customerRepository.BeginTransaction();
			try
			{
				await _customerRepository.DeleteAsync(customer);
                await trans.CommitAsync();
				return "Success";

			}
			catch  { 
			await trans.RollbackAsync();
				return "Failed";
			}

		}
		#endregion



	}
}
