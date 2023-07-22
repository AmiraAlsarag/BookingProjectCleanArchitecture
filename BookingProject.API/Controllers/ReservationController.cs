using BookingProject.API.Base;
using BookingProject.Core.Features.Customers.Commands.Models;
using BookingProject.API.Base;
using BookingProject.Core.Features.Reservations.Commands.Models;
using BookingProject.Core.Features.Reservations.Queries.Models;
using BookingProject.Data.AppMetaData;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using BookingProject.Core.Features.Customers.Queries.Models;

namespace BookingProject.API.Controllers
{
	[ApiController]
	public class ReservationController : AppControllerBase
	{
		//Get all Reservations

		[HttpGet(Router.ReservationRouting.List)]
		public async Task<IActionResult> GetReservationList()
		{
			var response = await Mediator.Send(new GetReservationListQuery());
			return Ok(response);
		}

		//Get by id
		[HttpGet(Router.ReservationRouting.GetByID)]
		public async Task<IActionResult> GetReservationByID([FromRoute] int id)
		{
			var response = await Mediator.Send(new GetReservationByIDQuery(id));
			return NewResult(response);
		}

		
		//Add New Reservation
		[HttpPost(Router.ReservationRouting.Create)]
		public async Task<IActionResult> Create([FromBody] AddReservationCommand command)
		{
			var response = await Mediator.Send(command);
			return NewResult(response);
		}
		//Edit Reservation
		[HttpPut(Router.ReservationRouting.Edit)]
		public async Task<IActionResult> Edit([FromBody] EditReservationCommand command)
		{
			var response = await Mediator.Send(command);
			return NewResult(response);
		}
		//DeleteReservation
		[HttpDelete(Router.ReservationRouting.Delete)]
		public async Task<IActionResult> Delete([FromRoute] int id)
		{
			return NewResult(await Mediator.Send(new DeleteReservationCommand(id)));
		}

	}
}
