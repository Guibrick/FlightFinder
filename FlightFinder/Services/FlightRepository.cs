using FlightFinder.Models;
using Newtonsoft.Json;

namespace FlightFinder.Services
{
    public class FlightRepository : IFlightRepository
    {
        public List<FlightRoute> FlightRoutes { get; set; }
        public FlightRepository()
        {
            var flights = new List<FlightRoute>();

            using (StreamReader reader = new StreamReader(@"Data/data.json"))
                flights = JsonConvert.DeserializeObject<List<FlightRoute>>(reader.ReadToEnd());

            FlightRoutes = flights;
        }

        public IEnumerable<FlightRoute> GetAllFlights()
        {
            return FlightRoutes;
        }

        public IEnumerable<List<Flight>> GetDestination(ItinerariesRequest request)
        {
            var itineraries = FlightRoutes
                .Where(flight => flight.DepartureDestination == request.DepartureDestination)
                .Where(flight => flight.ArrivalDestination == request.ArrivalDestination)
                .Select(flight => flight.Itineraries)
                .ToList();

            return itineraries;
        }

        public List<FlightRoute> GetDepartureTime(DepartureTimeRequest request)
        {
            var times = new List<FlightRoute>();

            foreach (var flight in FlightRoutes)
            {
                var departures = flight.Itineraries
                .FindAll(a => a.DepartureAt == request.DepartureAt);

                flight.Itineraries = departures;
                times.Add(flight);
            }
            return times;
        }

        public List<FlightRoute> GetArrivalTime(ArrivalTimeRequest request)
        {
            var times = new List<FlightRoute>();

            foreach (var flight in FlightRoutes)
            {
                var arrivals = flight.Itineraries
                .FindAll(a => a.ArrivalAt == request.ArrivalAt);

                flight.Itineraries = arrivals;
                times.Add(flight);
            }
            return times;
        }
    }

}