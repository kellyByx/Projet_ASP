using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppGestionZoo.Models;

namespace WebAppGestionZoo.infra
{
    public class SessionUtils
    {
        public static bool IsLogged
        {
            get
            {
               if (HttpContext.Current.Session["logged"] == null)
                {
                    HttpContext.Current.Session["logged"] = false;
                }
                return (bool)HttpContext.Current.Session["logged"];
            }

            set { HttpContext.Current.Session["logged"] = value; }
        }

        public static SoigneurModel ConnectedUser
        {
            get
            {
                return (SoigneurModel)HttpContext.Current.Session["ConnectedUser"];
            }

            set { HttpContext.Current.Session["ConnectedUser"] = value; }

        }

    }
}