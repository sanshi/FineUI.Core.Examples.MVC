using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Form.Controllers
{
    [Area("Form")]
    public class DropDownListAssignmentOrderController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnValueThenText_Click()
        {
            var list = UIHelper.DropDownList("DropDownList2");
            list.ClearSelection();
            list.SelectedValue("a");
            list.Text("自定义输入");
            UIHelper.Label("labResult").Text("赋值动作已发送");
            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnTextThenValue_Click()
        {
            var list = UIHelper.DropDownList("DropDownList2");
            list.ClearSelection();
            list.Text("自定义输入");
            list.SelectedValue("a");
            UIHelper.Label("labResult").Text("赋值动作已发送");
            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnReadDropDownList_Click(string selection)
        {
            UIHelper.Label("labResult").Text(selection);
            return UIHelper.Result();
        }

    }
}
