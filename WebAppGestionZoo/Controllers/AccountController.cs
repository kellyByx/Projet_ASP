using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppGestionZoo.infra;
using WebAppGestionZoo.Models;
using WebAppGestionZoo.Repositories;

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
            UnitOfWork ctx = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
           
            if (ModelState.IsValid)
            {
                SoigneurModel pf = ctx.UserAuth(lm);
                if (pf == null)
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
                    SessionUtils.ConnectedUser = pf;
                    return RedirectToAction("Index", "Home", new { area = "Membre" });
                }
                #region AncientLogin
                //if(lm.Login!="pandi" && lm.Password!="panda")
                //{
                //     if (lm.Login != "Kelly" && lm.Password != "dev")
                //      {
                //             ViewBag.Error = "Erreur Login/Password";
                //             return View();
                //      }

                //      else
                //      {
                //                SessionUtils.IsLogged = true;
                //                return RedirectToAction("Index", "Home", new { area = "Developer" });
                //                //return RedirectToAction("Index", "Home");
                //      }
                // }

                // else
                // {
                //     SessionUtils.IsLogged = true;
                //     return RedirectToAction("Index", "Home", new { area = "Membre" });
                //     //return RedirectToAction("Index", "Home");
                // }
                #endregion
            }

            else
            {
                return View();
            }
        }


    }
}

