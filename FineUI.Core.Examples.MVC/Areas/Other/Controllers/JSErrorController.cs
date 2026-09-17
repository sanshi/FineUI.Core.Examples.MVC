using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Other.Controllers
{
    [Area("Other")]
    public class JSErrorController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Other/JSError
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button4_Click()
        {
            PageContext.RegisterStartupScript("test();");

            return UIHelper.Result();
        }

    }
}