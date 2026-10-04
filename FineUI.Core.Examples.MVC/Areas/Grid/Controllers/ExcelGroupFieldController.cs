using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Grid.Controllers
{
    [Area("Grid")]
    public class ExcelGroupFieldController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Grid/ExcelGroupField
        public IActionResult Index()
        {
            return View();
        }
    }
}
