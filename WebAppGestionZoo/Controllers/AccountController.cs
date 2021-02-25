using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppGestionZoo.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }



        //    [HttpGet]
        //    public ActionResult Logout();
        //    {
        //      Session.Abandon();
        //       return RediractToAction("Index","Home");
        //     }



        //    [HttpGet]
        //    public ActionResult Login();
        //    {
        //    return View();
        //     }

        //[HttpPost]
        //public ActionResult Login(LoginModel lm)
        //{
        //    if(lm.Login!="panda" && lm.Password!="pandi")
        //    {
        //        return View();
        //    }
        //    else
        //    {
        //        return RedirectionToAction("Index", "Home", new {area="Membre"});
        //    }

        //}


    }
}