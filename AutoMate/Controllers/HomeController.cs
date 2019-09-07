using AutoMate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using static AutoMate.DBFunctions.UserProcessor;

namespace AutoMate.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult SignUp()
        {
            ViewBag.Message = "User sign up page";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(UserModel model)
        {
            if (ModelState.IsValid)
            {
                CreateUser(model);
                return RedirectToAction("Index");
            }

            return View();
        }

       
        public ActionResult ProfilePage()
        {
            ViewBag.Message = "Profile Page";
            UserModel data = new UserModel();
            data.Username = "FloydWatson";
            data.GivenName = "Floyd";
            
            

            return View(data);
        }

        public ActionResult EditUserDetails()
        {
            ViewBag.Message = "Edit Details";

            return View();
        }
        public ActionResult Dashboard()
        {
            ViewBag.Message = "Your dashboard page.";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Login";

            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult EditUserDetails(UserModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        return RedirectToAction("Index");
        //    }

        //    return View();
        //}

        public ActionResult ChartView()
        {
            return View();
        }
    }
}