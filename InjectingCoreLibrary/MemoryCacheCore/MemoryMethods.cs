using System;
using System.Collections.Generic;
using System.Runtime.Caching;
using CoreClient.ControlExtensions;

namespace InjectingCoreLibrary.MapperCore.MemoryCacheCore
{
    public class MemoryMethods : IMemoryInject
    {
        private readonly MemoryCache cache;
        public MemoryMethods() => cache = MemoryCache.Default;
        #region store
        public void StoreData<T>(T dataToStore, string alias)
        {
            CacheItemPolicy policy = new CacheItemPolicy { SlidingExpiration = TimeSpan.FromMinutes(0) };
            cache.Set(alias, dataToStore, policy);
        }
        public void StoreCollection<T>(IEnumerable<T> collectionToStore, string alias)
        {
            CacheItemPolicy policy = new CacheItemPolicy { SlidingExpiration = TimeSpan.FromMinutes(0) };
            cache.Set(alias, collectionToStore, policy);
        }
        public void ExpiratedStoreCollection<T>(IEnumerable<T> collectionToStore, string alias, int expiration = 10)
        {
            CacheItemPolicy policy = new CacheItemPolicy { SlidingExpiration = TimeSpan.FromMinutes(expiration) };
            cache.Set(alias, collectionToStore, policy);
        }
        #endregion
        #region get
        public IEnumerable<T> GetCollection<T>(string alias)
            => (IEnumerable<T>)cache.Get(alias);
        public T GetData<T>(string alias)
        {
            object tmp = cache.Get(alias);
            return tmp.IsNull() ? default : (T)tmp;
        }
        #endregion
    }
}
