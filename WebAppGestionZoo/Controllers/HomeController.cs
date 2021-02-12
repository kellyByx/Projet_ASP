using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppGestionZoo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Index = "active";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.About = "active";
            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Services = "active";
            return View();
        }

        public ActionResult Gallery()
        {
            ViewBag.Gallery = "active";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Contact = "active";
            return View();
        }

        public ActionResult Connection()
        {
            ViewBag.Connection = "active";
            return View();
        }


    }
}