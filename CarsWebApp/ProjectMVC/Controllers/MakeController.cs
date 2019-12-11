using ProjectMVC.Models;
using ProjectServi.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ProjectMVC.Controllers
{
    public class MakeController : Controller
    {
        private readonly IVehicleServiceRepository _vehicleRepository;

        public MakeController()
        {
            _vehicleRepository = new VehicleMakeRepository();
        }
        // GET: Make
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AsyncTimeout(6000)]
        [HandleError(ExceptionType = typeof(TimeoutException), View = "TimedOut")]
        public async Task<ActionResult> Brands(CancellationToken cancellationToken) //Read brands
        {
            /*CarContext model = new CarContext();
            VehicleMake vmodel = model.Cars;*/

            List<VehicleMake> bmodel = new List<VehicleMake>();

            var model = await _vehicleRepository.GetAllAsync(cancellationToken);

            //CarsFormModel model = new CarsFormModel();
            /*{
                NewCar = new CarsModel()
            };*/

            //model.VehicleServices = await _vehicleRepository.GetAllAsync(cancellationToken);

            /*foreach(var row in model)
            {
                bmodel.Add(new VehicleMake
                {
                    ID = row.
                });
            }*/

            return View(model);
        }
    }
}