using DDDLayer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDLayer.Support;

namespace DDDLayer.Infrastructure.Services
{
    public class UserService
    {
        public User Get(int id)
        {
            IDatabase db = Resolver.GetDatabaseObject(Constants.USER_COLLECTION);
            User user = db.Get<User>(id);
            if(user.IsDefined())
            {
                if(user.email.IsDefined() && user.status == Constants.STATUS_ACTIVE)
                {
                    return user;
                }
            }
            return null;
        }

        public User Get(string email, string password)
        {
            IDatabase db = Resolver.GetDatabaseObject(Constants.USER_COLLECTION);
            Dictionary<string, object> filters = new Dictionary<string, object>();
            filters.Add("email", email);
            filters.Add("password", password);
            User user = db.GetByFilter<User>(filters);
            if (user.IsDefined())
            {
                if (user.email.IsDefined() && user.status == Constants.STATUS_ACTIVE)
                {
                    return user;
                }
            }
            return null;
            
        }
    }
}
