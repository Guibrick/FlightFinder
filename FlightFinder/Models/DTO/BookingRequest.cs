namespace FlightFinder.Models.DTO
{
    public class BookingRequest
    {
        public string? UserId { get; set; }
        public string? FlightId { get; set; }
        public int AdultSeats { get; set; }
        public int ChildSeats { get; set; }
    }
}