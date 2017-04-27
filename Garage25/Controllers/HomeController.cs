using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Garage25.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "A very good and useful application this is!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Problem? Snacka med Gunnar!";

            return View();
        }
    }
}