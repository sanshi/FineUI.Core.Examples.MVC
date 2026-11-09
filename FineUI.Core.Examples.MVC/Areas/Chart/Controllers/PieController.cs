using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Chart.Controllers
{
    [Area("Chart")]
    public class PieController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        public IActionResult Index()
        {
            return View(new[]
            {
                new { Category = "Search Engine", Value = 1048 },
                new { Category = "Direct", Value = 735 },
                new { Category = "Email", Value = 580 },
                new { Category = "Union Ads", Value = 484 },
                new { Category = "Video Ads", Value = 300 }
            });
        }
    }
}
