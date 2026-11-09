using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Chart.Controllers
{
    [Area("Chart")]
    public class LineController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        public IActionResult Index()
        {
            return View(new[]
            {
                new { Category = "Mon", Value = 150 },
                new { Category = "Tue", Value = 230 },
                new { Category = "Wed", Value = 224 },
                new { Category = "Thu", Value = 218 },
                new { Category = "Fri", Value = 135 },
                new { Category = "Sat", Value = 147 },
                new { Category = "Sun", Value = 260 }
            });
        }

        public IActionResult Smooth()
        {
            return View(new[]
            {
                new { Category = "Mon", Value = 820 },
                new { Category = "Tue", Value = 932 },
                new { Category = "Wed", Value = 901 },
                new { Category = "Thu", Value = 934 },
                new { Category = "Fri", Value = 1290 },
                new { Category = "Sat", Value = 1330 },
                new { Category = "Sun", Value = 1320 }
            });
        }
    }
}
