using Microsoft.AspNetCore.Mvc;
using System;

namespace FineUI.Core.Examples.MVC.Areas.Form.Controllers
{
    [Area("Form")]
    public class CheckBoxClientServerEventController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Form/CheckBoxClientServerEvent
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CheckBox1_CheckedChanged(bool isChecked)
        {
            UIHelper.Label("labResult").Text("【服务端】复选框1的状态：" + (isChecked ? "选中" : "未选中"));

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CheckBox2_CheckedChanged(bool isChecked)
        {
            UIHelper.Label("labResult").Text("【服务端】复选框2的状态：" + (isChecked ? "选中" : "未选中"));

            return UIHelper.Result();
        }
    }
}
