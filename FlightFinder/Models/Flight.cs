using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FlightFinder.Models
{
    public class Flight
    {
        [Key]
        [JsonPropertyName("flight_id")]
        public string? Flight_Id { get; set; }

        [JsonPropertyName("departureAt")]
        public DateTime DepartureAt { get; set; }

        [JsonPropertyName("arrivalAt")]
        public DateTime ArrivalAt { get; set; }

        [JsonPropertyName("availableSeats")]
        public int AvailableSeats { get; set; }

        [JsonPropertyName("prices")]
        public virtual Price? Prices { get; set; } = null!;
    }
}
