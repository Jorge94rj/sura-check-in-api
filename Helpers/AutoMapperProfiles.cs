using AutoMapper;
using SuraCheckIn.API.Data;
using SuraCheckIn.API.Dtos;

namespace SuraCheckIn.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserListDto>();
                //.ForMember(dest => dest.property, opt => opt.MapFrom(src => src.UserEvents.FirstOrDefault().property));
        }
    }
}