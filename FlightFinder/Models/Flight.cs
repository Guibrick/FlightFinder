namespace FlightFinder.Models
{
    public class Flight
    {
        public string? FlightId { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
        public int AvailableSeats { get; set; }
        public Price? Price { get; set; }
    }
}
