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


namespace AutoMate.Controllers
{
    public class MapController : Controller
    {
        public ActionResult Index()
        {
            //TODO: Integrate map view and api data
            return View();
        }

    }
}