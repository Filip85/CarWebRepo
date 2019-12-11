using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectMVC.Models
{
    public class CarsModel
    {
        public int ID { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string Abrv { get; set; }
    }
}