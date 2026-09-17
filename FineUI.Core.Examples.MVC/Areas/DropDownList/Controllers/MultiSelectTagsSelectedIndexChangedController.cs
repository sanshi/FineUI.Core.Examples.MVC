using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.DropDownList.Controllers
{
    [Area("DropDownList")]
    public class MultiSelectTagsSelectedIndexChangedController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: DropDownList/MultiSelectTagsSelectedIndexChanged
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnGetSelection_Click(string[] DropDownList1, string DropDownList1_text)
        {
            ShowResult(DropDownList1, DropDownList1_text);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DropDownList1_SelectedIndexChanged(string[] DropDownList1, string DropDownList1_text)
        {
            ShowResult(DropDownList1, DropDownList1_text);

            return UIHelper.Result();
        }

        private void ShowResult(string[] value, string text)
        {
            var labResult = UIHelper.Label("labResult");

            if (!String.IsNullOrEmpty(text))
            {
                labResult.Text(String.Format("选中项文本：{0}<br/>选中项值：{1}", text, String.Join(", ", value)));
            }
            else
            {
                labResult.Text("无选中项");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSelectItem6_Click()
        {
            UIHelper.DropDownList("DropDownList1").SelectedValue("Value6");

            return UIHelper.Result();
        }


    }
}