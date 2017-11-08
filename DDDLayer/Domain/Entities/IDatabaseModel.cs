using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDLayer.Domain.Entities
{
    interface IDatabaseModel
    {
        string id { get; set; }

        int status { get; set; }

    }
}
