using System.Text.Json.Serialization;

namespace FlightFinder.Models
{
    public class FlightRequest
    {
        [JsonPropertyName("departureDestination")]
        public string DepartureDestination { get; set; }

        [JsonPropertyName("arrivalDestination")]
        public string ArrivalDestination { get; set; }
    }
}
