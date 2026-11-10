using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Linq;
using ChartRow = FineUI.Core.Examples.MVC.Areas.Chart.ChartDataRows.ChartRow;

namespace FineUI.Core.Examples.MVC.Areas.Chart.Controllers
{
    [Area("Chart")]
    public class LineController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        public IActionResult Basic()
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
            var visits = DailyVisitData.DailyVisits();
            ViewData["VisitRange"] = DailyVisitData.FirstDate + " - " + DailyVisitData.LastDate;
            ViewData["Rows"] = visits;
            ViewData["Scope"] = VisitSummary(visits);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult dpVisitRange_TextChanged(string dpVisitRange)
        {
            // 范围选择器提交一段完整文本，例如 2026-09-03 - 2026-09-05。
            var dates = dpVisitRange?.Split(new[] { " - " }, System.StringSplitOptions.None);
            var visits = dates?.Length == 2 ? DailyVisitData.DailyVisits(dates[0], dates[1]) : null;
            if (visits == null)
            {
                UIHelper.ToolbarText("ToolbarTextChartScope").Text("请选择有效日期，开始日期须早于或等于结束日期");
                return UIHelper.Result();
            }

            UIHelper.Chart("ChartVisitRange").LoadData(JArray.FromObject(visits));
            UIHelper.ToolbarText("ToolbarTextChartScope").Text(VisitSummary(visits));
            return UIHelper.Result();
        }

        public IActionResult PointDetails()
        {
            ViewData["Rows"] = DailyVisitData.DailyVisits();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChartDailyVisits_PointClick(string seriesKey, string dataKey)
        {
            var details = DailyVisitData.FindVisit(dataKey);
            if (seriesKey == "amount" && details != null)
            {
                UIHelper.Label("labVisitDate").Text("日期：" + dataKey);
                UIHelper.Label("labVisitCount").Text("访问量：" + details.Visits);
                UIHelper.Label("labConversionCount").Text("转化量：" + details.Conversions);
                var rate = (details.Conversions * 100.0 / details.Visits).ToString("0.0", CultureInfo.InvariantCulture);
                UIHelper.Label("labConversionRate").Text("转化率：" + rate + "%");
                UIHelper.Window("WindowVisitDetails").Show();
            }
            return UIHelper.Result();
        }

        public IActionResult MetricSwitch()
        {
            var rows = DailyMetric("visits");
            ViewData["Rows"] = rows;
            ViewData["Scope"] = MetricSummary("visits", rows);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult rblMetric_SelectedIndexChanged(string metric)
        {
            var rows = DailyMetric(metric);
            UIHelper.Chart("ChartMetricTrend").LoadData(JArray.FromObject(rows));
            UIHelper.ToolbarText("ToolbarTextChartScope").Text(MetricSummary(metric, rows));
            return UIHelper.Result();
        }

        public IActionResult DateFocus()
        {
            var rows = DailyFocus(DailyVisitData.FirstDate);
            ViewData["Rows"] = rows;
            ViewData["Scope"] = VisitFocusSummary(DailyVisitData.FirstDate);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChartDateFocus_PointClick(string seriesKey, string dataKey)
        {
            if (seriesKey == "amount" && DailyVisitData.FindVisit(dataKey) != null)
            {
                UIHelper.DatePicker("dpFocus").Text(dataKey);
                var rows = DailyFocus(dataKey);
                UIHelper.Chart("ChartDateFocus").LoadData(JArray.FromObject(rows));
                UIHelper.ToolbarText("ToolbarTextChartScope").Text(VisitFocusSummary(dataKey));
            }
            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnFocus_Click(string dpFocus)
        {
            var rows = DailyFocus(dpFocus);
            UIHelper.Chart("ChartDateFocus").LoadData(JArray.FromObject(rows));
            UIHelper.ToolbarText("ToolbarTextChartScope").Text(VisitFocusSummary(dpFocus));
            return UIHelper.Result();
        }

        private static string VisitSummary(ChartRow[] rows)
        {
            return rows.Length == 0 ? "所选日期内没有访问数据" : $"{rows.Length} 天 · 访问量 {rows.Sum(row => row.Amount)}";
        }

        private static ChartRow[] DailyMetric(string metric)
        {
            var rows = DailyVisitData.DailyVisits();
            return metric == "conversions"
                ? rows.Select(row => new ChartRow(row.Key, row.Category, DailyVisitData.FindVisit(row.Key).Conversions)).ToArray()
                : rows;
        }

        private static string MetricSummary(string metric, ChartRow[] rows)
        {
            var name = metric == "conversions" ? "转化量" : "访问量";
            return $"{name}合计：{rows.Sum(row => row.Amount)}";
        }

        private static object DailyFocus(string key)
        {
            return DailyVisitData.DailyVisits().Select(row => new
            {
                row.Key,
                row.Category,
                row.Amount,
                Color = row.Key == key ? "#d9480f" : ""
            }).ToArray();
        }

        private static string VisitFocusSummary(string key)
        {
            var details = DailyVisitData.FindVisit(key);
            return details == null ? "所选日期没有访问数据" : $"{key} · 访问量 {details.Visits} · 转化量 {details.Conversions}";
        }
    }
}
