using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPCLASSWORK1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {

            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "GoodMorning" : "GoodAfternoon";
            return View();
        }
    }
}