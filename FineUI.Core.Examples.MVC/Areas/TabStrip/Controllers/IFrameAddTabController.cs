using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.TabStrip.Controllers
{
    [Area("TabStrip")]
    public class IFrameAddTabController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: TabStrip/IFrameAddTab
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button1_Click()
        {
            UIHelper.TabStrip("TabStrip1").AddTab("tab1_iframe", "https://deepseek.com/", "DeepSeek官网", true);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button2_Click()
        {
            UIHelper.TabStrip("TabStrip1").AddTab("tab1_iframe", "https://asp.net/", "ASP.NET官网", true);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button3_Click()
        {
            UIHelper.TabStrip("TabStrip1").AddTab("tab2_iframe", "https://fineui.com/", "FineUI官网", true);

            return UIHelper.Result();
        }

    }
}