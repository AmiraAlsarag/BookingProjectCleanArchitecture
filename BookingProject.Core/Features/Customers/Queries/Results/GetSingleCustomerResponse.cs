using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Core.Features.Customers.Queries.Results
{
	public class GetSingleCustomerResponse
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Phone { get; set; }
	}
}
