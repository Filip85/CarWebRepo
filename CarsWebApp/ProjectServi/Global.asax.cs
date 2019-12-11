using ProjectServi.DataAccess;
using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Routing;
//using ProjectServi.BusinessLogic;

namespace ProjectServi
{
    public class MvcApplication : System.Web.HttpApplication
    {

        protected void Application_Start()
        {
            Database.SetInitializer<CarContext>(null);
            //Database.SetInitializer<VehicleContext>(null);
            //Database.SetInitializer<CarsContext>(null);

        }
    }
}
