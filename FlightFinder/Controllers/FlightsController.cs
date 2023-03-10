using FlightFinder.Models;
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

        [HttpGet]
        public IEnumerable<FlightRoute> GetAllFlights()
        {
            return _repository.GetAllFlights();
        }

        [HttpGet("Destination")]
        public IEnumerable<List<Flight>> GetItineraries([FromQuery] FlightRequest request)
        {
            var destination = _repository.GetDestination(request);

            return destination;
        }
    }
}