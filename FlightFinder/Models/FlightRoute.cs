namespace FlightFinder.Models
{
    public class FlightRoute
    {
        public string? Route_Id { get; set; }
        public string? DepartureDestination { get; set; }
        public string? ArrivalDestination { get; set; }
        public List<Flight>? Itineraries { get; set; }
    }
}