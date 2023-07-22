using AutoMapper;
using BookingProject.Core.Features.Customers.Commands.Models;
using BookingProject.Core.Features.Reservations.Commands.Models;
using BookingProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Core.Mapping.Reservations
{
	public partial class ReservationProfile : Profile
	{
		public void EditReservationCommandMapping()
		{
			CreateMap<EditReservationCommand, Reservation>()
				.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
		}
	}
}
