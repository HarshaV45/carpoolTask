using carpool.API.Models;
using System.Collections.Generic;

namespace carpool.API.Services.Interfaces
{
    public interface IRideServices
    {
        public List<Ride> GetAllRides();
        public Ride NewRide(Ride ride);
        public Ride RemoveRide(string id);
        public Ride FindRide(string id);
        public List<Ride> AvailableRides(string source, string destination);
    }
}