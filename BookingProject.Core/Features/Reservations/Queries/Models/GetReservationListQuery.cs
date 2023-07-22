using BookingProject.Core.Bases;
using BookingProject.Core.Features.Reservations.Queries.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Core.Features.Reservations.Queries.Models
{
	public class GetReservationListQuery: IRequest<Response<List<GetReservationListResponse>>>
	{
	}
}
