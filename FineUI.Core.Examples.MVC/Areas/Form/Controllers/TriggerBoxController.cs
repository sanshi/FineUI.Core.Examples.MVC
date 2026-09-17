using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Form.Controllers
{
    [Area("Form")]
    public class TriggerBoxController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Form/TriggerBox
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnCloseWindow_Click()
        {
            UIHelper.Window("Window1").Hide();
            UIHelper.TriggerBox("TriggerBox1").Text("弹出窗口被关闭了");

            return UIHelper.Result();
        }

    }
}