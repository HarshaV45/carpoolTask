using carpool.API.Models.Enums;

namespace carpool.API.Models
{
    public class CustomerRides
    {
        public string CustomerId { get; set; }
        public string RideId { get; set; }
        public RideType RideType { get; set; }
    }
}