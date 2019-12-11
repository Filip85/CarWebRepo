using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectServi.Models
{
    [Table("VehicleModel")]
    public class VehicleModelD
    {
        public int ID { get; set; }
        public int VehicleMakeID { get; set; }
        public string ModelName { get; set; }
        public string Abrv { get; set; }
    }
}