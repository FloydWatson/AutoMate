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
                return RedirectToAction("Index");
            }

            return View();
        }

        //Dummy user data
        UserModel DummyUser1 = new UserModel
        {
            GivenName = "Jesse",
            FamilyName = "Gray",
            MobileNumber = "0220950466",
            EmailAddress = "jgray@gmail.com",
            ConfirmEmailAddress = "jgray@gmail.com",
            UserID = 1,
            DriverVerification = true,
            Username = "jesse-gray",
            Rating = 95
        };


        public ActionResult ProfilePage()
        {
            ViewBag.Message = "Profile Page";

            return View(DummyUser1);
        }

        public ActionResult EditUserDetails()
        {
            ViewBag.Message = "Edit Details";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditUserDetails(UserModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("ProfilePage");
            }

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

            return View("Login");
        }

        public ActionResult Map()
        {
            ViewBag.Message = "Map";
            UserModel data = new UserModel();
            data.Username = "FloydWatson";
            data.GivenName = "Floyd";
            data.Rating = 4.1;
            return View(data);
        }
    }
}