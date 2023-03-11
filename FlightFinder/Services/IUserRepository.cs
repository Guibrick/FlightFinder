using FlightFinder.Models;
using FlightFinder.Models.DTO;

namespace FlightFinder.Services
{
    public interface IUserRepository
    {
        public User CreateUser(UserRequest request);
    }
}