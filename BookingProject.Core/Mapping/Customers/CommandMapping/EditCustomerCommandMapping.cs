using AutoMapper;
using BookingProject.Core.Features.Customers.Commands.Models;
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
		public void EditCustomerCommandMapping()
		{
			CreateMap<EditCustomerCommand, Customer>()
				.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
		}

	}
}
