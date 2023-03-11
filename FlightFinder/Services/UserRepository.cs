using FlightFinder.Models;
using FlightFinder.Models.DTO;
using Newtonsoft.Json;

namespace FlightFinder.Services
{
    public class UserRepository : IUserRepository
    {
        public List<FlightRoute> FlightRoutes { get; set; }
        public UserRepository()
        {
            var flights = new List<FlightRoute>();

            using (StreamReader reader = new StreamReader(@"Data/data.json"))
                flights = JsonConvert.DeserializeObject<List<FlightRoute>>(reader.ReadToEnd());

            FlightRoutes = flights;
        }

        public User CreateUser(UserRequest request)
        {
            var user = new User
            {
                UserId = Guid.NewGuid().ToString(),
                Name = request.Name,
                Surname = request.Surname,
                Email = request.Email,
                Password = request.Password
            };

            return user;
        }
    }
}