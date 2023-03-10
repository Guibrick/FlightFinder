using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FlightFinder.Models
{
    public class FlightRoute
    {
        [Key]
        [JsonPropertyName("route_id")]
        public string? Route_Id { get; set; }

        [JsonPropertyName("departureDestination")]
        public string? DepartureDestination { get; set; }

        [JsonPropertyName("arrivalDestination")]
        public string? ArrivalDestination { get; set; }

        [JsonPropertyName("itineraries")]
        public List<Flight>? Itineraries { get; set; } = null!;
    }
}