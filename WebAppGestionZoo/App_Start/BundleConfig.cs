using System.Web;
using System.Web.Optimization;

namespace WebAppGestionZoo
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
             bundles.Add(new StyleBundle("~/Content/css").Include
                (
                        "~/Content/bootstrap.css",
                        "~/css/style.css"
                ));

             bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                      "~/Scripts/jquery-{version}.js"
                   
                ));
            bundles.Add(new ScriptBundle("~/bundles/boostrap").Include(
                     "~/Scripts/bootstrap.js"

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
