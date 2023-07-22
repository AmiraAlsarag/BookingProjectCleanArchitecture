using AutoMapper;
using BookingProject.Core.Features.Customers.Commands.Models;
using BookingProject.Core.Features.Customers.Queries.Results;
using BookingProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Core.Mapping.Customers
{
	public partial class CustomerProfile : Profile
	{
		public void AddCustomerCommandMapping()
		{

			CreateMap<AddCustomerCommand,Customer>();


		}


	}
}
