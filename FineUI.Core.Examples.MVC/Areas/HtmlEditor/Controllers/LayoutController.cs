using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.HtmlEditor.Controllers
{
    [Area("HtmlEditor")]
    public class LayoutController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button1_Click(string content)
        {
            UIHelper.TextArea("TextArea1").Text(content);
            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button2_Click(string content)
        {
            UIHelper.HtmlEditor("HtmlEditor1").Text(content);
            return UIHelper.Result();
        }
    }
}
