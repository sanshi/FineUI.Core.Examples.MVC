using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Panel.Controllers
{
    [Area("Panel")]
    public class ToolsController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Panel/Tools
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button2_Click(bool collapsed)
        {
            ShowNotify(String.Format("面板处于{0}状态", collapsed ? "折叠" : "展开"));

            return UIHelper.Result();
        }

    }
}