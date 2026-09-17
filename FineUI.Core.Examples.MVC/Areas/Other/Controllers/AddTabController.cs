using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Other.Controllers
{
    [Area("Other")]
    public class AddTabController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Other/AddTab
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button3_Click()
        {
            PageContext.RegisterStartupScript("onCloseActiveTabClick();");

            return UIHelper.Result();
        }

    }
}