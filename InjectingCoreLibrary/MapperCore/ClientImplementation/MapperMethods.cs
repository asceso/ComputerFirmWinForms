using AutoMapper;
using InjectingCoreLibrary.MapperCore.Profiles;

namespace InjectingCoreLibrary.MapperCore.ClientImplementation
{
    public class MapperMethods : IMapperInject
    {
        public IMapper Mapper { get; }

        public MapperMethods()
        {
            MapperConfiguration configuration = new MapperConfiguration(cfg => cfg.AddProfile(new MainMapperProfile()));
            Mapper = configuration.CreateMapper();
        }

        public TOut Map<TIn, TOut>(TIn objectToConvert)
            where TIn : class
            where TOut : class
        {
            {
                if (Mapper == null)
                {
                    return null;
                }

                return Mapper.Map<TIn, TOut>(objectToConvert);
            }
        }
    }
}
