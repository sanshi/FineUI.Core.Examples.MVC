using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Message.Controllers
{
    [Area("Message")]
    public class ConfirmButtonsController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Message/ConfirmButtons
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmOK()
        {
            ShowNotify("你点击了[直接退出]按钮！");

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmCancel()
        {
            ShowNotify("你点击了[不退出]按钮！");

            return UIHelper.Result();
        }

    }
}