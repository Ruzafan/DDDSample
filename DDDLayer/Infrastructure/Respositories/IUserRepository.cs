using DDDLayer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDLayer.Infrastructure.Respositories
{
    public interface IUserRepository
    {
        User Get(int id);

        User Get(Dictionary<string, object> filters);
    }
}
