using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.DropDownList.Controllers
{
    [Area("DropDownList")]
    public class NoForceSelectionInitValueMultiSelectController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: DropDownList/NoForceSelectionInitValueMultiSelect
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnGetSelection_Click(string[] DropDownList1, string DropDownList1_text, bool DropDownList1_isUserInput)
        {
            var labResult = UIHelper.Label("labResult");

            if (DropDownList1 != null && DropDownList1.Length > 0)
            {
                // 用户输入按文字回显，先编码动态文字，避免结果区把输入当作 HTML 标签解析。
                labResult.Text(String.Format(
                    "选中项文本：{0}<br/>选中项值：{1}",
                    HtmlEncode(DropDownList1_text),
                    HtmlEncode(String.Join(", ", DropDownList1))));
            }
            else
            {
                labResult.Text(String.Format("用户输入值：{0}", HtmlEncode(DropDownList1_text)));
            }


            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSelectItem6_Click()
        {
            UIHelper.DropDownList("DropDownList1").SelectedValueArray("Value4", "Value6");
            
            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSetText_Click()
        {
            UIHelper.DropDownList("DropDownList1").Text("用户输入值");

            return UIHelper.Result();
        }

    }
}