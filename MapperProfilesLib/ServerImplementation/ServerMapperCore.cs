using AutoMapper;
using MapperCore.Profiles;

namespace MapperCore.ServerImplementation
{
    public static class ServerMapperCore
    {
        public static IMapper ServerMapper;
        public static void CreateServerMapper()
        {
            MapperConfiguration configuration = new MapperConfiguration(cfg => cfg.AddProfile(new ServerMapperProfile()));
            ServerMapper = configuration.CreateMapper();
        }
    }
}
