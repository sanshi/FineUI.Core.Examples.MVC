using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.TabStrip.Controllers
{
    [Area("TabStrip")]
    public class PositionToolsTitleVerticalController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: TabStrip/PositionToolsTitleVertical
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSubmit_Click(IFormCollection values)
        {
            ShowNotify(values);

            return UIHelper.Result();
        }

    }
}
