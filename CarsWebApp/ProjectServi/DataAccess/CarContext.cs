
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectServi.DataAccess
{
    public class CarContext: DbContext
    {
        public DbSet<ProjectServi.Models.VehicleMakeD> Cars { get; set; }

        public DbSet<Models.VehicleModelD> Models { get; set; }
    }
}