using BookingProject.Core.Bases;
using BookingProject.Core.Features.Customers.Queries.Results;
using BookingProject.Data.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Core.Features.Customers.Queries.Models
{
	public class GetCustomerByIDQuery : IRequest<Response<GetSingleCustomerResponse>> 
	{
        public int Id { get; set; }
        public GetCustomerByIDQuery(int ID)
        {
            Id = ID;
            
        }
    }
}
