using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.CSP.Controllers
{
    [Area("CSP")]
    public class GridController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: CSP/Grid
        public IActionResult Index()
        {
            var pm = PageManager.Instance;
            pm.CspScripts = true;
            pm.CspScriptsAllowNonce = true;
            pm.CspScriptsAllowUrls = new[] { "cdn.jsdelivr.net", "unpkg.com" };

            return View();
        }



    }
}