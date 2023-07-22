using Azure.Core;
using BookingProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Service.Abstracts
{
	public interface ICustomerService
	{
		public Task<List<Customer>>GetCustomersListAsync();
		public Task<Customer> GetCustomerByIDAsync(int id);
		public Task<String>AddAsync(Customer customer);
		public Task<bool> IsNameExist(string name);
		public Task<bool> IsNameExistExcludeSelf(string name,int id);
		public Task<String> EditAsync(Customer customer);
		public Task <string>DeleteAsync(Customer customer);





	}
}
