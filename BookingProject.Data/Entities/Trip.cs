using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Data.Entities
{
	public class Trip
	{

		public Trip()
		{

			CustomerTrips = new HashSet<CustomerTrip>();
		}


		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string CityName { get; set; }
		public string ImageUrl { get; set; }
		public int Price { get; set; }
		public string Content { get; set; }
		public DateTime CreationDate { get; set; }

		public virtual ICollection<CustomerTrip> CustomerTrips { get; set; }
	}
}
