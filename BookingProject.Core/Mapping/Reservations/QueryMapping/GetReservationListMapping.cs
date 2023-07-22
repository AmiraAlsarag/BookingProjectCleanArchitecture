using AutoMapper;
using BookingProject.Core.Features.Reservations.Queries.Results;
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
		public void GetReservationListMapping()
		{

			CreateMap<Reservation, GetReservationListResponse>();


		}
	}
}
