using AutoMapper;
using BookingProject.Core.Bases;
using BookingProject.Core.Features.Customers.Queries.Models;
using BookingProject.Core.Features.Customers.Queries.Results;
using BookingProject.Data.Entities;
using BookingProject.Service.Abstracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Core.Features.Customers.Queries.Handlers
{
	public class CustomerQueryHandler :ResponseHandler, IRequestHandler<GetCustomerListQuery,Response<List<GetCustomerListResponse>>>
		, IRequestHandler<GetCustomerByIDQuery, Response<GetSingleCustomerResponse>>
	{
		#region Fields
		private readonly ICustomerService _customerService;
		private readonly IMapper _mapper;

		#endregion

		#region Constructors
		public CustomerQueryHandler(ICustomerService customerService, IMapper mapper)
        {
            _customerService=customerService;
			_mapper=mapper;
            
        }
        #endregion

        #region Handle Functions

        #endregion
        public async Task<Response<List<GetCustomerListResponse>>> Handle(GetCustomerListQuery request, CancellationToken cancellationToken)
		{
			var customerList= await _customerService.GetCustomersListAsync();
			var customerListMapper = _mapper.Map<List<GetCustomerListResponse>>(customerList);
			return Success(customerListMapper);
		}

		public async Task<Response<GetSingleCustomerResponse>> Handle(GetCustomerByIDQuery request, CancellationToken cancellationToken)
		{
			var customer = await _customerService.GetCustomerByIDAsync(request.Id);

			if (customer == null) return NotFound<GetSingleCustomerResponse>("Object");
			var result = _mapper.Map<GetSingleCustomerResponse>(customer);
			return Success(result);
		}
	}
}
