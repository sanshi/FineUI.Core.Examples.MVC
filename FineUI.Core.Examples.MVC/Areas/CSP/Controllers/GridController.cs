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
            // 全局已开启严格 CSP；只有本页的外部脚本来源需要额外放行。
            PageManager.Instance.CspScriptsAllowUrls = new[] { "cdn.jsdelivr.net", "unpkg.com" };

            return View();
        }



    }
}
