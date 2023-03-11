using FlightFinder.Models;
using FlightFinder.Models.DTO;

namespace FlightFinder.Services
{
    public interface IBookingRepository
    {
        public Booking CreateBooking(BookingRequest request);
    }
}