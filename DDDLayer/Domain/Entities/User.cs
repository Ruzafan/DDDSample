using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDLayer.Domain.Entities
{
    public class User : IDatabaseModel
    {
        public string id { get; set; }

        public int status { get; set; }

        public string email { get; set; }

        public string password { get; set; }
    }
}
