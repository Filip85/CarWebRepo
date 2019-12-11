using ProjectServi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ProjectServi.DataAccess;
using System.Threading;

namespace ProjectServi.DataAccess
{
    public class VehicleMakeRepository : IVehicleServiceRepository
    {
        public async Task <List<VehicleMakeD>> GetAllAsync(CancellationToken cancellationToken = default(CancellationToken))
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
                await context.SaveChangesAsync(cancellationToken);

            }
        }

        public async Task CreateAsyncM(VehicleModelD vehicle, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var context = new CarContext())
            {

                context.Models.Add(vehicle);
                await context.SaveChangesAsync(cancellationToken);

            }
        }

        public async Task<List<VehicleModelD>> GetAllAsyncM(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var context = new CarContext())
            {
                return await context.Models.ToListAsync(cancellationToken);
            }
        }
    }
}