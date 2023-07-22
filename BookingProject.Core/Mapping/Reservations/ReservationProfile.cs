using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Core.Mapping.Reservations
{
	public partial class ReservationProfile : Profile
	{
		public ReservationProfile()
		{
			GetReservationListMapping();
			GetReservationByIDMapping();
			AddReservationCommandMapping();
			EditReservationCommandMapping();


		}
	}
}
