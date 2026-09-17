using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Panel.Controllers
{
    [Area("Panel")]
    public class DisabledController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Panel/Disabled
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button2_Click(bool disabled)
        {
            UIHelper.Panel("Panel1").Disabled(!disabled);

            return UIHelper.Result();
        }

    }
}