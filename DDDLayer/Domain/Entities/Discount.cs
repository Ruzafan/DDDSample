using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDLayer.Domain.Entities
{
    public class Discount
    {
        public int Percent { get; set; }

        public DateTime InitDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
