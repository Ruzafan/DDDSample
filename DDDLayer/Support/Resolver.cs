using DDDLayer.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDLayer.Support
{
    public static class Resolver
    {
        public static IDatabase GetDatabaseObject(string collectionName)
        {
            return new Mongo(collectionName);
        }
    }
}
