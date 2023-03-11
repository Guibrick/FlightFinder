using FlightFinder.Models;
using FlightFinder.Models.DTO;
using FlightFinder.Services;
using Microsoft.AspNetCore.Mvc;

namespace FlightFinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        readonly IFlightRepository _repository;

        public FlightsController(IFlightRepository repository) => _repository = repository;

        [HttpGet("AllFlights")]
        public IEnumerable<FlightRoute> GetAllFlights()
        {
            return _repository.GetAllFlights();
        }

        [HttpGet("Destination")]
        public IEnumerable<List<Flight>> GetItineraries([FromQuery] ItinerariesRequest request)
        {
            var destination = _repository.GetDestination(request);

            return destination;
        }

        [HttpGet("DepartureTime")]
        public List<FlightRoute> GetFlightsDepartureTime([FromQuery] DepartureTimeRequest request)
        {
            var time = _repository.GetDepartureTime(request);

            return time;
        }

        [HttpGet("ArrivalTime")]
        public List<FlightRoute> GetFlightsArrivalTime([FromQuery] ArrivalTimeRequest request)
        {
            var time = _repository.GetArrivalTime(request);

            return time;
        }
    }
}