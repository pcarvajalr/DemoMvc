using System.Web;
using System.Web.Optimization;
using System.Web.UI;

namespace DemoMvc
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {            
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
            
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css","~/Content/set1.css"));

            bundles.UseCdn = true;

            var fuentesCdn = "https://fonts.googleapis.com/css?family=Roboto:300,400,400i,500,700,900";
            var iconosCdn = "https://use.fontawesome.com/releases/v5.6.3/css/all.css";
            var bootstrapCdn = "https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/css/bootstrap.min.css";
            
            bundles.Add(new StyleBundle("~/Bootstrap/css",bootstrapCdn));

            bundles.Add(new StyleBundle("~/Fuentes/css",fuentesCdn));

            bundles.Add(new StyleBundle("~/Iconos/css",iconosCdn));

            BundleTable.EnableOptimizations = true;
        }
    }
}
