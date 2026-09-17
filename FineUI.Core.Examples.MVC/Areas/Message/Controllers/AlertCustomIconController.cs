using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Message.Controllers
{
    [Area("Message")]
    public class AlertCustomIconController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Message/AlertCustomIcon
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnHello_Click()
        {
            Alert alert = new Alert();
            alert.Message = "你好 FineUI.Core！";
            alert.Icon = Icon.Book;
            alert.Show();

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnHello2_Click()
        {
            Alert alert = new Alert();
            alert.Message = "你好 FineUI.Core！";
            alert.IconUrl = "~/res/images/success.png";
            alert.Target = Target.Top;
            alert.Show();

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnHello3_Click()
        {
            Alert alert = new Alert();
            alert.Message = "你好 FineUI.Core！";
            alert.IconFont = IconFont._Car;
            alert.Target = Target.Top;
            alert.Show();

            return UIHelper.Result();
        }

    }
}