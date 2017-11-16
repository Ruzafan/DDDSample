using DDDLayer.Domain.Entities;
using DDDLayer.Infrastructure.Services;
using DDDLayer.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDLayer.Application.UseCase
{
    public class LoginUseCase
    {
        private UserService _userService = new UserService();

        public bool Login(string email, string password)
        {
            if(email.IsDefined() && password.IsDefined())
            {
                User user = _userService.Get(email, password);
                if(user.IsDefined())
                {
                    return true;
                }
                
            }
            return false;
        }
    }
}
