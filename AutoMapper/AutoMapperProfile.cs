using AutoMapper;
using carpool.API.DTO.CustomerDTO;
using carpool.API.DTO.RideDTO;
using carpool.API.Models;

namespace carpool.API.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<NewCustomerDTO, Customer>().ReverseMap();
            CreateMap<GetRideDTO, Ride>().ReverseMap();
        }
    }
}