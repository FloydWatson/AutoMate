using AutoMate.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Script.Serialization;


namespace AutoMate.Controllers
{
    public class MapController : Controller
    {
        [HttpPost]
        public ActionResult Index(string lat, string lon)
        {
            //TODO: Integrate map view and api data, potentially get users gps location
            var transportApi = new TransportAPI();
            var serializer = new JavaScriptSerializer();
            var busStops = Task.Run(async () => { return await transportApi.MyBusStopAPI.getBusStopByDistanceAsync(lat, lon, "750"); }).Result;


            ViewBag.Data = busStops;



            return View();
        }

        public ActionResult Info()
        {
            return View();
        }

    }
}