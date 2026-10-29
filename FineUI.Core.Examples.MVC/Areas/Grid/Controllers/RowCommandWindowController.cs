using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Grid.Controllers
{
    [Area("Grid")]
    public class RowCommandWindowController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(string slug)
        {
            return View(model: slug ?? string.Empty);
        }
    }
}
