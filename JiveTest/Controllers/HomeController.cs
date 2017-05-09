using System;
using System.Collections.Generic;
using System.Web.Mvc;
using JiveTest.Models;

namespace JiveTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetUsers()
        {
            Console.WriteLine("Get all users from Jive");

            var model = new List<JivePersonObject> {new JivePersonObject {DisplayName = "One"}};

            return View(model);
        }
    }
}