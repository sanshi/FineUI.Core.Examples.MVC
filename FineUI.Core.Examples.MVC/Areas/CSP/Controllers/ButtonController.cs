using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.CSP.Controllers
{
    [Area("CSP")]
    public class ButtonController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: CSP/Button
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnEnable_Click()
        {
            ShowNotify("你点击了刚刚启用的按钮");

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnChangeEnable_Click()
        {
            var btnEnable = UIHelper.Button("btnEnable");

            btnEnable.Enabled(true);
            btnEnable.Text("本按钮已经启用（点击弹出对话框）");

            //throw new Exception("异常信息");

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnChangePressed_Click(bool pressed)
        {
            UIHelper.Button("btnPressed").Pressed(!pressed);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnTooltip_Click()
        {
            UIHelper.Button("btnTooltip").ToolTip("这是改变后的提示信息");

            return UIHelper.Result();
        }

    }
}