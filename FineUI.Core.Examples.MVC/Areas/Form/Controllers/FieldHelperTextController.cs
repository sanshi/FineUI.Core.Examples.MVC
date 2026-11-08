using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Form.Controllers
{
    [Area("Form")]
    public class FieldHelperTextController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update()
        {
            UIHelper.TextBox("tbxEmail").HelperText("请填写部门公共邮箱，便于同事接收后续通知。");
            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Clear()
        {
            UIHelper.TextBox("tbxEmail").HelperText(null);
            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Read(string helperText)
        {
            UIHelper.Label("labResult").Text("当前填写说明：" + helperText);
            return UIHelper.Result();
        }
    }
}
