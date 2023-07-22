using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Data.Entities
{
	public class Reservation
	{
		[Key]
        public int Id { get; set; }
		public int? TripId { get; set; }
		[ForeignKey("TripId")]
		public virtual Trip Trip { get; set; }


		public int? ReservedBy { get; set; }
		[ForeignKey("ReservedBy")]
		public virtual User User { get; set; }


		////


		public int? CustomerId { get; set; }
		[ForeignKey("CustomerId")]
		public virtual Customer Customer { get; set; }
		public string Notes { get; set; }
		public DateTime ReservationDate { get; set; }
		public DateTime CreationDate { get; set; }

	}
}
