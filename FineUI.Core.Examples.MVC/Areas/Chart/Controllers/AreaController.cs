using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Chart.Controllers
{
    [Area("Chart")]
    public class AreaController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        public IActionResult Index()
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

        public IActionResult Stacked()
        {
            return View(new[]
            {
                new
                {
                    Category = "Mon",
                    Email = 120, UnionAds = 220, VideoAds = 150, Direct = 320, SearchEngine = 820
                },
                new
                {
                    Category = "Tue",
                    Email = 132, UnionAds = 182, VideoAds = 232, Direct = 332, SearchEngine = 932
                },
                new
                {
                    Category = "Wed",
                    Email = 101, UnionAds = 191, VideoAds = 201, Direct = 301, SearchEngine = 901
                },
                new
                {
                    Category = "Thu",
                    Email = 134, UnionAds = 234, VideoAds = 154, Direct = 334, SearchEngine = 934
                },
                new
                {
                    Category = "Fri",
                    Email = 90, UnionAds = 290, VideoAds = 190, Direct = 390, SearchEngine = 1290
                },
                new
                {
                    Category = "Sat",
                    Email = 230, UnionAds = 330, VideoAds = 330, Direct = 330, SearchEngine = 1330
                },
                new
                {
                    Category = "Sun",
                    Email = 210, UnionAds = 310, VideoAds = 410, Direct = 320, SearchEngine = 1320
                }
            });
        }

        public IActionResult GradientStacked()
        {
            return View(new[]
            {
                new { Category = "Mon", Line1 = 140, Line2 = 120, Line3 = 320, Line4 = 220, Line5 = 220 },
                new { Category = "Tue", Line1 = 232, Line2 = 282, Line3 = 132, Line4 = 402, Line5 = 302 },
                new { Category = "Wed", Line1 = 101, Line2 = 111, Line3 = 201, Line4 = 231, Line5 = 181 },
                new { Category = "Thu", Line1 = 264, Line2 = 234, Line3 = 334, Line4 = 134, Line5 = 234 },
                new { Category = "Fri", Line1 = 90, Line2 = 220, Line3 = 190, Line4 = 190, Line5 = 210 },
                new { Category = "Sat", Line1 = 340, Line2 = 340, Line3 = 130, Line4 = 230, Line5 = 290 },
                new { Category = "Sun", Line1 = 250, Line2 = 310, Line3 = 220, Line4 = 120, Line5 = 150 }
            });
        }

        public IActionResult FillColor()
        {
            return View(new[]
            {
                new { Category = "A", First = 10, Second = 25 },
                new { Category = "B", First = 22, Second = 14 },
                new { Category = "C", First = 28, Second = 23 },
                new { Category = "D", First = 23, Second = 35 },
                new { Category = "E", First = 19, Second = 10 }
            });
        }
    }
}
