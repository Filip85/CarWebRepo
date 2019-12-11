
using ProjectServi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectMVC.Models
{
    public class CarsFormModel  //view model za Car formu
    {
        public IEnumerable<VehicleMakeD> VehicleServices { get; set; }
        public CarsModel NewCar { get; set; }
    }
}