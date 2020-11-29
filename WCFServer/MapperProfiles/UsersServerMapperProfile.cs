using AutoMapper;
using EFCore.Entities;
using WCFCore.DataContracts;

namespace WCFServer.MapperProfiles
{
    public class UsersServerMapperProfile : Profile
    {
        public UsersServerMapperProfile()
        {
            CreateMap<User, UserDataContract>();
            CreateMap<User, UserDataContract>().ReverseMap();
        }
    }
}
