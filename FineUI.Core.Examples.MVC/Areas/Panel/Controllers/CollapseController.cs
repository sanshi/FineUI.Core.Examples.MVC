using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Panel.Controllers
{
    [Area("Panel")]
    public class CollapseController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Panel/Collapse
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Panel1_CollapseExpand(bool collapsed)
        {
            ShowNotify(String.Format("面板一处于{0}状态", !collapsed ? "展开" : "折叠"));

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Panel2_CollapseExpand(bool collapsed)
        {
            ShowNotify(String.Format("面板二处于{0}状态", !collapsed ? "展开" : "折叠"));

            return UIHelper.Result();
        }

    }
}