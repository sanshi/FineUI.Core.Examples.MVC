using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.TabStrip.Controllers
{
    [Area("TabStrip")]
    public class AddTabController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: TabStrip/AddTab
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnAddTab3_Click()
        {
            UIHelper.TabStrip("TabStrip1").AddTab("dynamic_tab3", "https://deepseek.com/", "DeepSeek官网（服务端代码）", IconHelper.GetIconUrl(Icon.Application), true);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnAddTab4_Click()
        {
            UIHelper.TabStrip("TabStrip1").AddTab("dynamic_tab4", "https://asp.net/", "ASP.NET官网（服务端代码）", IconHelper.GetIconUrl(Icon.ApplicationAdd), true);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnRemoveTab3_Click()
        {
            UIHelper.TabStrip("TabStrip1").CloseTab("dynamic_tab3");

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnRemoveTab4_Click()
        {
            UIHelper.TabStrip("TabStrip1").CloseTab("dynamic_tab4");

            return UIHelper.Result();
        }
    }
}