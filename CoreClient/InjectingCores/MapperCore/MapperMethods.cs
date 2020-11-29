using AutoMapper;

namespace CoreClient.InjectingCores.MapperCore
{
    public class MapperMethods : IMapperInject
    {
        public IMapper Mapper { get; }

        public MapperMethods()
        {
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
