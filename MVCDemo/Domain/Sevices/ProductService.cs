using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Model;

namespace Domain.Sevices
{
    public class ProductService : IService<Product>
    {
        public Product Get(int id)
        {
            return new Product() { Id = id, Price = 200.00M, ProcessId = "MDM200023223", ProductName = "GetById", Remark = "Hello" };
        }

        public Product Get(string processId)
        {
            return new Product() { Id = 2002, Price = 200.00M, ProcessId = processId, ProductName = "GetByProcessId", Remark = "Hello" };
        }
    }
}
