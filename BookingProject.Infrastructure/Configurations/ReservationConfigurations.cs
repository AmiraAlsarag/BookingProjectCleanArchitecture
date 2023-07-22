using BookingProject.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Infrastructure.Configurations
{
	public class ReservationConfigurations : IEntityTypeConfiguration<Reservation>
	{
		public void Configure(EntityTypeBuilder<Reservation> builder)
		{

			builder.HasKey(b => b.Id);
		}
	}
}
