using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Form.Controllers
{
	[Area("Form")]
    public class TwinTriggerBoxClearIconController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Form/TwinTriggerBoxClearIcon
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult TwinTriggerBox1_Trigger2Click(string text)
        {
            // 点击 TwinTriggerBox 的搜索按钮
            if (!String.IsNullOrEmpty(text))
            {
                // 执行搜索动作
                ShowNotify(String.Format("在关键词“{0}”中搜索", text));

                UpdateClientJSParameter(text);
            }
            else
            {
                ShowNotify("请输入你要搜索的关键词！");
            }

            return UIHelper.Result();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TwinTriggerBox1_Trigger1Click()
        {
            // 点击 TwinTriggerBox 的取消按钮
            ShowNotify("取消搜索！");

            UpdateClientJSParameter("");

            return UIHelper.Result();
        }


        // 更新客户端变量
        private void UpdateClientJSParameter(string text)
        {
            PageContext.RegisterStartupScript(String.Format("updateLastTriggerBoxValue({0});", JsHelper.Enquote(text)));
        }

    }
}