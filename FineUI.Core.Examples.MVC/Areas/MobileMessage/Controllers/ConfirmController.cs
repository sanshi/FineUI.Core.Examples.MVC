using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.MobileMessage.Controllers
{
    [Area("MobileMessage")]
    public class ConfirmController : FineUI.Core.Examples.MVC.Controllers.BaseMobileController
    {
        // GET: MobileMessage/Confirm
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button1_Click()
        {
            Confirm confirm = new Confirm();
            confirm.Message = "您真的要执行删除操作吗？";
            confirm.Title = "确认操作";
            confirm.MessageBoxIcon = MessageBoxIcon.Question;
            confirm.Show();

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button2_Click()
        {
            Confirm confirm = new Confirm();
            confirm.Message = "您真的要执行删除操作吗？";
            confirm.Title = "确认操作";
            confirm.TitleAlign = TextAlign.Center;
            confirm.EnableClose = false;
            confirm.ButtonFill = true;
            confirm.Show();

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button3_Click()
        {
            Confirm confirm = new Confirm();
            confirm.Message = "您真的要执行删除操作吗？";
            confirm.Title = "确认操作";
            confirm.TitleAlign = TextAlign.Center;
            confirm.EnableClose = false;
            confirm.ButtonPlain = true;
            confirm.CancelButtonAhead = true;
            confirm.Show();

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button6_Click()
        {
            Confirm confirm = new Confirm();
            confirm.Message = "您真的要执行删除操作吗？";
            confirm.Title = "确认操作";
            confirm.TitleAlign = TextAlign.Center;
            confirm.EnableClose = false;
            confirm.ButtonPlain = true;
            confirm.Show();

            return UIHelper.Result();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button4_ConfirmResult(string button)
        {
            ShowNotify(String.Format("你点击了 Button4 对话框的 {0} 按钮", button));

            return UIHelper.Result();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button5_ConfirmResult(string button)
        {
            ShowNotify(String.Format("你点击了 Button5 对话框的 {0} 按钮", button));

            return UIHelper.Result();
        }

    }
}