namespace FlightFinder.Models
{
    public class Route
    {
        public string? RouteId { get; set; }
        public string? DepartureDestination { get; set; }
        public string? ArrivalDestination { get; set; }
        public Flight? Itinerary { get; set; }
    }
}
