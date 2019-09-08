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
        [HttpGet]
        public ActionResult Index()
        {
            //TODO: Integrate map view and api data, potentially get users gps location
            var transportApi = new TransportAPI();
            var serializer = new JavaScriptSerializer();
            var busStops = Task.Run(async () => { return await transportApi.MyBusStopAPI.getBusStopByDistanceAsync("-36.8485", "174.7633", "750"); }).Result;


            ViewBag.Data = busStops;



            return View();
        }


        [HttpPost]
        public ActionResult Index(string lat = "-36.8485", string lon = "174.7633")
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