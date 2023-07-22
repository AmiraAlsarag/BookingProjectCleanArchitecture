﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Data.Entities
{
	public class Customer
	{
		public Customer()
		{
			CustomerTrips = new HashSet<CustomerTrip>();
		}
		[Key]
        public int Id { get; set; }
		public string? Name { get; set; }
	    public string? Phone { get; set; }
		
		public virtual ICollection<CustomerTrip> CustomerTrips { get; set; }

	}

}
