﻿using DataManipulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AutoMate.Controllers
{
    public class MapController : Controller
    {
        // GET: Map
        public ActionResult Index()
        {            
            return View();
        }
    }
}