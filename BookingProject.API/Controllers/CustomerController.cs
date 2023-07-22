using BookingProject.API.Base;
using BookingProject.Core.Features.Customers.Commands.Models;
using BookingProject.Core.Features.Customers.Queries.Models;
using BookingProject.Data.AppMetaData;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookingProject.API.Controllers
{
	[ApiController]
	public class CustomerController : AppControllerBase
	{
		
		//Get all customers

		[HttpGet(Router.CustomerRouting.List)]
		public async Task<IActionResult> GetCustomerList() 
		{
			var response = await Mediator.Send(new GetCustomerListQuery());
			return Ok(response);
		}
		//Get by id
		[HttpGet(Router.CustomerRouting.GetByID)]
		public async Task<IActionResult> GetCustomerByID([FromRoute]int id)
		{
			var response = await Mediator.Send(new GetCustomerByIDQuery(id));
			return NewResult(response);
		}
		//Add New Customer
		[HttpPost(Router.CustomerRouting.Create)]
		public async Task<IActionResult> Create([FromBody] AddCustomerCommand command)
		{
			var response = await Mediator.Send(command);
			return NewResult(response);
		}
		//Edit Customer
		[HttpPut(Router.CustomerRouting.Edit)]
		public async Task<IActionResult> Edit([FromBody] EditCustomerCommand command)
		{
			var response = await Mediator.Send(command);
			return NewResult(response);
		}
		//DeleteCustomer
		[HttpDelete(Router.CustomerRouting.Delete)]
		public async Task<IActionResult> Delete([FromRoute] int id)
		{
			return NewResult(await Mediator.Send(new DeleteCustomerCommand(id)));
		}
	}
}
