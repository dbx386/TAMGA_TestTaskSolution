using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace TAMGA_TestTaskSolution.WEB.App_Start
{
    public class BundleConfig
    {        
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery.js").Include(
                         "~/Scripts/jquery.unobtrusive-ajax.min.js",
                          "~/Scripts/jquery-3.3.1.min.js"));
        
        }
    }
}