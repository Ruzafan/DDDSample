using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;
using System.IO;
using DDDLayer.Domain.Entities;

namespace DDDLayer.Support
{
    public static class CacheManager
    {
        private static ObjectCache _cache = MemoryCache.Default;

        public static void SaveOnCache(string key, IDatabaseModel value)
        {
            var cachePolicy = new CacheItemPolicy().AbsoluteExpiration = DateTimeOffset.Now.AddHours(2);
            _cache.Add(key, value, cachePolicy);
        }

        public static IDatabaseModel GetFromCache(string key)
        {
            return (IDatabaseModel)_cache.Get(key);
        }
    }
}
