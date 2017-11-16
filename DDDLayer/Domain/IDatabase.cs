using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDLayer.Domain
{
    public interface IDatabase
    {

        T Get<T>(int id);

        T GetByFilter<T>(Dictionary<string, object> filters);

        List<T> GetList<T>(List<int> ids);

    }
}
