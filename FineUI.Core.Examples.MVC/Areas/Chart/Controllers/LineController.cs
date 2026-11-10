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

        public IActionResult Stacked()
        {
            return View(new[]
            {
                new
                {
                    Category = "Mon",
                    Email = 120, UnionAds = 220, VideoAds = 150,
                    Direct = 320, SearchEngine = 820
                },
                new
                {
                    Category = "Tue",
                    Email = 132, UnionAds = 182, VideoAds = 232,
                    Direct = 332, SearchEngine = 932
                },
                new
                {
                    Category = "Wed",
                    Email = 101, UnionAds = 191, VideoAds = 201,
                    Direct = 301, SearchEngine = 901
                },
                new
                {
                    Category = "Thu",
                    Email = 134, UnionAds = 234, VideoAds = 154,
                    Direct = 334, SearchEngine = 934
                },
                new
                {
                    Category = "Fri",
                    Email = 90, UnionAds = 290, VideoAds = 190,
                    Direct = 390, SearchEngine = 1290
                },
                new
                {
                    Category = "Sat",
                    Email = 230, UnionAds = 330, VideoAds = 330,
                    Direct = 330, SearchEngine = 1330
                },
                new
                {
                    Category = "Sun",
                    Email = 210, UnionAds = 310, VideoAds = 410,
                    Direct = 320, SearchEngine = 1320
                }
            });
        }

        public IActionResult Step()
        {
            return View(new[]
            {
                new { Category = "Mon", AtStart = 120, AtMiddle = 220, AtEnd = 450 },
                new { Category = "Tue", AtStart = 132, AtMiddle = 282, AtEnd = 432 },
                new { Category = "Wed", AtStart = 101, AtMiddle = 201, AtEnd = 401 },
                new { Category = "Thu", AtStart = 134, AtMiddle = 234, AtEnd = 454 },
                new { Category = "Fri", AtStart = 90, AtMiddle = 290, AtEnd = 590 },
                new { Category = "Sat", AtStart = 230, AtMiddle = 430, AtEnd = 530 },
                new { Category = "Sun", AtStart = 210, AtMiddle = 410, AtEnd = 510 }
            });
        }
    }
}
