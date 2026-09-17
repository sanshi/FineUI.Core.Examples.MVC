using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Message.Controllers
{
    [Area("Message")]
    public class ConfirmCancelController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Message/ConfirmCancel
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnOperation1_Click()
        {
            ShowNotify("执行了操作一！");

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnOperation2_Click()
        {
            ShowNotify("执行了操作二！");

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnOperation3_Click(string opType)
        {
            if (opType == "cancel")
            {
                ShowNotify("取消执行操作三！");
            }
            else
            {
                ShowNotify("执行了操作三！");
            }

            return UIHelper.Result();
        }
    }
}