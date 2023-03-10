using FlightFinder.Models;

namespace FlightFinder.Services
{
    public interface IFlightRepository
    {
        IEnumerable<FlightRoute> GetAllFlights();
        IEnumerable<List<Flight>> GetDestination(FlightRequest request);
    }
}