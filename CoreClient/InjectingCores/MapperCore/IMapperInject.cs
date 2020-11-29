using AutoMapper;

namespace CoreClient.InjectingCores.MapperCore
{
    public interface IMapperInject
    {
        IMapper Mapper { get; }

        TOut Map<TIn, TOut>(TIn objectToConvert)
            where TIn : class
            where TOut : class;
    }
}
