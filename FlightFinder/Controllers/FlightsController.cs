using FlightFinder.Models;
using FlightFinder.Services;
using Microsoft.AspNetCore.Mvc;

namespace FlightFinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        // private readonly IConfiguration _configuration;
        readonly IFlightRepository _repository;

        public FlightsController(IFlightRepository repository) => _repository = repository;

        [HttpGet]
        public IEnumerable<FlightRoute> GetAllFlights()
        {
            return _repository.GetAllFlights();
        }

        /* [HttpGet]
         public IEnumerable<FlightRoute> GetFlights()
         {
             List<FlightRoute> flights = new List<FlightRoute>();

             using (StreamReader reader = new StreamReader(@"Data/data.json"))
             {
                 flights = JsonConvert.DeserializeObject<List<FlightRoute>>(reader.ReadToEnd());
             }

             return flights;
         }

         [HttpGet("{id}")]
         public async Task<ActionResult<Flight>> GetOneFlight(FlightRequest request)
         {
             var options = FlightsController.

                         var puppy = await db.Puppy.FindAsync(id);

             if (puppy == null)
             {
                 return NotFound();
             }

             return puppy;
         }*/
        /*[HttpGet]
        public IEnumerable<string> Get()
        {

            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}