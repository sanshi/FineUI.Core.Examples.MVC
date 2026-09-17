using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Form.Controllers
{
    [Area("Form")]
    public class HyperLinkController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Form/HyperLink
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnChangeEnable_Click(bool enabled)
        {
            UIHelper.HyperLink("HyperLink2").Enabled(!enabled);

            return UIHelper.Result();
        }

    }
}