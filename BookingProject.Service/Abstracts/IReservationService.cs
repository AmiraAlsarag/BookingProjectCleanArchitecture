using BookingProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Service.Abstracts
{
	public interface IReservationService
	{
		public Task<List<Reservation>> GetReservationsListAsync();
		public Task<Reservation> GetReservationByID(int id);
		public Task<String> AddAsync(Reservation reservation);
		
		public Task<String> EditAsync(Reservation reservation);
		public Task<string> DeleteAsync(Reservation reservation);


	}
}
