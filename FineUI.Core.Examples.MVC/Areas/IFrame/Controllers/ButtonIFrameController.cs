using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.IFrame.Controllers
{
    [Area("IFrame")]
    public class ButtonIFrameController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: IFrame/ButtonIFrame
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Window1_Close()
        {
            ShowNotify("Window1 被关闭了！");

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Window2_Close()
        {
            ShowNotify("Window2 被关闭了！");

            return UIHelper.Result();
        }

    }
}