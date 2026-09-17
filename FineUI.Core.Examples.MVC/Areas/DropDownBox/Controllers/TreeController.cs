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
    public class TreeController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: DropDownBox/Tree
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnGetSelection_Click(string DropDownBox1, string DropDownBox1_text)
        {
            var labResult = UIHelper.Label("labResult");
            if (!String.IsNullOrEmpty(DropDownBox1))
            {
                labResult.Text(String.Format("下拉框文本：{0}（值：{1}）", DropDownBox1_text, DropDownBox1));
            }
            else
            {
                labResult.Text("下拉框为空");
            }

            return UIHelper.Result();
        }

    }
}