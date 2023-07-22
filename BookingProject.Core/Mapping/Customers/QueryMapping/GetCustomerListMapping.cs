using BookingProject.Core.Features.Customers.Queries.Results;
using BookingProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Core.Mapping.Customers
{
	public partial class CustomerProfile
	{
        public void GetCustomerListMapping()
        {
			
				CreateMap<Customer, GetCustomerListResponse>();

			
		}
	}
    
}
