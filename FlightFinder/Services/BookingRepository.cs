using FlightFinder.Models;
using FlightFinder.Models.DTO;
using Newtonsoft.Json;

namespace FlightFinder.Services
{
    public class BookingRepository : IBookingRepository
    {
        public List<FlightRoute> FlightRoutes { get; set; }
        public BookingRepository()
        {
            var flights = new List<FlightRoute>();

            using (StreamReader reader = new StreamReader(@"Data/data.json"))
                flights = JsonConvert.DeserializeObject<List<FlightRoute>>(reader.ReadToEnd());

            FlightRoutes = flights;
        }

        public Booking CreateBooking(BookingRequest request)
        {
            /*var price = new List<double>();

            foreach (var flight in FlightRoutes)
            {
                if (request.AdultSeats > 0)
                {
                    var adult = flight.Itineraries
                    .Where(a => a.Flight_Id == request.FlightId)
                    .Select(a => a.Prices.Adult)
                    .First();

                    var adultPrice = request.AdultSeats * adult;

                    price.Add(adultPrice);
                }

                if (request.ChildSeats > 0)
                {
                    var child = flight.Itineraries
                    .Where(a => a.Flight_Id == request.FlightId)
                    .Select(a => a.Prices.Child)
                    .First();

                    var childPrice = request.AdultSeats * child;

                    price.Add(childPrice);
                }
            }*/

            var booking = new Booking
            {
                BookingId = Guid.NewGuid().ToString(),
                UserId = request.UserId,
                FlightId = request.FlightId,
                TotalPrice = 12.3232,
                AdultSeats = request.AdultSeats,
                ChildSeats = request.ChildSeats,
            };

            return booking;
        }
    }
}