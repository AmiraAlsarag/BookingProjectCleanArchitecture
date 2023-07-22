using AutoMapper;
using BookingProject.Core.Bases;
using BookingProject.Core.Features.Customers.Commands.Models;
using BookingProject.Data.Entities;
using BookingProject.Service.Abstracts;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Core.Features.Customers.Commands.Handlers
{
	public class CustomerCommandHandler : ResponseHandler, IRequestHandler<AddCustomerCommand, Response<String>>,
		IRequestHandler<EditCustomerCommand, Response<String>>,
				IRequestHandler<DeleteCustomerCommand, Response<String>>


	{
		#region Fields
		private readonly ICustomerService _customerService;
		private readonly IMapper _mapper;

		#endregion

		#region Constructors
		public CustomerCommandHandler(ICustomerService customerService, IMapper mapper)
		{
			_customerService = customerService;
			_mapper = mapper;

		}

		#endregion

		#region Handle Functions

		public async Task<Response<string>> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
		{
			//mapping between request / Customer
			var customermapper = _mapper.Map<Customer>(request);

			//add
			var result = await _customerService.AddAsync(customermapper);

            if (result == "Success")
			{ return Created("Added Successfully"); }
			else
				return BadRequest<string>();

				
		}

		public async Task<Response<string>> Handle(EditCustomerCommand request, CancellationToken cancellationToken)
		{
			//chec if id is exist 
			var customer = await _customerService.GetCustomerByIDAsync(request.Id);
			if (customer == null) return NotFound<string>("Customer Is Not Found");

			//mapping between request / Customer
			var customermapper = _mapper.Map<Customer>(request);

			var result = await _customerService.EditAsync(customermapper);

			if (result == "Success")
			{ return Success($"Edited Successfully{customermapper.Id}"); }
			else
				return BadRequest<string>();



		}

		public async Task<Response<string>> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
		{

			//chec if id is exist 
			var customer = await _customerService.GetCustomerByIDAsync(request.Id);
			if (customer == null) return NotFound<string>("Customer Is Not Found");
			//call delete service
			var result = await _customerService.DeleteAsync(customer);
			if (result == "Success")
			{ return Deleted<string>($"Deleted Successfully{request.Id}"); }
			else
				return BadRequest<string>();
		}
		#endregion

	}
}
