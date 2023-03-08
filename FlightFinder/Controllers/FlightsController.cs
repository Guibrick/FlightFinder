using FlightFinder.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FlightFinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IConfiguration _configuration;

        public FlightsController(IWebHostEnvironment webHostEnvironment, IConfiguration configuration)
        {
            _webHostEnvironment = webHostEnvironment;
            _configuration = configuration;
        }

        [HttpGet]
        public IEnumerable<FlightRoute> GetContacts()
        {
            List<FlightRoute> flights = new List<FlightRoute>();

            using (StreamReader reader = new StreamReader(@"Data/data.json"))
            {
                flights = JsonConvert.DeserializeObject<List<FlightRoute>>(reader.ReadToEnd());
            }

            return flights;
        }

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
