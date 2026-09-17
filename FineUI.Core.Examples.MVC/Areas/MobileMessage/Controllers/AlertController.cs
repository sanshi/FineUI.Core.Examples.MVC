using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.MobileMessage.Controllers
{
    [Area("MobileMessage")]
    public class AlertController : FineUI.Core.Examples.MVC.Controllers.BaseMobileController
    {
        // GET: MobileMessage/Alert
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button1_Click()
        {
            Alert alert = new Alert();
            alert.Message = "这是提示对话框的内容！";
            alert.Title = "标题文字";
            alert.MessageBoxIcon = MessageBoxIcon.Information;
            alert.Show();

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button2_Click()
        {
            Alert alert = new Alert();
            alert.Message = "这是提示对话框的内容！";
            alert.Title = "标题文字";
            alert.TitleAlign = TextAlign.Center;
            alert.EnableClose = false;
            alert.ButtonFill = true;
            alert.Show();

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button3_Click()
        {
            Alert alert = new Alert();
            alert.Message = "这是提示对话框的内容！";
            alert.Title = "标题文字";
            alert.TitleAlign = TextAlign.Center;
            alert.EnableClose = false;
            alert.ButtonPlain = true;
            alert.Show();

            return UIHelper.Result();
        }

    }
}