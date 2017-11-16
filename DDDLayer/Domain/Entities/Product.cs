using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDLayer.Domain.Entities
{
    public class Product : IDatabaseModel
    {

        public string Id { get; set; }

        public int Status { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public Discount Discount { get; set; }

        public List<string> Tags { get; set; }

        public List<string> Images { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime ModificationDate { get; set; }
    }
}
