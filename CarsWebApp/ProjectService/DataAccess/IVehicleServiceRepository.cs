using ProjectServi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectServi.DataAccess
{
    public interface IVehicleServiceRepository
    {
        Task<List<VehicleMakeD>> GetAllAsync(CancellationToken cancellationToken = default(CancellationToken)); //vraca Task<List<VehiceService>>
        Task CreateAsync(VehicleMakeD vehicle, CancellationToken cancellationToken = default(CancellationToken));
    }
}
