using NetFlask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppGestionZoo.infra;

namespace WebAppGestionZoo.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

         [HttpGet]
          public ActionResult Logout()
            {
              Session.Abandon();
              return RedirectToAction("Index","Home");
           }

        [HttpGet]
            public ActionResult Login()
           {
            return View();
            }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel lm)
        {
            if (ModelState.IsValid)
            {            
               if(lm.Login!="pandi" && lm.Password!="panda")
               {
                    if (lm.Login != "Kelly" && lm.Password != "dev")
                     {
                            ViewBag.Error = "Erreur Login/Password";
                            return View();
                     }

                     else
                     {
                               SessionUtils.IsLogged = true;
                               return RedirectToAction("Index", "Home", new { area = "Developer" });
                               //return RedirectToAction("Index", "Home");
                     }
                }

                else
                {
                    SessionUtils.IsLogged = true;
                    return RedirectToAction("Index", "Home", new { area = "Membre" });
                    //return RedirectToAction("Index", "Home");
                }
            }

            else
            {
                return View();
            }
        }


    }
}

