using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Other.Controllers
{
    [Area("Other")]
    public class AjaxLoadingController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Other/AjaxLoading
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button1_Click()
        {
            System.Threading.Thread.Sleep(1000);

            return UIHelper.Result();
        }

    }
}