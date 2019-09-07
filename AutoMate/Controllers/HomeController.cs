using AutoMate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

//Testing commit - Jesse 

namespace AutoMate.Controllers
{
    public class HomeController : Controller
    {
        private TransportAPI transportApi;

        public object Output { get; private set; }

        public String Index()
        {
            var serializer = new JavaScriptSerializer();
            var serializedResult = serializer.Serialize(transportApi.MyBusStopAPI.queryBusStopsAsync("bus_stop=Papakura Train Station"));
            return serializedResult;
            

            // return View();
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