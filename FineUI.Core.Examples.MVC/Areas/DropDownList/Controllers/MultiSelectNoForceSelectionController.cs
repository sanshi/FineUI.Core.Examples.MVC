using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.DropDownList.Controllers
{
    [Area("DropDownList")]
    public class MultiSelectNoForceSelectionController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: DropDownList/MultiSelectNoForceSelection
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
                labResult.Text(String.Format("选中项文本：{0}<br/>选中项值：{1}", DropDownList1_text, String.Join(", ", DropDownList1)));
            }
            else
            {
                labResult.Text(String.Format("用户输入值：{0}", DropDownList1_text));
            }


            return UIHelper.Result();
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