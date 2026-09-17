using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Newtonsoft.Json.Linq;


namespace FineUI.Core.Examples.MVC.Areas.DropDownBox.Controllers
{
    [Area("DropDownBox")]
    public class RadioButtonListEnableEditDefaultController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: DropDownBox/RadioButtonListEnableEditDefault
        public IActionResult Index()
        {
            // 设置下拉框的初始值为自定义文本
            ViewBag.DropDownBox1Text = "初始自定义值";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnGetSelection_Click(string DropDownBox1, string DropDownBox1_text, bool DropDownBox1_isUserInput)
        {
            var labResult = UIHelper.Label("labResult");
            if (!String.IsNullOrEmpty(DropDownBox1))
            {
                labResult.Text(String.Format("下拉框文本：{0}（值：{1}）", DropDownBox1_text, DropDownBox1));
            }
            else
            {
                labResult.Text(String.Format("用户输入值：{0}", DropDownBox1_text));
            }

            return UIHelper.Result();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSelectItem_Click()
        {
            var DropDownBox1 = UIHelper.DropDownBox("DropDownBox1");

            // 后台更新下拉框的值，需要同时设置Text和Value
            DropDownBox1.Value("js", "JavaScript");

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSetText_Click()
        {
            var DropDownBox1 = UIHelper.DropDownBox("DropDownBox1");

            // 后台更新下拉框的值，需要同时设置Text和Value
            DropDownBox1.Value(null, "用户输入值");

            return UIHelper.Result();
        }

    }
}