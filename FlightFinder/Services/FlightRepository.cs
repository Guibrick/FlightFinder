using FlightFinder.Models;
using Newtonsoft.Json;

namespace FlightFinder.Services
{
    public class FlightRepository : IFlightRepository
    {
        public IEnumerable<FlightRoute> Flights { get; set; }

        public FlightRepository(IEnumerable<FlightRoute> flights) => Flights = flights;

        public IEnumerable<FlightRoute> GetAllFlights()
        {
            var flights = new List<FlightRoute>();

            using (StreamReader reader = new StreamReader(@"Data/data.json"))
                flights = JsonConvert.DeserializeObject<List<FlightRoute>>(reader.ReadToEnd());


            return flights;
        }
    }
}