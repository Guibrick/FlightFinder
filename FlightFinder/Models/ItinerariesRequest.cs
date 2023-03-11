using System.Text.Json.Serialization;

namespace FlightFinder.Models
{
    public class ItinerariesRequest
    {
        [JsonPropertyName("departureDestination")]
        public string DepartureDestination { get; set; }

        [JsonPropertyName("arrivalDestination")]
        public string ArrivalDestination { get; set; }
    }
}
