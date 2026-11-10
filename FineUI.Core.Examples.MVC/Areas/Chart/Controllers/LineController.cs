using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

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

        public IActionResult Dashed()
        {
            return View(new[]
            {
                new { Category = "A", Value = 10 },
                new { Category = "B", Value = 22 },
                new { Category = "C", Value = 28 },
                new { Category = "D", Value = 23 },
                new { Category = "E", Value = 19 }
            });
        }

        public IActionResult DateRange()
        {
            var visits = ChartInteractionData.DailyVisits();
            ViewData["VisitRange"] = ChartInteractionData.FirstDate + " - " + ChartInteractionData.LastDate;
            ViewData["Rows"] = visits;
            ViewData["Scope"] = ChartInteractionData.VisitSummary(visits);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult QueryVisits(string dpVisitRange)
        {
            // 范围选择器提交一段完整文本，例如 2026-09-03 - 2026-09-05。
            var dates = dpVisitRange?.Split(new[] { " - " }, System.StringSplitOptions.None);
            var visits = dates?.Length == 2 ? ChartInteractionData.DailyVisits(dates[0], dates[1]) : null;
            if (visits == null)
            {
                UIHelper.ToolbarText("ToolbarTextChartScope").Text("请选择有效日期，开始日期须早于或等于结束日期");
                return UIHelper.Result();
            }

            UIHelper.Chart("ChartVisitRange").LoadData(JArray.FromObject(visits));
            UIHelper.ToolbarText("ToolbarTextChartScope").Text(ChartInteractionData.VisitSummary(visits));
            return UIHelper.Result();
        }

        public IActionResult PointDetails()
        {
            ViewData["Rows"] = ChartInteractionData.DailyVisits();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult VisitDetails(string seriesKey, string dataKey)
        {
            var details = ChartInteractionData.FindVisit(dataKey);
            if (seriesKey == "amount" && details != null)
            {
                UIHelper.Label("labVisitDate").Text("日期：" + dataKey);
                UIHelper.Label("labVisitCount").Text("访问量：" + details.Visits);
                UIHelper.Label("labConversionCount").Text("转化量：" + details.Conversions);
                UIHelper.Label("labConversionRate").Text("转化率：" + details.Rate);
                UIHelper.Window("WindowVisitDetails").Show();
            }
            return UIHelper.Result();
        }

        public IActionResult MetricSwitch()
        {
            var rows = ChartInteractionData.DailyMetric("visits");
            ViewData["Rows"] = rows;
            ViewData["Scope"] = ChartInteractionData.MetricSummary("visits", rows);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChangeMetric(string metric)
        {
            var rows = ChartInteractionData.DailyMetric(metric);
            UIHelper.Chart("ChartMetricTrend").LoadData(JArray.FromObject(rows));
            UIHelper.ToolbarText("ToolbarTextChartScope").Text(ChartInteractionData.MetricSummary(metric, rows));
            return UIHelper.Result();
        }

        public IActionResult DateFocus()
        {
            var rows = ChartInteractionData.DailyFocus(ChartInteractionData.FirstDate);
            ViewData["Rows"] = rows;
            ViewData["Scope"] = ChartInteractionData.VisitFocusSummary(ChartInteractionData.FirstDate);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult FocusDate(string seriesKey, string dataKey)
        {
            if (seriesKey == "amount" && ChartInteractionData.FindVisit(dataKey) != null)
            {
                UIHelper.DatePicker("dpFocus").Text(dataKey);
                var rows = ChartInteractionData.DailyFocus(dataKey);
                UIHelper.Chart("ChartDateFocus").LoadData(JArray.FromObject(rows));
                UIHelper.ToolbarText("ToolbarTextChartScope").Text(ChartInteractionData.VisitFocusSummary(dataKey));
            }
            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ReadDate(string dpFocus)
        {
            var rows = ChartInteractionData.DailyFocus(dpFocus);
            UIHelper.Chart("ChartDateFocus").LoadData(JArray.FromObject(rows));
            UIHelper.ToolbarText("ToolbarTextChartScope").Text(ChartInteractionData.VisitFocusSummary(dpFocus));
            return UIHelper.Result();
        }
    }
}
