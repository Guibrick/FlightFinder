using System.Text.Json.Serialization;

namespace FlightFinder.Models
{
    public class DepartureTimeRequest
    {
        [JsonPropertyName("departureAt")]
        public DateTime DepartureAt { get; set; }
    }
}
