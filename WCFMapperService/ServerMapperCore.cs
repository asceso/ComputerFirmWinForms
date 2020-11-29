using AutoMapper;

namespace WCFMapperService
{
    public static class ServerMapperCore
    {
        public static IMapper ServerMapper;

        public static void CreateServerMapper(Profile[] profiles)
        {
            MapperConfiguration configuration = new MapperConfiguration(
                cfg => {
                    foreach (var prof in profiles)
                        cfg.AddProfile(prof);
                });

            ServerMapper = configuration.CreateMapper();
        }
    }
}
