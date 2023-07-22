using BookingProject.Core.Bases;
using BookingProject.Core.Features.Customers.Queries.Results;
using BookingProject.Data.Entities;
using MediatR;
using Microsoft.AspNetCore.Http.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Core.Features.Customers.Queries.Models
{
    public class GetCustomerListQuery : IRequest<Response<List<GetCustomerListResponse>>>
    {

    }
}
