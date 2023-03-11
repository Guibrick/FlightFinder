using FlightFinder.Data;
using FlightFinder.Models;
using FlightFinder.Models.DTO;
using FlightFinder.Services;
using Microsoft.AspNetCore.Mvc;

namespace FlightFinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        readonly FlightsContext db;
        readonly IUserRepository repository;

        public UsersController(FlightsContext _db, IUserRepository _repository)
        {
            db = _db;
            repository = _repository;
        }

        [HttpGet("AllUsers")]
        public ActionResult<IEnumerable<User>> GetAll()
        {
            var all = repository.AllUsers();
            return Ok(all);
        }

        [HttpPost("Register")]
        public async Task<ActionResult<User>> Create([FromForm] UserRequest request)
        {
            var user = repository.CreateUser(request);
            db.Users.Add(user);
            await db.SaveChangesAsync();

            return Created("", user);
        }

        [HttpPost("Login")]
        public ActionResult<User> GetLoginUser([FromForm] LoginRequest request)
        {
            var login = repository.Login(request);

            return login;
        }
    }
}