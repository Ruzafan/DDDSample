using DDDLayer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDLayer.Support;
using DDDLayer.Domain;

namespace DDDLayer.Infrastructure.Services
{
    public class UserService
    {
        public User Get(int id)
        {
            User user = (User)CacheManager.GetFromCache(string.Format("User-{0}", id));
            if (user.IsDefined())
            {
                return user;
            }

            IDatabase db = Resolver.GetDatabaseObject(Constants.USER_COLLECTION);
            user = db.Get<User>(id);
            if(user.IsDefined())
            {
                if(user.Email.IsDefined() && user.Status == Constants.STATUS_ACTIVE)
                {
                    return user;
                }
            }
            return null;
        }

        public User Get(string email, string password)
        {
            IDatabase db = Resolver.GetDatabaseObject(Constants.USER_COLLECTION);
            Dictionary<string, object> filters = new Dictionary<string, object>()
            {
                { "email", email },
                { "password", password }
            };
            User user = db.GetByFilter<User>(filters);
            if (user.IsDefined())
            {
                if (user.Email.IsDefined() && user.Status == Constants.STATUS_ACTIVE)
                {
                    CacheManager.SaveOnCache(string.Format("User-{0}", user.Id), user);
                    return user;
                }
            }
            return null;
            
        }

       
    }
}
