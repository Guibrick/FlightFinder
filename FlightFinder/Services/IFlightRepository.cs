using FlightFinder.Models;
using FlightFinder.Models.DTO;

namespace FlightFinder.Services
{
    public interface IFlightRepository
    {
        IEnumerable<FlightRoute> GetAllFlights();
        IEnumerable<List<Flight>> GetDestination(ItinerariesRequest request);
        List<FlightRoute> GetDepartureTime(DepartureTimeRequest request);
        List<FlightRoute> GetArrivalTime(ArrivalTimeRequest request);
    }
}