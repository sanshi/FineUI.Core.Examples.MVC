using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

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

        public IActionResult TickAlign()
        {
            return View(new[]
            {
                new { Category = "Mon", Value = 10 },
                new { Category = "Tue", Value = 52 },
                new { Category = "Wed", Value = 200 },
                new { Category = "Thu", Value = 334 },
                new { Category = "Fri", Value = 390 },
                new { Category = "Sat", Value = 330 },
                new { Category = "Sun", Value = 220 }
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

        public IActionResult MixLineBar()
        {
            return View(new[]
            {
                new { Category = "Mon", Evaporation = 2.0, Precipitation = 2.6, Temperature = 2.0 },
                new { Category = "Tue", Evaporation = 4.9, Precipitation = 5.9, Temperature = 2.2 },
                new { Category = "Wed", Evaporation = 7.0, Precipitation = 9.0, Temperature = 3.3 },
                new { Category = "Thu", Evaporation = 23.2, Precipitation = 26.4, Temperature = 4.5 },
                new { Category = "Fri", Evaporation = 25.6, Precipitation = 28.7, Temperature = 6.3 },
                new { Category = "Sat", Evaporation = 76.7, Precipitation = 70.7, Temperature = 10.2 },
                new { Category = "Sun", Evaporation = 135.6, Precipitation = 175.6, Temperature = 20.3 }
            });
        }

        public IActionResult WorldPopulation()
        {
            return View(new[]
            {
                new { Category = "Brazil", Population2011 = 18203, Population2012 = 19325 },
                new { Category = "Indonesia", Population2011 = 23489, Population2012 = 23438 },
                new { Category = "USA", Population2011 = 29034, Population2012 = 31000 },
                new { Category = "India", Population2011 = 104970, Population2012 = 121594 },
                new { Category = "China", Population2011 = 131744, Population2012 = 134141 },
                new { Category = "World", Population2011 = 630230, Population2012 = 681807 }
            });
        }

        public IActionResult StackedHorizontal()
        {
            return View(new[]
            {
                new
                {
                    Category = "Mon",
                    Direct = 320, MailAd = 120, AffiliateAd = 220,
                    VideoAd = 150, SearchEngine = 820
                },
                new
                {
                    Category = "Tue",
                    Direct = 302, MailAd = 132, AffiliateAd = 182,
                    VideoAd = 212, SearchEngine = 832
                },
                new
                {
                    Category = "Wed",
                    Direct = 301, MailAd = 101, AffiliateAd = 191,
                    VideoAd = 201, SearchEngine = 901
                },
                new
                {
                    Category = "Thu",
                    Direct = 334, MailAd = 134, AffiliateAd = 234,
                    VideoAd = 154, SearchEngine = 934
                },
                new
                {
                    Category = "Fri",
                    Direct = 390, MailAd = 90, AffiliateAd = 290,
                    VideoAd = 190, SearchEngine = 1290
                },
                new
                {
                    Category = "Sat",
                    Direct = 330, MailAd = 230, AffiliateAd = 330,
                    VideoAd = 330, SearchEngine = 1330
                },
                new
                {
                    Category = "Sun",
                    Direct = 320, MailAd = 210, AffiliateAd = 310,
                    VideoAd = 410, SearchEngine = 1320
                }
            });
        }

        public IActionResult Waterfall()
        {
            return View(new[]
            {
                new { Category = "Total", Offset = 0, Cost = 2900 },
                new { Category = "Rent", Offset = 1700, Cost = 1200 },
                new { Category = "Utilities", Offset = 1400, Cost = 300 },
                new { Category = "Transportation", Offset = 1200, Cost = 200 },
                new { Category = "Meals", Offset = 300, Cost = 900 },
                new { Category = "Other", Offset = 0, Cost = 300 }
            });
        }

        public IActionResult Spacing()
        {
            return View(new[]
            {
                new { Category = "A", First = 23, Second = 12 },
                new { Category = "B", First = 24, Second = 14 },
                new { Category = "C", First = 18, Second = 9 },
                new { Category = "D", First = 25, Second = 9 },
                new { Category = "E", First = 18, Second = 11 }
            });
        }

        public IActionResult GridToChart()
        {
            ViewData["Regions"] = ChartInteractionData.RegionTotals();
            ViewData["Rows"] = ChartInteractionData.RegionTrend("east");
            ViewData["Scope"] = "华东 · 月度销售额";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SelectRegion(string rowId)
        {
            var region = ChartInteractionData.RegionName(rowId);
            if (region != null)
            {
                UIHelper.Chart("ChartRegionMonths").LoadData(JArray.FromObject(ChartInteractionData.RegionTrend(rowId)));
                UIHelper.ToolbarText("ToolbarTextChartScope").Text(region + " · 月度销售额");
            }
            return UIHelper.Result();
        }

        public IActionResult DrillDown()
        {
            ViewData["Rows"] = ChartInteractionData.RegionTotals();
            ViewData["Scope"] = "各区域销售额";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DrillRegion(string seriesKey, string dataKey)
        {
            var cities = ChartInteractionData.CityTotals(dataKey);
            if (seriesKey == "amount" && cities.Length > 0)
            {
                UIHelper.Chart("ChartRegionSales").LoadData(JArray.FromObject(cities));
                UIHelper.ToolbarText("ToolbarTextChartScope").Text(ChartInteractionData.RegionName(dataKey) + " · 城市销售额");
                UIHelper.Button("btnBack").Enabled(true);
            }
            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ResetRegions()
        {
            UIHelper.Chart("ChartRegionSales").LoadData(JArray.FromObject(ChartInteractionData.RegionTotals()));
            UIHelper.ToolbarText("ToolbarTextChartScope").Text("各区域销售额");
            UIHelper.Button("btnBack").Enabled(false);
            return UIHelper.Result();
        }

        public IActionResult SalesThreshold()
        {
            var rows = ChartInteractionData.RegionThreshold("0");
            ViewData["Rows"] = rows;
            ViewData["Scope"] = ChartInteractionData.ThresholdSummary(rows);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult FilterSales(string nbxMinimum)
        {
            var rows = ChartInteractionData.RegionThreshold(nbxMinimum);
            if (rows != null)
            {
                UIHelper.Chart("ChartSalesThreshold").LoadData(JArray.FromObject(rows));
            }
            UIHelper.ToolbarText("ToolbarTextChartScope").Text(ChartInteractionData.ThresholdSummary(rows));
            return UIHelper.Result();
        }
    }
}
