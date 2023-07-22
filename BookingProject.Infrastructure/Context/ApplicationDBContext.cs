using Microsoft.EntityFrameworkCore;
using BookingProject.Data.Entities;

using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Infrastructure.Data
{
	public class ApplicationDBContext : DbContext
	{
        public ApplicationDBContext()
        {
            

        }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
        {
        
        }
        public DbSet<Trip> Trips { get; set; }
       public DbSet<Reservation>Reservations { get; set; }
        public DbSet<User>Users { get; set; }
        public DbSet<Customer> Customers { get; set; }


    }
}
