using AutoMapper;
using BookingProject.Core.Bases;
using BookingProject.Core.Features.Customers.Commands.Models;
using BookingProject.Core.Features.Reservations.Commands.Models;
using BookingProject.Data.Entities;
using BookingProject.Service.Abstracts;
using BookingProject.Service.Implementations;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Core.Features.Reservations.Commands.Handlers
{
	internal class ReservationCommandHandler : ResponseHandler, IRequestHandler<AddReservationCommand, Response<String>>,
		IRequestHandler<EditReservationCommand, Response<String>>,
				IRequestHandler<DeleteReservationCommand, Response<String>>
	{

		#region Fields
		private readonly IReservationService _reservationService;
		private readonly IMapper _mapper;

		#endregion

		#region Constructors
		public ReservationCommandHandler(IReservationService reservationService, IMapper mapper)
		{
			_reservationService = reservationService;
			_mapper = mapper;

		}

		#endregion

		#region Handle Functions
		public async Task<Response<string>> Handle(EditReservationCommand request, CancellationToken cancellationToken)
		{
			//chec if id is exist 
			var reservation = await _reservationService.GetReservationByID(request.Id);
			if (reservation == null) return NotFound<string>("Reservation Is Not Found");

			//mapping between request /Reservation
			var reservationmapper = _mapper.Map<Reservation>(request);

			var result = await _reservationService.EditAsync(reservationmapper);

			if (result == "Success")
			{ return Success($"Edited Successfully{reservationmapper.Id}"); }
			else
				return BadRequest<string>();
			


		}

		public async Task<Response<string>> Handle(DeleteReservationCommand request, CancellationToken cancellationToken)
		{
			//chec if id is exist 
			var reservation = await _reservationService.GetReservationByID(request.Id);
			if (reservation == null) return NotFound<string>("Reservation Is Not Found");
			//call delete service
			var result = await _reservationService.DeleteAsync(reservation);
			if (result == "Success")
			{ return Deleted<string>($"Deleted Successfully{request.Id}"); }
			else
				return BadRequest<string>();
		}

		public async Task<Response<string>> Handle(AddReservationCommand request, CancellationToken cancellationToken)
		{
			//mapping between request / Reservation
			var reservationmapper = _mapper.Map<Reservation>(request);

			//add
			var result = await _reservationService.AddAsync(reservationmapper);

			if (result == "Success")
			{ return Created("Added Successfully"); }
			else
				return BadRequest<string>();
		}
		#endregion
	}
}
