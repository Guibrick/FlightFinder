using FlightFinder.Models;
using Microsoft.EntityFrameworkCore;

namespace FlightFinder.Data
{
    public class FlightsContext : DbContext
    {
        public FlightsContext(DbContextOptions<FlightsContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost, 1433;Database=FlightBooking;User Id=sa;Password=Stockholm-9876;TrustServerCertificate=True;");
        }
    }
}
