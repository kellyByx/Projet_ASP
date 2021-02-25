using WebAppGestionZoo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using WebAppGestionZoo.Repositories;

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

        public ActionResult Connection()
        {
            ViewBag.Connection = "active";
            return View();
        }

        //fomulaire
        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Contact = "active";
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactModel contact) 
        {
             UnitOfWork ctx = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
             if (ctx.SaveContact(contact))
            {
                ViewBag.SuccessMessage = " Message bien envoyé";
                return View();
            }
            else
            {
                ViewBag.ErrorMessage = " Message non enregistré";
                return View();
            }
        }



    }
}