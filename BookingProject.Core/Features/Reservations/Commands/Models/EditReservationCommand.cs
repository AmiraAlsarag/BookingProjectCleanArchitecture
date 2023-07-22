using BookingProject.Core.Bases;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Core.Features.Reservations.Commands.Models
{
	public class EditReservationCommand : IRequest<Response<string>>
	{
		public int Id { get; set; }
		public int TripId { get; set; }

		public int ReservedBy { get; set; }
		public int CustomerId { get; set; }
		public string Notes { get; set; }
		public DateTime ReservationDate { get; set; }
		public DateTime CreationDate { get; set; }

	}
}
