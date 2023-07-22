using BookingProject.Data.Entities;
using BookingProject.Infrastructure.Abstracts;
using BookingProject.Infrastructure.Repositories;
using BookingProject.Service.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Service.Implementations
{
	public class ReservationService : IReservationService
	{
		#region Fields
		private readonly IReservationRepository _reservationRepository;
		#endregion

		#region Constructors
		public ReservationService(IReservationRepository reservationRepository)
		{
			_reservationRepository = reservationRepository;
		}


		#endregion

		#region Handle Functions
		public async Task<string> AddAsync(Reservation reservation)
		{
			//Add reservation
			await _reservationRepository.AddAsync(reservation);
			return "Success";
		}

		

		public async Task<string> DeleteAsync(Reservation reservation)
		{
			var trans = _reservationRepository.BeginTransaction();
			try
			{
				await _reservationRepository.DeleteAsync(reservation);
				await trans.CommitAsync();
				return "Success";

			}
			catch
			{
				await trans.RollbackAsync();
				return "Failed";
			}
		}

	

		public async Task<string> EditAsync(Reservation reservation)
		{
			await _reservationRepository.UpdateAsync(reservation);
			return "Success";
		}
		


		public async Task<List<Reservation>> GetReservationsListAsync()
		{
			return await _reservationRepository.GetReservationsListAsync();
		}

		public async Task<Reservation> GetReservationByID(int id)
		{
			var reservation = _reservationRepository.GetTableNoTracking().Where(x => x.Id.Equals(id)).FirstOrDefault();
			return reservation;
		}

	}
}
#endregion
