using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Data.AppMetaData
{
	public static class Router
	{
		public const string SingleRoute = "/{id}";
		public const string root = "Api";
		public const string version = "V1";
		public const string Rule = root+"/"+version+"/";

		public static class CustomerRouting
		{
			public const string Prefix = Rule + "Customer";
			public const string List = Prefix + "/List";
			public const string GetByID = Prefix +SingleRoute ;
			public const string Create = Prefix + "/Create";
			public const string Edit = Prefix + "/Edit";
			public const string Delete = Prefix + "/{id}";


		}
		public static class ReservationRouting
		{
			public const string Prefix = Rule + "Reservation";
			public const string List = Prefix + "/List";
			public const string GetByID = Prefix +"/{id}";
			public const string Create = Prefix + "/Create";
			public const string Edit = Prefix + "/Edit";
			public const string Delete = Prefix + "/{id}";


		}


	}
}
