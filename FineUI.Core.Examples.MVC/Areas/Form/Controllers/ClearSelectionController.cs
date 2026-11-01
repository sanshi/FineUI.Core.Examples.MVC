using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Form.Controllers
{
    [Area("Form")]
    public class ClearSelectionController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        private void ClearAllSelections()
        {
            UIHelper.Grid("Grid1").ClearSelection();
            UIHelper.DropDownBox("DropDownBox1").ClearSelection();
            UIHelper.DropDownList("DropDownList1").ClearSelection();
            UIHelper.DataList("DataList1").ClearSelection();
            UIHelper.Tree("Tree1").ClearSelection();
            UIHelper.CheckBoxList("CheckBoxList1").ClearSelection();
            UIHelper.RadioButtonList("RadioButtonList1").ClearSelection();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnClearSelection_Click()
        {
            ClearAllSelections();
            UIHelper.Label("labResult").Text("清空动作已发送");
            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnClearAndSelect_Click()
        {
            ClearAllSelections();
            UIHelper.Grid("Grid1").SelectedRowIDArray("a");
            UIHelper.DropDownBox("DropDownBox1").Values(new[] { "a" }, new[] { "甲" });
            UIHelper.DropDownList("DropDownList1").SelectedValue("a");
            UIHelper.DataList("DataList1").SelectedValueArray("a");
            UIHelper.Tree("Tree1").SelectedNodeID("a");
            UIHelper.CheckBoxList("CheckBoxList1").SelectedValueArray("a");
            UIHelper.RadioButtonList("RadioButtonList1").SelectedValue("a");
            UIHelper.Label("labResult").Text("重新选择动作已发送");
            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnUncheckNodes_Click()
        {
            PageContext.InvokeFunction("uncheckTreeNodes");
            UIHelper.Label("labResult").Text("取消勾选动作已发送");
            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnReadSelection_Click(string selection)
        {
            UIHelper.Label("labResult").Text("当前" + selection);
            return UIHelper.Result();
        }
    }
}
