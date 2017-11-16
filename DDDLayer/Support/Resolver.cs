using DDDLayer.Infrastructure.Respositories;
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
        public static IUserRepository GetUserRepository(string collectionName)
        {
            return new UserMongoRepository();
        }
    }
}
