using BookingProject.Data.Entities;
using BookingProject.Infrastructure.Abstracts;
using BookingProject.Infrastructure.Data;
using BookingProject.Infrastructure.InfrastructureBases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Infrastructure.Repositories
{
	public class ReservationRepository : GenericRepositoryAsync<Reservation>, IReservationRepository
	{
		#region Fields
		private readonly DbSet<Reservation> _reservations;
		#endregion

		#region Constructors
		public ReservationRepository(ApplicationDBContext dbContext) : base(dbContext)
		{
			_reservations= dbContext.Set<Reservation>();

		}



		#endregion

		#region Handle Functions
		public async Task<List<Reservation>> GetReservationsListAsync()
		{
			return await _reservations.ToListAsync();
		}



		#endregion
	}
}
