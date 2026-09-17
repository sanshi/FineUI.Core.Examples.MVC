using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.TabStrip.Controllers
{
    [Area("TabStrip")]
    public class TabIndexChangedController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: TabStrip/TabIndexChanged
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button3_Click(int activeIndex)
        {
            int nextIndex = activeIndex + 1;

            if (nextIndex >= 3)
            {
                nextIndex = 0;
            }

            UIHelper.TabStrip("TabStrip1").ActiveTabIndex(nextIndex);

            return UIHelper.Result();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult TabStrip1_TabIndexChanged(int activeIndex)
        {
            if (activeIndex == 0)
            {
                UIHelper.Label("Label1").Text("标签回发时间：" + DateTime.Now.ToLongTimeString());
            }
            else if (activeIndex == 1)
            {
                UIHelper.Label("Label2").Text("标签回发时间：" + DateTime.Now.ToLongTimeString());
            }
            else if (activeIndex == 2)
            {
                UIHelper.Label("Label3").Text("标签回发时间：" + DateTime.Now.ToLongTimeString());
            }

            return UIHelper.Result();
        }
        
    }
}