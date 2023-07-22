using BookingProject.Core.Bases;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Core.Features.Reservations.Commands.Models
{
	public class DeleteReservationCommand : IRequest<Response<string>>
	{
		public int Id { get; set; }
		public DeleteReservationCommand(int id)
		{
			Id = id;

		}
	}
}
