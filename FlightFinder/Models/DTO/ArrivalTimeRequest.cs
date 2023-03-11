using System.Text.Json.Serialization;

namespace FlightFinder.Models.DTO
{
    public class ArrivalTimeRequest
    {
        [JsonPropertyName("arrivalAt")]
        public DateTime ArrivalAt { get; set; }
    }
}