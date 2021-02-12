﻿using System.Web;
using System.Web.Optimization;

namespace WebAppGestionZoo
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //           "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //           "~/Scripts/jquery.validate*"));

            // Utilisez la version de développement de Modernizr pour le développement et l'apprentissage. Puis, une fois
            // prêt pour la production, utilisez l'outil de génération à l'adresse https://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin.
            // bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //         "~/Scripts/bootstrap.js"));

            // bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include
                (
                        "~/Content/bootstrap.css",
                        "~/css/style.css"
                ));

             bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                      "~/Scripts/jquery-{version}.js"
                     // "~/Scripts/jquery-1.11.1.min.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryFlexiSel").Include(
                    "~/js/jquery.flexisel.js"
                ));


            bundles.Add(new ScriptBundle("~/bundles/jquerylightbox").Include(
               
                     "~/js/jquery.lightbox.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css/jqueryLightbox").Include(
                   "~/css/jquery.lightbox.css"
                   
                ));
        }
    }
}
