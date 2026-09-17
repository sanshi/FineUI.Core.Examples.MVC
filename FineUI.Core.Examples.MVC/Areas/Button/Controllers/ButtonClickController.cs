using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Button.Controllers
{
    [Area("Button")]
    public class ButtonClickController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Button/ButtonClick
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnServerClick_Click()
        {
            ShowNotify("这是服务器端事件");
            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnChangeClientClick2_Click()
        {
            // 回发中换掉客户端回调：下发的也只是新函数名，不是脚本
            UIHelper.Button("btnClientClick2").ClickHandler("onChangedClick");

            return UIHelper.Result();
        }


    }
}