using Site0505.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site0505.Data.Intefaces
{
    public interface IAllVehicles:IBaseInterface<Vehicle>
    {
        IEnumerable<Vehicle> GetAllVehicles { get; }
        void AddtoCart(Guid VehicleId);
    }
}
