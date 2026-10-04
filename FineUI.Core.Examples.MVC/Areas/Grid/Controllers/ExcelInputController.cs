using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Grid.Controllers
{
    [Area("Grid")]
    public class ExcelInputController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Grid/ExcelInput
        public IActionResult Index()
        {
            return View();
        }
    }
}
