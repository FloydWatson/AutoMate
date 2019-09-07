using AutoMate.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

//Testing commit - Jesse 

namespace AutoMate.Controllers
{
    public class HomeController : Controller
    {
        private TransportAPI transportApi;
        private List<BusStop> busstops;

        public string Index()
        {
            var transportApi = new TransportAPI();
            var serializer = new JavaScriptSerializer();
            var busStops = Task.Run(async () => { return await transportApi.MyBusStopAPI.getBusStopByDistanceAsync(); }).Result;

            if (busStops != null)
            {
                return JsonConvert.SerializeObject(busStops); 

            }
            return null;
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