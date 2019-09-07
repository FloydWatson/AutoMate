using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//Testing commit - Jesse 

namespace AutoMate.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            transportApi = new TransportAPI();
            return transportApi.MyBusStopAPI.queryBusStops("bus_stop=Papakura Train Station");
            

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}