using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudNhibernate.Model
{
    public class Product
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual int Quantity { get; set; }

        public virtual double Price { get; set; }
    }
}
