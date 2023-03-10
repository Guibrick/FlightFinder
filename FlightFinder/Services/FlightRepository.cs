using FlightFinder.Models;
using Newtonsoft.Json;

namespace FlightFinder.Services
{
    public class FlightRepository : IFlightRepository
    {
        public IEnumerable<FlightRoute> Flights { get; set; }
        public FlightRepository()
        {
            var flights = new List<FlightRoute>();

            using (StreamReader reader = new StreamReader(@"Data/data.json"))
                flights = JsonConvert.DeserializeObject<List<FlightRoute>>(reader.ReadToEnd());

            Flights = flights;
        }

        public IEnumerable<FlightRoute> GetAllFlights()
        {
            return Flights;
        }

        public IEnumerable<List<Flight>> GetDestination(FlightRequest request)
        {
            var itineraries = Flights
                .Where(flight => flight.DepartureDestination == request.DepartureDestination)
                .Where(flight => flight.ArrivalDestination == request.ArrivalDestination)
                .Select(flight => flight.Itineraries)
                .ToList();

            return itineraries;
        }
    }
}