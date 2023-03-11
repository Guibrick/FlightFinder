using FlightFinder.Models;
using FlightFinder.Models.DTO;

namespace FlightFinder.Services
{
    public interface IUserRepository
    {
        public IEnumerable<User> AllUsers();
        public User CreateUser(UserRequest request);
        public User Login(LoginRequest request);
    }
}