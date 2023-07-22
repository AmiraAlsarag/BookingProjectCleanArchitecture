
using BookingProject.Core.Bases;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Core.Features.Customers.Commands.Models
{
	public class DeleteCustomerCommand:IRequest<Response<string>>
	{
		public int Id { get; set;}
        public DeleteCustomerCommand(int id)
        {
            Id = id;
            
        }
    }
}
