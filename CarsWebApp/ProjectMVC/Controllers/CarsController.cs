using ProjectMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ProjectServi.DataAccess;
using ProjectServi.Models;

namespace ProjectMVC.Controllers
{
    public class CarsController : Controller
    {
        private readonly IVehicleServiceRepository _vehicleRepository;

        public CarsController()
        {
            _vehicleRepository = new VehicleMakeRepository();
        }
        // GET: Cars
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Save()
        {
            return View();
        }

        [HttpPost]
        [AsyncTimeout(6000)]
        [HandleError(ExceptionType = typeof(TimeoutException), View = "TimedOut")]
        public async Task<ActionResult> Save(CarsModel model, CancellationToken cancellationToken)
        {
            if(ModelState.IsValid)
            {
                //VehicleMakeD car = new VehicleMakeD(model.ID, model.BrandName, model.BrandName);
                VehicleMakeD car = new VehicleMakeD
                {
                   
                    BrandName = model.BrandName,
                    Abrv = model.Abrv
                };
 
                await _vehicleRepository.CreateAsync(car, cancellationToken);

                VehicleModelD modelcar = new VehicleModelD
                {
                    VehicleMakeID = car.ID,
                    ModelName = model.ModelName,
                    Abrv = model.Abrv
                };

                await _vehicleRepository.CreateAsyncM(modelcar, cancellationToken);
            }

            return View();
        }
    }
}