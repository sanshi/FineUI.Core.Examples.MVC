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
    public class GridMultiSelectEnableEditController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: DropDownBox/GridMultiSelectEnableEdit
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnGetSelection_Click(string[] DropDownBox1, string DropDownBox1_text, bool DropDownBox1_isUserInput)
        {
            var labResult = UIHelper.Label("labResult");
            if (DropDownBox1 != null && DropDownBox1.Length > 0)
            {
                labResult.Text(String.Format("下拉框文本：{0}（值：{1}）", DropDownBox1_text, String.Join(", ", DropDownBox1)));
            }
            else
            {
                labResult.Text(String.Format("用户输入值：{0}", DropDownBox1_text));
            }

            return UIHelper.Result();
        }


    }
}