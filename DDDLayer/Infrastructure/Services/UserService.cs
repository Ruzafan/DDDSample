using DDDLayer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDLayer.Support;
using DDDLayer.Infrastructure.Respositories;

namespace DDDLayer.Infrastructure.Services
{
    public class UserService
    {
        public User Get(int id)
        {
            IUserRepository userRepository = Resolver.GetUserRepository(Constants.USER_COLLECTION);
            return userRepository.Get(id);
            
        }

        public User Get(string email, string password)
        {
            IUserRepository userRepository = Resolver.GetUserRepository(Constants.USER_COLLECTION);
            Dictionary<string, object> filters = new Dictionary<string, object>();
            filters.Add("email", email);
            filters.Add("password", password);
            return userRepository.Get(filters);

        }
    }
}
