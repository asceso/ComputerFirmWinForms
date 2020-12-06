using AutoMapper;

namespace InjectingCoreLibrary.MapperCore.ClientImplementation
{
    public interface IMapperInject
    {
        IMapper Mapper { get; }

        TOut Map<TIn, TOut>(TIn objectToConvert)
            where TIn : class
            where TOut : class;

        TOut Map<TOut>(object objectToConvert) where TOut : class;
    }
}
