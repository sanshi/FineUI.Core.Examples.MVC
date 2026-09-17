using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Accordion.Controllers
{
    [Area("Accordion")]
    public class AccordionController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Accordion/Accordion
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button1_Click(int activeIndex)
        {
            ShowNotify(String.Format("当前展开的是第 {0} 个面板", activeIndex + 1));

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button2_Click(int activeIndex)
        {
            int nextIndex = activeIndex + 1;

            if (nextIndex >= 3)
            {
                nextIndex = 0;
            }

            UIHelper.Accordion("Accordion1").ActivePaneIndex(nextIndex);

            return UIHelper.Result();
        }
    }
}