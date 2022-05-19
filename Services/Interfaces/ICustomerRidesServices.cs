using carpool.API.Models;
using System.Collections.Generic;

namespace carpool.API.Services.Interfaces
{
    public interface ICustomerRidesServices
    {
        public List<CustomerRides> CustomerOfferedRides(string customerId);
        public List<CustomerRides> CustomerBookedRides(string customerId);
        public CustomerRides NewCustomerRide(CustomerRides newCustomerRide);
        public CustomerRides DeleteCustomerRide(string customerId, string rideId);
    }
}