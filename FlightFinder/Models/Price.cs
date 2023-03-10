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
        public float Adult { get; set; }

        [JsonPropertyName("child")]
        public float Child { get; set; }
    }
}
