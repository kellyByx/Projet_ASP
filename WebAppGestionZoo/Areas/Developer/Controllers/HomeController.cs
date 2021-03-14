using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppGestionZoo.infra;
using WebAppGestionZoo.Models;
using WebAppGestionZoo.Repositories;

namespace WebAppGestionZoo.Areas.Developer.Controllers
{
    public class HomeController : Controller
    {
        
            // GET: Membre/Home
            public ActionResult Index()
            {
                ViewBag.ZoneMembre = "active";
                if (!SessionUtils.IsLogged) return RedirectToAction("Login", "Account", new { area = "" }); //renvois pg login si pas connecter.
                return View();
            }

            [HttpGet]
            public ActionResult Logout()
            {
                Session.Abandon();
                return RedirectToAction("Index", "Home");
            }

            [HttpGet]
            public ActionResult NewSoigneur()
            {
                  return View();
             }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult NewSoigneur(SoigneurModel soigneur)
            {

                if (ModelState.IsValid)
                {
                    UnitOfWork ctx = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
                    if (ctx.SaveSignUp(soigneur))
                    {
                        return RedirectToAction("Index", "Home", new { area = "Developer" });
                    }
                    else
                    {
                        return RedirectToAction("NewSoigneur", "Home", new { area = "Developer" });
                    }
                }
                else 
                { 
                    ViewBag.ErrorMessage = " Message non enregistré";
                    return View();
                }

            }

    }
}