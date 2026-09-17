using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Grid.Controllers
{
    [Area("Grid")]
    public class CheckFieldColumnCheckAllSwitchTextController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Grid/CheckFieldColumnCheckAllSwitch
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSubmit_Click()
        {


            return UIHelper.Result();
        }

    }
}
