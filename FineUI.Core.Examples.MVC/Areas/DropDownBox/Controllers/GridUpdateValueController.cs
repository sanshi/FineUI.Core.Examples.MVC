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
    public class GridUpdateValueController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: DropDownBox/GridUpdateValue
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnUpdateValue_Click()
        {
            // 1. 对于未分页的表格，可以不设置 Text 属性，以便客户端重新计算
            // 2. 对于分页的表格，一定要手工设置 Text 属性，否则客户端无法取到 Value 对应的 Text 属性
            UIHelper.DropDownBox("DropDownBox1").Value("112");

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnGetSelection_Click(string[] DropDownBox1, string DropDownBox1_text)
        {
            var labResult = UIHelper.Label("labResult");
            if (DropDownBox1 != null && DropDownBox1.Length > 0)
            {
                labResult.Text(String.Format("下拉框文本：{0}（值：{1}）", DropDownBox1_text, String.Join(", ", DropDownBox1)));
            }
            else
            {
                labResult.Text("下拉框为空");
            }

            return UIHelper.Result();
        }

    }
}