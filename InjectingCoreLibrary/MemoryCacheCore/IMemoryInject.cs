using System.Collections.Generic;

namespace InjectingCoreLibrary.MapperCore.MemoryCacheCore
{
    public interface IMemoryInject
    {
        void StoreData<T>(T dataToStore, string alias);
        void StoreCollection<T>(IEnumerable<T> collectionToStore, string alias);
        void ExpiratedStoreCollection<T>(IEnumerable<T> collectionToStore, string alias, int expiration = 10);

        T GetData<T>(string alias);
        IEnumerable<T> GetCollection<T>(string alias);
    }
}
