using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Form.Controllers
{
    [Area("Form")]
    public class LabelController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Form/Label
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnChangeEnable_Click(bool enabled)
        {
            UIHelper.Label("Label3").Enabled(!enabled);

            return UIHelper.Result();
        }

    }
}