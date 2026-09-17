using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Toolbar.Controllers
{
    [Area("Toolbar")]
    public class MenuDynamicButtonController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Toolbar/MenuDynamicButton
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnDynamic_Click(int count)
        {
            ShowNotify("工具栏中的按钮数：" + count);

            return UIHelper.Result();
        }


    }
}