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
            var all = await db.Bookings.ToListAsync();
            return Ok(all);
        }

        [HttpPost("Book")]
        public async Task<ActionResult<Booking>> Create([FromForm] BookingRequest request)
        {
            var booking = repository.CreateBooking(request);
            db.Bookings.Add(booking);
            await db.SaveChangesAsync();

            return Created("", booking);
        }
    }
}
