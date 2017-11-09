using DDDLayer.Domain.Entities;
using DDDLayer.Infrastructure.Services;
using DDDLayer.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDLayer.Infrastructure.Respositories
{
    public class UserMongoRepository : IUserRepository
    {
        public UserMongoRepository()
        {

        }

        public User Get(int id)
        {
            IDatabase db = new Mongo(Constants.USER_COLLECTION);
            var user = db.Get<User>(id);
            if (user.IsDefined())
            {
                if (user.email.IsDefined() && user.status == Constants.STATUS_ACTIVE)
                {
                    return user;
                }
            }
            return null;
        }

        public User Get(Dictionary<string, object> filters)
        {
            IDatabase db = new Mongo(Constants.USER_COLLECTION);
            
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
