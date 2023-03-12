using FlightFinder.Data;
using FlightFinder.Models;
using FlightFinder.Models.DTO;
using FlightFinder.Services;
using Microsoft.AspNetCore.Mvc;

namespace FlightFinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        readonly FlightsContext db;
        readonly IBookingRepository repository;

        public BookingsController(FlightsContext _db, IBookingRepository _repository)
        {
            db = _db;
            repository = _repository;
        }

        [HttpGet("AllBookings")]
        public async Task<ActionResult<IEnumerable<Booking>>> GetAll()
        {
            var all = repository.AllBookings();
            return Ok(all);
        }

        [HttpPost("Book")]
        public async Task<ActionResult<Booking>> Create([FromForm] BookingRequest request)
        {
            if (db.Users.Find(request.UserId) == null) return NotFound("User does not exist.");

            var booking = repository.CreateBooking(request);
            db.Bookings.Add(booking);
            await db.SaveChangesAsync();

            return Created("", booking);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteBooking(string id)
        {
            var booking = await db.Bookings.FindAsync(id);
            if (booking == null) return NotFound();

            db.Bookings.Remove(booking);
            await db.SaveChangesAsync();

            return NoContent();
        }
    }
}