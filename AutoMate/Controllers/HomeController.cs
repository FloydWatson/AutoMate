using AutoMate.Models;
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

        public object Output { get; private set; }

        public string Index()
        {
            var transportApi = new TransportAPI();
            var serializer = new JavaScriptSerializer();
            var busstops = Task.Run(async () => { return await transportApi.MyBusStopAPI.queryBusStopsAsync("", ""); }).Result;

            if (busstops != null)
            {


                foreach (var el in busstops)
                    Console.WriteLine(el.stop_id);


            }

            return null;
            

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