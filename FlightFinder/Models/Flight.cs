namespace FlightFinder.Models
{
    public class Flight
    {
        public string? Flight_Id { get; set; }
        public DateTime DepartureAt { get; set; }
        public DateTime ArrivalAt { get; set; }
        public int AvailableSeats { get; set; }
        public Price? Prices { get; set; }
    }
}
