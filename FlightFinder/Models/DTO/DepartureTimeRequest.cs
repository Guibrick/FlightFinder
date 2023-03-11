using System.Text.Json.Serialization;

namespace FlightFinder.Models.DTO
{
    public class DepartureTimeRequest
    {
        [JsonPropertyName("departureAt")]
        public DateTime DepartureAt { get; set; }
    }
}
