using AutoMapper;
using BookingProject.Core.Bases;
using BookingProject.Core.Features.Customers.Queries.Models;
using BookingProject.Core.Features.Customers.Queries.Results;
using BookingProject.Core.Features.Reservations.Queries.Models;
using BookingProject.Core.Features.Reservations.Queries.Results;
using BookingProject.Service.Abstracts;
using BookingProject.Service.Implementations;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Core.Features.Reservations.Queries.Handlers
{
	public class ReservationQueryHandler : ResponseHandler, IRequestHandler<GetReservationByIDQuery, Response<GetReservationByIDResponse>>,
		 IRequestHandler<GetReservationListQuery, Response<List<GetReservationListResponse>>>

	{
		#region Fields
		private readonly IReservationService _reservationService;
		private readonly IMapper _mapper;

		#endregion

		#region Constructors
		public ReservationQueryHandler(IReservationService reservationService, IMapper mapper)
		{
			_reservationService = reservationService;
			_mapper = mapper;

		}
		#endregion
		public async Task<Response<GetReservationByIDResponse>> Handle(GetReservationByIDQuery request, CancellationToken cancellationToken)
		{
			var reservation = await _reservationService.GetReservationByID(request.Id);

			if (reservation == null) return NotFound<GetReservationByIDResponse>("Object");
			var result = _mapper.Map<GetReservationByIDResponse>(reservation);
			return Success(result);
			
		}

		public async Task<Response<List<GetReservationListResponse>>> Handle(GetReservationListQuery request, CancellationToken cancellationToken)
		{
			var reservationList = await _reservationService.GetReservationsListAsync();
			var reservationListMapper = _mapper.Map<List<GetReservationListResponse>>(reservationList);
			return Success(reservationListMapper);
		}
	}
}
