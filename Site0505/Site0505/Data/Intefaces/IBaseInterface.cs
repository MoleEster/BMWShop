using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site0505.Data.Intefaces
{
    public interface IBaseInterface<T>
    {
        T Get(Guid Id);
        void Add(T model);
        T Edit(T model);
        void Delete(Guid Id);
    }
}
