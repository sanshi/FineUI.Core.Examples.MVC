using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Grid.Controllers
{
    [Area("Grid")]
    public class ExcelController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Grid/Excel
        public IActionResult Index()
        {
            return View();
        }
    }
}
