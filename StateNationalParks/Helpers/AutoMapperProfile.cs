using AutoMapper;
using StateNationalParks.Dtos;
using StateNationalParks.Models;

namespace StateNationalParks.Helpers
{
  public class AutoMapperProfile : Profile
  {
    public AutoMapperProfile()
    {
      CreateMap<UserDto, User>();
      CreateMap<User, UserDto>();
    }
  }
}