using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.TabStrip.Controllers
{
    [Area("TabStrip")]
    public class AddTabRemoveOnCloseController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: TabStrip/AddTabRemoveOnClose
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnAddTab3_Click()
        {
            UIHelper.TabStrip("TabStrip1").AddTab(new TabOptions()
            {
                ID = "dynamic_tab3",
                IFrameUrl = "https://deepseek.com/",
                Title = "DeepSeek官网（服务端代码）",
                IconUrl = IconHelper.GetIconUrl(Icon.Application),
                EnableClose = true,
                RemoveOnClose = true
            });

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnAddTab4_Click()
        {
            UIHelper.TabStrip("TabStrip1").AddTab(new TabOptions()
            {
                ID = "dynamic_tab4",
                IFrameUrl = "https://asp.net/",
                Title = "ASP.NET官网（服务端代码）",
                IconUrl = IconHelper.GetIconUrl(Icon.ApplicationAdd),
                EnableClose = true,
                RemoveOnClose = true
            });

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