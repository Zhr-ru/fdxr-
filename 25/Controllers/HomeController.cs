using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _25.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //46552626
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
             能不能
            return View();
            777
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}