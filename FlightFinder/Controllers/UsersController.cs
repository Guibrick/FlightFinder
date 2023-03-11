using FlightFinder.Data;
using FlightFinder.Models;
using FlightFinder.Models.DTO;
using FlightFinder.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<ActionResult<IEnumerable<User>>> GetAll()
        {
            var all = await db.Users.ToListAsync();
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
    }
}