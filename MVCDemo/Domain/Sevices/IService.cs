using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Model;

namespace Domain.Sevices
{
    public interface IService<T> 
        where T : TEntity,new()        
    {
        T Get(int id);
        T Get(string processId);
     }

    public interface IService
    {
        object Get(int id);

        object Get(string processId);
    }
}
