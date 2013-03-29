using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Model
{
    public class Product:TEntity
    {
        public string ProductName { set; get; }

        public decimal Price { set; get; }
    }
}
