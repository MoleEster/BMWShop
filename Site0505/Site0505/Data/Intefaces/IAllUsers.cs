using Site0505.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site0505.Data.Intefaces
{
    public interface IAllUsers:IBaseInterface<User>
    {
        IEnumerable<User> GetAllUsers { get; }
    }
}
