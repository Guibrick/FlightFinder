using FlightFinder.Models;

namespace FlightFinder.Services
{
    public interface IFlightRepository
    {
        IEnumerable<FlightRoute> GetAllFlights();
    }
}