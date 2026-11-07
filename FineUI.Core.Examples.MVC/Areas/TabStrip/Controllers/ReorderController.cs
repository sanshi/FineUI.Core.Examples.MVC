using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.TabStrip.Controllers
{
    [Area("TabStrip")]
    public class ReorderController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult OpenFirst()
        {
            UIHelper.TabStrip("TabStrip1").ActiveTabIndex(0);
            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult OpenHome()
        {
            UIHelper.TabStrip("TabStrip1").ActivateTab("tabHome");
            return UIHelper.Result();
        }
    }
}
