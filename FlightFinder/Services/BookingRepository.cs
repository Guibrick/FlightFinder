using FlightFinder.Data;
using FlightFinder.Models;
using FlightFinder.Models.DTO;
using Newtonsoft.Json;

namespace FlightFinder.Services
{
    public class BookingRepository : IBookingRepository
    {
        readonly FlightsContext db;
        public List<FlightRoute> FlightRoutes { get; set; }

        public BookingRepository(FlightsContext _db)
        {
            db = _db;

            var flights = new List<FlightRoute>();

            using (StreamReader reader = new StreamReader(@"Data/data.json"))
                flights = JsonConvert.DeserializeObject<List<FlightRoute>>(reader.ReadToEnd());

            FlightRoutes = flights;
        }

        public IEnumerable<Booking> AllBookings()
        {
            var bookings = db.Bookings.ToList();
            return bookings;
        }

        public Booking CreateBooking(BookingRequest request)
        {
            var booking = new Booking
            {
                BookingId = Guid.NewGuid().ToString(),
                UserId = request.UserId,
                FlightId = request.FlightId,
                Name = db.Users.Where(u => u.UserId == request.UserId).Select(u => u.Name).FirstOrDefault(),
                Surname = db.Users.Where(u => u.UserId == request.UserId).Select(u => u.Surname).FirstOrDefault(),
                Departure = request.Departure,
                Arrival = request.Arrival,
                TotalPrice = 0,
                AdultSeats = request.AdultSeats,
                ChildSeats = request.ChildSeats,
            };

            return booking;

            /*var itineraries = FlightRoutes.Select(d => d.Itineraries);

            var price = new List<double>();

            if (request.AdultSeats > 0)
            {
                foreach (var itinerary in itineraries)
                {
                    var adult = itinerary
                    .Where(a => a.Flight_Id == request.FlightId)
                    .Select(a => a.Prices.Adult)
                    .First();

                    var adultPrice = request.AdultSeats * adult;
                    price.Add(adultPrice);
                }
            }

            if (request.ChildSeats > 0)
            {
                foreach (var itinerary in itineraries)
                {
                    var child = itinerary
                    .Where(a => a.Flight_Id == request.FlightId)
                    .Select(a => a.Prices.Child)
                    .First();

                    var childPrice = request.AdultSeats * child;
                    price.Add(childPrice);
                }
            }*/
        }
    }
}