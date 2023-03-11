using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlightFinder.Models
{
    public class Booking
    {
        [Key]
        public string? BookingId { get; set; }

        [ForeignKey("UserId")]
        public string? UserId { get; set; }
        public string? FlightId { get; set; }
        public double TotalPrice { get; set; }
        public int AdultSeats { get; set; }
        public int ChildSeats { get; set; }

        public virtual User? User { get; set; }
    }
}
