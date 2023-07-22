using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Data.Entities
{
	public class CustomerTrip
	{

		[Key]
		public int CustTripID { get; set; }
		public int CustomerID { get; set; }
		public int TripID { get; set; }

		[ForeignKey("CustomerID")]
		public virtual Customer Customer { get; set; }

		[ForeignKey("TripID")]
		public virtual Trip Trip { get; set; }
	}
}
