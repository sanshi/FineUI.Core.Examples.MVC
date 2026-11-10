using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Linq;
using System;
using ChartRow = FineUI.Core.Examples.MVC.Areas.Chart.ChartDataRows.ChartRow;

namespace FineUI.Core.Examples.MVC.Areas.Chart.Controllers
{
    [Area("Chart")]
    public class PieController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        public IActionResult Basic()
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

        public IActionResult Doughnut()
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

        public IActionResult HalfDoughnut()
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

        public IActionResult PadAngle()
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

        public IActionResult RoundedDoughnut()
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

        public IActionResult Rose()
        {
            return View(new[]
            {
                new { Category = "A", Value = 100 },
                new { Category = "B", Value = 200 },
                new { Category = "C", Value = 300 },
                new { Category = "D", Value = 400 },
                new { Category = "E", Value = 500 }
            });
        }

        public IActionResult TrendLink()
        {
            ViewData["Rows"] = ChannelVisitData.ChannelTotals();
            ViewData["Trend"] = ChannelVisitData.ChannelTrend();
            ViewData["Scope"] = "全部渠道 · 月度访问趋势";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChartChannels_PointClick(string seriesKey, string dataKey)
        {
            var channel = ChannelVisitData.ChannelName(dataKey);
            if (seriesKey == "amount" && channel != null)
            {
                UIHelper.Chart("ChartChannelTrend").LoadData(JArray.FromObject(ChannelVisitData.ChannelTrend(dataKey)));
                UIHelper.ToolbarText("ToolbarTextChartScope").Text(channel + " · 月度访问趋势");
            }
            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnAllChannels_Click()
        {
            UIHelper.Chart("ChartChannelTrend").LoadData(JArray.FromObject(ChannelVisitData.ChannelTrend()));
            UIHelper.ToolbarText("ToolbarTextChartScope").Text("全部渠道 · 月度访问趋势");
            return UIHelper.Result();
        }

        public IActionResult MonthFilter()
        {
            var rows = ChannelVisitData.ChannelTotals();
            ViewData["Rows"] = rows;
            ViewData["Scope"] = DistributionSummary("all", rows);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ddlMonth_SelectedIndexChanged(string month)
        {
            var rows = month == "all" ? ChannelVisitData.ChannelTotals() : ChannelVisitData.ChannelTotals(month);
            if (rows.Length > 0)
            {
                UIHelper.Chart("ChartChannelMonth").LoadData(JArray.FromObject(rows));
                UIHelper.ToolbarText("ToolbarTextChartScope").Text(DistributionSummary(month, rows));
            }
            return UIHelper.Result();
        }

        public IActionResult ChannelDetails()
        {
            var rows = ChannelVisitData.ChannelTotals();
            ViewData["Rows"] = rows;
            ViewData["Scope"] = ChannelDetailsSummary(null, null);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChartChannelDetails_PointClick(string seriesKey, string dataKey)
        {
            if (seriesKey == "amount" && ChannelVisitData.ChannelName(dataKey) != null)
            {
                var rows = ChannelVisitData.ChannelTrend(dataKey);
                UIHelper.Grid("GridChannelMonths").DataSource(rows, new[] { "Category", "Amount" });
                UIHelper.ToolbarText("ToolbarTextChartScope").Text(ChannelDetailsSummary(dataKey, rows));
            }
            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnClear_Click()
        {
            var rows = new ChartRow[0];
            UIHelper.Grid("GridChannelMonths").DataSource(rows, new[] { "Category", "Amount" });
            UIHelper.ToolbarText("ToolbarTextChartScope").Text(ChannelDetailsSummary(null, rows));
            return UIHelper.Result();
        }

        private static string DistributionSummary(string month, ChartRow[] rows)
        {
            var range = month == "all" ? "全部月份" : Array.Find(ChannelVisitData.ChannelTrend(), row => row.Key == month)?.Category;
            return $"{range} · 总访问量 {rows.Sum(row => row.Amount)}";
        }

        private static string ChannelDetailsSummary(string key, ChartRow[] rows)
        {
            return key == null ? "请选择一个渠道" : $"{ChannelVisitData.ChannelName(key)} · 六个月访问量 {rows.Sum(row => row.Amount)}";
        }
    }
}
