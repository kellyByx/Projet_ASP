using WebAppGestionZoo.Models;
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
        {   HomeViewModel hm = new HomeViewModel();
            ViewBag.Index = "active";
            return View(hm);
        }

        public ActionResult Coulisse()
        {
            CoulisseViewModel cm = new CoulisseViewModel();
            ViewBag.Coulisse = "active";
            return View(cm);
        }

        public ActionResult Animaux()
        {
            AnimauxViewModel am = new AnimauxViewModel();
            ViewBag.Animaux = "active";
            return View(am);
        }

        public ActionResult Gallerie()
        {
            GallerieViewModel gm = new GallerieViewModel();
            ViewBag.Gallerie = "active";
            return View(gm);
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