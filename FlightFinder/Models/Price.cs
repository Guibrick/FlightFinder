using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FlightFinder.Models
{
    public class Price
    {
        [Key]
        [JsonPropertyName("currency")]
        public string? Currency { get; set; }

        [JsonPropertyName("adult")]
        public double Adult { get; set; }

        [JsonPropertyName("child")]
        public double Child { get; set; }
    }
}
