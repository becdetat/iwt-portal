using System.Web.Optimization;

namespace IwtPortal
{
    public class BundleConfig
    {
        public static void Register(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css")
                .Include("~/Content/bootstrap/bootstrap.css")
                .Include("~/Content/css/site.css")
                );

            // Remember order is important!
            bundles.Add(new ScriptBundle("~/bundles/js")
                .Include("~/Scripts/jquery-1.9.1.js")
                .Include("~/Scripts/bootstrap.js")
                .IncludeDirectory("~/Scripts/site/", "*.js", true)
                );

            bundles.Add(new ScriptBundle("~/bundles/html5shiv")
                .Include("~/Scripts/html5shiv.js")
                .Include("~/Scripts/respond.min.js")
                );
        }
    }
}