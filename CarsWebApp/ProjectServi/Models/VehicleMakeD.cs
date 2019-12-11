using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectServi.Models
{
    [Table("VehicleMake")]
    public class VehicleMakeD
    {

        public int ID { get; set; }
        public string BrandName { get; set; }
        public string Abrv { get; set; }
    }
}