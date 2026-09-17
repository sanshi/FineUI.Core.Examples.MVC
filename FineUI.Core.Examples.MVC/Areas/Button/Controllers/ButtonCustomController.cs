using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Button.Controllers
{
    [Area("Button")]
    public class ButtonCustomController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Button/ButtonCustom
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button1_Click()
        {
            ShowNotify("点击了普通按钮");

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button2_Click()
        {
            ShowNotify("点击了自定义按钮");

            return UIHelper.Result();
        }

    }
}