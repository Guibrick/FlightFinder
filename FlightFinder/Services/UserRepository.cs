using FlightFinder.Data;
using FlightFinder.Models;
using FlightFinder.Models.DTO;

namespace FlightFinder.Services
{
    public class UserRepository : IUserRepository
    {
        readonly FlightsContext db;
        public UserRepository(FlightsContext _db) => db = _db;

        public IEnumerable<User> AllUsers()
        {
            var users = db.Users.ToList();
            return users;
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

        public User Login(LoginRequest request)
        {
            var login = AllUsers()
                .First(x => x.Email == request.Email);

            if (login != null && login.Password == request.Password)
            {
                return login;
            }

            throw new Exception();
        }
    }
}