using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Toolbar.Controllers
{
    [Area("Toolbar")]
    public class MenuCheckBoxController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Toolbar/MenuCheckBox
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult MenuLang_CheckedChanged(string checkedValue)
        {
            UIHelper.Label("labLangResult").Text("你选择的语言：" + checkedValue);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult MenuSite_CheckedChanged(string checkedValue)
        {
            UIHelper.Label("labSiteResult").Text("你选择的站点：" + checkedValue);

            return UIHelper.Result();
        }

    }
}