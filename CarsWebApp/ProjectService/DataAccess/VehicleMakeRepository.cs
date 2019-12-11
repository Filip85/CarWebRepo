using ProjectServi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ProjectServi.DataAccess;
using System.Threading;
using ProjectMVC.Models;

namespace ProjectService.DataAccess
{
    public class VehicleMakeRepository : IVehicleServiceRepository
    {
        public async Task<List<VehicleMakeD>> GetAllAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var context = new CarContext())
            {
                return await context.Cars.ToListAsync(cancellationToken);
            }
        }

        public async Task CreateAsync(VehicleMakeD vehicle, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var context = new CarContext())
            {

                context.Cars.Add(vehicle);
                //await context.SaveChangesAsync(cancellationToken);

            }
        }
    }
}