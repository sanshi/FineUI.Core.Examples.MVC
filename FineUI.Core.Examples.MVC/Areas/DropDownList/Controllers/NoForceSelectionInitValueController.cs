using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.DropDownList.Controllers
{
    [Area("DropDownList")]
    public class NoForceSelectionInitValueController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: DropDownList/NoForceSelectionInitValue
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnGetSelection_Click(string DropDownList1, string DropDownList1_text, bool DropDownList1_isUserInput)
        {
            var labResult = UIHelper.Label("labResult");

            if (!String.IsNullOrEmpty(DropDownList1))
            {
                labResult.Text(String.Format("选中项：{0}（值：{1}）", DropDownList1_text, DropDownList1));
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSetText_Click()
        {
            UIHelper.DropDownList("DropDownList1").Text("用户输入值");

            return UIHelper.Result();
        }
        

    }
}