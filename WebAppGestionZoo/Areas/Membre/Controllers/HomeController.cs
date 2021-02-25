using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppGestionZoo.Areas.Membre.Controllers
{
    public class HomeController : Controller
    {
        // GET: Membre/Home
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
    }
}