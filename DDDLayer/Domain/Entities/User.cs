using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDLayer.Domain.Entities
{
    public class User : IDatabaseModel
    {
        public string Id { get; set; }

        public int Status { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
