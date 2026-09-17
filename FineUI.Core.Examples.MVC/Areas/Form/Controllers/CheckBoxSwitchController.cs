using Microsoft.AspNetCore.Mvc;
using System;

namespace FineUI.Core.Examples.MVC.Areas.Form.Controllers
{
    [Area("Form")]
    public class CheckBoxSwitchController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Form/CheckBoxSwitch
        public IActionResult Index()
        {
            ViewBag.CheckBox5SwitchOnText = "<i class=\"f-icon f-iconfont f-iconfont-check\"></i>";
            ViewBag.CheckBox5SwitchOffText = "<i class=\"f-icon f-iconfont f-iconfont-close\"></i>";

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSelectCheckBox_Click(bool isChecked)
        {
            UIHelper.CheckBox("CheckBox1").Checked(!isChecked);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult btnDisableCheckBox_Click(bool isDisabled)
        {
            UIHelper.CheckBox("CheckBox1").Disabled(!isDisabled);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnChangeText_Click()
        {
            UIHelper.CheckBox("CheckBox1").Text(String.Format("复选框（{0}）", DateTime.Now.ToLongTimeString()));

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CheckBox2_CheckedChanged(bool isChecked)
        {
            ShowNotify("复选框的状态：" + (isChecked ? "选中" : "未选中"));

            return UIHelper.Result();
        }
    }
}
