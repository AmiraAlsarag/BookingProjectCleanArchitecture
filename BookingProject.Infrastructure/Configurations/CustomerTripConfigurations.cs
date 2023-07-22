using BookingProject.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection.Emit;

namespace BookingProject.Infrastructure.Configurations
{
	public class CustomerTripConfigurations : IEntityTypeConfiguration<CustomerTrip>
	{
		public void Configure(EntityTypeBuilder<CustomerTrip> builder)
		{
/*
	builder.HasMany<Customer>(g => g.Customers)
	.WithOne(s => s.CustomerTrips)
	.HasForeignKey(s => s.CurrentGradeId)
	.OnDelete(DeleteBehavior.Cascade);
*/
		}
	}
}
