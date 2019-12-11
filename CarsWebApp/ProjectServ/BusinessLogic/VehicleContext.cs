using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace ProjectServ.Models
{
    public class VehicleContext: DbContext
    {
        public DbSet<VehicleMake> Brands { get; set; }
    }
}
