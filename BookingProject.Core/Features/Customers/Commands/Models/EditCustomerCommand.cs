
using BookingProject.Core.Bases;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Core.Features.Customers.Commands.Models
{
	public class EditCustomerCommand: IRequest<Response<string>>
	{
        public int Id { get; set; }
        public string Name { get; set; }
		public string Phone { get; set; }
	}
}
