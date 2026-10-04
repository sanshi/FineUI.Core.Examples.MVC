using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Grid.Controllers
{
    [Area("Grid")]
    public class ExcelRowCommandDownloadController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Grid/ExcelRowCommandDownload
        public IActionResult Index()
        {
            return View();
        }
    }
}
