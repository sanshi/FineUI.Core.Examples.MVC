using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Chart.Controllers
{
    [Area("Chart")]
    public class BarController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        public IActionResult Index()
        {
            return View(new[]
            {
                new { Category = "Mon", Value = 120 },
                new { Category = "Tue", Value = 200 },
                new { Category = "Wed", Value = 150 },
                new { Category = "Thu", Value = 80 },
                new { Category = "Fri", Value = 70 },
                new { Category = "Sat", Value = 110 },
                new { Category = "Sun", Value = 130 }
            });
        }

        public IActionResult Background()
        {
            return View(new[]
            {
                new { Category = "Mon", Value = 120 },
                new { Category = "Tue", Value = 200 },
                new { Category = "Wed", Value = 150 },
                new { Category = "Thu", Value = 80 },
                new { Category = "Fri", Value = 70 },
                new { Category = "Sat", Value = 110 },
                new { Category = "Sun", Value = 130 }
            });
        }

        public IActionResult PointColor()
        {
            return View(new[]
            {
                new { Category = "Mon", Value = 120, PointColor = "" },
                new { Category = "Tue", Value = 200, PointColor = "#505372" },
                new { Category = "Wed", Value = 150, PointColor = "" },
                new { Category = "Thu", Value = 80, PointColor = "" },
                new { Category = "Fri", Value = 70, PointColor = "" },
                new { Category = "Sat", Value = 110, PointColor = "" },
                new { Category = "Sun", Value = 130, PointColor = "" }
            });
        }
    }
}
